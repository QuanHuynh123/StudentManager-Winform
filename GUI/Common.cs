using BLL;

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
    }
}
