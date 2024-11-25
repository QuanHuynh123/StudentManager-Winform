using BLL;
using ClosedXML.Excel;

namespace GUI
{
    public static class Common
    {
        public static void LoadFeatureForUser(Dictionary<string, Button> controls, string featureNmme)
        {
            if (SessionLogin.IsLoggedIn)
            {
                if (SessionLogin.LoggedInTeacher.RoleID == Constants.Principal)
                {
                    return;
                }

                var myFeatures = SessionLogin.LoggedInTeacher.Role.RoleActivities.GroupBy(ra => ra.Feature).ToList().Where(x => x.Key != null);
                var feature = myFeatures.FirstOrDefault(mf => mf.Key.Equals(featureNmme, StringComparison.OrdinalIgnoreCase));

                var unavailable = controls.ExceptBy(feature?.Select(f => f.ActivityName.ToLower()) ?? [], p => p.Key.ToLower());

                foreach (var control in unavailable)
                {
                    control.Value.Visible = false;
                    control.Value.Visible = false;
                }
            }
        }

        public static void ExportExcel<T>(IEnumerable<T> data, string fileName)
        {
            Directory.CreateDirectory("../../../../Exports");
            string filePath = $"../../../../Exports/{fileName}.xlsx";

            if (data == null || !data.Any())
            {
                throw new ArgumentException("Data cannot be null or empty.", nameof(data));
            }

            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Get the properties of the object
            var properties = typeof(T).GetProperties();

            // Add headers dynamically
            for (int col = 0; col < properties.Length; col++)
            {
                worksheet.Cell(1, col + 1).Value = properties[col].Name;
            }

            worksheet.Cell(1, 1).Style.Font.Bold = true;

            // Add data rows
            int row = 2;
            foreach (var item in data)
            {
                for (int col = 0; col < properties.Length; col++)
                {
                    var value = properties[col].GetValue(item);
                    worksheet.Cell(row, col + 1).Value = (XLCellValue)(value?.ToString() ?? string.Empty); // Handle nulls
                }
                row++;
            }

            // Auto-adjust columns
            worksheet.Columns().AdjustToContents();

            // Save the file
            workbook.SaveAs(filePath);
        }
    }
}
