Partial Public Class frmMenu
  Inherits Form
  Public myDB As New DB
    Public objRS2 As New ADODB.Recordset
    Public objRS3 As New ADODB.Recordset


#Region "Form1_Load"

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With myDB
            .Srv = "R400\SQLEXPRESS"
            .DB = "SQLTst"
            .RS = "Tst"
            .ConnectDB()
            .OpenRS()
        End With
        objRS2 = myDB.objRS
        ListView1.GridLines = True
        ListView1.LabelEdit = True
        ListView1.Columns.Add(objRS2.Fields(0).Name, 134)
        ListView1.Columns.Add(objRS2.Fields(1).Name, 134)
        objRS2.MoveFirst()
        While Not objRS2.EOF
            Dim LV As ListViewItem = ListView1.Items.Add(Strings.Left(objRS2.Fields(0).Value, 2))
            LV.SubItems.Add(objRS2.Fields(1).Value, Color.Blue, Color.Yellow, Nothing)
            objRS2.MoveNext()
        End While
        CreateMyListView()

    End Sub

#End Region
#Region "Buttons"
#Region "Button 1-5"

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim Nr As Integer
    Nr = ListView1.Items.Count + 1
    myDB.objRS.AddNew()
    myDB.objRS.Fields("TstId").Value = Nr
    myDB.objRS.Fields("Test").Value = "Test" & Nr
    myDB.objRS.Update()
    Dim LV As ListViewItem = ListView1.Items.Add(Nr)
    LV.SubItems.Add("Test" & Nr)
  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    ListView1.View = View.List
    ListView2.View = View.List
  End Sub

  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    ListView1.View = View.Details
    ListView2.View = View.Details
  End Sub

  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    ListView1.View = View.SmallIcon
    ListView2.View = View.SmallIcon
  End Sub

  Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    ListView1.View = View.LargeIcon
    ListView2.View = View.LargeIcon
  End Sub

#End Region
#Region "Button 6-11"

  Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    ListView1.View = View.Tile
    ListView2.View = View.Tile
  End Sub

  Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
    ListView1_Click(Nothing, Nothing)
    ListView2_Click(Nothing, Nothing)
  End Sub

  Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    'SplashScreen1.Show()
  End Sub

  Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    'LoginForm1.Show()
  End Sub

  Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    Dim hash As New Hashtable()
    Dim de As DictionaryEntry

    hash.Add("nbg", "Nürnberg")
    hash.Add("muc", "München")
    hash.Add("ham", "Hamburg")

    ' Werte der Hashtable auflisten
    Dim strTST1 As String 'Überwachen um Auswirkung zu sehen
    Dim strTST2 As String 'Überwachen um Auswirkung zu sehen
    For Each de In hash
      strTST1 = de.Key
      strTST2 = de.Value
    Next
  End Sub

  Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
    Dim strHlp As String
    Dim arrSpalte As String() = {"NeuId INTEGER NOT NULL", "NeuName Text NOT NULL", "NeuPLZ VARCHAR(5) NULL"}
    strHlp = InputBox("Tabellenname?", "Bitte Tabellenname angeben")
    myDB.ErstelleTabelle(strHlp, arrSpalte)
  End Sub

#End Region
#End Region
#Region "Listen"

  Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
    MsgBox(ListView1.FocusedItem.SubItems(0).Text & ListView1.FocusedItem.SubItems(1).Text)
  End Sub

  Private Sub ListView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
    MsgBox(ListView2.FocusedItem.SubItems(0).Text & ListView2.FocusedItem.SubItems(1).Text & ListView2.FocusedItem.SubItems(2).Text & ListView2.FocusedItem.SubItems(3).Text)
  End Sub

#End Region
#Region "Sonstige"

  Private Sub CreateMyListView()
    ' Set the view to show details.
    ListView2.View = View.Details
    ' Allow the user to edit item text.
    ListView2.LabelEdit = True
    ' Display check boxes.
    ListView2.CheckBoxes = False
    ' Select the item and subitems when selection is made.
    ListView2.FullRowSelect = True
    ' Display grid lines.
    ListView2.GridLines = True
    ' Sort the items in the list in ascending order.
    ListView2.Sorting = SortOrder.Ascending

    Dim item1 As New ListViewItem(New String() {"item1", "1", "2", "3"}, 0, Color.Empty, Color.Aquamarine, New Font("Century Gothic", 10.0F, FontStyle.Regular, GraphicsUnit.Point, Nothing))
    Dim item2 As New ListViewItem(New String() {"item2", "4", "5", "6"}, 1, Color.Empty, Color.LightBlue, New Font("Century Gothic", 10.0F, FontStyle.Regular, GraphicsUnit.Point, Nothing))
    Dim item3 As New ListViewItem(New String() {"item3", "7", "8", "9"}, 2, Color.Empty, Color.Aqua, New Font("Century Gothic", 10.0F, FontStyle.Regular, GraphicsUnit.Point, Nothing))
    Dim item4 As New ListViewItem(New String() {"item4", "10", "11", "12"}, 0, Color.Empty, Color.LightBlue, New Font("Century Gothic", 10.0F, FontStyle.Regular, GraphicsUnit.Point, Nothing))

    ' Create columns for the items and subitems.
    ListView2.Columns.Add("Item Column", 75, HorizontalAlignment.Left)
    ListView2.Columns.Add("Column 2", 70, HorizontalAlignment.Left)
    ListView2.Columns.Add("Column 3", 70, HorizontalAlignment.Left)
    ListView2.Columns.Add("Column 4", 70, HorizontalAlignment.Center)

    'Add the items to the ListView.
    ListView2.Items.AddRange(New ListViewItem() {item1, item2, item3, item4})

    ' Create two ImageList objects.
    Dim imageListSmall As New ImageList()
    Dim imageListLarge As New ImageList()

    ' Initialize the ImageList objects with bitmaps.
    'imageListSmall.Images.Add(Bitmap.FromFile("C:\Small1.bmp"))
    'imageListSmall.Images.Add(Bitmap.FromFile("C:\Small2.bmp"))
    'imageListSmall.Images.Add(Bitmap.FromFile("C:\Small3.bmp"))
    'imageListLarge.Images.Add(Bitmap.FromFile("C:\Large1.bmp"))
    'imageListLarge.Images.Add(Bitmap.FromFile("C:\Large2.bmp"))
    'imageListLarge.Images.Add(Bitmap.FromFile("C:\Large3.bmp"))

    'Assign the ImageList objects to the ListView.
    ListView2.LargeImageList = imageListLarge
    ListView2.SmallImageList = imageListSmall

  End Sub
#End Region

  Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

  End Sub
End Class