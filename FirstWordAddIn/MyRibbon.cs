using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstWordAddIn
{
    public partial class MyRibbon
    {
        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void OnAction_Button(object sender, RibbonControlEventArgs e)
        {
            switch (e.Control.Id)
            {
                case "AboutButton":
                    AboutForm frmAbout = new AboutForm();
                    frmAbout.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
