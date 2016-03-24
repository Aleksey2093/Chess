namespace Chess_window
{
    partial class Main_window
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
            this.tableLayoutPanel1Основной = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локальнаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одинИгрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дваИгрокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сетеваяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2Доска = new System.Windows.Forms.TableLayoutPanel();
            this.label_type_game = new System.Windows.Forms.ToolStripLabel();
            this.label_hod_gamer_now = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1Основной.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1Основной
            // 
            this.tableLayoutPanel1Основной.ColumnCount = 1;
            this.tableLayoutPanel1Основной.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Основной.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1Основной.Controls.Add(this.toolStrip1, 0, 2);
            this.tableLayoutPanel1Основной.Controls.Add(this.tableLayoutPanel2Доска, 0, 1);
            this.tableLayoutPanel1Основной.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1Основной.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1Основной.Name = "tableLayoutPanel1Основной";
            this.tableLayoutPanel1Основной.RowCount = 3;
            this.tableLayoutPanel1Основной.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1Основной.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1Основной.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1Основной.Size = new System.Drawing.Size(733, 334);
            this.tableLayoutPanel1Основной.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.локальнаяИграToolStripMenuItem,
            this.сетеваяИграToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            // 
            // локальнаяИграToolStripMenuItem
            // 
            this.локальнаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одинИгрокToolStripMenuItem,
            this.дваИгрокаToolStripMenuItem});
            this.локальнаяИграToolStripMenuItem.Name = "локальнаяИграToolStripMenuItem";
            this.локальнаяИграToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.локальнаяИграToolStripMenuItem.Text = "Локальная игра";
            // 
            // одинИгрокToolStripMenuItem
            // 
            this.одинИгрокToolStripMenuItem.Name = "одинИгрокToolStripMenuItem";
            this.одинИгрокToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.одинИгрокToolStripMenuItem.Text = "Один игрок";
            this.одинИгрокToolStripMenuItem.Click += new System.EventHandler(this.одинИгрокToolStripMenuItem_Click);
            // 
            // дваИгрокаToolStripMenuItem
            // 
            this.дваИгрокаToolStripMenuItem.Name = "дваИгрокаToolStripMenuItem";
            this.дваИгрокаToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.дваИгрокаToolStripMenuItem.Text = "Два игрока";
            this.дваИгрокаToolStripMenuItem.Click += new System.EventHandler(this.дваИгрокаToolStripMenuItem_Click);
            // 
            // сетеваяИграToolStripMenuItem
            // 
            this.сетеваяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.подключитьсяToolStripMenuItem});
            this.сетеваяИграToolStripMenuItem.Name = "сетеваяИграToolStripMenuItem";
            this.сетеваяИграToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сетеваяИграToolStripMenuItem.Text = "Сетевая игра";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // подключитьсяToolStripMenuItem
            // 
            this.подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            this.подключитьсяToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.подключитьсяToolStripMenuItem.Text = "Подключиться";
            this.подключитьсяToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_type_game,
            this.label_hod_gamer_now});
            this.toolStrip1.Location = new System.Drawing.Point(0, 304);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel2Доска
            // 
            this.tableLayoutPanel2Доска.AutoSize = true;
            this.tableLayoutPanel2Доска.ColumnCount = 8;
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2Доска.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2Доска.Name = "tableLayoutPanel2Доска";
            this.tableLayoutPanel2Доска.RowCount = 8;
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2Доска.Size = new System.Drawing.Size(727, 268);
            this.tableLayoutPanel2Доска.TabIndex = 2;
            this.tableLayoutPanel2Доска.MouseEnter += new System.EventHandler(this.tableLayoutPanel2Доска_MouseEnter);
            // 
            // label_type_game
            // 
            this.label_type_game.Name = "label_type_game";
            this.label_type_game.Size = new System.Drawing.Size(86, 22);
            this.label_type_game.Text = "toolStripLabel1";
            // 
            // label_hod_gamer_now
            // 
            this.label_hod_gamer_now.Name = "label_hod_gamer_now";
            this.label_hod_gamer_now.Size = new System.Drawing.Size(86, 22);
            this.label_hod_gamer_now.Text = "toolStripLabel2";
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 334);
            this.Controls.Add(this.tableLayoutPanel1Основной);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_window";
            this.Text = "Шахматы";
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.tableLayoutPanel1Основной.ResumeLayout(false);
            this.tableLayoutPanel1Основной.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1Основной;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2Доска;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локальнаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сетеваяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одинИгрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дваИгрокаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel label_type_game;
        private System.Windows.Forms.ToolStripLabel label_hod_gamer_now;
    }
}

