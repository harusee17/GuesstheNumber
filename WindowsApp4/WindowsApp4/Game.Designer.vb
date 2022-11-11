<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputNo = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuShadowPanel1 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnter = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuShadowPanel2 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel4 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.BunifuShadowPanel3 = New Bunifu.UI.WinForms.BunifuShadowPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnExit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnRetry = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnHome = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuShadowPanel1.SuspendLayout()
        Me.BunifuShadowPanel2.SuspendLayout()
        Me.BunifuShadowPanel4.SuspendLayout()
        Me.BunifuShadowPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Katahdin Round", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODE"
        '
        'inputNo
        '
        Me.inputNo.AcceptsReturn = False
        Me.inputNo.AcceptsTab = False
        Me.inputNo.AnimationSpeed = 200
        Me.inputNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.inputNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.inputNo.BackColor = System.Drawing.Color.Transparent
        Me.inputNo.BackgroundImage = CType(resources.GetObject("inputNo.BackgroundImage"), System.Drawing.Image)
        Me.inputNo.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.inputNo.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.inputNo.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputNo.BorderColorIdle = System.Drawing.Color.Silver
        Me.inputNo.BorderRadius = 25
        Me.inputNo.BorderThickness = 1
        Me.inputNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.inputNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputNo.DefaultFont = New System.Drawing.Font("Nunito", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputNo.DefaultText = ""
        Me.inputNo.FillColor = System.Drawing.Color.White
        Me.inputNo.HideSelection = True
        Me.inputNo.IconLeft = Nothing
        Me.inputNo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.inputNo.IconPadding = 10
        Me.inputNo.IconRight = Nothing
        Me.inputNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.inputNo.Lines = New String(-1) {}
        Me.inputNo.Location = New System.Drawing.Point(44, 127)
        Me.inputNo.MaxLength = 32767
        Me.inputNo.MinimumSize = New System.Drawing.Size(1, 1)
        Me.inputNo.Modified = False
        Me.inputNo.Multiline = False
        Me.inputNo.Name = "inputNo"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.inputNo.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Gray
        StateProperties2.FillColor = System.Drawing.Color.Gray
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.inputNo.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.inputNo.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.inputNo.OnIdleState = StateProperties4
        Me.inputNo.Padding = New System.Windows.Forms.Padding(3)
        Me.inputNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.inputNo.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.inputNo.PlaceholderText = ""
        Me.inputNo.ReadOnly = False
        Me.inputNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.inputNo.SelectedText = ""
        Me.inputNo.SelectionLength = 0
        Me.inputNo.SelectionStart = 0
        Me.inputNo.ShortcutsEnabled = True
        Me.inputNo.Size = New System.Drawing.Size(260, 45)
        Me.inputNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.inputNo.TabIndex = 1
        Me.inputNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.inputNo.TextMarginBottom = 0
        Me.inputNo.TextMarginLeft = 3
        Me.inputNo.TextMarginTop = 0
        Me.inputNo.TextPlaceholder = ""
        Me.inputNo.UseSystemPasswordChar = False
        Me.inputNo.WordWrap = True
        '
        'BunifuShadowPanel1
        '
        Me.BunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel1.BorderRadius = 20
        Me.BunifuShadowPanel1.BorderThickness = 2
        Me.BunifuShadowPanel1.Controls.Add(Me.Label3)
        Me.BunifuShadowPanel1.Controls.Add(Me.Label2)
        Me.BunifuShadowPanel1.Controls.Add(Me.btnEnter)
        Me.BunifuShadowPanel1.Controls.Add(Me.inputNo)
        Me.BunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel1.Location = New System.Drawing.Point(24, 22)
        Me.BunifuShadowPanel1.Name = "BunifuShadowPanel1"
        Me.BunifuShadowPanel1.PanelColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel1.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel1.ShadowDept = 2
        Me.BunifuShadowPanel1.ShadowDepth = 5
        Me.BunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel1.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel1.Size = New System.Drawing.Size(344, 270)
        Me.BunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nunito ExtraBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(90, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of trials left: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nunito ExtraBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter a number between.."
        '
        'btnEnter
        '
        Me.btnEnter.ActiveBorderThickness = 1
        Me.btnEnter.ActiveCornerRadius = 10
        Me.btnEnter.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnEnter.ActiveForecolor = System.Drawing.Color.White
        Me.btnEnter.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnEnter.BackColor = System.Drawing.Color.Transparent
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.ButtonText = "ENTER"
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnter.Font = New System.Drawing.Font("Nunito ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.IdleBorderThickness = 1
        Me.btnEnter.IdleCornerRadius = 10
        Me.btnEnter.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnEnter.IdleForecolor = System.Drawing.Color.White
        Me.btnEnter.IdleLineColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(81, 185)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(181, 59)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuShadowPanel2
        '
        Me.BunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.BorderRadius = 20
        Me.BunifuShadowPanel2.BorderThickness = 2
        Me.BunifuShadowPanel2.Controls.Add(Me.ListBox1)
        Me.BunifuShadowPanel2.Controls.Add(Me.Label4)
        Me.BunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel2.Location = New System.Drawing.Point(374, 22)
        Me.BunifuShadowPanel2.Name = "BunifuShadowPanel2"
        Me.BunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuShadowPanel2.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel2.ShadowDept = 2
        Me.BunifuShadowPanel2.ShadowDepth = 5
        Me.BunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel2.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel2.Size = New System.Drawing.Size(203, 270)
        Me.BunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel2.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Nunito", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 28
        Me.ListBox1.Location = New System.Drawing.Point(15, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(171, 196)
        Me.ListBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nunito ExtraBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Your guesses:"
        '
        'BunifuShadowPanel4
        '
        Me.BunifuShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel4.BorderRadius = 20
        Me.BunifuShadowPanel4.BorderThickness = 1
        Me.BunifuShadowPanel4.Controls.Add(Me.BunifuShadowPanel1)
        Me.BunifuShadowPanel4.Controls.Add(Me.BunifuShadowPanel2)
        Me.BunifuShadowPanel4.Controls.Add(Me.BunifuShadowPanel3)
        Me.BunifuShadowPanel4.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel4.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel4.Location = New System.Drawing.Point(60, 63)
        Me.BunifuShadowPanel4.Name = "BunifuShadowPanel4"
        Me.BunifuShadowPanel4.PanelColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel4.PanelColor2 = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuShadowPanel4.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel4.ShadowDept = 2
        Me.BunifuShadowPanel4.ShadowDepth = 5
        Me.BunifuShadowPanel4.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel4.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel4.Size = New System.Drawing.Size(600, 389)
        Me.BunifuShadowPanel4.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel4.TabIndex = 18
        '
        'BunifuShadowPanel3
        '
        Me.BunifuShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuShadowPanel3.BorderRadius = 18
        Me.BunifuShadowPanel3.BorderThickness = 1
        Me.BunifuShadowPanel3.Controls.Add(Me.Label5)
        Me.BunifuShadowPanel3.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid
        Me.BunifuShadowPanel3.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical
        Me.BunifuShadowPanel3.Location = New System.Drawing.Point(24, 292)
        Me.BunifuShadowPanel3.Name = "BunifuShadowPanel3"
        Me.BunifuShadowPanel3.PanelColor = System.Drawing.Color.DodgerBlue
        Me.BunifuShadowPanel3.PanelColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuShadowPanel3.ShadowColor = System.Drawing.Color.Transparent
        Me.BunifuShadowPanel3.ShadowDept = 2
        Me.BunifuShadowPanel3.ShadowDepth = 5
        Me.BunifuShadowPanel3.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded
        Me.BunifuShadowPanel3.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel3.Size = New System.Drawing.Size(553, 71)
        Me.BunifuShadowPanel3.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat
        Me.BunifuShadowPanel3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Nunito Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(520, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "GUESS THE NUMBER!"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnBack.CustomizableEdges = BorderEdges1
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
        Me.btnBack.Location = New System.Drawing.Point(1, 2)
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
        Me.btnBack.TabIndex = 17
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBack.TextMarginLeft = 0
        Me.btnBack.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnBack.UseDefaultRadiusAndThickness = True
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
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnExit.CustomizableEdges = BorderEdges2
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
        Me.btnExit.Location = New System.Drawing.Point(606, 1)
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
        Me.btnExit.TabIndex = 19
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExit.TextMarginLeft = 0
        Me.btnExit.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnExit.UseDefaultRadiusAndThickness = True
        '
        'btnRetry
        '
        Me.btnRetry.AllowAnimations = True
        Me.btnRetry.AllowMouseEffects = True
        Me.btnRetry.AllowToggling = False
        Me.btnRetry.AnimationSpeed = 200
        Me.btnRetry.AutoGenerateColors = False
        Me.btnRetry.AutoRoundBorders = False
        Me.btnRetry.AutoSizeLeftIcon = True
        Me.btnRetry.AutoSizeRightIcon = True
        Me.btnRetry.BackColor = System.Drawing.Color.Transparent
        Me.btnRetry.BackColor1 = System.Drawing.Color.Transparent
        Me.btnRetry.BackgroundImage = CType(resources.GetObject("btnRetry.BackgroundImage"), System.Drawing.Image)
        Me.btnRetry.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnRetry.ButtonText = "RETRY"
        Me.btnRetry.ButtonTextMarginLeft = 0
        Me.btnRetry.ColorContrastOnClick = 45
        Me.btnRetry.ColorContrastOnHover = 45
        Me.btnRetry.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnRetry.CustomizableEdges = BorderEdges3
        Me.btnRetry.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRetry.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRetry.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRetry.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnRetry.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnRetry.Font = New System.Drawing.Font("Katahdin Round", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.ForeColor = System.Drawing.Color.White
        Me.btnRetry.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRetry.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnRetry.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnRetry.IconMarginLeft = 11
        Me.btnRetry.IconPadding = 10
        Me.btnRetry.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetry.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnRetry.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnRetry.IconSize = 25
        Me.btnRetry.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnRetry.IdleBorderRadius = 1
        Me.btnRetry.IdleBorderThickness = 1
        Me.btnRetry.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnRetry.IdleIconLeftImage = CType(resources.GetObject("btnRetry.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnRetry.IdleIconRightImage = Nothing
        Me.btnRetry.IndicateFocus = False
        Me.btnRetry.Location = New System.Drawing.Point(455, 450)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRetry.OnDisabledState.BorderRadius = 0
        Me.btnRetry.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnRetry.OnDisabledState.BorderThickness = 0
        Me.btnRetry.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnRetry.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnRetry.OnDisabledState.IconLeftImage = Nothing
        Me.btnRetry.OnDisabledState.IconRightImage = Nothing
        Me.btnRetry.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnRetry.onHoverState.BorderRadius = 0
        Me.btnRetry.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnRetry.onHoverState.BorderThickness = 0
        Me.btnRetry.onHoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnRetry.onHoverState.ForeColor = System.Drawing.Color.Gold
        Me.btnRetry.onHoverState.IconLeftImage = Nothing
        Me.btnRetry.onHoverState.IconRightImage = Nothing
        Me.btnRetry.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnRetry.OnIdleState.BorderRadius = 0
        Me.btnRetry.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnRetry.OnIdleState.BorderThickness = 0
        Me.btnRetry.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnRetry.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnRetry.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton1.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.btnRetry.OnIdleState.IconRightImage = Nothing
        Me.btnRetry.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnRetry.OnPressedState.BorderRadius = 0
        Me.btnRetry.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnRetry.OnPressedState.BorderThickness = 0
        Me.btnRetry.OnPressedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRetry.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnRetry.OnPressedState.IconLeftImage = Nothing
        Me.btnRetry.OnPressedState.IconRightImage = Nothing
        Me.btnRetry.Size = New System.Drawing.Size(126, 52)
        Me.btnRetry.TabIndex = 20
        Me.btnRetry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetry.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRetry.TextMarginLeft = 0
        Me.btnRetry.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnRetry.UseDefaultRadiusAndThickness = True
        '
        'btnHome
        '
        Me.btnHome.AllowAnimations = True
        Me.btnHome.AllowMouseEffects = True
        Me.btnHome.AllowToggling = False
        Me.btnHome.AnimationSpeed = 200
        Me.btnHome.AutoGenerateColors = False
        Me.btnHome.AutoRoundBorders = False
        Me.btnHome.AutoSizeLeftIcon = True
        Me.btnHome.AutoSizeRightIcon = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackColor1 = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnHome.ButtonText = "HOME"
        Me.btnHome.ButtonTextMarginLeft = 0
        Me.btnHome.ColorContrastOnClick = 45
        Me.btnHome.ColorContrastOnHover = 45
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnHome.CustomizableEdges = BorderEdges4
        Me.btnHome.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHome.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnHome.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHome.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnHome.Font = New System.Drawing.Font("Katahdin Round", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnHome.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnHome.IconMarginLeft = 11
        Me.btnHome.IconPadding = 10
        Me.btnHome.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnHome.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnHome.IconSize = 25
        Me.btnHome.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnHome.IdleBorderRadius = 1
        Me.btnHome.IdleBorderThickness = 1
        Me.btnHome.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnHome.IdleIconLeftImage = CType(resources.GetObject("btnHome.IdleIconLeftImage"), System.Drawing.Image)
        Me.btnHome.IdleIconRightImage = Nothing
        Me.btnHome.IndicateFocus = False
        Me.btnHome.Location = New System.Drawing.Point(590, 450)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnHome.OnDisabledState.BorderRadius = 0
        Me.btnHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnHome.OnDisabledState.BorderThickness = 0
        Me.btnHome.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHome.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnHome.OnDisabledState.IconLeftImage = Nothing
        Me.btnHome.OnDisabledState.IconRightImage = Nothing
        Me.btnHome.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnHome.onHoverState.BorderRadius = 0
        Me.btnHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnHome.onHoverState.BorderThickness = 0
        Me.btnHome.onHoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.onHoverState.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnHome.onHoverState.IconLeftImage = Nothing
        Me.btnHome.onHoverState.IconRightImage = Nothing
        Me.btnHome.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnHome.OnIdleState.BorderRadius = 0
        Me.btnHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnHome.OnIdleState.BorderThickness = 0
        Me.btnHome.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnHome.OnIdleState.IconLeftImage = CType(resources.GetObject("BunifuButton2.OnIdleState.IconLeftImage"), System.Drawing.Image)
        Me.btnHome.OnIdleState.IconRightImage = Nothing
        Me.btnHome.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.btnHome.OnPressedState.BorderRadius = 0
        Me.btnHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnHome.OnPressedState.BorderThickness = 0
        Me.btnHome.OnPressedState.FillColor = System.Drawing.Color.Transparent
        Me.btnHome.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnHome.OnPressedState.IconLeftImage = Nothing
        Me.btnHome.OnPressedState.IconRightImage = Nothing
        Me.btnHome.Size = New System.Drawing.Size(126, 52)
        Me.btnHome.TabIndex = 21
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnHome.TextMarginLeft = 0
        Me.btnHome.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnHome.UseDefaultRadiusAndThickness = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 504)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BunifuShadowPanel4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Game"
        Me.BunifuShadowPanel1.ResumeLayout(False)
        Me.BunifuShadowPanel1.PerformLayout()
        Me.BunifuShadowPanel2.ResumeLayout(False)
        Me.BunifuShadowPanel2.PerformLayout()
        Me.BunifuShadowPanel4.ResumeLayout(False)
        Me.BunifuShadowPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputNo As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuShadowPanel1 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuShadowPanel2 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuShadowPanel3 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnBack As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuShadowPanel4 As Bunifu.UI.WinForms.BunifuShadowPanel
    Friend WithEvents btnExit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnRetry As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnHome As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
