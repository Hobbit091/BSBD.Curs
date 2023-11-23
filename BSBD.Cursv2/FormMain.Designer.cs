namespace BSBD.Cursv2
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonИгрок = new System.Windows.Forms.Button();
            this.buttonBet = new System.Windows.Forms.Button();
            this.buttonGame = new System.Windows.Forms.Button();
            this.buttonCroupier = new System.Windows.Forms.Button();
            this.buttonGameList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // ButtonИгрок
            // 
            this.ButtonИгрок.Location = new System.Drawing.Point(25, 70);
            this.ButtonИгрок.Name = "ButtonИгрок";
            this.ButtonИгрок.Size = new System.Drawing.Size(75, 23);
            this.ButtonИгрок.TabIndex = 1;
            this.ButtonИгрок.Text = "Игрок";
            this.ButtonИгрок.UseVisualStyleBackColor = true;
            this.ButtonИгрок.Click += new System.EventHandler(this.ButtonИгрок_Click);
            // 
            // buttonBet
            // 
            this.buttonBet.Location = new System.Drawing.Point(25, 125);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(75, 23);
            this.buttonBet.TabIndex = 2;
            this.buttonBet.Text = "Ставка";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // buttonGame
            // 
            this.buttonGame.Location = new System.Drawing.Point(25, 242);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(75, 23);
            this.buttonGame.TabIndex = 3;
            this.buttonGame.Text = "Игра";
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // buttonCroupier
            // 
            this.buttonCroupier.Location = new System.Drawing.Point(25, 181);
            this.buttonCroupier.Name = "buttonCroupier";
            this.buttonCroupier.Size = new System.Drawing.Size(75, 23);
            this.buttonCroupier.TabIndex = 4;
            this.buttonCroupier.Text = "Крупье";
            this.buttonCroupier.UseVisualStyleBackColor = true;
            this.buttonCroupier.Click += new System.EventHandler(this.buttonCroupier_Click);
            // 
            // buttonGameList
            // 
            this.buttonGameList.Location = new System.Drawing.Point(25, 293);
            this.buttonGameList.Name = "buttonGameList";
            this.buttonGameList.Size = new System.Drawing.Size(75, 23);
            this.buttonGameList.TabIndex = 5;
            this.buttonGameList.Text = "Запись игры";
            this.buttonGameList.UseVisualStyleBackColor = true;
            this.buttonGameList.Click += new System.EventHandler(this.buttonGameList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGameList);
            this.Controls.Add(this.buttonCroupier);
            this.Controls.Add(this.buttonGame);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.ButtonИгрок);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button ButtonИгрок;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonCroupier;
        private System.Windows.Forms.Button buttonGameList;
    }
}

