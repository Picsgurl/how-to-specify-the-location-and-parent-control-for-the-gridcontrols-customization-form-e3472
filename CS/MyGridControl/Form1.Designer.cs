namespace MyGridControl
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbShowStandart = new DevExpress.XtraEditors.SimpleButton();
            this.myGridContrl = new DevExpress.MyControl.MyGridControl();
            this.myGridV = new DevExpress.MyControl.MyGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbShowLocation = new DevExpress.XtraEditors.SimpleButton();
            this.sbShowInParent = new DevExpress.XtraEditors.SimpleButton();
            this.seX = new DevExpress.XtraEditors.SpinEdit();
            this.labCtrlX = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seY = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridContrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbShowStandart
            // 
            this.sbShowStandart.Location = new System.Drawing.Point(12, 11);
            this.sbShowStandart.Name = "sbShowStandart";
            this.sbShowStandart.Size = new System.Drawing.Size(105, 23);
            this.sbShowStandart.TabIndex = 1;
            this.sbShowStandart.Text = "Show standart";
            this.sbShowStandart.Click += new System.EventHandler(this.sbShowStandart_Click);
            // 
            // myGridContrl
            // 
            this.myGridContrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myGridContrl.Location = new System.Drawing.Point(12, 40);
            this.myGridContrl.MainView = this.myGridV;
            this.myGridContrl.Name = "myGridContrl";
            this.myGridContrl.Size = new System.Drawing.Size(605, 337);
            this.myGridContrl.TabIndex = 2;
            this.myGridContrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridV});
            // 
            // myGridV
            // 
            this.myGridV.GridControl = this.myGridContrl;
            this.myGridV.Name = "myGridV";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(628, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 337);
            this.panel1.TabIndex = 3;
            // 
            // sbShowLocation
            // 
            this.sbShowLocation.Location = new System.Drawing.Point(315, 11);
            this.sbShowLocation.Name = "sbShowLocation";
            this.sbShowLocation.Size = new System.Drawing.Size(124, 23);
            this.sbShowLocation.TabIndex = 4;
            this.sbShowLocation.Text = "Show at location";
            this.sbShowLocation.Click += new System.EventHandler(this.sbShowLocation_Click);
            // 
            // sbShowInParent
            // 
            this.sbShowInParent.Location = new System.Drawing.Point(445, 11);
            this.sbShowInParent.Name = "sbShowInParent";
            this.sbShowInParent.Size = new System.Drawing.Size(95, 23);
            this.sbShowInParent.TabIndex = 5;
            this.sbShowInParent.Text = "Show in parent";
            this.sbShowInParent.Click += new System.EventHandler(this.sbShowInParent_Click);
            // 
            // seX
            // 
            this.seX.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seX.Location = new System.Drawing.Point(156, 13);
            this.seX.Name = "seX";
            this.seX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seX.Properties.MaxValue = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.seX.Size = new System.Drawing.Size(67, 20);
            this.seX.TabIndex = 6;
            // 
            // labCtrlX
            // 
            this.labCtrlX.Location = new System.Drawing.Point(140, 16);
            this.labCtrlX.Name = "labCtrlX";
            this.labCtrlX.Size = new System.Drawing.Size(10, 13);
            this.labCtrlX.TabIndex = 7;
            this.labCtrlX.Text = "X:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(229, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Y:";
            // 
            // seY
            // 
            this.seY.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seY.Location = new System.Drawing.Point(243, 13);
            this.seY.Name = "seY";
            this.seY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seY.Properties.MaxValue = new decimal(new int[] {
            768,
            0,
            0,
            0});
            this.seY.Size = new System.Drawing.Size(61, 20);
            this.seY.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 389);
            this.Controls.Add(this.seY);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labCtrlX);
            this.Controls.Add(this.seX);
            this.Controls.Add(this.sbShowInParent);
            this.Controls.Add(this.sbShowLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myGridContrl);
            this.Controls.Add(this.sbShowStandart);
            this.Name = "FormMain";
            this.Text = "Main form";
            ((System.ComponentModel.ISupportInitialize)(this.myGridContrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seY.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbShowStandart;
        private DevExpress.MyControl.MyGridControl myGridContrl;
        private DevExpress.MyControl.MyGridView myGridV;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbShowLocation;
        private DevExpress.XtraEditors.SimpleButton sbShowInParent;
        private DevExpress.XtraEditors.SpinEdit seX;
        private DevExpress.XtraEditors.LabelControl labCtrlX;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seY;

    }
}

