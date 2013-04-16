Public Class gsNumInput
    ' gsNumInput macht aus einer normalen Textbox eine Textbox, 
    ' welche nur numerische Eingaben (Ziffern 0...9, +, - und Dezimaltrennzeichen)
    ' zulässt. 

    ' Die Variable mTB erhält mit Sub New(TextBoxControl)
    ' einen Verweis auf die auf numerische Eingaben zu 
    ' beschränkende Textbox.

    ' Die Eigenschaft NumDecimales bestimmt, ob und wieviele Dezimalstellen
    ' in die Textbox eingegeben werden können.

    ' NumDecimales = 0: 
    '   Nur Ganzzahlen erlaubt, kein Dezimaltrennzeichen

    ' NumDecimales > 0 
    '   Es sind NumDecimales Dezimalstellen erlaubt

    ' Als Dezimaltrennzeichen wird nur das von der Ländereinstellung 
    ' vorgegebenen Zeichen akzeptiert.

    ' Vorzeichen (+,-) können nur als erstes Zeichen eingegeben werden.
    ' Das Einfügen nicht numerischer Werte aus der Zwischenablage in die 
    ' Textbox wird verhindert.
    ' Ebenso können aus der Zwischenablage num. Werte, welche die 
    ' zulässige Anzahl von Dezimalstellen überschreiten nicht eingefügt werden.

    Private mNumDecimales As Integer   ' Anzahl erlaubter Dezimalstellen
    Private mSelStart As Integer           ' akt. Cursorposition
    Private mDP As Integer                  ' ASCII-Wert des Dezimaltrennzeichens
    Private mBuffer As String               ' Puffer für Textboxinhalt

    Private WithEvents mTB As TextBox

    Public Sub New(ByVal TextBoxControl As TextBox)
        mTB = TextBoxControl
        GetDecimalSeparator()
    End Sub

    Public Property NumDecimales() As Integer
        Get
            NumDecimales = mNumDecimales
        End Get
        Set(ByVal Value As Integer)
            mNumDecimales = Value
        End Set
    End Property

    Private Sub GetDecimalSeparator()
        ' Dezimaltrennzeichen für Zahlen lt. Ländereinstellung
        mDP = Asc(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
    End Sub

    Private Sub SetSelStart(ByVal NewSelStart As Integer)
        If mTB.SelectionLength = 0 Then
            mSelStart = NewSelStart
            mTB.SelectionStart = mSelStart
        End If
    End Sub

    Private Function IsNumericExt(ByVal Text As String) As Boolean
        Dim i As Integer
        If Len(Text) > 0 Then
            If mNumDecimales > 0 Then
                IsNumericExt = IsNumeric(Text)
            Else
                For i = 1 To Len(Text)
                    Select Case Asc(Mid(Text, i, 1))
                        Case 0 To 47, 58 To 255
                            IsNumericExt = False
                            Exit Function
                    End Select
                Next i
                IsNumericExt = True
            End If
        Else
            IsNumericExt = True
        End If
    End Function

    Private Sub mTB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mTB.KeyDown
        SetSelStart(mTB.SelectionStart)
    End Sub

    Private Sub mTB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                ' Taste Return (Enter)
            Case Is < 32, 48 To 57
                ' Tastenkombinationen Strg+X, Strg+C, Strg+V (<32)
                ' sowie die Ziffern 0 ... 9 sind erlaubt.

            Case 43, 45
                ' Zeichen "+" (43) oder "-" (45) erlaubt,
                ' wenn es das erste Zeichen in der Textbox ist
                If mTB.SelectionStart > 1 Then
                    e.Handled = True
                End If

            Case mDP
                If mNumDecimales > 0 Then
                    If InStr(mTB.Text, Chr(mDP)) > 0 Then
                        e.Handled = True
                    End If
                Else
                    e.Handled = True
                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub mTB_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mTB.KeyUp
        SetSelStart(mTB.SelectionStart)
    End Sub

    Private Sub mTB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mTB.MouseDown
        SetSelStart(mTB.SelectionStart)
    End Sub

    Private Sub mTB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mTB.TextChanged
        Static InhibitFlag As Boolean
        Dim DP As Integer

        If Not InhibitFlag Then
            Select Case False
                Case IsNumeric(mTB.Text)
                    Select Case mTB.Text
                        Case "-", "+"
                            SetSelStart(mTB.SelectionStart)
                        Case Else
                            If Len(mTB.Text) > 0 Then
                                InhibitFlag = True
                                ' bisherigen Zustand der Textbox wieder herstellen
                                mTB.Text = mBuffer
                                InhibitFlag = False
                                SetSelStart(mSelStart)
                            End If
                    End Select
                Case Else
                    DP = InStr(mTB.Text, Chr(mDP))
                    If DP > 0 Then
                        If (mNumDecimales = 0) Or (Len(Mid(mTB.Text, DP + 1)) > mNumDecimales) Then

                            InhibitFlag = True
                            mTB.Text = mBuffer
                            InhibitFlag = False
                            SetSelStart(mSelStart)

                        End If
                    Else
                        SetSelStart(mTB.SelectionStart)
                    End If
            End Select

            mBuffer = mTB.Text
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not mTB Is Nothing Then
            mTB = Nothing
        End If
        MyBase.Finalize()
    End Sub
End Class
