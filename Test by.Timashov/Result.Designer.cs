
namespace Test_by.Timashov
{
    partial class Result
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
            this.label = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.rateTxt = new System.Windows.Forms.Label();
            this.backToMenu = new System.Windows.Forms.Button();
            this.timeTxt = new System.Windows.Forms.Label();
            this.advice = new System.Windows.Forms.Label();
            this.sym = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(32, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(396, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Поздравляем, с окончанием теста!";
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTxt.Location = new System.Drawing.Point(12, 93);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(257, 24);
            this.scoreTxt.TabIndex = 3;
            this.scoreTxt.Text = "Вы получили 0 баллов из 20";
            // 
            // rateTxt
            // 
            this.rateTxt.AutoSize = true;
            this.rateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateTxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.rateTxt.Location = new System.Drawing.Point(12, 58);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(335, 24);
            this.rateTxt.TabIndex = 3;
            this.rateTxt.Text = "Оценка 4 (не хватило 5 баллов до 5)";
            // 
            // backToMenu
            // 
            this.backToMenu.Location = new System.Drawing.Point(13, 401);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(483, 36);
            this.backToMenu.TabIndex = 4;
            this.backToMenu.Text = "Назад в меню";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTxt.Location = new System.Drawing.Point(12, 129);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(291, 24);
            this.timeTxt.TabIndex = 3;
            this.timeTxt.Text = "Вы потратили 12 минут на тест";
            // 
            // advice
            // 
            this.advice.AutoSize = true;
            this.advice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advice.Location = new System.Drawing.Point(12, 242);
            this.advice.Name = "advice";
            this.advice.Size = new System.Drawing.Size(231, 40);
            this.advice.TabIndex = 3;
            this.advice.Text = "Перед прохождением теста, \r\nизучи материал.";
            // 
            // sym
            // 
            this.sym.AutoSize = true;
            this.sym.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sym.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.sym.Location = new System.Drawing.Point(326, 204);
            this.sym.Name = "sym";
            this.sym.Size = new System.Drawing.Size(132, 108);
            this.sym.TabIndex = 5;
            this.sym.Text = "🔥";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.sym);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.advice);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Result";
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Label rateTxt;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Label timeTxt;
        private System.Windows.Forms.Label advice;
        private System.Windows.Forms.Label sym;
    }
}