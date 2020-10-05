namespace GoogleMapAndRotation
{
    partial class Destinations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Destinations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetListBox = new System.Windows.Forms.ListBox();
            this.insertTarget = new System.Windows.Forms.Button();
            this.TargetLot = new System.Windows.Forms.TextBox();
            this.TargetLat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TangentListBox = new System.Windows.Forms.ListBox();
            this.insertTanget = new System.Windows.Forms.Button();
            this.TangentLat = new System.Windows.Forms.TextBox();
            this.TangentLot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TargetListBox);
            this.groupBox1.Controls.Add(this.insertTarget);
            this.groupBox1.Controls.Add(this.TargetLot);
            this.groupBox1.Controls.Add(this.TargetLat);
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARGETS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latitude";
            // 
            // TargetListBox
            // 
            this.TargetListBox.ColumnWidth = 25;
            this.TargetListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TargetListBox.FormattingEnabled = true;
            this.TargetListBox.ItemHeight = 18;
            this.TargetListBox.Location = new System.Drawing.Point(6, 111);
            this.TargetListBox.Name = "TargetListBox";
            this.TargetListBox.Size = new System.Drawing.Size(379, 256);
            this.TargetListBox.TabIndex = 2;
            // 
            // insertTarget
            // 
            this.insertTarget.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertTarget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.insertTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertTarget.ForeColor = System.Drawing.Color.White;
            this.insertTarget.Image = ((System.Drawing.Image)(resources.GetObject("insertTarget.Image")));
            this.insertTarget.Location = new System.Drawing.Point(325, 61);
            this.insertTarget.Name = "insertTarget";
            this.insertTarget.Size = new System.Drawing.Size(60, 26);
            this.insertTarget.TabIndex = 1;
            this.insertTarget.UseVisualStyleBackColor = true;
            this.insertTarget.Click += new System.EventHandler(this.İnsertTarget_Click);
            // 
            // TargetLot
            // 
            this.TargetLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TargetLot.Location = new System.Drawing.Point(170, 61);
            this.TargetLot.Name = "TargetLot";
            this.TargetLot.Size = new System.Drawing.Size(149, 26);
            this.TargetLot.TabIndex = 0;
            // 
            // TargetLat
            // 
            this.TargetLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TargetLat.Location = new System.Drawing.Point(6, 61);
            this.TargetLat.Name = "TargetLat";
            this.TargetLat.Size = new System.Drawing.Size(149, 26);
            this.TargetLat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TangentListBox);
            this.groupBox2.Controls.Add(this.insertTanget);
            this.groupBox2.Controls.Add(this.TangentLat);
            this.groupBox2.Controls.Add(this.TangentLot);
            this.groupBox2.Location = new System.Drawing.Point(430, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 392);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TANGENTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(177, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitude";
            // 
            // TangentListBox
            // 
            this.TangentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TangentListBox.FormattingEnabled = true;
            this.TangentListBox.ItemHeight = 18;
            this.TangentListBox.Location = new System.Drawing.Point(16, 111);
            this.TangentListBox.Name = "TangentListBox";
            this.TangentListBox.Size = new System.Drawing.Size(379, 256);
            this.TangentListBox.TabIndex = 2;
            // 
            // insertTanget
            // 
            this.insertTanget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertTanget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
            this.insertTanget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertTanget.Image = ((System.Drawing.Image)(resources.GetObject("insertTanget.Image")));
            this.insertTanget.Location = new System.Drawing.Point(335, 61);
            this.insertTanget.Name = "insertTanget";
            this.insertTanget.Size = new System.Drawing.Size(60, 26);
            this.insertTanget.TabIndex = 1;
            this.insertTanget.UseVisualStyleBackColor = true;
            this.insertTanget.Click += new System.EventHandler(this.İnsertTanget_Click);
            // 
            // TangentLat
            // 
            this.TangentLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TangentLat.Location = new System.Drawing.Point(16, 61);
            this.TangentLat.Name = "TangentLat";
            this.TangentLat.Size = new System.Drawing.Size(149, 26);
            this.TangentLat.TabIndex = 0;
            // 
            // TangentLot
            // 
            this.TangentLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TangentLot.Location = new System.Drawing.Point(180, 61);
            this.TangentLot.Name = "TangentLot";
            this.TangentLot.Size = new System.Drawing.Size(149, 26);
            this.TangentLot.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rota Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Destinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(866, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Destinations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destinations";
            this.Load += new System.EventHandler(this.Destinations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TargetLot;
        private System.Windows.Forms.TextBox TargetLat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TargetListBox;
        private System.Windows.Forms.Button insertTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox TangentListBox;
        private System.Windows.Forms.Button insertTanget;
        private System.Windows.Forms.TextBox TangentLat;
        private System.Windows.Forms.TextBox TangentLot;
        private System.Windows.Forms.Button button1;
    }
}