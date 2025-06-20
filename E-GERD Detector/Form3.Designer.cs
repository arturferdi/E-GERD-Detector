namespace GerdQ
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.statusBarPnl_Title_Lbl = new System.Windows.Forms.Label();
            this.statusPnl = new System.Windows.Forms.Panel();
            this.statusBarPnl_MinBtn = new Bunifu.UI.WinForms.BunifuShapes();
            this.statusBarPnl_CloseBtn = new Bunifu.UI.WinForms.BunifuShapes();
            this.finalResultPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.finalResultPanel_Home_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.finalResultPanel_saveData_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.finalResultPanel_result_lbl = new System.Windows.Forms.Label();
            this.finalResultPanel_Sign = new System.Windows.Forms.PictureBox();
            this.finalResultPanel_HasilDiag_lbl = new System.Windows.Forms.Label();
            this.tipsPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.tipsPanel_asset = new Bunifu.UI.WinForms.BunifuShapes();
            this.tipsPanel_txtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tipsPanel_tips_lbl = new System.Windows.Forms.Label();
            this.allDataPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.allDataPanel_txtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.allDataPanel_asset = new Bunifu.UI.WinForms.BunifuShapes();
            this.allDataPanel_Data_lbl = new System.Windows.Forms.Label();
            this.statusPnl.SuspendLayout();
            this.finalResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalResultPanel_Sign)).BeginInit();
            this.tipsPanel.SuspendLayout();
            this.allDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // statusBarPnl_Title_Lbl
            // 
            this.statusBarPnl_Title_Lbl.AutoSize = true;
            this.statusBarPnl_Title_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBarPnl_Title_Lbl.ForeColor = System.Drawing.Color.Azure;
            this.statusBarPnl_Title_Lbl.Location = new System.Drawing.Point(259, 8);
            this.statusBarPnl_Title_Lbl.Name = "statusBarPnl_Title_Lbl";
            this.statusBarPnl_Title_Lbl.Size = new System.Drawing.Size(130, 19);
            this.statusBarPnl_Title_Lbl.TabIndex = 0;
            this.statusBarPnl_Title_Lbl.Text = "E GERD Detector";
            this.statusBarPnl_Title_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusPnl
            // 
            this.statusPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.statusPnl.Controls.Add(this.statusBarPnl_MinBtn);
            this.statusPnl.Controls.Add(this.statusBarPnl_CloseBtn);
            this.statusPnl.Controls.Add(this.statusBarPnl_Title_Lbl);
            this.statusPnl.Location = new System.Drawing.Point(0, 0);
            this.statusPnl.Name = "statusPnl";
            this.statusPnl.Size = new System.Drawing.Size(650, 35);
            this.statusPnl.TabIndex = 2;
            this.statusPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusPnl_MouseDown);
            this.statusPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.statusPnl_MouseMove);
            this.statusPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.statusPnl_MouseUp);
            // 
            // statusBarPnl_MinBtn
            // 
            this.statusBarPnl_MinBtn.Angle = 0F;
            this.statusBarPnl_MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.statusBarPnl_MinBtn.BorderColor = System.Drawing.Color.Transparent;
            this.statusBarPnl_MinBtn.BorderThickness = 1;
            this.statusBarPnl_MinBtn.FillColor = System.Drawing.Color.Yellow;
            this.statusBarPnl_MinBtn.FillShape = true;
            this.statusBarPnl_MinBtn.Location = new System.Drawing.Point(599, 8);
            this.statusBarPnl_MinBtn.Name = "statusBarPnl_MinBtn";
            this.statusBarPnl_MinBtn.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.statusBarPnl_MinBtn.Sides = 5;
            this.statusBarPnl_MinBtn.Size = new System.Drawing.Size(17, 17);
            this.statusBarPnl_MinBtn.TabIndex = 2;
            this.statusBarPnl_MinBtn.Text = "bunifuShapes2";
            this.statusBarPnl_MinBtn.Click += new System.EventHandler(this.statusBarPnl_MinBtn_Click);
            // 
            // statusBarPnl_CloseBtn
            // 
            this.statusBarPnl_CloseBtn.Angle = 0F;
            this.statusBarPnl_CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.statusBarPnl_CloseBtn.BorderColor = System.Drawing.Color.Transparent;
            this.statusBarPnl_CloseBtn.BorderThickness = 1;
            this.statusBarPnl_CloseBtn.FillColor = System.Drawing.Color.Red;
            this.statusBarPnl_CloseBtn.FillShape = true;
            this.statusBarPnl_CloseBtn.Location = new System.Drawing.Point(622, 8);
            this.statusBarPnl_CloseBtn.Name = "statusBarPnl_CloseBtn";
            this.statusBarPnl_CloseBtn.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.statusBarPnl_CloseBtn.Sides = 5;
            this.statusBarPnl_CloseBtn.Size = new System.Drawing.Size(17, 17);
            this.statusBarPnl_CloseBtn.TabIndex = 1;
            this.statusBarPnl_CloseBtn.Text = "bunifuShapes1";
            this.statusBarPnl_CloseBtn.Click += new System.EventHandler(this.statusBarPnl_CloseBtn_Click);
            // 
            // finalResultPanel
            // 
            this.finalResultPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.finalResultPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalResultPanel.BackgroundImage")));
            this.finalResultPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalResultPanel.BorderColor = System.Drawing.Color.Silver;
            this.finalResultPanel.BorderRadius = 20;
            this.finalResultPanel.BorderThickness = 1;
            this.finalResultPanel.Controls.Add(this.finalResultPanel_Home_btn);
            this.finalResultPanel.Controls.Add(this.finalResultPanel_saveData_btn);
            this.finalResultPanel.Controls.Add(this.finalResultPanel_result_lbl);
            this.finalResultPanel.Controls.Add(this.finalResultPanel_Sign);
            this.finalResultPanel.Controls.Add(this.finalResultPanel_HasilDiag_lbl);
            this.finalResultPanel.Location = new System.Drawing.Point(273, 41);
            this.finalResultPanel.Name = "finalResultPanel";
            this.finalResultPanel.ShowBorders = true;
            this.finalResultPanel.Size = new System.Drawing.Size(368, 377);
            this.finalResultPanel.TabIndex = 5;
            // 
            // finalResultPanel_Home_btn
            // 
            this.finalResultPanel_Home_btn.AllowAnimations = true;
            this.finalResultPanel_Home_btn.AllowMouseEffects = true;
            this.finalResultPanel_Home_btn.AllowToggling = false;
            this.finalResultPanel_Home_btn.AnimationSpeed = 200;
            this.finalResultPanel_Home_btn.AutoGenerateColors = false;
            this.finalResultPanel_Home_btn.AutoRoundBorders = false;
            this.finalResultPanel_Home_btn.AutoSizeLeftIcon = true;
            this.finalResultPanel_Home_btn.AutoSizeRightIcon = true;
            this.finalResultPanel_Home_btn.BackColor = System.Drawing.Color.Transparent;
            this.finalResultPanel_Home_btn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.finalResultPanel_Home_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalResultPanel_Home_btn.BackgroundImage")));
            this.finalResultPanel_Home_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_Home_btn.ButtonText = "Halaman Awal";
            this.finalResultPanel_Home_btn.ButtonTextMarginLeft = 0;
            this.finalResultPanel_Home_btn.ColorContrastOnClick = 45;
            this.finalResultPanel_Home_btn.ColorContrastOnHover = 45;
            this.finalResultPanel_Home_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.finalResultPanel_Home_btn.CustomizableEdges = borderEdges1;
            this.finalResultPanel_Home_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.finalResultPanel_Home_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.finalResultPanel_Home_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.finalResultPanel_Home_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.finalResultPanel_Home_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.finalResultPanel_Home_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finalResultPanel_Home_btn.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_Home_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finalResultPanel_Home_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.finalResultPanel_Home_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.finalResultPanel_Home_btn.IconMarginLeft = 11;
            this.finalResultPanel_Home_btn.IconPadding = 10;
            this.finalResultPanel_Home_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.finalResultPanel_Home_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.finalResultPanel_Home_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.finalResultPanel_Home_btn.IconSize = 25;
            this.finalResultPanel_Home_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.finalResultPanel_Home_btn.IdleBorderRadius = 15;
            this.finalResultPanel_Home_btn.IdleBorderThickness = 1;
            this.finalResultPanel_Home_btn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.finalResultPanel_Home_btn.IdleIconLeftImage = null;
            this.finalResultPanel_Home_btn.IdleIconRightImage = global::GerdQ.Properties.Resources.home_button;
            this.finalResultPanel_Home_btn.IndicateFocus = false;
            this.finalResultPanel_Home_btn.Location = new System.Drawing.Point(205, 310);
            this.finalResultPanel_Home_btn.Name = "finalResultPanel_Home_btn";
            this.finalResultPanel_Home_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.finalResultPanel_Home_btn.OnDisabledState.BorderRadius = 15;
            this.finalResultPanel_Home_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_Home_btn.OnDisabledState.BorderThickness = 1;
            this.finalResultPanel_Home_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.finalResultPanel_Home_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.finalResultPanel_Home_btn.OnDisabledState.IconLeftImage = null;
            this.finalResultPanel_Home_btn.OnDisabledState.IconRightImage = null;
            this.finalResultPanel_Home_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.finalResultPanel_Home_btn.onHoverState.BorderRadius = 15;
            this.finalResultPanel_Home_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_Home_btn.onHoverState.BorderThickness = 1;
            this.finalResultPanel_Home_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.finalResultPanel_Home_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_Home_btn.onHoverState.IconLeftImage = null;
            this.finalResultPanel_Home_btn.onHoverState.IconRightImage = null;
            this.finalResultPanel_Home_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.finalResultPanel_Home_btn.OnIdleState.BorderRadius = 15;
            this.finalResultPanel_Home_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_Home_btn.OnIdleState.BorderThickness = 1;
            this.finalResultPanel_Home_btn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.finalResultPanel_Home_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_Home_btn.OnIdleState.IconLeftImage = null;
            this.finalResultPanel_Home_btn.OnIdleState.IconRightImage = global::GerdQ.Properties.Resources.home_button;
            this.finalResultPanel_Home_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.finalResultPanel_Home_btn.OnPressedState.BorderRadius = 15;
            this.finalResultPanel_Home_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_Home_btn.OnPressedState.BorderThickness = 1;
            this.finalResultPanel_Home_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.finalResultPanel_Home_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_Home_btn.OnPressedState.IconLeftImage = null;
            this.finalResultPanel_Home_btn.OnPressedState.IconRightImage = null;
            this.finalResultPanel_Home_btn.Size = new System.Drawing.Size(150, 39);
            this.finalResultPanel_Home_btn.TabIndex = 4;
            this.finalResultPanel_Home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalResultPanel_Home_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalResultPanel_Home_btn.TextMarginLeft = 0;
            this.finalResultPanel_Home_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.finalResultPanel_Home_btn.UseDefaultRadiusAndThickness = true;
            this.finalResultPanel_Home_btn.Click += new System.EventHandler(this.finalResultPanel_Home_btn_Click);
            // 
            // finalResultPanel_saveData_btn
            // 
            this.finalResultPanel_saveData_btn.AllowAnimations = true;
            this.finalResultPanel_saveData_btn.AllowMouseEffects = true;
            this.finalResultPanel_saveData_btn.AllowToggling = false;
            this.finalResultPanel_saveData_btn.AnimationSpeed = 200;
            this.finalResultPanel_saveData_btn.AutoGenerateColors = false;
            this.finalResultPanel_saveData_btn.AutoRoundBorders = false;
            this.finalResultPanel_saveData_btn.AutoSizeLeftIcon = true;
            this.finalResultPanel_saveData_btn.AutoSizeRightIcon = true;
            this.finalResultPanel_saveData_btn.BackColor = System.Drawing.Color.Transparent;
            this.finalResultPanel_saveData_btn.BackColor1 = System.Drawing.Color.DarkOrchid;
            this.finalResultPanel_saveData_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalResultPanel_saveData_btn.BackgroundImage")));
            this.finalResultPanel_saveData_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_saveData_btn.ButtonText = "Simpan Data";
            this.finalResultPanel_saveData_btn.ButtonTextMarginLeft = 0;
            this.finalResultPanel_saveData_btn.ColorContrastOnClick = 45;
            this.finalResultPanel_saveData_btn.ColorContrastOnHover = 45;
            this.finalResultPanel_saveData_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.finalResultPanel_saveData_btn.CustomizableEdges = borderEdges2;
            this.finalResultPanel_saveData_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.finalResultPanel_saveData_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.finalResultPanel_saveData_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.finalResultPanel_saveData_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.finalResultPanel_saveData_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.finalResultPanel_saveData_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finalResultPanel_saveData_btn.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_saveData_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.finalResultPanel_saveData_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.finalResultPanel_saveData_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.finalResultPanel_saveData_btn.IconMarginLeft = 11;
            this.finalResultPanel_saveData_btn.IconPadding = 10;
            this.finalResultPanel_saveData_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.finalResultPanel_saveData_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.finalResultPanel_saveData_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.finalResultPanel_saveData_btn.IconSize = 25;
            this.finalResultPanel_saveData_btn.IdleBorderColor = System.Drawing.Color.DarkOrchid;
            this.finalResultPanel_saveData_btn.IdleBorderRadius = 15;
            this.finalResultPanel_saveData_btn.IdleBorderThickness = 1;
            this.finalResultPanel_saveData_btn.IdleFillColor = System.Drawing.Color.DarkOrchid;
            this.finalResultPanel_saveData_btn.IdleIconLeftImage = null;
            this.finalResultPanel_saveData_btn.IdleIconRightImage = global::GerdQ.Properties.Resources.save;
            this.finalResultPanel_saveData_btn.IndicateFocus = false;
            this.finalResultPanel_saveData_btn.Location = new System.Drawing.Point(13, 310);
            this.finalResultPanel_saveData_btn.Name = "finalResultPanel_saveData_btn";
            this.finalResultPanel_saveData_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.finalResultPanel_saveData_btn.OnDisabledState.BorderRadius = 15;
            this.finalResultPanel_saveData_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_saveData_btn.OnDisabledState.BorderThickness = 1;
            this.finalResultPanel_saveData_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.finalResultPanel_saveData_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.finalResultPanel_saveData_btn.OnDisabledState.IconLeftImage = null;
            this.finalResultPanel_saveData_btn.OnDisabledState.IconRightImage = null;
            this.finalResultPanel_saveData_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.finalResultPanel_saveData_btn.onHoverState.BorderRadius = 15;
            this.finalResultPanel_saveData_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_saveData_btn.onHoverState.BorderThickness = 1;
            this.finalResultPanel_saveData_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.finalResultPanel_saveData_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_saveData_btn.onHoverState.IconLeftImage = null;
            this.finalResultPanel_saveData_btn.onHoverState.IconRightImage = null;
            this.finalResultPanel_saveData_btn.OnIdleState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.finalResultPanel_saveData_btn.OnIdleState.BorderRadius = 15;
            this.finalResultPanel_saveData_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_saveData_btn.OnIdleState.BorderThickness = 1;
            this.finalResultPanel_saveData_btn.OnIdleState.FillColor = System.Drawing.Color.DarkOrchid;
            this.finalResultPanel_saveData_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_saveData_btn.OnIdleState.IconLeftImage = null;
            this.finalResultPanel_saveData_btn.OnIdleState.IconRightImage = global::GerdQ.Properties.Resources.save;
            this.finalResultPanel_saveData_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.finalResultPanel_saveData_btn.OnPressedState.BorderRadius = 15;
            this.finalResultPanel_saveData_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.finalResultPanel_saveData_btn.OnPressedState.BorderThickness = 1;
            this.finalResultPanel_saveData_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.finalResultPanel_saveData_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.finalResultPanel_saveData_btn.OnPressedState.IconLeftImage = null;
            this.finalResultPanel_saveData_btn.OnPressedState.IconRightImage = null;
            this.finalResultPanel_saveData_btn.Size = new System.Drawing.Size(150, 39);
            this.finalResultPanel_saveData_btn.TabIndex = 3;
            this.finalResultPanel_saveData_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalResultPanel_saveData_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalResultPanel_saveData_btn.TextMarginLeft = 0;
            this.finalResultPanel_saveData_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.finalResultPanel_saveData_btn.UseDefaultRadiusAndThickness = true;
            this.finalResultPanel_saveData_btn.Click += new System.EventHandler(this.finalResultPanel_saveData_btn_Click);
            // 
            // finalResultPanel_result_lbl
            // 
            this.finalResultPanel_result_lbl.BackColor = System.Drawing.Color.Green;
            this.finalResultPanel_result_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalResultPanel_result_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.finalResultPanel_result_lbl.Location = new System.Drawing.Point(3, 246);
            this.finalResultPanel_result_lbl.Name = "finalResultPanel_result_lbl";
            this.finalResultPanel_result_lbl.Size = new System.Drawing.Size(363, 33);
            this.finalResultPanel_result_lbl.TabIndex = 2;
            this.finalResultPanel_result_lbl.Text = "Terdeteksi Dini GERD";
            this.finalResultPanel_result_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalResultPanel_Sign
            // 
            this.finalResultPanel_Sign.Image = global::GerdQ.Properties.Resources.yes;
            this.finalResultPanel_Sign.Location = new System.Drawing.Point(94, 9);
            this.finalResultPanel_Sign.Name = "finalResultPanel_Sign";
            this.finalResultPanel_Sign.Size = new System.Drawing.Size(180, 180);
            this.finalResultPanel_Sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalResultPanel_Sign.TabIndex = 1;
            this.finalResultPanel_Sign.TabStop = false;
            // 
            // finalResultPanel_HasilDiag_lbl
            // 
            this.finalResultPanel_HasilDiag_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalResultPanel_HasilDiag_lbl.Location = new System.Drawing.Point(82, 204);
            this.finalResultPanel_HasilDiag_lbl.Name = "finalResultPanel_HasilDiag_lbl";
            this.finalResultPanel_HasilDiag_lbl.Size = new System.Drawing.Size(205, 33);
            this.finalResultPanel_HasilDiag_lbl.TabIndex = 0;
            this.finalResultPanel_HasilDiag_lbl.Text = "Hasil diagnosis menyatakan bahwa Anda";
            this.finalResultPanel_HasilDiag_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipsPanel
            // 
            this.tipsPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.tipsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tipsPanel.BackgroundImage")));
            this.tipsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tipsPanel.BorderColor = System.Drawing.Color.Silver;
            this.tipsPanel.BorderRadius = 20;
            this.tipsPanel.BorderThickness = 1;
            this.tipsPanel.Controls.Add(this.tipsPanel_asset);
            this.tipsPanel.Controls.Add(this.tipsPanel_txtBox);
            this.tipsPanel.Controls.Add(this.tipsPanel_tips_lbl);
            this.tipsPanel.Location = new System.Drawing.Point(7, 235);
            this.tipsPanel.Name = "tipsPanel";
            this.tipsPanel.ShowBorders = true;
            this.tipsPanel.Size = new System.Drawing.Size(260, 183);
            this.tipsPanel.TabIndex = 4;
            // 
            // tipsPanel_asset
            // 
            this.tipsPanel_asset.Angle = 0F;
            this.tipsPanel_asset.BackColor = System.Drawing.Color.Transparent;
            this.tipsPanel_asset.BorderColor = System.Drawing.Color.Transparent;
            this.tipsPanel_asset.BorderThickness = 0;
            this.tipsPanel_asset.FillColor = System.Drawing.Color.GreenYellow;
            this.tipsPanel_asset.FillShape = true;
            this.tipsPanel_asset.Location = new System.Drawing.Point(11, 10);
            this.tipsPanel_asset.Name = "tipsPanel_asset";
            this.tipsPanel_asset.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.tipsPanel_asset.Sides = 5;
            this.tipsPanel_asset.Size = new System.Drawing.Size(17, 17);
            this.tipsPanel_asset.TabIndex = 3;
            this.tipsPanel_asset.Text = "bunifuShapes1";
            // 
            // tipsPanel_txtBox
            // 
            this.tipsPanel_txtBox.AcceptsReturn = false;
            this.tipsPanel_txtBox.AcceptsTab = false;
            this.tipsPanel_txtBox.AnimationSpeed = 200;
            this.tipsPanel_txtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tipsPanel_txtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tipsPanel_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.tipsPanel_txtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tipsPanel_txtBox.BackgroundImage")));
            this.tipsPanel_txtBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tipsPanel_txtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tipsPanel_txtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tipsPanel_txtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.tipsPanel_txtBox.BorderRadius = 15;
            this.tipsPanel_txtBox.BorderThickness = 1;
            this.tipsPanel_txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tipsPanel_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tipsPanel_txtBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tipsPanel_txtBox.DefaultText = "";
            this.tipsPanel_txtBox.FillColor = System.Drawing.Color.White;
            this.tipsPanel_txtBox.HideSelection = true;
            this.tipsPanel_txtBox.IconLeft = null;
            this.tipsPanel_txtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tipsPanel_txtBox.IconPadding = 10;
            this.tipsPanel_txtBox.IconRight = null;
            this.tipsPanel_txtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tipsPanel_txtBox.Lines = new string[0];
            this.tipsPanel_txtBox.Location = new System.Drawing.Point(3, 33);
            this.tipsPanel_txtBox.MaxLength = 32767;
            this.tipsPanel_txtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.tipsPanel_txtBox.Modified = false;
            this.tipsPanel_txtBox.Multiline = true;
            this.tipsPanel_txtBox.Name = "tipsPanel_txtBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tipsPanel_txtBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tipsPanel_txtBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tipsPanel_txtBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tipsPanel_txtBox.OnIdleState = stateProperties4;
            this.tipsPanel_txtBox.Padding = new System.Windows.Forms.Padding(3);
            this.tipsPanel_txtBox.PasswordChar = '\0';
            this.tipsPanel_txtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tipsPanel_txtBox.PlaceholderText = "Enter text";
            this.tipsPanel_txtBox.ReadOnly = true;
            this.tipsPanel_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tipsPanel_txtBox.SelectedText = "";
            this.tipsPanel_txtBox.SelectionLength = 0;
            this.tipsPanel_txtBox.SelectionStart = 0;
            this.tipsPanel_txtBox.ShortcutsEnabled = true;
            this.tipsPanel_txtBox.Size = new System.Drawing.Size(254, 147);
            this.tipsPanel_txtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tipsPanel_txtBox.TabIndex = 0;
            this.tipsPanel_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tipsPanel_txtBox.TextMarginBottom = 0;
            this.tipsPanel_txtBox.TextMarginLeft = 3;
            this.tipsPanel_txtBox.TextMarginTop = 6;
            this.tipsPanel_txtBox.TextPlaceholder = "Enter text";
            this.tipsPanel_txtBox.UseSystemPasswordChar = false;
            this.tipsPanel_txtBox.WordWrap = true;
            // 
            // tipsPanel_tips_lbl
            // 
            this.tipsPanel_tips_lbl.AutoSize = true;
            this.tipsPanel_tips_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tipsPanel_tips_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsPanel_tips_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.tipsPanel_tips_lbl.Location = new System.Drawing.Point(38, 9);
            this.tipsPanel_tips_lbl.Name = "tipsPanel_tips_lbl";
            this.tipsPanel_tips_lbl.Size = new System.Drawing.Size(36, 19);
            this.tipsPanel_tips_lbl.TabIndex = 2;
            this.tipsPanel_tips_lbl.Text = "Tips";
            // 
            // allDataPanel
            // 
            this.allDataPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.allDataPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allDataPanel.BackgroundImage")));
            this.allDataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allDataPanel.BorderColor = System.Drawing.Color.Silver;
            this.allDataPanel.BorderRadius = 20;
            this.allDataPanel.BorderThickness = 1;
            this.allDataPanel.Controls.Add(this.allDataPanel_txtBox);
            this.allDataPanel.Controls.Add(this.allDataPanel_asset);
            this.allDataPanel.Controls.Add(this.allDataPanel_Data_lbl);
            this.allDataPanel.Location = new System.Drawing.Point(7, 41);
            this.allDataPanel.Name = "allDataPanel";
            this.allDataPanel.ShowBorders = true;
            this.allDataPanel.Size = new System.Drawing.Size(260, 183);
            this.allDataPanel.TabIndex = 3;
            // 
            // allDataPanel_txtBox
            // 
            this.allDataPanel_txtBox.AcceptsReturn = false;
            this.allDataPanel_txtBox.AcceptsTab = false;
            this.allDataPanel_txtBox.AnimationSpeed = 200;
            this.allDataPanel_txtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.allDataPanel_txtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.allDataPanel_txtBox.BackColor = System.Drawing.Color.Transparent;
            this.allDataPanel_txtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allDataPanel_txtBox.BackgroundImage")));
            this.allDataPanel_txtBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.allDataPanel_txtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allDataPanel_txtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.allDataPanel_txtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.allDataPanel_txtBox.BorderRadius = 15;
            this.allDataPanel_txtBox.BorderThickness = 1;
            this.allDataPanel_txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.allDataPanel_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.allDataPanel_txtBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.allDataPanel_txtBox.DefaultText = "";
            this.allDataPanel_txtBox.FillColor = System.Drawing.Color.White;
            this.allDataPanel_txtBox.HideSelection = true;
            this.allDataPanel_txtBox.IconLeft = null;
            this.allDataPanel_txtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.allDataPanel_txtBox.IconPadding = 10;
            this.allDataPanel_txtBox.IconRight = null;
            this.allDataPanel_txtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.allDataPanel_txtBox.Lines = new string[0];
            this.allDataPanel_txtBox.Location = new System.Drawing.Point(3, 33);
            this.allDataPanel_txtBox.MaxLength = 32767;
            this.allDataPanel_txtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.allDataPanel_txtBox.Modified = false;
            this.allDataPanel_txtBox.Multiline = true;
            this.allDataPanel_txtBox.Name = "allDataPanel_txtBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.allDataPanel_txtBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.allDataPanel_txtBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.allDataPanel_txtBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.allDataPanel_txtBox.OnIdleState = stateProperties8;
            this.allDataPanel_txtBox.Padding = new System.Windows.Forms.Padding(3);
            this.allDataPanel_txtBox.PasswordChar = '\0';
            this.allDataPanel_txtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.allDataPanel_txtBox.PlaceholderText = "Enter text";
            this.allDataPanel_txtBox.ReadOnly = true;
            this.allDataPanel_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allDataPanel_txtBox.SelectedText = "";
            this.allDataPanel_txtBox.SelectionLength = 0;
            this.allDataPanel_txtBox.SelectionStart = 0;
            this.allDataPanel_txtBox.ShortcutsEnabled = true;
            this.allDataPanel_txtBox.Size = new System.Drawing.Size(254, 147);
            this.allDataPanel_txtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.allDataPanel_txtBox.TabIndex = 4;
            this.allDataPanel_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allDataPanel_txtBox.TextMarginBottom = 0;
            this.allDataPanel_txtBox.TextMarginLeft = 3;
            this.allDataPanel_txtBox.TextMarginTop = 0;
            this.allDataPanel_txtBox.TextPlaceholder = "Enter text";
            this.allDataPanel_txtBox.UseSystemPasswordChar = false;
            this.allDataPanel_txtBox.WordWrap = true;
            // 
            // allDataPanel_asset
            // 
            this.allDataPanel_asset.Angle = 0F;
            this.allDataPanel_asset.BackColor = System.Drawing.Color.Transparent;
            this.allDataPanel_asset.BorderColor = System.Drawing.Color.Transparent;
            this.allDataPanel_asset.BorderThickness = 0;
            this.allDataPanel_asset.FillColor = System.Drawing.Color.GreenYellow;
            this.allDataPanel_asset.FillShape = true;
            this.allDataPanel_asset.Location = new System.Drawing.Point(13, 9);
            this.allDataPanel_asset.Name = "allDataPanel_asset";
            this.allDataPanel_asset.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.allDataPanel_asset.Sides = 5;
            this.allDataPanel_asset.Size = new System.Drawing.Size(17, 17);
            this.allDataPanel_asset.TabIndex = 3;
            this.allDataPanel_asset.Text = "bunifuShapes1";
            // 
            // allDataPanel_Data_lbl
            // 
            this.allDataPanel_Data_lbl.AutoSize = true;
            this.allDataPanel_Data_lbl.BackColor = System.Drawing.Color.Transparent;
            this.allDataPanel_Data_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDataPanel_Data_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.allDataPanel_Data_lbl.Location = new System.Drawing.Point(40, 8);
            this.allDataPanel_Data_lbl.Name = "allDataPanel_Data_lbl";
            this.allDataPanel_Data_lbl.Size = new System.Drawing.Size(40, 19);
            this.allDataPanel_Data_lbl.TabIndex = 2;
            this.allDataPanel_Data_lbl.Text = "Data";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.finalResultPanel);
            this.Controls.Add(this.tipsPanel);
            this.Controls.Add(this.allDataPanel);
            this.Controls.Add(this.statusPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.statusPnl.ResumeLayout(false);
            this.statusPnl.PerformLayout();
            this.finalResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalResultPanel_Sign)).EndInit();
            this.tipsPanel.ResumeLayout(false);
            this.tipsPanel.PerformLayout();
            this.allDataPanel.ResumeLayout(false);
            this.allDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel statusPnl;
        private Bunifu.UI.WinForms.BunifuShapes statusBarPnl_MinBtn;
        private Bunifu.UI.WinForms.BunifuShapes statusBarPnl_CloseBtn;
        private System.Windows.Forms.Label statusBarPnl_Title_Lbl;
        private Bunifu.UI.WinForms.BunifuPanel allDataPanel;
        private Bunifu.UI.WinForms.BunifuPanel tipsPanel;
        private Bunifu.UI.WinForms.BunifuTextBox tipsPanel_txtBox;
        private Bunifu.UI.WinForms.BunifuShapes allDataPanel_asset;
        private System.Windows.Forms.Label allDataPanel_Data_lbl;
        private Bunifu.UI.WinForms.BunifuShapes tipsPanel_asset;
        private System.Windows.Forms.Label tipsPanel_tips_lbl;
        private Bunifu.UI.WinForms.BunifuPanel finalResultPanel;
        private System.Windows.Forms.Label finalResultPanel_HasilDiag_lbl;
        private System.Windows.Forms.PictureBox finalResultPanel_Sign;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton finalResultPanel_saveData_btn;
        private System.Windows.Forms.Label finalResultPanel_result_lbl;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton finalResultPanel_Home_btn;
        private Bunifu.UI.WinForms.BunifuTextBox allDataPanel_txtBox;
    }
}