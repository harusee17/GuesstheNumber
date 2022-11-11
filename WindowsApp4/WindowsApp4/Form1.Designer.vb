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
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.btnMin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel1 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.BunifuShadowPanel2 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.btnQuit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnHelp = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnStart = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel1.SuspendLayout()
        Me.BunifuShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMin
        '
        Me.btnMin.AllowAnimations = True
        Me.btnMin.AllowMouseEffects = True
        Me.btnMin.AllowToggling = False
        Me.btnMin.AnimationSpeed = 200
        Me.btnMin.AutoGenerateColors = False
        Me.btnMin.AutoRoundBorders = False
        Me.btnMin.AutoSizeLeftIcon = True
        Me.btnMin.AutoSizeRightIcon = True
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.BackColor1 = System.Drawing.Color.Transparent
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnMin.ButtonText = "—"
        Me.btnMin.ButtonTextMarginLeft = 0
        Me.btnMin.ColorContrastOnClick = 45
        Me.btnMin.ColorContrastOnHover = 45
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnMin.CustomizableEdges = BorderEdges1
        Me.btnMin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMin.DisabledBorderColor = System.Drawing.Color.Transparent
        Me.btnMin.DisabledFillColor = System.Drawing.Color.Transparent
        Me.btnMin.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnMin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnMin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMin.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnMin.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnMin.IconMarginLeft = 11
        Me.btnMin.IconPadding = 10
        Me.btnMin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMin.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnMin.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnMin.IconSize = 25
        Me.btnMin.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnMin.IdleBorderRadius = 1
        Me.btnMin.IdleBorderThickness = 1
        Me.btnMin.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnMin.IdleIconLeftImage = Nothing
        Me.btnMin.IdleIconRightImage = Nothing
        Me.btnMin.IndicateFocus = False
        Me.btnMin.Location = New System.Drawing.Point(607, 1)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.OnDisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnMin.OnDisabledState.BorderRadius = 0
        Me.btnMin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnMin.OnDisabledState.BorderThickness = 0
        Me.btnMin.OnDisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnMin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnMin.OnDisabledState.IconLeftImage = Nothing
        Me.btnMin.OnDisabledState.IconRightImage = Nothing
        Me.btnMin.onHoverState.BorderColor = System.Drawing.Color.White
        Me.btnMin.onHoverState.BorderRadius = 0
        Me.btnMin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnMin.onHoverState.BorderThickness = 0
        Me.btnMin.onHoverState.FillColor = System.Drawing.Color.White
        Me.btnMin.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.btnMin.onHoverState.IconLeftImage = Nothing
        Me.btnMin.onHoverState.IconRightImage = Nothing
        Me.btnMin.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnMin.OnIdleState.BorderRadius = 0
        Me.btnMin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnMin.OnIdleState.BorderThickness = 0
        Me.btnMin.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnMin.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnMin.OnIdleState.IconLeftImage = Nothing
        Me.btnMin.OnIdleState.IconRightImage = Nothing
        Me.btnMin.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnMin.OnPressedState.BorderRadius = 0
        Me.btnMin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnMin.OnPressedState.BorderThickness = 0
        Me.btnMin.OnPressedState.FillColor = System.Drawing.Color.Transparent
        Me.btnMin.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnMin.OnPressedState.IconLeftImage = Nothing
        Me.btnMin.OnPressedState.IconRightImage = Nothing
        Me.btnMin.Size = New System.Drawing.Size(110, 45)
        Me.btnMin.TabIndex = 5
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMin.TextMarginLeft = 0
        Me.btnMin.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnMin.UseDefaultRadiusAndThickness = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Katahdin Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Guess the Number!"
        '
        'BunifuShadowPanel1
        '
        Me.BunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.BorderRadius = 50
        Me.BunifuShadowPanel1.BorderThickness = 1
        Me.BunifuShadowPanel1.Controls.Add(Me.BunifuShadowPanel2)
        Me.BunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel1.Location = New System.Drawing.Point(186, 64)
        Me.BunifuShadowPanel1.Name = "BunifuShadowPanel1"
        Me.BunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel1.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.ShadowDept = 2
        Me.BunifuShadowPanel1.ShadowDepth = 0
        Me.BunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel1.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel1.Size = New System.Drawing.Size(336, 416)
        Me.BunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel1.TabIndex = 13
        '
        'BunifuShadowPanel2
        '
        Me.BunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.BorderRadius = 50
        Me.BunifuShadowPanel2.BorderThickness = 1
        Me.BunifuShadowPanel2.Controls.Add(Me.btnQuit)
        Me.BunifuShadowPanel2.Controls.Add(Me.btnHelp)
        Me.BunifuShadowPanel2.Controls.Add(Me.btnStart)
        Me.BunifuShadowPanel2.Controls.Add(Me.Label3)
        Me.BunifuShadowPanel2.Controls.Add(Me.Label2)
        Me.BunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel2.Location = New System.Drawing.Point(18, 15)
        Me.BunifuShadowPanel2.Name = "BunifuShadowPanel2"
        Me.BunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.ShadowDept = 2
        Me.BunifuShadowPanel2.ShadowDepth = 0
        Me.BunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel2.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel2.Size = New System.Drawing.Size(300, 384)
        Me.BunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel2.TabIndex = 0
        '
        'btnQuit
        '
        Me.btnQuit.ActiveBorderThickness = 1
        Me.btnQuit.ActiveCornerRadius = 25
        Me.btnQuit.ActiveFillColor = System.Drawing.Color.White
        Me.btnQuit.ActiveForecolor = System.Drawing.Color.Black
        Me.btnQuit.ActiveLineColor = System.Drawing.Color.White
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BackgroundImage = CType(resources.GetObject("btnQuit.BackgroundImage"), System.Drawing.Image)
        Me.btnQuit.ButtonText = "QUIT"
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnQuit.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.IdleBorderThickness = 1
        Me.btnQuit.IdleCornerRadius = 25
        Me.btnQuit.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnQuit.IdleForecolor = System.Drawing.Color.White
        Me.btnQuit.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnQuit.Location = New System.Drawing.Point(53, 218)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(190, 65)
        Me.btnQuit.TabIndex = 16
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHelp
        '
        Me.btnHelp.ActiveBorderThickness = 1
        Me.btnHelp.ActiveCornerRadius = 25
        Me.btnHelp.ActiveFillColor = System.Drawing.Color.White
        Me.btnHelp.ActiveForecolor = System.Drawing.Color.Black
        Me.btnHelp.ActiveLineColor = System.Drawing.Color.White
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.ButtonText = "HELP"
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHelp.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.IdleBorderThickness = 1
        Me.btnHelp.IdleCornerRadius = 25
        Me.btnHelp.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnHelp.IdleForecolor = System.Drawing.Color.White
        Me.btnHelp.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnHelp.Location = New System.Drawing.Point(53, 127)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(190, 65)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.ActiveBorderThickness = 1
        Me.btnStart.ActiveCornerRadius = 25
        Me.btnStart.ActiveFillColor = System.Drawing.Color.White
        Me.btnStart.ActiveForecolor = System.Drawing.Color.Black
        Me.btnStart.ActiveLineColor = System.Drawing.Color.White
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.ButtonText = "START"
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStart.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.IdleBorderThickness = 1
        Me.btnStart.IdleCornerRadius = 25
        Me.btnStart.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnStart.IdleForecolor = System.Drawing.Color.White
        Me.btnStart.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnStart.Location = New System.Drawing.Point(53, 36)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(190, 65)
        Me.btnStart.TabIndex = 14
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(98, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CSC 0312-0315"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Assignment No. 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 504)
        Me.Controls.Add(Me.BunifuShadowPanel1)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess the Number!"
        Me.BunifuShadowPanel1.ResumeLayout(False)
        Me.BunifuShadowPanel2.ResumeLayout(False)
        Me.BunifuShadowPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuShadowPanel1 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents BunifuShadowPanel2 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnHelp As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnStart As Bunifu.Framework.UI.BunifuThinButton2
End Class
