﻿Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Registrator



Namespace DevExpress.MyControl
    Public Class MyGridViewInfoRegistrator
        Inherits GridInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property



        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyGridView(TryCast(grid, GridControl))
        End Function
    End Class
End Namespace
