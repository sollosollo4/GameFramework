namespace GameFramework.Forms
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.MainInterface = new System.Windows.Forms.TableLayoutPanel();
            this.HeroIcon = new System.Windows.Forms.PictureBox();
            this.BackPackIcon = new System.Windows.Forms.PictureBox();
            this.Achivments_Icon = new System.Windows.Forms.PictureBox();
            this.Skills_Icon = new System.Windows.Forms.PictureBox();
            this.Map_Icon = new System.Windows.Forms.PictureBox();
            this.Guild_Icon = new System.Windows.Forms.PictureBox();
            this.Talking_Icon = new System.Windows.Forms.PictureBox();
            this.Settings_Icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeroIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPackIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Achivments_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skills_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guild_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Talking_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainInterface
            // 
            this.MainInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainInterface.ColumnCount = 8;
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49957F));
            this.MainInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50301F));
            this.MainInterface.Controls.Add(this.HeroIcon, 0, 0);
            this.MainInterface.Controls.Add(this.BackPackIcon, 1, 0);
            this.MainInterface.Controls.Add(this.Achivments_Icon, 2, 0);
            this.MainInterface.Controls.Add(this.Skills_Icon, 3, 0);
            this.MainInterface.Controls.Add(this.Map_Icon, 4, 0);
            this.MainInterface.Controls.Add(this.Guild_Icon, 5, 0);
            this.MainInterface.Controls.Add(this.Talking_Icon, 6, 0);
            this.MainInterface.Controls.Add(this.Settings_Icon, 7, 0);
            this.MainInterface.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.MainInterface.Location = new System.Drawing.Point(12, 805);
            this.MainInterface.Margin = new System.Windows.Forms.Padding(0);
            this.MainInterface.Name = "MainInterface";
            this.MainInterface.Padding = new System.Windows.Forms.Padding(5);
            this.MainInterface.RowCount = 1;
            this.MainInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainInterface.Size = new System.Drawing.Size(678, 83);
            this.MainInterface.TabIndex = 0;
            // 
            // HeroIcon
            // 
            this.HeroIcon.BackColor = System.Drawing.Color.Transparent;
            this.HeroIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroIcon.Image = ((System.Drawing.Image)(resources.GetObject("HeroIcon.Image")));
            this.HeroIcon.Location = new System.Drawing.Point(15, 5);
            this.HeroIcon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HeroIcon.Name = "HeroIcon";
            this.HeroIcon.Size = new System.Drawing.Size(73, 73);
            this.HeroIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeroIcon.TabIndex = 0;
            this.HeroIcon.TabStop = false;
            this.HeroIcon.Click += new System.EventHandler(this.HeroIcon_Click);
            // 
            // BackPackIcon
            // 
            this.BackPackIcon.BackColor = System.Drawing.Color.Transparent;
            this.BackPackIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPackIcon.Image = ((System.Drawing.Image)(resources.GetObject("BackPackIcon.Image")));
            this.BackPackIcon.Location = new System.Drawing.Point(98, 5);
            this.BackPackIcon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BackPackIcon.Name = "BackPackIcon";
            this.BackPackIcon.Size = new System.Drawing.Size(73, 73);
            this.BackPackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackPackIcon.TabIndex = 0;
            this.BackPackIcon.TabStop = false;
            this.BackPackIcon.Click += new System.EventHandler(this.BackPackIcon_Click);
            // 
            // Achivments_Icon
            // 
            this.Achivments_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Achivments_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Achivments_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Achivments_Icon.Image")));
            this.Achivments_Icon.Location = new System.Drawing.Point(181, 5);
            this.Achivments_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Achivments_Icon.Name = "Achivments_Icon";
            this.Achivments_Icon.Size = new System.Drawing.Size(73, 73);
            this.Achivments_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Achivments_Icon.TabIndex = 0;
            this.Achivments_Icon.TabStop = false;
            this.Achivments_Icon.Click += new System.EventHandler(this.Achivments_Icon_Click);
            // 
            // Skills_Icon
            // 
            this.Skills_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Skills_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skills_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Skills_Icon.Image")));
            this.Skills_Icon.Location = new System.Drawing.Point(264, 5);
            this.Skills_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Skills_Icon.Name = "Skills_Icon";
            this.Skills_Icon.Size = new System.Drawing.Size(73, 73);
            this.Skills_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skills_Icon.TabIndex = 0;
            this.Skills_Icon.TabStop = false;
            this.Skills_Icon.Click += new System.EventHandler(this.Skills_Icon_Click);
            // 
            // Map_Icon
            // 
            this.Map_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Map_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Map_Icon.Image")));
            this.Map_Icon.Location = new System.Drawing.Point(347, 5);
            this.Map_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Map_Icon.Name = "Map_Icon";
            this.Map_Icon.Size = new System.Drawing.Size(73, 73);
            this.Map_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map_Icon.TabIndex = 0;
            this.Map_Icon.TabStop = false;
            this.Map_Icon.Click += new System.EventHandler(this.Map_Icon_Click);
            // 
            // Guild_Icon
            // 
            this.Guild_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Guild_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Guild_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Guild_Icon.Image")));
            this.Guild_Icon.Location = new System.Drawing.Point(430, 5);
            this.Guild_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Guild_Icon.Name = "Guild_Icon";
            this.Guild_Icon.Size = new System.Drawing.Size(73, 73);
            this.Guild_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guild_Icon.TabIndex = 0;
            this.Guild_Icon.TabStop = false;
            this.Guild_Icon.Click += new System.EventHandler(this.Guild_Icon_Click);
            // 
            // Talking_Icon
            // 
            this.Talking_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Talking_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Talking_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Talking_Icon.Image")));
            this.Talking_Icon.Location = new System.Drawing.Point(513, 5);
            this.Talking_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Talking_Icon.Name = "Talking_Icon";
            this.Talking_Icon.Size = new System.Drawing.Size(73, 73);
            this.Talking_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Talking_Icon.TabIndex = 0;
            this.Talking_Icon.TabStop = false;
            this.Talking_Icon.Click += new System.EventHandler(this.Talking_Icon_Click);
            // 
            // Settings_Icon
            // 
            this.Settings_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Icon.Image")));
            this.Settings_Icon.Location = new System.Drawing.Point(596, 5);
            this.Settings_Icon.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Settings_Icon.Name = "Settings_Icon";
            this.Settings_Icon.Size = new System.Drawing.Size(77, 73);
            this.Settings_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings_Icon.TabIndex = 0;
            this.Settings_Icon.TabStop = false;
            this.Settings_Icon.Click += new System.EventHandler(this.Settings_Icon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1598, 858);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.MainInterface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeroIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPackIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Achivments_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skills_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guild_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Talking_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Icon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainInterface;
        private System.Windows.Forms.PictureBox HeroIcon;
        private System.Windows.Forms.PictureBox BackPackIcon;
        private System.Windows.Forms.PictureBox Achivments_Icon;
        private System.Windows.Forms.PictureBox Skills_Icon;
        private System.Windows.Forms.PictureBox Map_Icon;
        private System.Windows.Forms.PictureBox Guild_Icon;
        private System.Windows.Forms.PictureBox Talking_Icon;
        private System.Windows.Forms.PictureBox Settings_Icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}