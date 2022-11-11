<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel2 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.btnDiff = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAvg = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnEasy = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.labelDiff = New System.Windows.Forms.Label()
        Me.labelAvg = New System.Windows.Forms.Label()
        Me.labelEasy = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel1 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.btnExit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnBack = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnMin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuShadowPanel2.SuspendLayout()
        Me.BunifuShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Katahdin Round", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(153, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 38)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CHOOSE DIFFICULTY"
        '
        'BunifuShadowPanel2
        '
        Me.BunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.BorderRadius = 45
        Me.BunifuShadowPanel2.BorderThickness = 1
        Me.BunifuShadowPanel2.Controls.Add(Me.btnDiff)
        Me.BunifuShadowPanel2.Controls.Add(Me.btnAvg)
        Me.BunifuShadowPanel2.Controls.Add(Me.btnEasy)
        Me.BunifuShadowPanel2.Controls.Add(Me.labelDiff)
        Me.BunifuShadowPanel2.Controls.Add(Me.labelAvg)
        Me.BunifuShadowPanel2.Controls.Add(Me.labelEasy)
        Me.BunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel2.Location = New System.Drawing.Point(25, 22)
        Me.BunifuShadowPanel2.Name = "BunifuShadowPanel2"
        Me.BunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.ShadowDept = 2
        Me.BunifuShadowPanel2.ShadowDepth = 0
        Me.BunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel2.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel2.Size = New System.Drawing.Size(462, 340)
        Me.BunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel2.TabIndex = 0
        '
        'btnDiff
        '
        Me.btnDiff.ActiveBorderThickness = 1
        Me.btnDiff.ActiveCornerRadius = 25
        Me.btnDiff.ActiveFillColor = System.Drawing.Color.White
        Me.btnDiff.ActiveForecolor = System.Drawing.Color.Black
        Me.btnDiff.ActiveLineColor = System.Drawing.Color.White
        Me.btnDiff.BackColor = System.Drawing.Color.Transparent
        Me.btnDiff.BackgroundImage = CType(resources.GetObject("btnDiff.BackgroundImage"), System.Drawing.Image)
        Me.btnDiff.ButtonText = "DIFFICULT"
        Me.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiff.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiff.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDiff.IdleBorderThickness = 1
        Me.btnDiff.IdleCornerRadius = 25
        Me.btnDiff.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnDiff.IdleForecolor = System.Drawing.Color.White
        Me.btnDiff.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnDiff.Location = New System.Drawing.Point(139, 241)
        Me.btnDiff.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnDiff.Name = "btnDiff"
        Me.btnDiff.Size = New System.Drawing.Size(180, 65)
        Me.btnDiff.TabIndex = 8
        Me.btnDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAvg
        '
        Me.btnAvg.ActiveBorderThickness = 1
        Me.btnAvg.ActiveCornerRadius = 25
        Me.btnAvg.ActiveFillColor = System.Drawing.Color.White
        Me.btnAvg.ActiveForecolor = System.Drawing.Color.Black
        Me.btnAvg.ActiveLineColor = System.Drawing.Color.White
        Me.btnAvg.BackColor = System.Drawing.Color.Transparent
        Me.btnAvg.BackgroundImage = CType(resources.GetObject("btnAvg.BackgroundImage"), System.Drawing.Image)
        Me.btnAvg.ButtonText = "AVERAGE"
        Me.btnAvg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvg.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvg.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAvg.IdleBorderThickness = 1
        Me.btnAvg.IdleCornerRadius = 25
        Me.btnAvg.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnAvg.IdleForecolor = System.Drawing.Color.White
        Me.btnAvg.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnAvg.Location = New System.Drawing.Point(139, 135)
        Me.btnAvg.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(180, 65)
        Me.btnAvg.TabIndex = 7
        Me.btnAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEasy
        '
        Me.btnEasy.ActiveBorderThickness = 1
        Me.btnEasy.ActiveCornerRadius = 25
        Me.btnEasy.ActiveFillColor = System.Drawing.Color.White
        Me.btnEasy.ActiveForecolor = System.Drawing.Color.Black
        Me.btnEasy.ActiveLineColor = System.Drawing.Color.White
        Me.btnEasy.BackColor = System.Drawing.Color.Transparent
        Me.btnEasy.BackgroundImage = CType(resources.GetObject("btnEasy.BackgroundImage"), System.Drawing.Image)
        Me.btnEasy.ButtonText = "EASY"
        Me.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEasy.Font = New System.Drawing.Font("Katahdin Round", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEasy.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEasy.IdleBorderThickness = 1
        Me.btnEasy.IdleCornerRadius = 25
        Me.btnEasy.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnEasy.IdleForecolor = System.Drawing.Color.White
        Me.btnEasy.IdleLineColor = System.Drawing.Color.DodgerBlue
        Me.btnEasy.Location = New System.Drawing.Point(139, 32)
        Me.btnEasy.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(180, 65)
        Me.btnEasy.TabIndex = 6
        Me.btnEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelDiff
        '
        Me.labelDiff.AutoSize = True
        Me.labelDiff.Font = New System.Drawing.Font("Nunito SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDiff.ForeColor = System.Drawing.Color.White
        Me.labelDiff.Location = New System.Drawing.Point(163, 300)
        Me.labelDiff.Name = "labelDiff"
        Me.labelDiff.Size = New System.Drawing.Size(0, 22)
        Me.labelDiff.TabIndex = 5
        '
        'labelAvg
        '
        Me.labelAvg.AutoSize = True
        Me.labelAvg.Font = New System.Drawing.Font("Nunito SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAvg.ForeColor = System.Drawing.Color.White
        Me.labelAvg.Location = New System.Drawing.Point(162, 194)
        Me.labelAvg.Name = "labelAvg"
        Me.labelAvg.Size = New System.Drawing.Size(0, 22)
        Me.labelAvg.TabIndex = 4
        '
        'labelEasy
        '
        Me.labelEasy.AutoSize = True
        Me.labelEasy.Font = New System.Drawing.Font("Nunito SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEasy.ForeColor = System.Drawing.Color.White
        Me.labelEasy.Location = New System.Drawing.Point(163, 91)
        Me.labelEasy.Name = "labelEasy"
        Me.labelEasy.Size = New System.Drawing.Size(0, 22)
        Me.labelEasy.TabIndex = 3
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
        Me.BunifuShadowPanel1.Location = New System.Drawing.Point(91, 103)
        Me.BunifuShadowPanel1.Name = "BunifuShadowPanel1"
        Me.BunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel1.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.ShadowDept = 2
        Me.BunifuShadowPanel1.ShadowDepth = 0
        Me.BunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel1.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel1.Size = New System.Drawing.Size(513, 385)
        Me.BunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel1.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.AllowAnimations = True
        Me.btnExit.AllowMouseEffects = True
        Me.btnExit.AllowToggling = False
        Me.btnExit.AnimationSpeed = 200
        Me.btnExit.AutoGenerateColors = False
        Me.btnExit.AutoRoundBorders = False
        Me.btnExit.AutoSizeLeftIcon = True
        Me.btnExit.AutoSizeRightIcon = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackColor1 = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.ButtonText = "╳"
        Me.btnExit.ButtonTextMarginLeft = 0
        Me.btnExit.ColorContrastOnClick = 45
        Me.btnExit.ColorContrastOnHover = 45
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnExit.CustomizableEdges = BorderEdges1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.DisabledBorderColor = System.Drawing.Color.Transparent
        Me.btnExit.DisabledFillColor = System.Drawing.Color.Transparent
        Me.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnExit.IconMarginLeft = 11
        Me.btnExit.IconPadding = 10
        Me.btnExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnExit.IconSize = 25
        Me.btnExit.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnExit.IdleBorderRadius = 1
        Me.btnExit.IdleBorderThickness = 1
        Me.btnExit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnExit.IdleIconLeftImage = Nothing
        Me.btnExit.IdleIconRightImage = Nothing
        Me.btnExit.IndicateFocus = False
        Me.btnExit.Location = New System.Drawing.Point(606, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnDisabledState.BorderColor = System.Drawing.Color.Transparent
        Me.btnExit.OnDisabledState.BorderRadius = 0
        Me.btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnDisabledState.BorderThickness = 0
        Me.btnExit.OnDisabledState.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExit.OnDisabledState.IconLeftImage = Nothing
        Me.btnExit.OnDisabledState.IconRightImage = Nothing
        Me.btnExit.onHoverState.BorderColor = System.Drawing.Color.White
        Me.btnExit.onHoverState.BorderRadius = 0
        Me.btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.onHoverState.BorderThickness = 0
        Me.btnExit.onHoverState.FillColor = System.Drawing.Color.White
        Me.btnExit.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.btnExit.onHoverState.IconLeftImage = Nothing
        Me.btnExit.onHoverState.IconRightImage = Nothing
        Me.btnExit.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnExit.OnIdleState.BorderRadius = 0
        Me.btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnIdleState.BorderThickness = 0
        Me.btnExit.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnExit.OnIdleState.IconLeftImage = Nothing
        Me.btnExit.OnIdleState.IconRightImage = Nothing
        Me.btnExit.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnExit.OnPressedState.BorderRadius = 0
        Me.btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnPressedState.BorderThickness = 0
        Me.btnExit.OnPressedState.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnExit.OnPressedState.IconLeftImage = Nothing
        Me.btnExit.OnPressedState.IconRightImage = Nothing
        Me.btnExit.Size = New System.Drawing.Size(110, 45)
        Me.btnExit.TabIndex = 15
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExit.TextMarginLeft = 0
        Me.btnExit.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnExit.UseDefaultRadiusAndThickness = True
        '
        'btnBack
        '
        Me.btnBack.AllowAnimations = True
        Me.btnBack.AllowMouseEffects = True
        Me.btnBack.AllowToggling = False
        Me.btnBack.AnimationSpeed = 200
        Me.btnBack.AutoGenerateColors = False
        Me.btnBack.AutoRoundBorders = False
        Me.btnBack.AutoSizeLeftIcon = True
        Me.btnBack.AutoSizeRightIcon = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackColor1 = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack.ButtonText = "BACK"
        Me.btnBack.ButtonTextMarginLeft = 0
        Me.btnBack.ColorContrastOnClick = 45
        Me.btnBack.ColorContrastOnHover = 45
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnBack.CustomizableEdges = BorderEdges2
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBack.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBack.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnBack.Font = New System.Drawing.Font("Katahdin Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnBack.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnBack.IconMarginLeft = 11
        Me.btnBack.IconPadding = 10
        Me.btnBack.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnBack.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnBack.IconSize = 25
        Me.btnBack.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnBack.IdleBorderRadius = 1
        Me.btnBack.IdleBorderThickness = 1
        Me.btnBack.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnBack.IdleIconLeftImage = CType(resources.GetObject("btnBack.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnBack.IdleIconRightImage = Nothing
        Me.btnBack.IndicateFocus = False
        Me.btnBack.Location = New System.Drawing.Point(1, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnBack.OnDisabledState.BorderRadius = 0
        Me.btnBack.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack.OnDisabledState.BorderThickness = 0
        Me.btnBack.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBack.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBack.OnDisabledState.IconLeftImage = Nothing
        Me.btnBack.OnDisabledState.IconRightImage = Nothing
        Me.btnBack.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnBack.onHoverState.BorderRadius = 0
        Me.btnBack.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack.onHoverState.BorderThickness = 0
        Me.btnBack.onHoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.onHoverState.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnBack.onHoverState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage"), System.Drawing.Image)
        Me.btnBack.onHoverState.IconRightImage = Nothing
        Me.btnBack.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnBack.OnIdleState.BorderRadius = 0
        Me.btnBack.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack.OnIdleState.BorderThickness = 0
        Me.btnBack.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnBack.OnIdleState.IconLeftImage = CType(resources.GetObject("btnBack.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.btnBack.OnIdleState.IconRightImage = Nothing
        Me.btnBack.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnBack.OnPressedState.BorderRadius = 0
        Me.btnBack.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnBack.OnPressedState.BorderThickness = 0
        Me.btnBack.OnPressedState.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnBack.OnPressedState.IconLeftImage = CType(resources.GetObject("resource.IconLeftImage1"), System.Drawing.Image)
        Me.btnBack.OnPressedState.IconRightImage = Nothing
        Me.btnBack.Size = New System.Drawing.Size(152, 55)
        Me.btnBack.TabIndex = 16
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBack.TextMarginLeft = 0
        Me.btnBack.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnBack.UseDefaultRadiusAndThickness = True
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
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnMin.CustomizableEdges = BorderEdges3
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
        Me.btnMin.Location = New System.Drawing.Point(494, 0)
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
        Me.btnMin.TabIndex = 17
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMin.TextMarginLeft = 0
        Me.btnMin.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnMin.UseDefaultRadiusAndThickness = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 504)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BunifuShadowPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Guess the Number!"
        Me.BunifuShadowPanel2.ResumeLayout(False)
        Me.BunifuShadowPanel2.PerformLayout()
        Me.BunifuShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuShadowPanel2 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents BunifuShadowPanel1 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents btnExit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnBack As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents labelDiff As Label
    Friend WithEvents labelAvg As Label
    Friend WithEvents labelEasy As Label
    Friend WithEvents btnMin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnEasy As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnDiff As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAvg As Bunifu.Framework.UI.BunifuThinButton2
End Class
