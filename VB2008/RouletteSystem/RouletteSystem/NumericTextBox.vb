Imports System.ComponentModel

Public Class NumericTextBox
    Inherits TextBox

    Private _bIsInteger As Boolean = False
    Private _bStartsWithNull As Boolean = True
    Protected Overrides Sub OnKeyPress( _
      ByVal e As System.Windows.Forms.KeyPressEventArgs)

        MyBase.OnKeyPress(e)

        Select Case Asc(e.KeyChar)
            ' Zahlen und Backspace

            Case 49 To 57, 8
                ' Do Nothing

            Case 48
                ' Beginnende 0 Unterdrücken
                If Not StartsWithNull Then
                    If Me.SelectionStart = 0 And e.KeyChar = "0" Then
                        e.KeyChar = ""
                    End If
                End If

            Case 44
                ' Dezimaltrennzeichen zulassen bzw. unterdrücken
                If IsInteger Then
                    e.Handled = True
                Else
                    If Me.Text.Contains(",") Then e.Handled = True
                End If

            Case Else
                e.Handled = True
        End Select

    End Sub

    Protected Overrides Sub OnKeyUp( _
     ByVal e As System.Windows.Forms.KeyEventArgs)

        MyBase.OnKeyUp(e)
        ' Text nach Eingabe kontrollieren ob diese nicht mit 0 Beginnt

        If Not StartsWithNull Then

            Dim bNullFirst As Boolean = True

            While bNullFirst = True
                If Len(Me.Text) = 0 Then
                    bNullFirst = False
                Else
                    If Me.Text.Substring(0, 1) = "0" Then
                        Me.Text = Me.Text.Substring(1, Len(Me.Text) - 1)
                        bNullFirst = True
                    Else
                        bNullFirst = False
                    End If
                End If
            End While

        End If
    End Sub

    <Description("Legt fest ob die TextBox nur Ganzzahlen annimmt. " & _
                 "True = Integer, False = Float"), Category("Numeric")> _
    Public Property IsInteger() As Boolean
        Get
            Return _bIsInteger
        End Get
        Set(ByVal value As Boolean)
            _bIsInteger = value
        End Set
    End Property

    <Description("Legt fest ob die TextBox mit 0 beginnen darf. " & _
                 "True = Darf mit 0 beginnen, False = Darf nicht mit 0 beginnen"), Category("Numeric")> _
    Public Property StartsWithNull() As Boolean
        Get
            Return _bStartsWithNull
        End Get
        Set(ByVal value As Boolean)
            _bStartsWithNull = value
        End Set
    End Property
End Class