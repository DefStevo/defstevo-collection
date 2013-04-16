Module Module1
    Public Const FILE_ATTRIBUTE_NORMAL As Short = &H80S
    Public Const FILE_FLAG_NO_BUFFERING As Integer = &H20000000
    Public Const FILE_FLAG_WRITE_THROUGH As Integer = &H80000000

    Public Const PIPE_ACCESS_DUPLEX As Short = &H3S
    Public Const PIPE_READMODE_MESSAGE As Short = &H2S
    Public Const PIPE_TYPE_MESSAGE As Short = &H4S
    Public Const PIPE_WAIT As Short = &H0S

    Public Const INVALID_HANDLE_VALUE As Short = -1

    Declare Function CreateNamedPipe Lib "kernel32" Alias "CreateNamedPipeA" _
    (ByVal lpName As String, ByVal dwOpenMode As Integer, _
    ByVal dwPipeMode As Integer, ByVal nMaxInstances As Integer, _
    ByVal nOutBufferSize As Integer, ByVal nInBufferSize As Integer, _
    ByVal nDefaultTimeOut As Integer, ByVal lpSecurityAttributes As IntPtr _
    ) As Integer

    Declare Function ConnectNamedPipe Lib "kernel32" _
        (ByVal hNamedPipe As Integer, ByVal lpOverlapped As Integer) As Integer

    Declare Function DisconnectNamedPipe Lib "kernel32" _
        (ByVal hNamedPipe As Integer) As Integer

    Declare Function WriteFile Lib "kernel32" _
    (ByVal hFile As Integer, ByRef lpBuffer() As Byte, _
    ByVal nNumberOfBytesToWrite As Integer, ByRef lpNumberOfBytesWritten As Integer, _
    ByVal lpOverlapped As Integer _
    ) As Integer

    Declare Function ReadFile Lib "kernel32" _
    (ByVal hFile As Integer, ByRef lpBuffer As Integer, _
    ByVal nNumberOfBytesToRead As Integer, ByRef lpNumberOfBytesRead As Integer, _
    ByVal lpOverlapped As Integer _
    ) As Integer

    Declare Function FlushFileBuffers Lib "kernel32" _
        (ByVal hFile As Integer) As Integer

    Declare Function CloseHandle Lib "kernel32" _
        (ByVal hObject As Integer) As Integer

End Module
