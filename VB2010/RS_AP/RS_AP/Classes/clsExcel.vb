Imports Microsoft.Office.Interop.Excel

Public Class clsExcel
    Private _Excel As New Microsoft.Office.Interop.Excel.Application

    Public Function Open(strFile As String) As Boolean
        _Excel = New Microsoft.Office.Interop.Excel.Application
        _Excel.Workbooks.Open(strFile)
        _Excel.Visible = True
        Return (True)

    End Function

    Public Function ReadRange(Range As String) As String
        Dim Result(_Excel.Range(Range).Rows.Count - 1, _Excel.Range(Range).Columns.Count - 1) As String

        For i As Integer = 0 To _Excel.Range(Range).Rows.Count - 1
            For i2 As Integer = 0 To _Excel.Range(Range).Columns.Count - 1
                Result(i, i2) = _Excel.Range(Range).Cells(i + 1, i2 + 1).Value
            Next
        Next

        Return Result(0, 0)

    End Function

    Public Function WriteRange(Range As String, Value As String) As Boolean
        _Excel.Range(Range).Value = Value
        Return True
    End Function

    Public Function Close(strFile As String) As Boolean
        _Excel.GetSaveAsFilename("Mappe1")
        _Excel.DisplayAlerts = False
        _Excel.Application.Quit()
        Return True
    End Function
End Class
