﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiPOS))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Posuser1 = New DinvoiceStandalone2._0.posuser()
        Me.Posuser2 = New DinvoiceStandalone2._0.posuser()
        Me.Posuser3 = New DinvoiceStandalone2._0.posuser()
        Me.Posuser4 = New DinvoiceStandalone2._0.posuser()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1295, 804)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Posuser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1287, 778)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Parked 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Posuser2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1287, 778)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Parked 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Posuser3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1287, 778)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Parked 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Posuser4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1287, 778)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Parked 4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Posuser1
        '
        Me.Posuser1.BackColor = System.Drawing.Color.White
        Me.Posuser1.Location = New System.Drawing.Point(0, 0)
        Me.Posuser1.Name = "Posuser1"
        Me.Posuser1.Size = New System.Drawing.Size(1288, 738)
        Me.Posuser1.TabIndex = 0
        '
        'Posuser2
        '
        Me.Posuser2.BackColor = System.Drawing.Color.White
        Me.Posuser2.Location = New System.Drawing.Point(0, 0)
        Me.Posuser2.Name = "Posuser2"
        Me.Posuser2.Size = New System.Drawing.Size(1288, 738)
        Me.Posuser2.TabIndex = 0
        '
        'Posuser3
        '
        Me.Posuser3.BackColor = System.Drawing.Color.White
        Me.Posuser3.Location = New System.Drawing.Point(-1, 0)
        Me.Posuser3.Name = "Posuser3"
        Me.Posuser3.Size = New System.Drawing.Size(1288, 738)
        Me.Posuser3.TabIndex = 0
        '
        'Posuser4
        '
        Me.Posuser4.BackColor = System.Drawing.Color.White
        Me.Posuser4.Location = New System.Drawing.Point(0, 0)
        Me.Posuser4.Name = "Posuser4"
        Me.Posuser4.Size = New System.Drawing.Size(1288, 738)
        Me.Posuser4.TabIndex = 0
        '
        'MultiPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 805)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MultiPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiPOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Posuser1 As DinvoiceStandalone2._0.posuser
    Friend WithEvents Posuser2 As DinvoiceStandalone2._0.posuser
    Friend WithEvents Posuser3 As DinvoiceStandalone2._0.posuser
    Friend WithEvents Posuser4 As DinvoiceStandalone2._0.posuser
End Class