using System.Drawing;

namespace GameFramework
{
	partial class MainMenu
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainMenuButton_CloseGame = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.MainMenuButton_Settings = new System.Windows.Forms.Button();
            this.MainMenuButton_ContinueGame = new System.Windows.Forms.Button();
            this.MainMenuButton_NewGame = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MainMenuPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton_CloseGame
            // 
            this.MainMenuButton_CloseGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton_CloseGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainMenuButton_CloseGame.FlatAppearance.BorderSize = 0;
            this.MainMenuButton_CloseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton_CloseGame.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton_CloseGame.Location = new System.Drawing.Point(25, 248);
            this.MainMenuButton_CloseGame.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.MainMenuButton_CloseGame.Name = "MainMenuButton_CloseGame";
            this.MainMenuButton_CloseGame.Size = new System.Drawing.Size(294, 58);
            this.MainMenuButton_CloseGame.TabIndex = 0;
            this.MainMenuButton_CloseGame.Text = "Закрыть игру";
            this.MainMenuButton_CloseGame.UseVisualStyleBackColor = false;
            this.MainMenuButton_CloseGame.Click += new System.EventHandler(this.MainMenuButton_CloseGame_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainMenuPanel.Controls.Add(this.MainMenuButton_Settings);
            this.MainMenuPanel.Controls.Add(this.MainMenuButton_ContinueGame);
            this.MainMenuPanel.Controls.Add(this.MainMenuButton_NewGame);
            this.MainMenuPanel.Controls.Add(this.MainMenuButton_CloseGame);
            this.MainMenuPanel.Location = new System.Drawing.Point(78, 252);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(343, 358);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // MainMenuButton_Settings
            // 
            this.MainMenuButton_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainMenuButton_Settings.FlatAppearance.BorderSize = 0;
            this.MainMenuButton_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton_Settings.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton_Settings.Location = new System.Drawing.Point(25, 182);
            this.MainMenuButton_Settings.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.MainMenuButton_Settings.Name = "MainMenuButton_Settings";
            this.MainMenuButton_Settings.Size = new System.Drawing.Size(294, 58);
            this.MainMenuButton_Settings.TabIndex = 0;
            this.MainMenuButton_Settings.Text = "Настройки";
            this.MainMenuButton_Settings.UseVisualStyleBackColor = false;
            this.MainMenuButton_Settings.Click += new System.EventHandler(this.MainMenuButton_Settings_Click);
            // 
            // MainMenuButton_ContinueGame
            // 
            this.MainMenuButton_ContinueGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton_ContinueGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainMenuButton_ContinueGame.FlatAppearance.BorderSize = 0;
            this.MainMenuButton_ContinueGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton_ContinueGame.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton_ContinueGame.Location = new System.Drawing.Point(25, 116);
            this.MainMenuButton_ContinueGame.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.MainMenuButton_ContinueGame.Name = "MainMenuButton_ContinueGame";
            this.MainMenuButton_ContinueGame.Size = new System.Drawing.Size(294, 58);
            this.MainMenuButton_ContinueGame.TabIndex = 0;
            this.MainMenuButton_ContinueGame.Text = "Загрузить игру";
            this.MainMenuButton_ContinueGame.UseVisualStyleBackColor = false;
            this.MainMenuButton_ContinueGame.Click += new System.EventHandler(this.MainMenuButton_ContinueGame_Click);
            // 
            // MainMenuButton_NewGame
            // 
            this.MainMenuButton_NewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainMenuButton_NewGame.FlatAppearance.BorderSize = 0;
            this.MainMenuButton_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton_NewGame.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton_NewGame.Location = new System.Drawing.Point(25, 50);
            this.MainMenuButton_NewGame.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.MainMenuButton_NewGame.Name = "MainMenuButton_NewGame";
            this.MainMenuButton_NewGame.Size = new System.Drawing.Size(294, 58);
            this.MainMenuButton_NewGame.TabIndex = 0;
            this.MainMenuButton_NewGame.Text = "Новая игра";
            this.MainMenuButton_NewGame.UseVisualStyleBackColor = false;
            this.MainMenuButton_NewGame.Click += new System.EventHandler(this.MainMenuButton_NewGame_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SettingsPanel.ColumnCount = 3;
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SettingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.SettingsPanel.Controls.Add(this.label1, 0, 1);
            this.SettingsPanel.Controls.Add(this.label2, 0, 2);
            this.SettingsPanel.Controls.Add(this.label3, 0, 3);
            this.SettingsPanel.Controls.Add(this.label4, 0, 4);
            this.SettingsPanel.Controls.Add(this.label5, 1, 0);
            this.SettingsPanel.Controls.Add(this.comboBox1, 1, 1);
            this.SettingsPanel.Controls.Add(this.trackBar1, 1, 2);
            this.SettingsPanel.Location = new System.Drawing.Point(427, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.RowCount = 7;
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.SettingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.SettingsPanel.Size = new System.Drawing.Size(1161, 876);
            this.SettingsPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расширение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(50, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 98);
            this.label2.TabIndex = 1;
            this.label2.Text = "Звук";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(50, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 82);
            this.label3.TabIndex = 2;
            this.label3.Text = "00000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(50, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 80);
            this.label4.TabIndex = 3;
            this.label4.Text = "00000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(390, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 92);
            this.label5.TabIndex = 4;
            this.label5.Text = "Настройки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.SettingsPanel.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(768, 41);
            this.comboBox1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.SettingsPanel.SetColumnSpan(this.trackBar1, 2);
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(390, 176);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(768, 92);
            this.trackBar1.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1600, 881);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Font = new System.Drawing.Font("Constantia", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1598, 858);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagiMagica";
            this.MainMenuPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button MainMenuButton_CloseGame;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button MainMenuButton_Settings;
        private System.Windows.Forms.Button MainMenuButton_ContinueGame;
        private System.Windows.Forms.Button MainMenuButton_NewGame;
        private System.Windows.Forms.TableLayoutPanel SettingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

