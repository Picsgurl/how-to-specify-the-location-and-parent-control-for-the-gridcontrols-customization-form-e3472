Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator



Namespace DevExpress.MyControl
    Public Class MyGridControl
        Inherits GridControl

        Protected Overrides Function CreateDefaultView() As BaseView
            Return CreateView("MyGridView")
        End Function



        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyGridViewInfoRegistrator())
        End Sub
    End Class
End Namespace
