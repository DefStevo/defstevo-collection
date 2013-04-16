Partial Public Class Employee

    Public Overrides Function tostring() As String
        Return String.Format("{0} {1} {2}", Me._TitleOfCourtesy, Me._FirstName, Me._LastName)
    End Function
End Class
