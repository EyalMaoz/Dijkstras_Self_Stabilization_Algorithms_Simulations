using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dijkstra_third_algorithm
{
    public class RoundButton : Button
    {
        public RoundButton()
        {
            //EnabledChanged += RoundButton_EnabledChanged;
            //BackColor = Enabled == false ? Color.LightYellow : Color.LightGreen;
            ForeColor = Color.Black;
        }



        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            int offset = 0;
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(offset, offset, ClientSize.Width- offset, ClientSize.Height- offset);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
