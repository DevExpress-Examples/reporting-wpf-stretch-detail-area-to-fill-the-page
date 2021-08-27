<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2075)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[UsableDetailPageHeightConverter.cs](./CS/UsableDetailPageHeightConverter.cs) (VB: [UsableDetailPageHeightConverter.vb](./VB/UsableDetailPageHeightConverter.vb))**
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to stretch the detail area to fill the entire page


<p>The following example demonstrates how to calculate the height of a usable page area without a page header and a page footer. This might be required to specify the size of a detail area, which fills the entire page.</p>


<h3>Description</h3>

<p>For this, it is necessary to implement a converter class that subtracts the height of a page header and footer from the entire usable page height. Then, this converter should be used in a <strong>DataTemplate</strong> for a detail area.</p>

<br/>


