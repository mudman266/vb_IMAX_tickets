<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelectType = New System.Windows.Forms.Label()
        Me.cmbTicketType = New System.Windows.Forms.ComboBox()
        Me.lblNumTickets = New System.Windows.Forms.Label()
        Me.txtNumTickets = New System.Windows.Forms.TextBox()
        Me.btnCalculatePrice = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(12, 12)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(549, 404)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(603, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(264, 41)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "IMAX Tickets"
        '
        'lblSelectType
        '
        Me.lblSelectType.AutoSize = True
        Me.lblSelectType.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectType.Location = New System.Drawing.Point(567, 90)
        Me.lblSelectType.Name = "lblSelectType"
        Me.lblSelectType.Size = New System.Drawing.Size(174, 32)
        Me.lblSelectType.TabIndex = 2
        Me.lblSelectType.Text = "Ticket Type:"
        '
        'cmbTicketType
        '
        Me.cmbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTicketType.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTicketType.FormattingEnabled = True
        Me.cmbTicketType.Items.AddRange(New Object() {"Matinee ($16)", "Evening ($27)"})
        Me.cmbTicketType.Location = New System.Drawing.Point(746, 92)
        Me.cmbTicketType.Name = "cmbTicketType"
        Me.cmbTicketType.Size = New System.Drawing.Size(167, 29)
        Me.cmbTicketType.TabIndex = 3
        '
        'lblNumTickets
        '
        Me.lblNumTickets.AutoSize = True
        Me.lblNumTickets.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTickets.Location = New System.Drawing.Point(567, 151)
        Me.lblNumTickets.Name = "lblNumTickets"
        Me.lblNumTickets.Size = New System.Drawing.Size(265, 32)
        Me.lblNumTickets.TabIndex = 4
        Me.lblNumTickets.Text = "Number of Tickets:"
        Me.lblNumTickets.Visible = False
        '
        'txtNumTickets
        '
        Me.txtNumTickets.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTickets.Location = New System.Drawing.Point(838, 151)
        Me.txtNumTickets.Name = "txtNumTickets"
        Me.txtNumTickets.Size = New System.Drawing.Size(100, 36)
        Me.txtNumTickets.TabIndex = 5
        Me.txtNumTickets.Visible = False
        '
        'btnCalculatePrice
        '
        Me.btnCalculatePrice.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculatePrice.Location = New System.Drawing.Point(704, 210)
        Me.btnCalculatePrice.Name = "btnCalculatePrice"
        Me.btnCalculatePrice.Size = New System.Drawing.Size(180, 43)
        Me.btnCalculatePrice.TabIndex = 6
        Me.btnCalculatePrice.Text = "Get Price"
        Me.btnCalculatePrice.UseVisualStyleBackColor = True
        Me.btnCalculatePrice.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(567, 280)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(448, 48)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price: "
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrice.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(704, 354)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(180, 43)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 430)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalculatePrice)
        Me.Controls.Add(Me.txtNumTickets)
        Me.Controls.Add(Me.lblNumTickets)
        Me.Controls.Add(Me.cmbTicketType)
        Me.Controls.Add(Me.lblSelectType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmMain"
        Me.Text = "IMAX Tickets"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSelectType As Label
    Friend WithEvents cmbTicketType As ComboBox
    Friend WithEvents lblNumTickets As Label
    Friend WithEvents txtNumTickets As TextBox
    Friend WithEvents btnCalculatePrice As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnClear As Button
End Class
