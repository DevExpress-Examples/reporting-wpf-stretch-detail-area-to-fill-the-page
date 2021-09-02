Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing

Namespace PageHeightDemo

	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New SimpleLink(DirectCast(Resources("detail"), DataTemplate), 1)
			link.PageHeaderTemplate = DirectCast(Resources("pageHeader"), DataTemplate)
			link.PageFooterTemplate = DirectCast(Resources("pageFooter"), DataTemplate)
			link.ShowPrintPreviewDialog(Me)
		End Sub
	End Class
End Namespace
