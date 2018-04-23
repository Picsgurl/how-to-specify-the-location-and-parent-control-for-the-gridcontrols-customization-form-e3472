using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Views.Base.ViewInfo;





namespace DevExpress.MyControl
{
    public class MyGridView : GridView
    {
        private Control parentControl;



        protected override string ViewName 
        { 
            get { return "MyGridView"; } 
        }



        public MyGridView() : this(null) 
        {
        }


        public MyGridView(GridControl grid)
            : base(grid)
        {
            parentControl = null;
        }


        public void ShowCustomization(Point location)
        {
            parentControl = null;
            ColumnsCustomization(location);
        }



        public void ShowCustomization(Control parent)
        {
            parentControl = parent;
            ColumnsCustomization(BaseViewInfo.EmptyPoint);
        }


        protected override CustomizationForm CreateCustomizationForm()
        {
            return (parentControl != null ? new MyCustomizationForm(this, parentControl) : new MyCustomizationForm(this)) as CustomizationForm;
        }
    }
}
