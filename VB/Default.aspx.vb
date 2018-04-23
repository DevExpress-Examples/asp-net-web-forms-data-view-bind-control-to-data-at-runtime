#Region "#usings"
Imports DevExpress.Web
Imports System.Collections
Imports System.Drawing
Imports System.Linq
Imports System.Web.UI
#End Region ' #usings

Partial Public Class _Default
    Inherits System.Web.UI.Page

    #Region "#binding"
    Protected Sub DataView_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        DataView.DataSource = GetDataSource()
'        #Region "#templateAssigning"
        DataView.ItemTemplate = New MyDataViewTemplate()
'        #End Region ' #templateAssigning
        DataView.DataBind()
    End Sub
    Public Function GetDataSource() As IEnumerable
        Dim dataSource As IEnumerable = Enumerable.Range(1, 10).Select(Function(i) New With {Key .ID = i, Key .Name = "Name" & i, Key .Description = "Sample description for the item."})
        Return dataSource
    End Function
    #End Region ' #binding
End Class