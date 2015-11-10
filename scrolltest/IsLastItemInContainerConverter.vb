Imports System.Globalization

Public Class IsLastItemInContainerConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Dim item = CType(value, DependencyObject)
        Dim ic = ItemsControl.ItemsControlFromItemContainer(item)

        Dim ff = ic.ItemContainerGenerator.IndexFromContainer(item)
        If (ff = 0) Then
            Return True
        End If
        Dim last = ic.ItemContainerGenerator.IndexFromContainer(item) = ic.Items.Count - 1

        Return last
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class