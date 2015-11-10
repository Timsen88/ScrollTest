Imports System.Collections.ObjectModel

Class MainWindow



    Private Sub ReceiptListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ReceiptListBox.SelectionChanged

        '  Dim scrollViewer As ScrollViewer = CType(sender.Template.FindName("UpButton", ScrollViewer), ScrollViewer)
        Dim currentItem = ReceiptListBox.SelectedItem
        If Not currentItem Is Nothing Then
            '  test2.Clear()
            ReceiptListBox.UpdateLayout()
            ReceiptListBox.ScrollIntoView(currentItem)
            ' offsetDifferet = False

            Dim send = CType(sender, ListBox)
            Dim _verticalScrollBar = CType(send.Template.FindName("VerticalScroller", send), ScrollViewer)

            'If _verticalScrollBar.VerticalOffset = 0 Then
            '    _upButton.Visibility = Visibility.Collapsed
            'Else
            '    _upButton.Visibility = Visibility.Visible
            'End If

            'If _verticalScrollBar.VerticalOffset = _verticalScrollBar.ScrollableHeight Then
            '    _downButton.Visibility = Visibility.Collapsed
            'Else
            '    _downButton.Visibility = Visibility.Visible
            'End If

            '_scroll = _verticalScrollBar

        End If

    End Sub

    Private _totalAmount As Decimal
    Public Property TotalAmount() As Decimal
        Get
            Return _totalAmount
        End Get
        Set(ByVal value As Decimal)
            _totalAmount = value
        End Set
    End Property


    Private _totaldisc As Decimal
    Public Property TotalDiscount() As Decimal
        Get
            Return _totaldisc
        End Get
        Set(ByVal value As Decimal)
            _totaldisc = value
        End Set
    End Property

    Private ReceiptLines As ObservableCollection(Of ReceiptLine) = New ObservableCollection(Of ReceiptLine)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))
        'ReceiptLines.Add(New ReceiptLine(1, "adasdasd"))

        Me.TotalAmount = 12314
        Me.DataContext = ReceiptLines
        ReceiptListBox.ItemsSource = ReceiptLines

    End Sub

    Private Sub VerticalScroller_ScrollChanged(sender As Object, e As ScrollChangedEventArgs)

    End Sub

    Private Sub UpButton_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub VerticalScroller_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ff = New ReceiptLine(1, "new item!")
        ReceiptLines.Add(ff)
        ' ReceiptListBox.ItemsSource = ReceiptLines
        ReceiptListBox.SelectedItem = ff



    End Sub
End Class

Public Class ReceiptLine

    Private test As String
    Public Property Text() As String
        Get
            Return test
        End Get
        Set(ByVal value As String)
            test = value
        End Set
    End Property
    Private price2 As Decimal
    Public Property Price() As Decimal
        Get
            Return price2
        End Get
        Set(ByVal value As Decimal)
            price2 = value
        End Set
    End Property

    Public Sub New(price1 As Decimal, text1 As String)
        Text = text1
        Price = price1
    End Sub

End Class

