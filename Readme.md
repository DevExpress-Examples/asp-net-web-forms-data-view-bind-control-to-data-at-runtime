<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128563630/15.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T358210)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyDataViewTemplate.cs](./CS/App_Code/MyDataViewTemplate.cs) (VB: [MyDataViewTemplate.vb](./VB/App_Code/MyDataViewTemplate.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to bind the ASPxDataView control to a data source at runtime
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t358210/)**
<!-- run online end -->


<p>To bind the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxDataViewtopic">ASPxDataView</a> control to a data source at runtime, use any object that implements the <a href="https://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx">IEnumerable</a> interface such as <a href="https://msdn.microsoft.com/en-us/library/system.data.dataset.aspx">ADO.NET datasets</a>, data readers (e.g., <a href="https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldatareader.aspx">SqlDataReader</a>, <a href="https://msdn.microsoft.com/en-us/library/system.data.oledb.oledbdatareader.aspx">OleDbDataReader</a>), and most collections. Assign the data object to the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxDataWebControlBase_DataSourcetopic">ASPxDataView.DataSource</a> property value and call the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxWebControl_DataBindtopic">ASPxDataView.DataBind</a> method to bind the control to data.<br><br>In this example, a custom data source is created with the <a href="https://msdn.microsoft.com/en-us/library/system.linq.enumerable.range%28v=vs.100%29.aspx">Enumerable.Range</a> method. The item template for displaying <a href="http://help.devexpress.com/#AspNet/CustomDocument115725">data items</a> is also created at runtime.</p>
<br><strong>See Also:<br></strong><a href="http://help.devexpress.com/#AspNet/CustomDocument115695">ASPxDataView — Binding to Data</a><br><a href="https://www.devexpress.com/Support/Center/p/T358208">How to bind the ASPxDataView control to the data source declaratively</a><br><a href="https://www.devexpress.com/Support/Center/p/T358211">How to fill the unbound ASPxDataView control with data items at runtime</a>

<br/>


