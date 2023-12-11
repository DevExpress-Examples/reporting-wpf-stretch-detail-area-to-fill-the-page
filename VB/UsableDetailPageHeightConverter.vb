Imports System
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Globalization

Namespace PageHeightDemo

    Public Class UsableDetailPageHeightConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Function Convert(ByVal values As Object(), ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim height As Double = CDbl(values(0))
            For i As Integer = 1 To values.Length - 1
                height -= CDbl(values(i))
            Next

            Return height
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes As Type(), ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotSupportedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
