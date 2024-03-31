<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txtsku = New TextBox()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ListView1 = New ListView()
        ColumnHeader6 = New ColumnHeader()
        PictureBox1 = New PictureBox()
        lbltransnumb = New Label()
        lblbranch = New Label()
        lbluser = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btncheckout = New Button()
        Label4 = New Label()
        txtchange = New TextBox()
        Label3 = New Label()
        txtcash = New TextBox()
        Label2 = New Label()
        txtTotal = New TextBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        transnum = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtsku
        ' 
        txtsku.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point)
        txtsku.Location = New Point(59, 60)
        txtsku.Margin = New Padding(4)
        txtsku.Name = "txtsku"
        txtsku.Size = New Size(1073, 43)
        txtsku.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 76)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 21)
        Label1.TabIndex = 1
        Label1.Text = "SKU:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(512, 112)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 21)
        Label5.TabIndex = 12
        Label5.Text = "Cart:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 112)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 21)
        Label6.TabIndex = 13
        Label6.Text = "List of Products:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(13, 137)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(491, 392)
        DataGridView1.TabIndex = 14
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Product Name"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Price"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Qty"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Subtotal"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "ProductId"
        ColumnHeader5.Width = 0
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader6, ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        ListView1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ListView1.GridLines = True
        ListView1.Location = New Point(512, 137)
        ListView1.Margin = New Padding(4)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(617, 256)
        ListView1.TabIndex = 15
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "SKU"
        ColumnHeader6.Width = 200
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.vecteezy_modern_and_minimalist_p_o_s_letter_initials_logo_
        PictureBox1.Location = New Point(12, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' lbltransnumb
        ' 
        lbltransnumb.AutoSize = True
        lbltransnumb.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbltransnumb.Location = New Point(192, 377)
        lbltransnumb.Margin = New Padding(4, 0, 4, 0)
        lbltransnumb.Name = "lbltransnumb"
        lbltransnumb.Size = New Size(118, 45)
        lbltransnumb.TabIndex = 20
        lbltransnumb.Text = "100001"
        ' 
        ' lblbranch
        ' 
        lblbranch.AutoSize = True
        lblbranch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblbranch.Location = New Point(89, 9)
        lblbranch.Margin = New Padding(4, 0, 4, 0)
        lblbranch.Name = "lblbranch"
        lblbranch.Size = New Size(47, 15)
        lblbranch.TabIndex = 21
        lblbranch.Text = "Branch:"
        ' 
        ' lbluser
        ' 
        lbluser.AutoSize = True
        lbluser.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbluser.Location = New Point(89, 27)
        lbluser.Margin = New Padding(4, 0, 4, 0)
        lbluser.Name = "lbluser"
        lbluser.Size = New Size(33, 15)
        lbluser.TabIndex = 22
        lbluser.Text = "User:"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(512, 405)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(617, 206)
        TabControl1.TabIndex = 25
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btncheckout)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txtchange)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txtcash)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtTotal)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(609, 178)
        TabPage1.TabIndex = 0
        TabPage1.Text = "CASH"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btncheckout
        ' 
        btncheckout.BackColor = Color.Orange
        btncheckout.ForeColor = Color.White
        btncheckout.Location = New Point(409, 54)
        btncheckout.Margin = New Padding(4)
        btncheckout.Name = "btncheckout"
        btncheckout.Size = New Size(96, 73)
        btncheckout.TabIndex = 16
        btncheckout.Text = "Checkout"
        btncheckout.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(19, 117)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 28)
        Label4.TabIndex = 15
        Label4.Text = "Change:"
        ' 
        ' txtchange
        ' 
        txtchange.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        txtchange.Location = New Point(113, 111)
        txtchange.Margin = New Padding(4)
        txtchange.Name = "txtchange"
        txtchange.ReadOnly = True
        txtchange.Size = New Size(268, 34)
        txtchange.TabIndex = 14
        txtchange.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(45, 75)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 28)
        Label3.TabIndex = 13
        Label3.Text = "Cash:"
        ' 
        ' txtcash
        ' 
        txtcash.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        txtcash.Location = New Point(113, 69)
        txtcash.Margin = New Padding(4)
        txtcash.Name = "txtcash"
        txtcash.Size = New Size(268, 34)
        txtcash.TabIndex = 12
        txtcash.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(45, 33)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 28)
        Label2.TabIndex = 11
        Label2.Text = "Total:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point)
        txtTotal.Location = New Point(113, 27)
        txtTotal.Margin = New Padding(4)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(268, 34)
        txtTotal.TabIndex = 10
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(609, 178)
        TabPage2.TabIndex = 1
        TabPage2.Text = "POST DATED CHECK"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(609, 178)
        TabPage3.TabIndex = 2
        TabPage3.Text = "PARTIAL PAYMENT"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(609, 178)
        TabPage4.TabIndex = 3
        TabPage4.Text = "E-PAYMENT"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' transnum
        ' 
        transnum.AutoSize = True
        transnum.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        transnum.Location = New Point(551, 117)
        transnum.Margin = New Padding(4, 0, 4, 0)
        transnum.Name = "transnum"
        transnum.Size = New Size(93, 15)
        transnum.TabIndex = 26
        transnum.Text = "Transactionnum"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1145, 629)
        Controls.Add(transnum)
        Controls.Add(TabControl1)
        Controls.Add(lbluser)
        Controls.Add(lblbranch)
        Controls.Add(PictureBox1)
        Controls.Add(ListView1)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(txtsku)
        Controls.Add(lbltransnumb)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Genus POS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtsku As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltransnumb As Label
    Friend WithEvents lblbranch As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btncheckout As Button
    Friend WithEvents transnum As Label
End Class
