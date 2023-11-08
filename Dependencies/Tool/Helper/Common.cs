using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;

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
