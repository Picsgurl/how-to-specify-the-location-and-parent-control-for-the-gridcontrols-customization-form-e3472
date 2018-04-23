using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors.Customization;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Localization;



namespace DevExpress.MyControl
{
    [ToolboxItem(false)]
    public class MyCustomizationForm : CustomizationForm
    {
        private Control parentControl;



        public MyCustomizationForm(GridView view)
            : base(view)
        {
            parentControl = null;
        }



        public MyCustomizationForm(GridView view, Control parent)
            : this(view)
        {
            parentControl = parent;
        }



        public override void ShowCustomization(Point location)
        {
            if (parentControl != null)
            {
                ShowCustomization(parentControl);
                return;
            }

            base.ShowCustomization(location);
        }
    }
}
