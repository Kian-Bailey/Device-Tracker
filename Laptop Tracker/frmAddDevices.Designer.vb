﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNavNext = New System.Windows.Forms.Button()
        Me.btnNavPrev = New System.Windows.Forms.Button()
        Me.mnuNav.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddDevices
        '
        Me.lblAddDevices.AutoSize = True
        Me.lblAddDevices.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAddDevices.Font = New System.Drawing.Font("Futura Bk BT", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddDevices.Location = New System.Drawing.Point(3, 0)
        Me.lblAddDevices.Name = "lblAddDevices"
        Me.lblAddDevices.Size = New System.Drawing.Size(389, 100)
        Me.lblAddDevices.TabIndex = 0
        Me.lblAddDevices.Text = "Add Devices"
        '
        'txtDeviceID
        '
        Me.txtDeviceID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDeviceID.Enabled = False
        Me.txtDeviceID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.txtDeviceID.Location = New System.Drawing.Point(897, 3)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.Size = New System.Drawing.Size(888, 71)
        Me.txtDeviceID.TabIndex = 2
        '
        'lblDeviceID
        '
        Me.lblDeviceID.AutoSize = True
        Me.lblDeviceID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceID.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.lblDeviceID.Location = New System.Drawing.Point(3, 0)
        Me.lblDeviceID.Name = "lblDeviceID"
        Me.lblDeviceID.Size = New System.Drawing.Size(888, 109)
        Me.lblDeviceID.TabIndex = 1
        Me.lblDeviceID.Text = "Device ID"
        '
        'lblDeviceModel
        '
        Me.lblDeviceModel.AutoSize = True
        Me.lblDeviceModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceModel.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.lblDeviceModel.Location = New System.Drawing.Point(3, 109)
        Me.lblDeviceModel.Name = "lblDeviceModel"
        Me.lblDeviceModel.Size = New System.Drawing.Size(888, 109)
        Me.lblDeviceModel.TabIndex = 3
        Me.lblDeviceModel.Text = "Device Model"
        '
        'txtModel
        '
        Me.txtModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtModel.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.txtModel.Location = New System.Drawing.Point(897, 112)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(888, 71)
        Me.txtModel.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.txtName.Location = New System.Drawing.Point(897, 221)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(888, 71)
        Me.txtName.TabIndex = 6
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDeviceName.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.lblDeviceName.Location = New System.Drawing.Point(3, 218)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(888, 109)
        Me.lblDeviceName.TabIndex = 5
        Me.lblDeviceName.Text = "Device Name"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSerialNumber.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.txtSerialNumber.Location = New System.Drawing.Point(897, 330)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(888, 71)
        Me.txtSerialNumber.TabIndex = 8
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSerialNumber.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.lblSerialNumber.Location = New System.Drawing.Point(3, 327)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(888, 109)
        Me.lblSerialNumber.TabIndex = 7
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'lblUsage
        '
        Me.lblUsage.AutoSize = True
        Me.lblUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsage.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.lblUsage.Location = New System.Drawing.Point(3, 436)
        Me.lblUsage.Name = "lblUsage"
        Me.lblUsage.Size = New System.Drawing.Size(888, 112)
        Me.lblUsage.TabIndex = 9
        Me.lblUsage.Text = "Usage"
        '
        'comUsage
        '
        Me.comUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comUsage.Font = New System.Drawing.Font("Futura Bk BT", 20.0!)
        Me.comUsage.FormattingEnabled = True
        Me.comUsage.Items.AddRange(New Object() {"Broken", "Desktop", "Not In Use", "Permanent Use", "Spare", "To be Returned"})
        Me.comUsage.Location = New System.Drawing.Point(897, 439)
        Me.comUsage.Name = "comUsage"
        Me.comUsage.Size = New System.Drawing.Size(888, 71)
        Me.comUsage.TabIndex = 10
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Futura Bk BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(3, 657)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(1788, 149)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'mnuNav
        '
        Me.mnuNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnuNav.Font = New System.Drawing.Font("Futura Bk BT", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNav.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuNav.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.DevicesToolStripMenuItem})
        Me.mnuNav.Location = New System.Drawing.Point(200, 0)
        Me.mnuNav.Name = "mnuNav"
        Me.mnuNav.Size = New System.Drawing.Size(1588, 94)
        Me.mnuNav.TabIndex = 15
        Me.mnuNav.Text = "Menu"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(105, 90)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(140, 90)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(124, 90)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 150)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(50)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(850, 700)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1794, 809)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1788, 548)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tlpMenu, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1894, 1009)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'tlpMenu
        '
        Me.tlpMenu.ColumnCount = 4
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpMenu.Controls.Add(Me.btnNavNext, 1, 0)
        Me.tlpMenu.Controls.Add(Me.btnNavPrev, 0, 0)
        Me.tlpMenu.Controls.Add(Me.mnuNav, 2, 0)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Location = New System.Drawing.Point(3, 3)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 1
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(1888, 94)
        Me.tlpMenu.TabIndex = 0
        '
        'btnNavNext
        '
        Me.btnNavNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnNavNext.BackgroundImage = CType(resources.GetObject("btnNavNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNavNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNavNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNavNext.FlatAppearance.BorderSize = 0
        Me.btnNavNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavNext.Font = New System.Drawing.Font("Futura Bk BT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavNext.ForeColor = System.Drawing.Color.White
        Me.btnNavNext.Location = New System.Drawing.Point(103, 3)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(94, 88)
        Me.btnNavNext.TabIndex = 17
        Me.btnNavNext.UseVisualStyleBackColor = False
        '
        'btnNavPrev
        '
        Me.btnNavPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnNavPrev.BackgroundImage = CType(resources.GetObject("btnNavPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnNavPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNavPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNavPrev.FlatAppearance.BorderSize = 0
        Me.btnNavPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPrev.Font = New System.Drawing.Font("Futura Bk BT", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavPrev.ForeColor = System.Drawing.Color.White
        Me.btnNavPrev.Location = New System.Drawing.Point(3, 3)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(94, 88)
        Me.btnNavPrev.TabIndex = 16
        Me.btnNavPrev.UseVisualStyleBackColor = False
        '
        'frmAddDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddDevices"
        Me.Text = "Add Devices"
        Me.mnuNav.ResumeLayout(False)
        Me.mnuNav.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        Me.tlpMenu.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents btnNavPrev As Button
    Friend WithEvents btnNavNext As Button
End Class