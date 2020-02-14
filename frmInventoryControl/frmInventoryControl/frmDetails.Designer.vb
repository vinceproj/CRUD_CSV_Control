<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.radFiction = New System.Windows.Forms.RadioButton()
        Me.radNonfiction = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(90, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(297, 26)
        Me.txtTitle.TabIndex = 0
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(90, 91)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(297, 26)
        Me.txtAuthor.TabIndex = 1
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(90, 135)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(59, 26)
        Me.txtStock.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(328, 135)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(59, 26)
        Me.txtPrice.TabIndex = 3
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(20, 304)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(367, 46)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record Details"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.radNonfiction)
        Me.grpCategory.Controls.Add(Me.radFiction)
        Me.grpCategory.Location = New System.Drawing.Point(20, 181)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(367, 100)
        Me.grpCategory.TabIndex = 5
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'radFiction
        '
        Me.radFiction.AutoSize = True
        Me.radFiction.Location = New System.Drawing.Point(52, 38)
        Me.radFiction.Name = "radFiction"
        Me.radFiction.Size = New System.Drawing.Size(81, 24)
        Me.radFiction.TabIndex = 0
        Me.radFiction.TabStop = True
        Me.radFiction.Text = "Fiction"
        Me.radFiction.UseVisualStyleBackColor = True
        '
        'radNonfiction
        '
        Me.radNonfiction.AutoSize = True
        Me.radNonfiction.Location = New System.Drawing.Point(210, 38)
        Me.radNonfiction.Name = "radNonfiction"
        Me.radNonfiction.Size = New System.Drawing.Size(105, 24)
        Me.radNonfiction.TabIndex = 1
        Me.radNonfiction.TabStop = True
        Me.radNonfiction.Text = "Nonfiction"
        Me.radNonfiction.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(35, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Title:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(16, 91)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(61, 20)
        Me.lblAuthor.TabIndex = 7
        Me.lblAuthor.Text = "Author:"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(23, 138)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(54, 20)
        Me.lblStock.TabIndex = 8
        Me.lblStock.Text = "Stock:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(269, 138)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 9
        Me.lblPrice.Text = "Price:"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 369)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "frmDetails"
        Me.Text = "Details"
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents radNonfiction As RadioButton
    Friend WithEvents radFiction As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrice As Label
End Class
