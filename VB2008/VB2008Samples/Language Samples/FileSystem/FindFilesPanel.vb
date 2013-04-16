﻿' Copyright (c) Microsoft Corporation. All rights reserved.
Public Class FindFilesPanel
    Inherits FileSystemSample.TaskPanelBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents FilesListBox As System.Windows.Forms.ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerNonUserCode()> Private Sub InitializeComponent()
        Me.FilesListBox = New System.Windows.Forms.ListBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Text = "Returns all of the files in a directiory, optionally recursing to include subdire" & _
            "ctories in the search"
        '
        'ExececuteMethodButton
        '
        '
        'ResetValuesButton
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FilesListBox)
        Me.GroupBox2.Controls.SetChildIndex(Me.FilesListBox, 0)
        Me.GroupBox2.Controls.SetChildIndex(Me.EndParenLabel, 0)
        Me.GroupBox2.Controls.SetChildIndex(Me.ExececuteMethodButton, 0)
        Me.GroupBox2.Controls.SetChildIndex(Me.ResetValuesButton, 0)
        '
        'FilesListBox
        '
        Me.FilesListBox.FormattingEnabled = True
        Me.FilesListBox.Location = New System.Drawing.Point(14, 214)
        Me.FilesListBox.Name = "FilesListBox"
        Me.FilesListBox.Size = New System.Drawing.Size(559, 173)
        Me.FilesListBox.TabIndex = 4
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = False
        Me.BackgroundWorker1.WorkerSupportsCancellation = False
        '
        'FindFilesPanel
        '
        Me.Name = "FindFilesPanel"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared panelInstance As FindFilesPanel
    Friend WithEvents dirChooser As New DirectoryChooser()
    Friend WithEvents recurseComboBox As New ComboBox()
    Friend WithEvents wildCardsComboBox As New ComboBox()

    Private searchResults As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
    Private directory As String
    Private recurse As Boolean
    Private wildCards As String()

    ''' <summary>
    ''' Get a global instace of the panel
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetInstance() As FindFilesPanel
        If (panelInstance Is Nothing) Then
            panelInstance = New FindFilesPanel
        End If
        Return panelInstance
    End Function

    ''' <summary>
    ''' Add a control for each parameter to My.Computer.FileSystem.GetFiles()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FindFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeUserControls()
        MyBase.AddParameter("directory", dirChooser)
        MyBase.AddParameter("recurse", recurseComboBox)
        MyBase.AddParameter("wildCards", wildCardsComboBox)
    End Sub

    ''' <summary>
    ''' Initialize the controls to their default values
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeUserControls()
        MyBase.MethodNameLabel.Text = "My.Computer.FileSystem.GetFiles("
        Me.dirChooser.Reset()
        recurseComboBox.Items.AddRange(New String() {"True", "False"})
        recurseComboBox.AutoSize = True
        recurseComboBox.SelectedItem = "False"

        wildCardsComboBox.Items.AddRange(New String() {"*.*", "*.txt", "*.doc", "*.vb", "*.bmp", ".jpg"})
        wildCardsComboBox.AutoSize = True
        wildCardsComboBox.SelectedItem = "*.*"
    End Sub

    ''' <summary>
    ''' Search the chosen directory for files that match the wildcards provided.  We run this operation in the background,
    ''' as it may take a very long time.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExececuteMethodButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExececuteMethodButton.Click
        Me.FilesListBox.Items.Clear()
        Me.FilesListBox.Items.Add("Searching " & Me.dirChooser.Directory & "...")

        directory = Me.dirChooser.Directory
        recurse = Boolean.Parse(CType(Me.recurseComboBox.SelectedItem, String))
        wildCards = New String() {CType(Me.wildCardsComboBox.SelectedItem, String)}

        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub


    ''' <summary>
    ''' Reset the panel to its original state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ResetValuesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetValuesButton.Click
        InitializeUserControls()
    End Sub

    ''' <summary>
    ''' Run GetFiles() in the background
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If (recurse) Then
                searchResults = My.Computer.FileSystem.GetFiles(directory, FileIO.SearchOption.SearchAllSubDirectories, wildCards)
            Else
                searchResults = My.Computer.FileSystem.GetFiles(directory, FileIO.SearchOption.SearchTopLevelOnly, wildCards)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' The search is completed, so update the UI.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.FilesListBox.Items.Clear()
        If (searchResults Is Nothing Or searchResults.Count < 1) Then
            Me.FilesListBox.Items.Add("<No directories found.>")
        Else
            For Each searchResult As String In searchResults
                Me.FilesListBox.Items.Add(searchResult)
            Next
        End If
    End Sub

End Class
