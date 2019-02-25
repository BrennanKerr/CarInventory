<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.cmbTitles = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.chkVIP = New System.Windows.Forms.CheckBox()
        Me.lvwCustomers = New System.Windows.Forms.ListView()
        Me.colVIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(95, 422)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "&Enter"
        Me.CustomerToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(176, 422)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.CustomerToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.CustomerToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(84, 34)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(121, 20)
        Me.tbFirstName.TabIndex = 3
        Me.CustomerToolTip.SetToolTip(Me.tbFirstName, "Type the customer's first name here.")
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(84, 60)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(121, 20)
        Me.tbLastName.TabIndex = 5
        Me.CustomerToolTip.SetToolTip(Me.tbLastName, "Type the customer's last name here.")
        '
        'cmbTitles
        '
        Me.cmbTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitles.FormattingEnabled = True
        Me.cmbTitles.Items.AddRange(New Object() {"Mr.", "Mrs.", "Miss.", "Ms.", "Mstr.", "Dr."})
        Me.cmbTitles.Location = New System.Drawing.Point(84, 7)
        Me.cmbTitles.Name = "cmbTitles"
        Me.cmbTitles.Size = New System.Drawing.Size(121, 21)
        Me.cmbTitles.TabIndex = 1
        Me.CustomerToolTip.SetToolTip(Me.cmbTitles, "Select the customer's title.")
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(12, 7)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(66, 13)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "&Title: "
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(12, 34)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(66, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "&First Name: "
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(12, 63)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(66, 13)
        Me.lbLastName.TabIndex = 4
        Me.lbLastName.Text = "&Last Name: "
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkVIP
        '
        Me.chkVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVIP.Location = New System.Drawing.Point(51, 83)
        Me.chkVIP.Name = "chkVIP"
        Me.chkVIP.Size = New System.Drawing.Size(46, 24)
        Me.chkVIP.TabIndex = 6
        Me.chkVIP.Text = "&VIP:"
        Me.chkVIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomerToolTip.SetToolTip(Me.chkVIP, "Check to make the customer a VIP.")
        Me.chkVIP.UseVisualStyleBackColor = True
        '
        'lvwCustomers
        '
        Me.lvwCustomers.CheckBoxes = True
        Me.lvwCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colVIP, Me.colID, Me.colTitle, Me.colFirstName, Me.colLastName})
        Me.lvwCustomers.FullRowSelect = True
        Me.lvwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCustomers.Location = New System.Drawing.Point(2, 108)
        Me.lvwCustomers.MultiSelect = False
        Me.lvwCustomers.Name = "lvwCustomers"
        Me.lvwCustomers.Size = New System.Drawing.Size(330, 246)
        Me.lvwCustomers.TabIndex = 7
        Me.CustomerToolTip.SetToolTip(Me.lvwCustomers, "Select a customer to modify.")
        Me.lvwCustomers.UseCompatibleStateImageBehavior = False
        Me.lvwCustomers.View = System.Windows.Forms.View.Details
        '
        'colVIP
        '
        Me.colVIP.Text = "VIP"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colTitle
        '
        Me.colTitle.Text = "Title"
        '
        'colFirstName
        '
        Me.colFirstName.Text = "FirstName"
        '
        'colLastName
        '
        Me.colLastName.Text = "Last Name"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(2, 357)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(330, 60)
        Me.lbResult.TabIndex = 8
        Me.CustomerToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'frmCustomerList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(334, 452)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCustomers)
        Me.Controls.Add(Me.chkVIP)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbTitles)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents cmbTitles As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents chkVIP As CheckBox
    Friend WithEvents lvwCustomers As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents colVIP As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents CustomerToolTip As ToolTip
    Friend WithEvents lbResult As Label
End Class
