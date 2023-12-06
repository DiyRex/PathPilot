namespace PathPilot
{
    partial class PathManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathManager));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDrag1 = new Bunifu.UI.WinForms.BunifuFormDrag();
            this.bunifuFormControlBox1 = new Bunifu.UI.WinForms.BunifuFormControlBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pathGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPathx = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnUpdatePathx = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDeletePathx = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            ((System.ComponentModel.ISupportInitialize)(this.pathGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormDrag1
            // 
            this.bunifuFormDrag1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDrag1.ContainerControl = this;
            this.bunifuFormDrag1.DockIndicatorsOpacity = 0.5D;
            this.bunifuFormDrag1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDrag1.DockingOptions.DockAll = true;
            this.bunifuFormDrag1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDrag1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDrag1.DockingOptions.DockLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockRight = true;
            this.bunifuFormDrag1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockTopRight = true;
            this.bunifuFormDrag1.DragOpacity = 0.9D;
            this.bunifuFormDrag1.Enabled = true;
            this.bunifuFormDrag1.ParentForm = this;
            this.bunifuFormDrag1.ShowCursorChanges = true;
            this.bunifuFormDrag1.ShowDockingIndicators = true;
            this.bunifuFormDrag1.TitleBarOptions.BunifuFormDrag = this.bunifuFormDrag1;
            this.bunifuFormDrag1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDrag1.TitleBarOptions.Enabled = true;
            this.bunifuFormDrag1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDrag1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuFormControlBox1
            // 
            this.bunifuFormControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormControlBox1.BunifuFormDrag = null;
            this.bunifuFormControlBox1.CloseBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.CloseBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.CloseBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.CloseBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.CloseBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.CloseBoxOptions.Icon")));
            this.bunifuFormControlBox1.CloseBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.CloseBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconSize = new System.Drawing.Size(18, 18);
            this.bunifuFormControlBox1.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.HelpBox = false;
            this.bunifuFormControlBox1.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.HelpBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.HelpBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.HelpBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.HelpBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.HelpBoxOptions.Icon")));
            this.bunifuFormControlBox1.HelpBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.HelpBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconSize = new System.Drawing.Size(22, 22);
            this.bunifuFormControlBox1.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Location = new System.Drawing.Point(274, 1);
            this.bunifuFormControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuFormControlBox1.MaximizeBox = false;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconAlt = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.IconAlt")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconSize = new System.Drawing.Size(16, 16);
            this.bunifuFormControlBox1.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.MinimizeBox = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MinimizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconSize = new System.Drawing.Size(14, 14);
            this.bunifuFormControlBox1.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Name = "bunifuFormControlBox1";
            this.bunifuFormControlBox1.ShowDesignBorders = false;
            this.bunifuFormControlBox1.Size = new System.Drawing.Size(65, 29);
            this.bunifuFormControlBox1.TabIndex = 3;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(101, 33);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(138, 30);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Path Manager";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pathGrid
            // 
            this.pathGrid.AllowCustomTheming = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.pathGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.pathGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pathGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pathGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.pathGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pathGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.pathGrid.ColumnHeadersHeight = 5;
            this.pathGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path});
            this.pathGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pathGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.pathGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pathGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.pathGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pathGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.pathGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.Name = null;
            this.pathGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.pathGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.pathGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            this.pathGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pathGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.pathGrid.EnableHeadersVisualStyles = false;
            this.pathGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pathGrid.HeaderBackColor = System.Drawing.Color.White;
            this.pathGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.pathGrid.HeaderForeColor = System.Drawing.Color.White;
            this.pathGrid.Location = new System.Drawing.Point(12, 148);
            this.pathGrid.Name = "pathGrid";
            this.pathGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.pathGrid.RowHeadersVisible = false;
            this.pathGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pathGrid.RowTemplate.Height = 40;
            this.pathGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pathGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pathGrid.Size = new System.Drawing.Size(318, 290);
            this.pathGrid.TabIndex = 5;
            this.pathGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Path
            // 
            this.Path.HeaderText = "path";
            this.Path.Name = "Path";
            // 
            // btnAddPathx
            // 
            this.btnAddPathx.ActiveImage = null;
            this.btnAddPathx.AllowAnimations = true;
            this.btnAddPathx.AllowBuffering = false;
            this.btnAddPathx.AllowToggling = false;
            this.btnAddPathx.AllowZooming = false;
            this.btnAddPathx.AllowZoomingOnFocus = false;
            this.btnAddPathx.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPathx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPathx.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPathx.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddPathx.ErrorImage")));
            this.btnAddPathx.FadeWhenInactive = false;
            this.btnAddPathx.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddPathx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPathx.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPathx.Image")));
            this.btnAddPathx.ImageActive = null;
            this.btnAddPathx.ImageLocation = null;
            this.btnAddPathx.ImageMargin = 10;
            this.btnAddPathx.ImageSize = new System.Drawing.Size(29, 29);
            this.btnAddPathx.ImageZoomSize = new System.Drawing.Size(39, 39);
            this.btnAddPathx.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddPathx.InitialImage")));
            this.btnAddPathx.Location = new System.Drawing.Point(26, 82);
            this.btnAddPathx.Name = "btnAddPathx";
            this.btnAddPathx.Rotation = 0;
            this.btnAddPathx.ShowActiveImage = true;
            this.btnAddPathx.ShowCursorChanges = true;
            this.btnAddPathx.ShowImageBorders = false;
            this.btnAddPathx.ShowSizeMarkers = false;
            this.btnAddPathx.Size = new System.Drawing.Size(39, 39);
            this.btnAddPathx.TabIndex = 6;
            this.btnAddPathx.ToolTipText = "";
            this.btnAddPathx.WaitOnLoad = false;
            this.btnAddPathx.Zoom = 10;
            this.btnAddPathx.ZoomSpeed = 10;
            this.btnAddPathx.Click += new System.EventHandler(this.btnAddPathx_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(34, 117);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(22, 15);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Add";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(213, 117);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(38, 15);
            this.bunifuLabel3.TabIndex = 9;
            this.bunifuLabel3.Text = "Update";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnUpdatePathx
            // 
            this.btnUpdatePathx.ActiveImage = null;
            this.btnUpdatePathx.AllowAnimations = true;
            this.btnUpdatePathx.AllowBuffering = false;
            this.btnUpdatePathx.AllowToggling = false;
            this.btnUpdatePathx.AllowZooming = false;
            this.btnUpdatePathx.AllowZoomingOnFocus = false;
            this.btnUpdatePathx.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePathx.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdatePathx.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePathx.ErrorImage")));
            this.btnUpdatePathx.FadeWhenInactive = false;
            this.btnUpdatePathx.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnUpdatePathx.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePathx.Image")));
            this.btnUpdatePathx.ImageActive = null;
            this.btnUpdatePathx.ImageLocation = null;
            this.btnUpdatePathx.ImageMargin = 10;
            this.btnUpdatePathx.ImageSize = new System.Drawing.Size(29, 29);
            this.btnUpdatePathx.ImageZoomSize = new System.Drawing.Size(39, 39);
            this.btnUpdatePathx.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePathx.InitialImage")));
            this.btnUpdatePathx.Location = new System.Drawing.Point(212, 82);
            this.btnUpdatePathx.Name = "btnUpdatePathx";
            this.btnUpdatePathx.Rotation = 0;
            this.btnUpdatePathx.ShowActiveImage = true;
            this.btnUpdatePathx.ShowCursorChanges = true;
            this.btnUpdatePathx.ShowImageBorders = false;
            this.btnUpdatePathx.ShowSizeMarkers = false;
            this.btnUpdatePathx.Size = new System.Drawing.Size(39, 39);
            this.btnUpdatePathx.TabIndex = 8;
            this.btnUpdatePathx.ToolTipText = "";
            this.btnUpdatePathx.WaitOnLoad = false;
            this.btnUpdatePathx.Zoom = 10;
            this.btnUpdatePathx.ZoomSpeed = 10;
            this.btnUpdatePathx.Click += new System.EventHandler(this.btnUpdatePathx_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(274, 117);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(33, 15);
            this.bunifuLabel4.TabIndex = 11;
            this.bunifuLabel4.Text = "Delete";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDeletePathx
            // 
            this.btnDeletePathx.ActiveImage = null;
            this.btnDeletePathx.AllowAnimations = true;
            this.btnDeletePathx.AllowBuffering = false;
            this.btnDeletePathx.AllowToggling = false;
            this.btnDeletePathx.AllowZooming = false;
            this.btnDeletePathx.AllowZoomingOnFocus = false;
            this.btnDeletePathx.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePathx.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeletePathx.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePathx.ErrorImage")));
            this.btnDeletePathx.FadeWhenInactive = false;
            this.btnDeletePathx.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDeletePathx.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePathx.Image")));
            this.btnDeletePathx.ImageActive = null;
            this.btnDeletePathx.ImageLocation = null;
            this.btnDeletePathx.ImageMargin = 10;
            this.btnDeletePathx.ImageSize = new System.Drawing.Size(29, 29);
            this.btnDeletePathx.ImageZoomSize = new System.Drawing.Size(39, 39);
            this.btnDeletePathx.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePathx.InitialImage")));
            this.btnDeletePathx.Location = new System.Drawing.Point(270, 82);
            this.btnDeletePathx.Name = "btnDeletePathx";
            this.btnDeletePathx.Rotation = 0;
            this.btnDeletePathx.ShowActiveImage = true;
            this.btnDeletePathx.ShowCursorChanges = true;
            this.btnDeletePathx.ShowImageBorders = false;
            this.btnDeletePathx.ShowSizeMarkers = false;
            this.btnDeletePathx.Size = new System.Drawing.Size(39, 39);
            this.btnDeletePathx.TabIndex = 10;
            this.btnDeletePathx.ToolTipText = "";
            this.btnDeletePathx.WaitOnLoad = false;
            this.btnDeletePathx.Zoom = 10;
            this.btnDeletePathx.ZoomSpeed = 10;
            this.btnDeletePathx.Click += new System.EventHandler(this.btnDeletePathx_Click);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.DimGray;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(6, 143);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Rectangle;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(330, 300);
            this.bunifuShapes1.TabIndex = 12;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // PathManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.btnDeletePathx);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.btnUpdatePathx);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnAddPathx);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pathGrid);
            this.Controls.Add(this.bunifuFormControlBox1);
            this.Controls.Add(this.bunifuShapes1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PathManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pathGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuFormDrag bunifuFormDrag1;
        private Bunifu.UI.WinForms.BunifuDataGridView pathGrid;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuFormControlBox bunifuFormControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddPathx;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuImageButton btnDeletePathx;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuImageButton btnUpdatePathx;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
    }
}