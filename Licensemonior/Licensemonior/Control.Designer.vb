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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmMớiDữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmDữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaDữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuấtCơSởDữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThiếtLậpCàiĐặtEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(823, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmMớiDữLiệuToolStripMenuItem, Me.TìmKiếmDữLiệuToolStripMenuItem, Me.XóaDữLiệuToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'ThêmMớiDữLiệuToolStripMenuItem
        '
        Me.ThêmMớiDữLiệuToolStripMenuItem.Name = "ThêmMớiDữLiệuToolStripMenuItem"
        Me.ThêmMớiDữLiệuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ThêmMớiDữLiệuToolStripMenuItem.Text = "Thêm dữ liệu"
        '
        'TìmKiếmDữLiệuToolStripMenuItem
        '
        Me.TìmKiếmDữLiệuToolStripMenuItem.Name = "TìmKiếmDữLiệuToolStripMenuItem"
        Me.TìmKiếmDữLiệuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TìmKiếmDữLiệuToolStripMenuItem.Text = "Tìm kiếm dữ liệu"
        '
        'XóaDữLiệuToolStripMenuItem
        '
        Me.XóaDữLiệuToolStripMenuItem.Name = "XóaDữLiệuToolStripMenuItem"
        Me.XóaDữLiệuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.XóaDữLiệuToolStripMenuItem.Text = "&Thoát"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbouToolStripMenuItem, Me.XuấtCơSởDữLiệuToolStripMenuItem, Me.ThiếtLậpCàiĐặtEmailToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.AboutToolStripMenuItem.Text = "Trợ giúp"
        '
        'AbouToolStripMenuItem
        '
        Me.AbouToolStripMenuItem.Name = "AbouToolStripMenuItem"
        Me.AbouToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AbouToolStripMenuItem.Text = "About"
        '
        'XuấtCơSởDữLiệuToolStripMenuItem
        '
        Me.XuấtCơSởDữLiệuToolStripMenuItem.Name = "XuấtCơSởDữLiệuToolStripMenuItem"
        Me.XuấtCơSởDữLiệuToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.XuấtCơSởDữLiệuToolStripMenuItem.Text = "Xuất cơ sở dữ liệu"
        '
        'ThiếtLậpCàiĐặtEmailToolStripMenuItem
        '
        Me.ThiếtLậpCàiĐặtEmailToolStripMenuItem.Name = "ThiếtLậpCàiĐặtEmailToolStripMenuItem"
        Me.ThiếtLậpCàiĐặtEmailToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ThiếtLậpCàiĐặtEmailToolStripMenuItem.Text = "Nhập cơ sở dữ liệu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(823, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Nhập Incident report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmMớiDữLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TìmKiếmDữLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XóaDữLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbouToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuấtCơSởDữLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThiếtLậpCàiĐặtEmailToolStripMenuItem As ToolStripMenuItem
End Class
