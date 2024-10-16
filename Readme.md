<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128563630/15.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T358210)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Data View for ASP.NET Web Forms - How to bind the control to a data source at runtime
This example demonstrates how to bind the [Data View](https://docs.devexpress.com/AspNet/8280/components/data-and-image-navigation/dataview?p=netframework) control to a data source at runtime. When the control is loaded, the [Load](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.control.load?view=netframework-4.8.1) event's handler creates a data source, defines a template for data items, and binds the control to the data source.

![Bind Data View to Data Source](result.png)

At runtime, assign an object that implements the [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-8.0) interface to the [DataSource](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxDataWebControlBase.DataSource) property and call the [DataBind](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxWebControl.DataBind) method to bind the `ASPxDataView` control to this object.

## Files to Review

* [MyDataViewTemplate.cs](./CS/App_Code/MyDataViewTemplate.cs) (VB: [MyDataViewTemplate.vb](./VB/App_Code/MyDataViewTemplate.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))

## Documentation

- [Bind Data View to Data](https://docs.devexpress.com/AspNet/115695/components/data-and-image-navigation/dataview/concepts/binding-to-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-data-view-bind-control-to-data-at-runtime&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-data-view-bind-control-to-data-at-runtime&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
