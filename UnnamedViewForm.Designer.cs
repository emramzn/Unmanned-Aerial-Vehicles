namespace GoogleMapAndRotation
{
    partial class UnnamedViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnnamedViewForm));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MapViewSattBTN = new System.Windows.Forms.Button();
            this.MapViewTerrBTN = new System.Windows.Forms.Button();
            this.MapViewGoogleBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NumberPnt_LBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TargetPnt_LBL = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 89);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1805, 546);
            this.gMapControl1.TabIndex = 4;
            this.gMapControl1.Zoom = 0D;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(709, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 62);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(629, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 68);
            this.button1.TabIndex = 4;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(802, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 61);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1417, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 43);
            this.listBox1.TabIndex = 8;
            this.listBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1829, 10);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.MapViewGoogleBTN);
            this.panel2.Controls.Add(this.MapViewTerrBTN);
            this.panel2.Controls.Add(this.MapViewSattBTN);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1829, 83);
            this.panel2.TabIndex = 10;
            // 
            // MapViewSattBTN
            // 
            this.MapViewSattBTN.BackColor = System.Drawing.Color.Transparent;
            this.MapViewSattBTN.FlatAppearance.BorderSize = 0;
            this.MapViewSattBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapViewSattBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MapViewSattBTN.Image = ((System.Drawing.Image)(resources.GetObject("MapViewSattBTN.Image")));
            this.MapViewSattBTN.Location = new System.Drawing.Point(214, 9);
            this.MapViewSattBTN.Name = "MapViewSattBTN";
            this.MapViewSattBTN.Size = new System.Drawing.Size(70, 62);
            this.MapViewSattBTN.TabIndex = 9;
            this.MapViewSattBTN.UseVisualStyleBackColor = false;
            this.MapViewSattBTN.Click += new System.EventHandler(this.MapViewSattBTN_Click);
            // 
            // MapViewTerrBTN
            // 
            this.MapViewTerrBTN.BackColor = System.Drawing.Color.Transparent;
            this.MapViewTerrBTN.FlatAppearance.BorderSize = 0;
            this.MapViewTerrBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapViewTerrBTN.Image = ((System.Drawing.Image)(resources.GetObject("MapViewTerrBTN.Image")));
            this.MapViewTerrBTN.Location = new System.Drawing.Point(290, 10);
            this.MapViewTerrBTN.Name = "MapViewTerrBTN";
            this.MapViewTerrBTN.Size = new System.Drawing.Size(64, 61);
            this.MapViewTerrBTN.TabIndex = 10;
            this.MapViewTerrBTN.UseVisualStyleBackColor = false;
            this.MapViewTerrBTN.Click += new System.EventHandler(this.MapViewTerrBTN_Click);
            // 
            // MapViewGoogleBTN
            // 
            this.MapViewGoogleBTN.BackColor = System.Drawing.Color.Transparent;
            this.MapViewGoogleBTN.FlatAppearance.BorderSize = 0;
            this.MapViewGoogleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapViewGoogleBTN.Image = ((System.Drawing.Image)(resources.GetObject("MapViewGoogleBTN.Image")));
            this.MapViewGoogleBTN.Location = new System.Drawing.Point(360, 11);
            this.MapViewGoogleBTN.Name = "MapViewGoogleBTN";
            this.MapViewGoogleBTN.Size = new System.Drawing.Size(72, 60);
            this.MapViewGoogleBTN.TabIndex = 11;
            this.MapViewGoogleBTN.UseVisualStyleBackColor = false;
            this.MapViewGoogleBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1714, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // NumberPnt_LBL
            // 
            this.NumberPnt_LBL.AutoSize = true;
            this.NumberPnt_LBL.BackColor = System.Drawing.Color.Transparent;
            this.NumberPnt_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberPnt_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberPnt_LBL.Location = new System.Drawing.Point(62, 17);
            this.NumberPnt_LBL.Name = "NumberPnt_LBL";
            this.NumberPnt_LBL.Size = new System.Drawing.Size(106, 37);
            this.NumberPnt_LBL.TabIndex = 13;
            this.NumberPnt_LBL.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.TargetPnt_LBL);
            this.panel3.Controls.Add(this.NumberPnt_LBL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1511, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 83);
            this.panel3.TabIndex = 14;
            // 
            // TargetPnt_LBL
            // 
            this.TargetPnt_LBL.AutoSize = true;
            this.TargetPnt_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TargetPnt_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TargetPnt_LBL.Location = new System.Drawing.Point(49, 55);
            this.TargetPnt_LBL.Name = "TargetPnt_LBL";
            this.TargetPnt_LBL.Size = new System.Drawing.Size(0, 16);
            this.TargetPnt_LBL.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(976, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 54);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1057, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 54);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1138, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "** Yapılan hesaplamalar doğrultusunda İHA \'lar için oluşturulan rota bilgileri \r\n" +
    "    (Minimum irtifa, dönüş açısı, İHA konumu) bulut sistemine yükleyebilir \r\n   " +
    "  ya da dışa aktarabilirsiniz.";
            // 
            // UnnamedViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1829, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UnnamedViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Route For Unmanned Air Vehicles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnnamedViewForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        public GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MapViewGoogleBTN;
        private System.Windows.Forms.Button MapViewTerrBTN;
        private System.Windows.Forms.Button MapViewSattBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NumberPnt_LBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TargetPnt_LBL;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}