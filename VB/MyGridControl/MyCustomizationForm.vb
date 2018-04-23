Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Customization
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Localization



Namespace DevExpress.MyControl
	<ToolboxItem(False)> _
	Public Class MyCustomizationForm
		Inherits CustomizationForm
		Private parentControl As Control



		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
			parentControl = Nothing
		End Sub



		Public Sub New(ByVal view As GridView, ByVal parent As Control)
			Me.New(view)
			parentControl = parent
		End Sub



		Public Overrides Overloads Sub ShowCustomization(ByVal location As Point)
			If parentControl IsNot Nothing Then
				ShowCustomization(parentControl)
				Return
			End If

			MyBase.ShowCustomization(location)
		End Sub
	End Class
End Namespace
