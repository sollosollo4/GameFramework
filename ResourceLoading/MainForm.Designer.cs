namespace ResourceLoading
{
    partial class MainForm
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
            this.AddItem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DamageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FireMTextBox = new System.Windows.Forms.TextBox();
            this.AgilityTextBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ForceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IntellectTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.IceMTextBox = new System.Windows.Forms.TextBox();
            this.NatureMTextBox = new System.Windows.Forms.TextBox();
            this.LigthMTextBox = new System.Windows.Forms.TextBox();
            this.DarkMTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ScriptsNamesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NeedLevelTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиСпособностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиУмениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(8, 437);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(154, 27);
            this.AddItem.TabIndex = 0;
            this.AddItem.Text = "Добавить предмет";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NeedLevelTextBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.ItemNameTextBox);
            this.tabPage1.Controls.Add(this.AddItem);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Характеристики предмета";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(6, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 320);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.59036F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.40964F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DamageTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FireMTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgilityTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ForceTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.IntellectTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.IceMTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NatureMTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.LigthMTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.DarkMTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ScriptsNamesTextBox, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 320);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип урона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Урон(физ./маг.)";
            // 
            // DamageTextBox
            // 
            this.DamageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DamageTextBox.Location = new System.Drawing.Point(160, 27);
            this.DamageTextBox.Name = "DamageTextBox";
            this.DamageTextBox.Size = new System.Drawing.Size(168, 23);
            this.DamageTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ловкость";
            // 
            // FireMTextBox
            // 
            this.FireMTextBox.Location = new System.Drawing.Point(473, 3);
            this.FireMTextBox.Name = "FireMTextBox";
            this.FireMTextBox.Size = new System.Drawing.Size(180, 23);
            this.FireMTextBox.TabIndex = 1;
            // 
            // AgilityTextBox
            // 
            this.AgilityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgilityTextBox.Location = new System.Drawing.Point(160, 51);
            this.AgilityTextBox.Name = "AgilityTextBox";
            this.AgilityTextBox.Size = new System.Drawing.Size(168, 23);
            this.AgilityTextBox.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Physical",
            "Magical"});
            this.comboBox2.Location = new System.Drawing.Point(160, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Сила";
            // 
            // ForceTextBox
            // 
            this.ForceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForceTextBox.Location = new System.Drawing.Point(160, 85);
            this.ForceTextBox.Name = "ForceTextBox";
            this.ForceTextBox.Size = new System.Drawing.Size(168, 23);
            this.ForceTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Интеллект";
            // 
            // IntellectTextBox
            // 
            this.IntellectTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntellectTextBox.Location = new System.Drawing.Point(160, 116);
            this.IntellectTextBox.Name = "IntellectTextBox";
            this.IntellectTextBox.Size = new System.Drawing.Size(168, 23);
            this.IntellectTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Огонь(надбавка)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Вода(надбавка)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Природа(надбавка)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Свет(надбавка)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Тьма(надбавка)";
            // 
            // IceMTextBox
            // 
            this.IceMTextBox.Location = new System.Drawing.Point(473, 27);
            this.IceMTextBox.Name = "IceMTextBox";
            this.IceMTextBox.Size = new System.Drawing.Size(180, 23);
            this.IceMTextBox.TabIndex = 1;
            // 
            // NatureMTextBox
            // 
            this.NatureMTextBox.Location = new System.Drawing.Point(473, 51);
            this.NatureMTextBox.Name = "NatureMTextBox";
            this.NatureMTextBox.Size = new System.Drawing.Size(180, 23);
            this.NatureMTextBox.TabIndex = 1;
            // 
            // LigthMTextBox
            // 
            this.LigthMTextBox.Location = new System.Drawing.Point(473, 85);
            this.LigthMTextBox.Name = "LigthMTextBox";
            this.LigthMTextBox.Size = new System.Drawing.Size(180, 23);
            this.LigthMTextBox.TabIndex = 1;
            // 
            // DarkMTextBox
            // 
            this.DarkMTextBox.Location = new System.Drawing.Point(473, 116);
            this.DarkMTextBox.Name = "DarkMTextBox";
            this.DarkMTextBox.Size = new System.Drawing.Size(180, 23);
            this.DarkMTextBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Имя скрипта";
            // 
            // ScriptsNamesTextBox
            // 
            this.ScriptsNamesTextBox.Location = new System.Drawing.Point(160, 179);
            this.ScriptsNamesTextBox.Name = "ScriptsNamesTextBox";
            this.ScriptsNamesTextBox.Size = new System.Drawing.Size(168, 23);
            this.ScriptsNamesTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Редкость предмета";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Необходимый уровень";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя предмета";
            // 
            // NeedLevelTextBox
            // 
            this.NeedLevelTextBox.Location = new System.Drawing.Point(176, 27);
            this.NeedLevelTextBox.Name = "NeedLevelTextBox";
            this.NeedLevelTextBox.Size = new System.Drawing.Size(156, 23);
            this.NeedLevelTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Common",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary",
            "Unreal"});
            this.comboBox1.Location = new System.Drawing.Point(339, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(8, 27);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(156, 23);
            this.ItemNameTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spells";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(925, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skills";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(925, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "OtherResource";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиПредметToolStripMenuItem,
            this.найтиСпособностьToolStripMenuItem,
            this.найтиУмениеToolStripMenuItem});
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.общееToolStripMenuItem.Text = "Общее";
            // 
            // найтиПредметToolStripMenuItem
            // 
            this.найтиПредметToolStripMenuItem.Name = "найтиПредметToolStripMenuItem";
            this.найтиПредметToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.найтиПредметToolStripMenuItem.Text = "Найти предмет";
            // 
            // найтиСпособностьToolStripMenuItem
            // 
            this.найтиСпособностьToolStripMenuItem.Name = "найтиСпособностьToolStripMenuItem";
            this.найтиСпособностьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.найтиСпособностьToolStripMenuItem.Text = "Найти способность";
            // 
            // найтиУмениеToolStripMenuItem
            // 
            this.найтиУмениеToolStripMenuItem.Name = "найтиУмениеToolStripMenuItem";
            this.найтиУмениеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.найтиУмениеToolStripMenuItem.Text = "Найти умение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DamageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FireMTextBox;
        private System.Windows.Forms.TextBox AgilityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ForceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IntellectTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IceMTextBox;
        private System.Windows.Forms.TextBox NatureMTextBox;
        private System.Windows.Forms.TextBox LigthMTextBox;
        private System.Windows.Forms.TextBox DarkMTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ScriptsNamesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NeedLevelTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиСпособностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиУмениеToolStripMenuItem;
    }
}

