namespace Test_by.Timashov
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.goSetting = new System.Windows.Forms.Button();
            this.startTest = new System.Windows.Forms.Button();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.backToMenu = new System.Windows.Forms.Button();
            this.groupTime = new System.Windows.Forms.GroupBox();
            this.min30 = new System.Windows.Forms.RadioButton();
            this.min20 = new System.Windows.Forms.RadioButton();
            this.min15 = new System.Windows.Forms.RadioButton();
            this.min10 = new System.Windows.Forms.RadioButton();
            this.timerCB = new System.Windows.Forms.CheckBox();
            this.helpCB = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.groupTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.goSetting);
            this.panel1.Controls.Add(this.startTest);
            this.panel1.Location = new System.Drawing.Point(274, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 255);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(16, 176);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(209, 64);
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Text = "Выход ➔";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // goSetting
            // 
            this.goSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.goSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.goSetting.FlatAppearance.BorderSize = 0;
            this.goSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goSetting.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goSetting.Location = new System.Drawing.Point(16, 96);
            this.goSetting.Name = "goSetting";
            this.goSetting.Size = new System.Drawing.Size(209, 64);
            this.goSetting.TabIndex = 0;
            this.goSetting.TabStop = false;
            this.goSetting.Text = "Настройки ➔";
            this.goSetting.UseVisualStyleBackColor = false;
            this.goSetting.Click += new System.EventHandler(this.goSetting_Click);
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.startTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startTest.FlatAppearance.BorderSize = 0;
            this.startTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTest.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTest.Location = new System.Drawing.Point(16, 15);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(209, 64);
            this.startTest.TabIndex = 0;
            this.startTest.TabStop = false;
            this.startTest.Text = "Начать тестирование ➔";
            this.startTest.UseVisualStyleBackColor = false;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.Controls.Add(this.backToMenu);
            this.panelSettings.Controls.Add(this.groupTime);
            this.panelSettings.Controls.Add(this.timerCB);
            this.panelSettings.Controls.Add(this.helpCB);
            this.panelSettings.Location = new System.Drawing.Point(0, 27);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(529, 280);
            this.panelSettings.TabIndex = 3;
            this.panelSettings.Visible = false;
            // 
            // backToMenu
            // 
            this.backToMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.backToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backToMenu.FlatAppearance.BorderSize = 0;
            this.backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenu.Location = new System.Drawing.Point(12, 203);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(236, 64);
            this.backToMenu.TabIndex = 2;
            this.backToMenu.TabStop = false;
            this.backToMenu.Text = "Назад в меню ➔";
            this.backToMenu.UseVisualStyleBackColor = false;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // groupTime
            // 
            this.groupTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupTime.Controls.Add(this.min30);
            this.groupTime.Controls.Add(this.min20);
            this.groupTime.Controls.Add(this.min15);
            this.groupTime.Controls.Add(this.min10);
            this.groupTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTime.Location = new System.Drawing.Point(12, 66);
            this.groupTime.Name = "groupTime";
            this.groupTime.Size = new System.Drawing.Size(236, 119);
            this.groupTime.TabIndex = 1;
            this.groupTime.TabStop = false;
            this.groupTime.Text = "Тест закончится авто. через:";
            // 
            // min30
            // 
            this.min30.AutoSize = true;
            this.min30.Enabled = false;
            this.min30.Location = new System.Drawing.Point(7, 91);
            this.min30.Name = "min30";
            this.min30.Size = new System.Drawing.Size(77, 19);
            this.min30.TabIndex = 0;
            this.min30.Text = "30 минут";
            this.min30.UseVisualStyleBackColor = true;
            // 
            // min20
            // 
            this.min20.AutoSize = true;
            this.min20.Enabled = false;
            this.min20.Location = new System.Drawing.Point(7, 68);
            this.min20.Name = "min20";
            this.min20.Size = new System.Drawing.Size(77, 19);
            this.min20.TabIndex = 0;
            this.min20.Text = "20 минут";
            this.min20.UseVisualStyleBackColor = true;
            // 
            // min15
            // 
            this.min15.AutoSize = true;
            this.min15.Enabled = false;
            this.min15.Location = new System.Drawing.Point(7, 43);
            this.min15.Name = "min15";
            this.min15.Size = new System.Drawing.Size(77, 19);
            this.min15.TabIndex = 0;
            this.min15.Text = "15 минут";
            this.min15.UseVisualStyleBackColor = true;
            // 
            // min10
            // 
            this.min10.AutoSize = true;
            this.min10.Enabled = false;
            this.min10.Location = new System.Drawing.Point(7, 20);
            this.min10.Name = "min10";
            this.min10.Size = new System.Drawing.Size(77, 19);
            this.min10.TabIndex = 0;
            this.min10.Text = "10 минут";
            this.min10.UseVisualStyleBackColor = true;
            // 
            // timerCB
            // 
            this.timerCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timerCB.AutoSize = true;
            this.timerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerCB.Location = new System.Drawing.Point(12, 38);
            this.timerCB.Name = "timerCB";
            this.timerCB.Size = new System.Drawing.Size(281, 22);
            this.timerCB.TabIndex = 0;
            this.timerCB.Text = "Режим прохождения теста на время";
            this.timerCB.UseVisualStyleBackColor = true;
            this.timerCB.CheckedChanged += new System.EventHandler(this.timerCB_CheckedChanged);
            // 
            // helpCB
            // 
            this.helpCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpCB.AutoSize = true;
            this.helpCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpCB.Location = new System.Drawing.Point(12, 10);
            this.helpCB.Name = "helpCB";
            this.helpCB.Size = new System.Drawing.Size(154, 22);
            this.helpCB.TabIndex = 0;
            this.helpCB.Text = "Режим подсказок";
            this.helpCB.UseVisualStyleBackColor = true;
            this.helpCB.CheckedChanged += new System.EventHandler(this.helpCB_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Test_by.Timashov.Properties.Resources.copybook;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест по циклам";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.groupTime.ResumeLayout(false);
            this.groupTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button goSetting;
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.GroupBox groupTime;
        private System.Windows.Forms.RadioButton min30;
        private System.Windows.Forms.RadioButton min20;
        private System.Windows.Forms.RadioButton min15;
        private System.Windows.Forms.RadioButton min10;
        private System.Windows.Forms.CheckBox timerCB;
        private System.Windows.Forms.CheckBox helpCB;
        private System.Windows.Forms.Button backToMenu;
    }
}

