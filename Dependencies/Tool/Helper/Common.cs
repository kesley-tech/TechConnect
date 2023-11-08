using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public class Common
    {
        private static NotifyIcon notifyIcon = new NotifyIcon()
        {
            Icon = SystemIcons.Application,
            Text = "TechConnection",
            ContextMenu = new ContextMenu(),
            Visible = true
        };

        public static void ShowNotification(string content, ToolTipIcon icon)
        {
            notifyIcon.ShowBalloonTip(1200, "Notificação", content, icon);
        }
    }
}
