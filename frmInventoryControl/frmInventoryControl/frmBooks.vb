'Project:       Project 8_Assignment1
'Programmer:    Vincent Tran
'Date:          11/5/19
'Description:   Create a multi-form app that handles book inventory saved to a .txt file

Public Class frmBooks
    'Declare structure for handling
    Public Structure BookStruct
        Public strBookTitle As String
        Public strBookAuthor As String
        Public strBookGenre As String
        Public intBookUnits As Integer
        Public dblBookPrice As Double
    End Structure
    'Declare other vars
    Public booksArray(50) As BookStruct 'Array size limited to 50
    Public intBooksStock As Integer
    Public bolUpdOrAdd As Boolean 'False for Update & True for Add
    Public intCurrentIndex As Integer = 0
    Public intCurrentBooks As Integer = 0
    Public swBooksData As IO.StreamReader
    Public swBooksUpdater As IO.StreamWriter
    Public intGenreFlag As Integer = 0

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try to open the file, read in the books to the array, and then close the file connection
        Try
            swBooksData = IO.File.OpenText("Books.txt")
            readInBooks()
            swBooksData.Close()
        Catch ex As Exception
            MessageBox.Show("Error reading in file.")
        End Try

        'Display the book titles in the list box
        Try
            displayBooksByType()
        Catch ex As Exception
            MessageBox.Show("Error listing book titles")
        End Try

    End Sub

    Private Sub readInBooks()
        'Declare temp vars
        Dim tempArray() As String
        Dim tempString As String


        'Do loop until end of file; Split line into parts and set parts as needed 
        Do Until swBooksData.EndOfStream
            tempString = swBooksData.ReadLine()
            tempArray = tempString.Split(","c)

            booksArray(intCurrentIndex).strBookTitle = tempArray(0)
            booksArray(intCurrentIndex).strBookAuthor = tempArray(1)
            booksArray(intCurrentIndex).strBookGenre = tempArray(2)
            booksArray(intCurrentIndex).intBookUnits = tempArray(3)
            booksArray(intCurrentIndex).dblBookPrice = tempArray(4)

            intCurrentIndex += 1
            intCurrentBooks += 1
        Loop
    End Sub

    Private Sub displayBooksByType()
        'Select case based on handling flag; Set check values; Clear list and add wanted titles
        Select Case intGenreFlag
            Case 0
                mnuDisplayAll.Checked = True
                mnuDisplayFiction.Checked = False
                mnuDisplayNonfiction.Checked = False
                lstBooks.Items.Clear()
                For index As Integer = 0 To intCurrentBooks - 1
                    If booksArray(index).strBookTitle <> "" Then
                        lstBooks.Items.Add(booksArray(index).strBookTitle)
                    End If
                Next
            Case 1
                mnuDisplayAll.Checked = False
                mnuDisplayFiction.Checked = True
                mnuDisplayNonfiction.Checked = False
                lstBooks.Items.Clear()
                For index As Integer = 0 To intCurrentBooks - 1
                    If booksArray(index).strBookGenre = "F" Then
                        lstBooks.Items.Add(booksArray(index).strBookTitle)
                    End If
                Next
            Case 2
                mnuDisplayAll.Checked = False
                mnuDisplayFiction.Checked = False
                mnuDisplayNonfiction.Checked = True
                lstBooks.Items.Clear()
                For index As Integer = 0 To intCurrentBooks - 1
                    If booksArray(index).strBookGenre = "N" Then
                        lstBooks.Items.Add(booksArray(index).strBookTitle)
                    End If
                Next
        End Select
    End Sub

    Private Sub displayValuesByType()
        'Declare temp var for handling
        Dim tempSum As Double = 0.0

        'Select Case for handling what type of genre is selected
        Select Case intGenreFlag
            Case 0
                For index As Integer = 0 To intCurrentBooks - 1
                    tempSum += booksArray(index).dblBookPrice * booksArray(index).intBookUnits
                Next
                MessageBox.Show("Total value Of all books: " + tempSum.ToString("c"))
            Case 1
                For index As Integer = 0 To intCurrentBooks - 1
                    If booksArray(index).strBookGenre = "F" Then
                        tempSum += booksArray(index).dblBookPrice * booksArray(index).intBookUnits
                    End If
                Next
                MessageBox.Show("Total value of fiction books: " + tempSum.ToString("c"))
            Case 2
                For index As Integer = 0 To intCurrentBooks - 1
                    If booksArray(index).strBookGenre = "N" Then
                        tempSum += booksArray(index).dblBookPrice * booksArray(index).intBookUnits
                    End If
                Next
                MessageBox.Show("Total value of nonfiction books: " + tempSum.ToString("c"))
        End Select
    End Sub

    Private Sub mnuDisplayAll_Click(sender As Object, e As EventArgs) Handles mnuDisplayAll.Click
        'Set handling flag; Display books based on flag
        intGenreFlag = 0
        displayBooksByType()
    End Sub

    Private Sub mnuDisplayFiction_Click(sender As Object, e As EventArgs) Handles mnuDisplayFiction.Click
        'Set handling flag; Display books based on flag
        intGenreFlag = 1
        displayBooksByType()
    End Sub

    Private Sub mnuDisplayNonfiction_Click(sender As Object, e As EventArgs) Handles mnuDisplayNonfiction.Click
        'Set handling flag; Display books based on flag
        intGenreFlag = 2
        displayBooksByType()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'End Program
        End
    End Sub

    Private Sub mnuValuesAll_Click(sender As Object, e As EventArgs) Handles mnuValuesAll.Click
        'Set handling flag; Output value based on flag
        intGenreFlag = 0
        displayValuesByType()
    End Sub

    Private Sub mnuValuesFiction_Click(sender As Object, e As EventArgs) Handles mnuValuesFiction.Click
        'Set handling flag; Output value based on flag
        intGenreFlag = 1
        displayValuesByType()
    End Sub

    Private Sub mnuValuesNonfiction_Click(sender As Object, e As EventArgs) Handles mnuValuesNonfiction.Click
        'Set handling flag; Output value based on flag
        intGenreFlag = 2
        displayValuesByType()
    End Sub

    Private Sub mnuBookAdd_Click(sender As Object, e As EventArgs) Handles mnuBookAdd.Click
        'Set flag for handling; Open form for use
        Try
            bolUpdOrAdd = True
            Dim openDetails = New frmDetails
            openDetails.Show()
        Catch ex As Exception
            MessageBox.Show("Error adding a book")
        End Try

    End Sub

    Private Sub mnuBookDelete_Click(sender As Object, e As EventArgs) Handles mnuBookDelete.Click
        'Set chosen array value to it's successor and repeat until reaching an empty array
        Try
            intCurrentIndex = lstBooks.SelectedIndex
            If intCurrentIndex >= 0 Then
                For i As Integer = intCurrentIndex To intCurrentBooks
                    If booksArray(i + 1).strBookTitle <> "" Then
                        booksArray(i).strBookTitle = booksArray(i + 1).strBookTitle
                    End If
                Next
            Else
                MessageBox.Show("Please select a book from the list.")
                Exit Sub
            End If

            'Set last value to empty string and other reset values; Used to "resize" the array
            booksArray(intCurrentBooks - 1).strBookTitle = ""
            booksArray(intCurrentBooks - 1).strBookAuthor = ""
            booksArray(intCurrentBooks - 1).strBookGenre = ""
            booksArray(intCurrentBooks - 1).intBookUnits = -1
            booksArray(intCurrentBooks - 1).dblBookPrice = -1

            'Decrement current books count and refresh the display
            intCurrentBooks -= 1
            displayBooksByType()
        Catch ex As Exception
            MessageBox.Show("Error deleting book")
        End Try
    End Sub

    Private Sub mnuBookUpdate_Click(sender As Object, e As EventArgs) Handles mnuBookUpdate.Click
        'Get index for handling; Open form
        Try
            intCurrentIndex = lstBooks.SelectedIndex
            If intCurrentIndex >= 0 Then
                bolUpdOrAdd = False
                Dim openDetails = New frmDetails
                openDetails.Show()
            Else
                MessageBox.Show("Please select a book from the list.")
            End If

        Catch ex As Exception
            MessageBox.Show("Please select a book from the list.")
        End Try

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'Overwrite file to empty the file at file path; Close connection
        swBooksUpdater = IO.File.CreateText("Books.txt")
        swBooksUpdater.Close()

        'For all books in array set values to string and append string to file
        For i As Integer = 0 To intCurrentBooks - 1
            Dim tempString As String = ""

            tempString += booksArray(i).strBookTitle + ","
            tempString += booksArray(i).strBookAuthor + ","
            tempString += booksArray(i).strBookGenre + ","
            tempString += booksArray(i).intBookUnits.ToString + ","
            tempString += booksArray(i).dblBookPrice.ToString
            swBooksUpdater = IO.File.AppendText("Books.txt")
            swBooksUpdater.WriteLine(tempString)
            swBooksUpdater.Close()

        Next


    End Sub
End Class
