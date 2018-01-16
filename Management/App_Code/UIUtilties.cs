using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Management.App_Code
{
    class UIUtilties
    {
        public static void DataGridView_RowAdded(object sender, int rowIndex)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            if (rowIndex % 2 == 0)
            {
                style.BackColor = Color.LightGray;
            }
            else
            {
                style.BackColor = Color.White;
            }
            view.Rows[rowIndex].DefaultCellStyle = style;
        }

        public static void DataGridView_RowAdded(object sender, int rowIndex, bool isCriticalRow)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            if (isCriticalRow)
            {
                style.BackColor = Color.Red;
            }
            else if (rowIndex % 2 == 0)
            {
                style.BackColor = Color.LightGray;
            }
            else
            {
                style.BackColor = Color.White;
            }
            view.Rows[rowIndex].DefaultCellStyle = style;
        }

        public static void ShowNotification(string title)
        {
            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = SystemIcons.Warning,
                BalloonTipText = title,
            };

            notification.ShowBalloonTip(5000);
            Thread.Sleep(10000);
            notification.Dispose();
        }
    }
}
