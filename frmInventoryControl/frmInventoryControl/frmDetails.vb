'Project:       Project 8_Assignment1
'Programmer:    Vincent Tran
'Date:          11/5/19
'Description:   Create a multi-form app that handles book inventory saved to a .txt file

Public Class frmDetails
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check flag for handling; Set appropriate text box preferences
        'Read in values
        If frmBooks.bolUpdOrAdd = False Then
            txtTitle.Enabled = False
            txtAuthor.Enabled = False
            Try
                txtTitle.Text = frmBooks.booksArray(frmBooks.intCurrentIndex).strBookTitle
                txtAuthor.Text = frmBooks.booksArray(frmBooks.intCurrentIndex).strBookAuthor
                txtStock.Text = frmBooks.booksArray(frmBooks.intCurrentIndex).intBookUnits
                txtPrice.Text = frmBooks.booksArray(frmBooks.intCurrentIndex).dblBookPrice
                If frmBooks.booksArray(frmBooks.intCurrentIndex).strBookGenre = "F" Then
                    radFiction.Checked = True
                    radNonfiction.Checked = False
                Else
                    radFiction.Checked = False
                    radNonfiction.Checked = True
                End If
            Catch ex As Exception
                MessageBox.Show("Please select a book from the list to update")
            End Try
        End If

        'Check flag for handling; Set for input
        If frmBooks.bolUpdOrAdd = True Then
            radFiction.Checked = False
            radNonfiction.Checked = False
        End If

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Check flag for handling; If updating read in appropriate parameters and set
        If frmBooks.bolUpdOrAdd = False Then
            Try
                frmBooks.booksArray(frmBooks.intCurrentIndex).intBookUnits = txtStock.Text
                frmBooks.booksArray(frmBooks.intCurrentIndex).dblBookPrice = txtPrice.Text
                If radFiction.Checked Then
                    frmBooks.booksArray(frmBooks.intCurrentIndex).strBookGenre = "F"
                Else
                    frmBooks.booksArray(frmBooks.intCurrentIndex).strBookGenre = "N"
                End If
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Please keep no fields blank")
            End Try
        End If

        'Check flags for handling; Input validation
        If frmBooks.bolUpdOrAdd = True Then
            If txtTitle.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf txtAuthor.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf txtStock.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf txtTitle.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf radFiction.Checked = False And radNonfiction.Checked = False Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            End If

            'Set value of new array entry
            Try
                frmBooks.booksArray(frmBooks.intCurrentBooks).strBookTitle = txtTitle.Text
                frmBooks.booksArray(frmBooks.intCurrentBooks).strBookAuthor = txtAuthor.Text
                frmBooks.booksArray(frmBooks.intCurrentBooks).intBookUnits = txtStock.Text
                frmBooks.booksArray(frmBooks.intCurrentBooks).dblBookPrice = txtPrice.Text
                If radFiction.Checked Then
                    frmBooks.booksArray(frmBooks.intCurrentBooks).strBookGenre = "F"
                ElseIf radNonfiction.Checked Then
                    frmBooks.booksArray(frmBooks.intCurrentBooks).strBookGenre = "N"
                End If
                frmBooks.lstBooks.Items.Add(frmBooks.booksArray(frmBooks.intCurrentBooks).strBookTitle)
                frmBooks.intCurrentBooks += 1
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Please fill all fields")
            End Try
        End If
    End Sub
End Class