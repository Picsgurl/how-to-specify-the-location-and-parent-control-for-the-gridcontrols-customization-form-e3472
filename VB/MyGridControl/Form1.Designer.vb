Imports Microsoft.VisualBasic
Imports System
Namespace MyGridControl
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.sbShowStandart = New DevExpress.XtraEditors.SimpleButton()
			Me.myGridContrl = New DevExpress.MyControl.MyGridControl()
			Me.myGridV = New DevExpress.MyControl.MyGridView()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.sbShowLocation = New DevExpress.XtraEditors.SimpleButton()
			Me.sbShowInParent = New DevExpress.XtraEditors.SimpleButton()
			Me.seX = New DevExpress.XtraEditors.SpinEdit()
			Me.labCtrlX = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.seY = New DevExpress.XtraEditors.SpinEdit()
			CType(Me.myGridContrl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridV, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sbShowStandart
			' 
			Me.sbShowStandart.Location = New System.Drawing.Point(12, 11)
			Me.sbShowStandart.Name = "sbShowStandart"
			Me.sbShowStandart.Size = New System.Drawing.Size(105, 23)
			Me.sbShowStandart.TabIndex = 1
			Me.sbShowStandart.Text = "Show standart"
'			Me.sbShowStandart.Click += New System.EventHandler(Me.sbShowStandart_Click);
			' 
			' myGridContrl
			' 
			Me.myGridContrl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.myGridContrl.Location = New System.Drawing.Point(12, 40)
			Me.myGridContrl.MainView = Me.myGridV
			Me.myGridContrl.Name = "myGridContrl"
			Me.myGridContrl.Size = New System.Drawing.Size(605, 337)
			Me.myGridContrl.TabIndex = 2
			Me.myGridContrl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridV})
			' 
			' myGridV
			' 
			Me.myGridV.GridControl = Me.myGridContrl
			Me.myGridV.Name = "myGridV"
			' 
			' panel1
			' 
			Me.panel1.AllowDrop = True
			Me.panel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))))
			Me.panel1.Location = New System.Drawing.Point(628, 40)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(343, 337)
			Me.panel1.TabIndex = 3
			' 
			' sbShowLocation
			' 
			Me.sbShowLocation.Location = New System.Drawing.Point(315, 11)
			Me.sbShowLocation.Name = "sbShowLocation"
			Me.sbShowLocation.Size = New System.Drawing.Size(124, 23)
			Me.sbShowLocation.TabIndex = 4
			Me.sbShowLocation.Text = "Show at location"
'			Me.sbShowLocation.Click += New System.EventHandler(Me.sbShowLocation_Click);
			' 
			' sbShowInParent
			' 
			Me.sbShowInParent.Location = New System.Drawing.Point(445, 11)
			Me.sbShowInParent.Name = "sbShowInParent"
			Me.sbShowInParent.Size = New System.Drawing.Size(95, 23)
			Me.sbShowInParent.TabIndex = 5
			Me.sbShowInParent.Text = "Show in parent"
'			Me.sbShowInParent.Click += New System.EventHandler(Me.sbShowInParent_Click);
			' 
			' seX
			' 
			Me.seX.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seX.Location = New System.Drawing.Point(156, 13)
			Me.seX.Name = "seX"
			Me.seX.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seX.Properties.MaxValue = New Decimal(New Integer() { 1024, 0, 0, 0})
			Me.seX.Size = New System.Drawing.Size(67, 20)
			Me.seX.TabIndex = 6
			' 
			' labCtrlX
			' 
			Me.labCtrlX.Location = New System.Drawing.Point(140, 16)
			Me.labCtrlX.Name = "labCtrlX"
			Me.labCtrlX.Size = New System.Drawing.Size(10, 13)
			Me.labCtrlX.TabIndex = 7
			Me.labCtrlX.Text = "X:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(229, 16)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(10, 13)
			Me.labelControl1.TabIndex = 8
			Me.labelControl1.Text = "Y:"
			' 
			' seY
			' 
			Me.seY.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.seY.Location = New System.Drawing.Point(243, 13)
			Me.seY.Name = "seY"
			Me.seY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seY.Properties.MaxValue = New Decimal(New Integer() { 768, 0, 0, 0})
			Me.seY.Size = New System.Drawing.Size(61, 20)
			Me.seY.TabIndex = 9
			' 
			' FormMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(983, 389)
			Me.Controls.Add(Me.seY)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.labCtrlX)
			Me.Controls.Add(Me.seX)
			Me.Controls.Add(Me.sbShowInParent)
			Me.Controls.Add(Me.sbShowLocation)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.myGridContrl)
			Me.Controls.Add(Me.sbShowStandart)
			Me.Name = "FormMain"
			Me.Text = "Main form"
			CType(Me.myGridContrl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridV, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents sbShowStandart As DevExpress.XtraEditors.SimpleButton
		Private myGridContrl As DevExpress.MyControl.MyGridControl
		Private myGridV As DevExpress.MyControl.MyGridView
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents sbShowLocation As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbShowInParent As DevExpress.XtraEditors.SimpleButton
		Private seX As DevExpress.XtraEditors.SpinEdit
		Private labCtrlX As DevExpress.XtraEditors.LabelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private seY As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace

