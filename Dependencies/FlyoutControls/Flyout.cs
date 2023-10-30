using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechConnect
{
    public class Flyout
    {
        public static DialogResult ShowFlyoutDialog(String sHeader, Color nForeColor, Control oShowControl, params FlyoutCommand[] aOptions)
        {
            FlyoutAction oFlyoutAction = new FlyoutAction();
            foreach (FlyoutCommand oCommand in aOptions)
                oFlyoutAction.Commands.Add(oCommand);
            oFlyoutAction.Caption = sHeader;

            FlyoutProperties oProp = new FlyoutProperties();
            oProp.ButtonSize = new Size(100, 40);
            oProp.Style = FlyoutStyle.MessageBox;
            oProp.Alignment = ContentAlignment.MiddleCenter;

            if (nForeColor != Color.Empty)
            {
                oProp.Appearance.ForeColor = nForeColor;
                oProp.Appearance.Options.UseForeColor = true;
            }
            else
                oProp.Appearance.Options.UseForeColor = false;


            DialogResult oDialogResult = DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(Application.OpenForms[0], oShowControl, oFlyoutAction, oProp);

            return oDialogResult;
        }


        public static void ShowFlyout(String sHeader, Color nForeColor, Control oShowControl, params FlyoutCommand[] aOptions)
        {
            FlyoutAction oFlyoutAction = new FlyoutAction();
            foreach (FlyoutCommand oCommand in aOptions)
                oFlyoutAction.Commands.Add(oCommand);
            oFlyoutAction.Caption = sHeader;

            FlyoutProperties oProp = new FlyoutProperties();
            oProp.ButtonSize = new Size(100, 40);
            oProp.Style = FlyoutStyle.MessageBox;
            oProp.Alignment = ContentAlignment.MiddleCenter;

            if (nForeColor != Color.Empty)
            {
                oProp.Appearance.ForeColor = nForeColor;
                oProp.Appearance.Options.UseForeColor = true;
            }
            else
                oProp.Appearance.Options.UseForeColor = false;

            DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(Application.OpenForms[0], oShowControl, oFlyoutAction, oProp);

        }

        public static FlyoutCommand CreateFlyoutCommand(String sText, DialogResult nResult)
        {
            FlyoutCommand oCommand = new FlyoutCommand();

            oCommand.Text = sText;
            oCommand.Result = nResult;

            return oCommand;
        }
    }
}