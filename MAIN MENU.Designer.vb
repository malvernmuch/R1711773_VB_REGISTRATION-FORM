<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtMainMenu
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.STUDENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LECTURERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EQUIPMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTSToolStripMenuItem, Me.ResultsToolStripMenuItem, Me.FeesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 70)
        '
        'STUDENTSToolStripMenuItem
        '
        Me.STUDENTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LECTURERToolStripMenuItem, Me.MARKSToolStripMenuItem})
        Me.STUDENTSToolStripMenuItem.Name = "STUDENTSToolStripMenuItem"
        Me.STUDENTSToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.STUDENTSToolStripMenuItem.Text = "STUDENTS"
        '
        'LECTURERToolStripMenuItem
        '
        Me.LECTURERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRATIONToolStripMenuItem})
        Me.LECTURERToolStripMenuItem.Name = "LECTURERToolStripMenuItem"
        Me.LECTURERToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LECTURERToolStripMenuItem.Text = "LECTURER"
        '
        'REGISTRATIONToolStripMenuItem
        '
        Me.REGISTRATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EQUIPMENTToolStripMenuItem})
        Me.REGISTRATIONToolStripMenuItem.Name = "REGISTRATIONToolStripMenuItem"
        Me.REGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.REGISTRATIONToolStripMenuItem.Text = "REGISTRATION"
        '
        'EQUIPMENTToolStripMenuItem
        '
        Me.EQUIPMENTToolStripMenuItem.Name = "EQUIPMENTToolStripMenuItem"
        Me.EQUIPMENTToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EQUIPMENTToolStripMenuItem.Text = "EQUIPMENT"
        '
        'MARKSToolStripMenuItem
        '
        Me.MARKSToolStripMenuItem.Name = "MARKSToolStripMenuItem"
        Me.MARKSToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MARKSToolStripMenuItem.Text = "UPDATE MARKS"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.FeesToolStripMenuItem.Text = "Fees"
        '
        'txtMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 378)
        Me.IsMdiContainer = True
        Me.Name = "txtMainMenu"
        Me.Text = "Main  Menu"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents STUDENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LECTURERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EQUIPMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MARKSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
