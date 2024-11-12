using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomPanel : Panel
{
    private int _cornerRadius = 30; // Đặt bán kính bo góc

    // Tạo thuộc tính để tùy chỉnh bán kính bo góc
    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            this.Invalidate(); // Vẽ lại panel khi thay đổi
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Tạo GraphicsPath với bo góc
        GraphicsPath path = new GraphicsPath();
        int radius = _cornerRadius;

        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Góc trên trái
        path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90); // Góc trên phải
        path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90); // Góc dưới phải
        path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90); // Góc dưới trái

        path.CloseAllFigures();

        // Thiết lập vùng để vẽ
        this.Region = new Region(path);

        // Vẽ phần nền (nếu cần)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.FillPath(new SolidBrush(this.BackColor), path);
    }
}
