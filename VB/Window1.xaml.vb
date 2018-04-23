Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Wpf.Printing

Namespace PageHeightDemo

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New SimpleLink(CType(Resources("detail"), DataTemplate), 1)
			link.PageHeader = CType(Resources("pageHeader"), ControlTemplate)
			link.PageFooter = CType(Resources("pageFooter"), ControlTemplate)
			link.ShowPrintPreviewDialog(Me)
		End Sub
	End Class
End Namespace
