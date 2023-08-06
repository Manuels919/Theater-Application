<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblTicketPrice = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstAvailableSeats = New System.Windows.Forms.ListBox()
        Me.lblAvailableSeats = New System.Windows.Forms.Label()
        Me.btnSellSeat = New System.Windows.Forms.Button()
        Me.btnSaveData = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTicketPriceOutput = New System.Windows.Forms.Label()
        Me.lblTaxOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSeatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalSalesOutput = New System.Windows.Forms.Label()
        Me.lblTicketsSoldOutput = New System.Windows.Forms.Label()
        Me.lblTotalSeatsOutput = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblTicketsSold = New System.Windows.Forms.Label()
        Me.lblTotalSeats = New System.Windows.Forms.Label()
        Me.lblSeatsRemaining = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTicketPrice
        '
        Me.lblTicketPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblTicketPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketPrice.Location = New System.Drawing.Point(241, 97)
        Me.lblTicketPrice.Name = "lblTicketPrice"
        Me.lblTicketPrice.Size = New System.Drawing.Size(104, 25)
        Me.lblTicketPrice.TabIndex = 4
        Me.lblTicketPrice.Text = "Ticket Price:"
        Me.lblTicketPrice.UseCompatibleTextRendering = True
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(241, 149)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(104, 25)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(241, 205)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(104, 25)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total:"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(241, 260)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(104, 25)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name:"
        '
        'lstAvailableSeats
        '
        Me.lstAvailableSeats.FormattingEnabled = True
        Me.lstAvailableSeats.ItemHeight = 16
        Me.lstAvailableSeats.Location = New System.Drawing.Point(40, 97)
        Me.lstAvailableSeats.Name = "lstAvailableSeats"
        Me.lstAvailableSeats.Size = New System.Drawing.Size(77, 228)
        Me.lstAvailableSeats.TabIndex = 3
        '
        'lblAvailableSeats
        '
        Me.lblAvailableSeats.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableSeats.Location = New System.Drawing.Point(36, 50)
        Me.lblAvailableSeats.Name = "lblAvailableSeats"
        Me.lblAvailableSeats.Size = New System.Drawing.Size(122, 44)
        Me.lblAvailableSeats.TabIndex = 1
        Me.lblAvailableSeats.Text = "Available Seats Remaining:"
        '
        'btnSellSeat
        '
        Me.btnSellSeat.Location = New System.Drawing.Point(334, 308)
        Me.btnSellSeat.Name = "btnSellSeat"
        Me.btnSellSeat.Size = New System.Drawing.Size(118, 33)
        Me.btnSellSeat.TabIndex = 18
        Me.btnSellSeat.Text = "Sell Seat"
        Me.btnSellSeat.UseVisualStyleBackColor = True
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(501, 308)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(118, 33)
        Me.btnSaveData.TabIndex = 19
        Me.btnSaveData.Text = "&Save Data"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(350, 260)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 22)
        Me.txtName.TabIndex = 17
        '
        'lblTicketPriceOutput
        '
        Me.lblTicketPriceOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTicketPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTicketPriceOutput.Location = New System.Drawing.Point(351, 97)
        Me.lblTicketPriceOutput.Name = "lblTicketPriceOutput"
        Me.lblTicketPriceOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTicketPriceOutput.TabIndex = 5
        '
        'lblTaxOutput
        '
        Me.lblTaxOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxOutput.Location = New System.Drawing.Point(351, 149)
        Me.lblTaxOutput.Name = "lblTaxOutput"
        Me.lblTaxOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTaxOutput.TabIndex = 9
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOutput.Location = New System.Drawing.Point(350, 205)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTotalOutput.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetSeatsToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetSeatsToolStripMenuItem
        '
        Me.ResetSeatsToolStripMenuItem.Name = "ResetSeatsToolStripMenuItem"
        Me.ResetSeatsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ResetSeatsToolStripMenuItem.Text = "Reset Seats"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblTotalSalesOutput
        '
        Me.lblTotalSalesOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalSalesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSalesOutput.Location = New System.Drawing.Point(601, 205)
        Me.lblTotalSalesOutput.Name = "lblTotalSalesOutput"
        Me.lblTotalSalesOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTotalSalesOutput.TabIndex = 15
        '
        'lblTicketsSoldOutput
        '
        Me.lblTicketsSoldOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTicketsSoldOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTicketsSoldOutput.Location = New System.Drawing.Point(601, 149)
        Me.lblTicketsSoldOutput.Name = "lblTicketsSoldOutput"
        Me.lblTicketsSoldOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTicketsSoldOutput.TabIndex = 11
        '
        'lblTotalSeatsOutput
        '
        Me.lblTotalSeatsOutput.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotalSeatsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSeatsOutput.Location = New System.Drawing.Point(601, 97)
        Me.lblTotalSeatsOutput.Name = "lblTotalSeatsOutput"
        Me.lblTotalSeatsOutput.Size = New System.Drawing.Size(111, 25)
        Me.lblTotalSeatsOutput.TabIndex = 7
        '
        'lblSales
        '
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(491, 205)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(104, 25)
        Me.lblSales.TabIndex = 14
        Me.lblSales.Text = "Total Sales:"
        '
        'lblTicketsSold
        '
        Me.lblTicketsSold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsSold.Location = New System.Drawing.Point(491, 149)
        Me.lblTicketsSold.Name = "lblTicketsSold"
        Me.lblTicketsSold.Size = New System.Drawing.Size(104, 25)
        Me.lblTicketsSold.TabIndex = 10
        Me.lblTicketsSold.Text = "Tickets Sold:"
        '
        'lblTotalSeats
        '
        Me.lblTotalSeats.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalSeats.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSeats.Location = New System.Drawing.Point(491, 97)
        Me.lblTotalSeats.Name = "lblTotalSeats"
        Me.lblTotalSeats.Size = New System.Drawing.Size(104, 25)
        Me.lblTotalSeats.TabIndex = 6
        Me.lblTotalSeats.Text = "Total Seats:"
        Me.lblTotalSeats.UseCompatibleTextRendering = True
        '
        'lblSeatsRemaining
        '
        Me.lblSeatsRemaining.BackColor = System.Drawing.SystemColors.Info
        Me.lblSeatsRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeatsRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatsRemaining.Location = New System.Drawing.Point(164, 50)
        Me.lblSeatsRemaining.Name = "lblSeatsRemaining"
        Me.lblSeatsRemaining.Size = New System.Drawing.Size(70, 44)
        Me.lblSeatsRemaining.TabIndex = 2
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSellSeat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Manuel_Final_Project.My.Resources.Resources.theater3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSeatsRemaining)
        Me.Controls.Add(Me.lblTotalSalesOutput)
        Me.Controls.Add(Me.lblTicketsSoldOutput)
        Me.Controls.Add(Me.lblTotalSeatsOutput)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblTicketsSold)
        Me.Controls.Add(Me.lblTotalSeats)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblTaxOutput)
        Me.Controls.Add(Me.lblTicketPriceOutput)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSaveData)
        Me.Controls.Add(Me.btnSellSeat)
        Me.Controls.Add(Me.lblAvailableSeats)
        Me.Controls.Add(Me.lstAvailableSeats)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTicketPrice)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Manuel's Theater"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTicketPrice As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lstAvailableSeats As ListBox
    Friend WithEvents lblAvailableSeats As Label
    Friend WithEvents btnSellSeat As Button
    Friend WithEvents btnSaveData As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTicketPriceOutput As Label
    Friend WithEvents lblTaxOutput As Label
    Friend WithEvents lblTotalOutput As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSeatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotalSalesOutput As Label
    Friend WithEvents lblTicketsSoldOutput As Label
    Friend WithEvents lblTotalSeatsOutput As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblTicketsSold As Label
    Friend WithEvents lblTotalSeats As Label
    Friend WithEvents lblSeatsRemaining As Label
End Class
