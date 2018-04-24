Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MyGridControl
    Partial Public Class FormMain
        Inherits Form

        Private dtList As DataTable
        Public Sub New()
            InitializeComponent()
            InitDataList()
            myGridContrl.DataSource = dtList
        End Sub



        Private Sub InitDataList()
            dtList = New DataTable()
            dtList.Columns.AddRange(New DataColumn() { _
                New DataColumn("Name"), _
                New DataColumn("Info") _
            })

            Dim rnd As New Random()
            For i As Integer = 0 To 9
                dtList.Rows.Add(New Object() { "Name_" & rnd.Next(10, 100).ToString(), "Info" & rnd.Next(1000, 100000).ToString() })
            Next i

        End Sub



        Private Sub sbShowStandart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowStandart.Click
            myGridV.ShowCustomization()
        End Sub



        Private Sub sbShowLocation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowLocation.Click
            myGridV.ShowCustomization(New Point(CInt((seX.Value)), CInt((seY.Value))))
        End Sub



        Private Sub sbShowInParent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowInParent.Click
            myGridV.ShowCustomization(panel1)
        End Sub
    End Class
End Namespace