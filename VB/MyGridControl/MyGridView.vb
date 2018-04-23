Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports DevExpress.XtraGrid.Views.Base.ViewInfo





Namespace DevExpress.MyControl
	Public Class MyGridView
		Inherits GridView
		Private parentControl As Control



		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property



		Public Sub New()
			Me.New(Nothing)
		End Sub


		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			parentControl = Nothing
		End Sub


		Public Overloads Sub ShowCustomization(ByVal location As Point)
			parentControl = Nothing
			ColumnsCustomization(location)
		End Sub



		Public Overloads Sub ShowCustomization(ByVal parent As Control)
			parentControl = parent
			ColumnsCustomization(BaseViewInfo.EmptyPoint)
		End Sub


		Protected Overrides Function CreateCustomizationForm() As CustomizationForm
			If parentControl IsNot Nothing Then
				Return TryCast((New MyCustomizationForm(Me, parentControl)), CustomizationForm)
			Else
				Return TryCast((New MyCustomizationForm(Me)), CustomizationForm)
			End If
		End Function
	End Class
End Namespace
