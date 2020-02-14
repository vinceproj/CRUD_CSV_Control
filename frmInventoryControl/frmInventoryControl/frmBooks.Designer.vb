<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValues = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayNonfiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValuesNonfiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuBook, Me.mnuDisplay, Me.mnuValues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(50, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuBook
        '
        Me.mnuBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookAdd, Me.mnuBookDelete, Me.mnuBookUpdate})
        Me.mnuBook.Name = "mnuBook"
        Me.mnuBook.Size = New System.Drawing.Size(65, 29)
        Me.mnuBook.Text = "Book"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayAll, Me.mnuDisplayFiction, Me.mnuDisplayNonfiction})
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(82, 29)
        Me.mnuDisplay.Text = "Display"
        '
        'mnuValues
        '
        Me.mnuValues.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuValuesAll, Me.mnuValuesFiction, Me.mnuValuesNonfiction})
        Me.mnuValues.Name = "mnuValues"
        Me.mnuValues.Size = New System.Drawing.Size(74, 29)
        Me.mnuValues.Text = "Values"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(252, 30)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(252, 30)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuBookAdd
        '
        Me.mnuBookAdd.Name = "mnuBookAdd"
        Me.mnuBookAdd.Size = New System.Drawing.Size(252, 30)
        Me.mnuBookAdd.Text = "Add"
        '
        'mnuBookDelete
        '
        Me.mnuBookDelete.Name = "mnuBookDelete"
        Me.mnuBookDelete.Size = New System.Drawing.Size(252, 30)
        Me.mnuBookDelete.Text = "Delete"
        '
        'mnuBookUpdate
        '
        Me.mnuBookUpdate.Name = "mnuBookUpdate"
        Me.mnuBookUpdate.Size = New System.Drawing.Size(252, 30)
        Me.mnuBookUpdate.Text = "Update"
        '
        'mnuDisplayAll
        '
        Me.mnuDisplayAll.Name = "mnuDisplayAll"
        Me.mnuDisplayAll.Size = New System.Drawing.Size(252, 30)
        Me.mnuDisplayAll.Text = "All"
        '
        'mnuDisplayFiction
        '
        Me.mnuDisplayFiction.Name = "mnuDisplayFiction"
        Me.mnuDisplayFiction.Size = New System.Drawing.Size(252, 30)
        Me.mnuDisplayFiction.Text = "Fiction"
        '
        'mnuDisplayNonfiction
        '
        Me.mnuDisplayNonfiction.Name = "mnuDisplayNonfiction"
        Me.mnuDisplayNonfiction.Size = New System.Drawing.Size(252, 30)
        Me.mnuDisplayNonfiction.Text = "Nonfiction"
        '
        'mnuValuesAll
        '
        Me.mnuValuesAll.Name = "mnuValuesAll"
        Me.mnuValuesAll.Size = New System.Drawing.Size(252, 30)
        Me.mnuValuesAll.Text = "All"
        '
        'mnuValuesFiction
        '
        Me.mnuValuesFiction.Name = "mnuValuesFiction"
        Me.mnuValuesFiction.Size = New System.Drawing.Size(252, 30)
        Me.mnuValuesFiction.Text = "Fiction"
        '
        'mnuValuesNonfiction
        '
        Me.mnuValuesNonfiction.Name = "mnuValuesNonfiction"
        Me.mnuValuesNonfiction.Size = New System.Drawing.Size(252, 30)
        Me.mnuValuesNonfiction.Text = "Nonfiction"
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.ItemHeight = 20
        Me.lstBooks.Location = New System.Drawing.Point(12, 36)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(383, 344)
        Me.lstBooks.TabIndex = 1
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 397)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBooks"
        Me.Text = "Book Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuBook As ToolStripMenuItem
    Friend WithEvents mnuBookAdd As ToolStripMenuItem
    Friend WithEvents mnuBookDelete As ToolStripMenuItem
    Friend WithEvents mnuBookUpdate As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuDisplayAll As ToolStripMenuItem
    Friend WithEvents mnuDisplayFiction As ToolStripMenuItem
    Friend WithEvents mnuDisplayNonfiction As ToolStripMenuItem
    Friend WithEvents mnuValues As ToolStripMenuItem
    Friend WithEvents mnuValuesAll As ToolStripMenuItem
    Friend WithEvents mnuValuesFiction As ToolStripMenuItem
    Friend WithEvents mnuValuesNonfiction As ToolStripMenuItem
    Public WithEvents lstBooks As ListBox
End Class
