<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EAS_Main
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
        Me.FlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartFlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_Fuel_1 = New System.Windows.Forms.Label()
        Me.Lbl_Fuel_2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlightToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FlightToolStripMenuItem
        '
        Me.FlightToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartFlightToolStripMenuItem, Me.SaveFlightToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FlightToolStripMenuItem.Name = "FlightToolStripMenuItem"
        Me.FlightToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.FlightToolStripMenuItem.Text = "Flight"
        '
        'StartFlightToolStripMenuItem
        '
        Me.StartFlightToolStripMenuItem.Name = "StartFlightToolStripMenuItem"
        Me.StartFlightToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartFlightToolStripMenuItem.Text = "Start Flight"
        '
        'SaveFlightToolStripMenuItem
        '
        Me.SaveFlightToolStripMenuItem.Name = "SaveFlightToolStripMenuItem"
        Me.SaveFlightToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveFlightToolStripMenuItem.Text = "Save Flight"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Lbl_Fuel_1
        '
        Me.Lbl_Fuel_1.AutoSize = True
        Me.Lbl_Fuel_1.Location = New System.Drawing.Point(569, 173)
        Me.Lbl_Fuel_1.Name = "Lbl_Fuel_1"
        Me.Lbl_Fuel_1.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Fuel_1.TabIndex = 1
        Me.Lbl_Fuel_1.Text = "Fuel:"
        '
        'Lbl_Fuel_2
        '
        Me.Lbl_Fuel_2.AutoSize = True
        Me.Lbl_Fuel_2.Location = New System.Drawing.Point(605, 173)
        Me.Lbl_Fuel_2.Name = "Lbl_Fuel_2"
        Me.Lbl_Fuel_2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Fuel_2.TabIndex = 2
        '
        'EAS_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Fuel_2)
        Me.Controls.Add(Me.Lbl_Fuel_1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EAS_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EAS Flight Log"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartFlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl_Fuel_1 As Label
    Friend WithEvents Lbl_Fuel_2 As Label
End Class
