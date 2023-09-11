<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDevices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDevices))
        Me.lblAddDevices = New System.Windows.Forms.Label()
        Me.txtDeviceID = New System.Windows.Forms.TextBox()
        Me.lblDeviceID = New System.Windows.Forms.Label()
        Me.lblDeviceModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblUsage = New System.Windows.Forms.Label()
        Me.comUsage = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mnuNav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddDevices
        '
        Me.lblAddDevices.AutoSize = True
        Me.lblAddDevices.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAddDevices.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddDevices.Location = New System.Drawing.Point(3, 0)
        Me.lblAddDevices.Name = "lblAddDevices"
        Me.lblAddDevices.Size = New System.Drawing.Size(429, 100)
        Me.lblAddDevices.TabIndex = 0
        Me.lblAddDevices.Text = "Add Devices"
        '
        'txtDeviceID
        '
        Me.txtDeviceID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDeviceID.Enabled = False
        Me.txtDeviceID.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.txtDeviceID.Location = New System.Drawing.Point(947, 3)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(938, 73)
        Me.txtDeviceID.TabIndex = 2
        '
        'lblDeviceID
        '
        Me.lblDeviceID.AutoSize = True
        Me.lblDeviceID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceID.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lblDeviceID.Location = New System.Drawing.Point(3, 0)
        Me.lblDeviceID.Name = "lblDeviceID"
        Me.lblDeviceID.Size = New System.Drawing.Size(938, 141)
        Me.lblDeviceID.TabIndex = 1
        Me.lblDeviceID.Text = "Device ID"
        '
        'lblDeviceModel
        '
        Me.lblDeviceModel.AutoSize = True
        Me.lblDeviceModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceModel.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lblDeviceModel.Location = New System.Drawing.Point(3, 141)
        Me.lblDeviceModel.Name = "lblDeviceModel"
        Me.lblDeviceModel.Size = New System.Drawing.Size(938, 141)
        Me.lblDeviceModel.TabIndex = 3
        Me.lblDeviceModel.Text = "Device Model"
        '
        'txtModel
        '
        Me.txtModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtModel.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.txtModel.Location = New System.Drawing.Point(947, 144)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(938, 73)
        Me.txtModel.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.txtName.Location = New System.Drawing.Point(947, 285)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(938, 73)
        Me.txtName.TabIndex = 6
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceName.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lblDeviceName.Location = New System.Drawing.Point(3, 282)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(938, 141)
        Me.lblDeviceName.TabIndex = 5
        Me.lblDeviceName.Text = "Device Name"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSerialNumber.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.txtSerialNumber.Location = New System.Drawing.Point(947, 426)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(938, 73)
        Me.txtSerialNumber.TabIndex = 8
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSerialNumber.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lblSerialNumber.Location = New System.Drawing.Point(3, 423)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(938, 141)
        Me.lblSerialNumber.TabIndex = 7
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'lblUsage
        '
        Me.lblUsage.AutoSize = True
        Me.lblUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsage.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.lblUsage.Location = New System.Drawing.Point(3, 564)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(938, 144)
        Me.lblUsage.TabIndex = 9
        Me.lblUsage.Text = "Usage"
        '
        'comUsage
        '
        Me.comUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comUsage.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.comUsage.FormattingEnabled = True
        Me.comUsage.Items.AddRange(New Object() {"Broken", "Desktop", "Not In Use", "Permanent Use", "Spare", "To be Returned"})
        Me.comUsage.Location = New System.Drawing.Point(947, 567)
        Me.comUsage.Name = "comUsage"
        Me.comUsage.Size = New System.Drawing.Size(938, 71)
        Me.comUsage.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(3, 817)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(1888, 149)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'mnuNav
        '
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNav.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(0, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Size = New System.Drawing.Size(1894, 40)
        Me.mnuNav.TabIndex = 15
        Me.mnuNav.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(105, 36)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(140, 36)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(124, 36)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddDevices, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSubmit, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(850, 700)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1894, 969)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblDeviceID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDeviceModel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.comUsage, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDeviceName, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSerialNumber, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblUsage, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSerialNumber, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtModel, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDeviceID, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 103)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1888, 708)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'frmAddDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.mnuNav)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddDevices"
        Me.Text = "Add Devices"
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddDevices As Label
    Friend WithEvents txtDeviceID As TextBox
    Friend WithEvents lblDeviceID As Label
    Friend WithEvents lblDeviceModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents lblUsage As Label
    Friend WithEvents comUsage As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents mnuNav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
