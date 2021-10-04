namespace ChannelViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rb_Red = new System.Windows.Forms.RadioButton();
            this.rb_Green = new System.Windows.Forms.RadioButton();
            this.rb_Blue = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pb_MainImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_Zoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inputPanel.AutoSize = true;
            this.inputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputPanel.BackColor = System.Drawing.Color.DimGray;
            this.inputPanel.Controls.Add(this.rb_Red);
            this.inputPanel.Controls.Add(this.rb_Green);
            this.inputPanel.Controls.Add(this.rb_Blue);
            this.inputPanel.Controls.Add(this.rb_All);
            this.inputPanel.Controls.Add(this.flowLayoutPanel1);
            this.inputPanel.Location = new System.Drawing.Point(50, 433);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(367, 107);
            this.inputPanel.TabIndex = 2;
            // 
            // rb_Red
            // 
            this.rb_Red.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Red.AutoSize = true;
            this.rb_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rb_Red.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Red.Checked = true;
            this.rb_Red.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_Red.FlatAppearance.BorderSize = 0;
            this.rb_Red.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rb_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Red.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Red.ForeColor = System.Drawing.Color.White;
            this.rb_Red.Location = new System.Drawing.Point(0, 0);
            this.rb_Red.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Red.Name = "rb_Red";
            this.rb_Red.Size = new System.Drawing.Size(52, 107);
            this.rb_Red.TabIndex = 0;
            this.rb_Red.TabStop = true;
            this.rb_Red.Text = "R";
            this.rb_Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rb_Red, "Shortcut: 1 or R");
            this.rb_Red.UseVisualStyleBackColor = true;
            // 
            // rb_Green
            // 
            this.rb_Green.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Green.AutoSize = true;
            this.rb_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rb_Green.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Green.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_Green.FlatAppearance.BorderSize = 0;
            this.rb_Green.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rb_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Green.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Green.ForeColor = System.Drawing.Color.White;
            this.rb_Green.Location = new System.Drawing.Point(52, 0);
            this.rb_Green.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Green.Name = "rb_Green";
            this.rb_Green.Size = new System.Drawing.Size(56, 107);
            this.rb_Green.TabIndex = 1;
            this.rb_Green.Text = "G";
            this.rb_Green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rb_Green, "Shortcut: 2 or G");
            this.rb_Green.UseVisualStyleBackColor = true;
            // 
            // rb_Blue
            // 
            this.rb_Blue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Blue.AutoSize = true;
            this.rb_Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rb_Blue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Blue.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_Blue.FlatAppearance.BorderSize = 0;
            this.rb_Blue.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.rb_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_Blue.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Blue.ForeColor = System.Drawing.Color.White;
            this.rb_Blue.Location = new System.Drawing.Point(108, 0);
            this.rb_Blue.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Blue.Name = "rb_Blue";
            this.rb_Blue.Size = new System.Drawing.Size(52, 107);
            this.rb_Blue.TabIndex = 2;
            this.rb_Blue.Text = "B";
            this.rb_Blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rb_Blue, "Shortcut: 3 or B");
            this.rb_Blue.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_All.AutoSize = true;
            this.rb_All.BackColor = System.Drawing.Color.Black;
            this.rb_All.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_All.Dock = System.Windows.Forms.DockStyle.Left;
            this.rb_All.FlatAppearance.BorderSize = 0;
            this.rb_All.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_All.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_All.ForeColor = System.Drawing.Color.White;
            this.rb_All.Location = new System.Drawing.Point(160, 0);
            this.rb_All.Margin = new System.Windows.Forms.Padding(0);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(95, 107);
            this.rb_All.TabIndex = 3;
            this.rb_All.Text = "ALL";
            this.rb_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rb_All, "Shortcut: 4 or A");
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pb_MainImage
            // 
            this.pb_MainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_MainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_MainImage.ImageLocation = "";
            this.pb_MainImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_MainImage.InitialImage")));
            this.pb_MainImage.Location = new System.Drawing.Point(0, 0);
            this.pb_MainImage.Name = "pb_MainImage";
            this.pb_MainImage.Size = new System.Drawing.Size(578, 544);
            this.pb_MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MainImage.TabIndex = 0;
            this.pb_MainImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_MainImage, "Press Space to toggle position updates");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.tb_Zoom);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(258, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 101);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tb_Zoom
            // 
            this.tb_Zoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_Zoom.LargeChange = 1;
            this.tb_Zoom.Location = new System.Drawing.Point(3, 3);
            this.tb_Zoom.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tb_Zoom.Maximum = 3;
            this.tb_Zoom.Minimum = 1;
            this.tb_Zoom.Name = "tb_Zoom";
            this.tb_Zoom.Size = new System.Drawing.Size(100, 69);
            this.tb_Zoom.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb_Zoom, "Zoom out to display larger areas of the screen\r\nShortcut: Arrow keys");
            this.tb_Zoom.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.pb_MainImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ChannelViewer";
            this.TopMost = true;
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Zoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_MainImage;
        private System.Windows.Forms.FlowLayoutPanel inputPanel;
        private System.Windows.Forms.RadioButton rb_Red;
        private System.Windows.Forms.RadioButton rb_Green;
        private System.Windows.Forms.RadioButton rb_Blue;
        private System.Windows.Forms.RadioButton rb_All;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar tb_Zoom;
        private System.Windows.Forms.Label label1;
    }
}

