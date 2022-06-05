namespace WindowsFormsApp2
{
    partial class frmРесторан
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
            this.components = new System.ComponentModel.Container();
            this.lstМеню = new System.Windows.Forms.CheckedListBox();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНовоеБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказатьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНазваниеБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstЗаказ = new System.Windows.Forms.CheckedListBox();
            this.cmdДобавить = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuФайл = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuКухня = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuContext.SuspendLayout();
            this.mnuGeneral.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstМеню
            // 
            this.lstМеню.ContextMenuStrip = this.mnuContext;
            this.lstМеню.FormattingEnabled = true;
            this.lstМеню.Items.AddRange(new object[] {
            "Картошка",
            "Грибной суп",
            "Борщ",
            "Оливье",
            "Салат Цезарь",
            "Шпинат",
            "Плов",
            "Чай",
            "Кофе",
            "Кола",
            "Какао"});
            this.lstМеню.Location = new System.Drawing.Point(12, 64);
            this.lstМеню.Name = "lstМеню";
            this.lstМеню.Size = new System.Drawing.Size(290, 334);
            this.lstМеню.TabIndex = 0;
            this.lstМеню.SelectedIndexChanged += new System.EventHandler(this.lstМеню_SelectedIndexChanged);
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовоеБлюдоToolStripMenuItem,
            this.заказатьБлюдоToolStripMenuItem,
            this.удалитьБлюдоToolStripMenuItem,
            this.изменитьНазваниеБлюдаToolStripMenuItem});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(221, 92);
            // 
            // добавитьНовоеБлюдоToolStripMenuItem
            // 
            this.добавитьНовоеБлюдоToolStripMenuItem.Name = "добавитьНовоеБлюдоToolStripMenuItem";
            this.добавитьНовоеБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьНовоеБлюдоToolStripMenuItem.Text = "Добавить новое блюдо";
            this.добавитьНовоеБлюдоToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовоеБлюдоToolStripMenuItem_Click);
            // 
            // заказатьБлюдоToolStripMenuItem
            // 
            this.заказатьБлюдоToolStripMenuItem.Name = "заказатьБлюдоToolStripMenuItem";
            this.заказатьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.заказатьБлюдоToolStripMenuItem.Text = "Заказать блюдо";
            this.заказатьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.заказатьБлюдоToolStripMenuItem_Click);
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            this.удалитьБлюдоToolStripMenuItem.Click += new System.EventHandler(this.удалитьБлюдоToolStripMenuItem_Click);
            // 
            // изменитьНазваниеБлюдаToolStripMenuItem
            // 
            this.изменитьНазваниеБлюдаToolStripMenuItem.Name = "изменитьНазваниеБлюдаToolStripMenuItem";
            this.изменитьНазваниеБлюдаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.изменитьНазваниеБлюдаToolStripMenuItem.Text = "Изменить название блюда";
            this.изменитьНазваниеБлюдаToolStripMenuItem.Click += new System.EventHandler(this.изменитьНазваниеБлюдаToolStripMenuItem_Click);
            // 
            // lstЗаказ
            // 
            this.lstЗаказ.FormattingEnabled = true;
            this.lstЗаказ.Location = new System.Drawing.Point(498, 64);
            this.lstЗаказ.Name = "lstЗаказ";
            this.lstЗаказ.Size = new System.Drawing.Size(290, 334);
            this.lstЗаказ.TabIndex = 1;
            // 
            // cmdДобавить
            // 
            this.cmdДобавить.BackColor = System.Drawing.Color.GreenYellow;
            this.cmdДобавить.Location = new System.Drawing.Point(357, 64);
            this.cmdДобавить.Name = "cmdДобавить";
            this.cmdДобавить.Size = new System.Drawing.Size(89, 23);
            this.cmdДобавить.TabIndex = 2;
            this.cmdДобавить.Text = "Добавить ->";
            this.cmdДобавить.UseVisualStyleBackColor = false;
            this.cmdДобавить.Click += new System.EventHandler(this.cmdДобавить_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(357, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Убрать < -";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Заказать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label2.Location = new System.Drawing.Point(501, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заказ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuФайл,
            this.mnuКухня});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Size = new System.Drawing.Size(800, 24);
            this.mnuGeneral.TabIndex = 8;
            this.mnuGeneral.Text = "mnuGeneral";
            this.mnuGeneral.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuФайл
            // 
            this.mnuФайл.Name = "mnuФайл";
            this.mnuФайл.Size = new System.Drawing.Size(48, 20);
            this.mnuФайл.Text = "Файл";
            // 
            // mnuКухня
            // 
            this.mnuКухня.Name = "mnuКухня";
            this.mnuКухня.Size = new System.Drawing.Size(91, 20);
            this.mnuКухня.Text = "Выбор кухни";
            this.mnuКухня.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuКухня_DropDownItemClicked);
            this.mnuКухня.Click += new System.EventHandler(this.mnuКухня_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "Cтандартная кухня";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // frmРесторан
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdДобавить);
            this.Controls.Add(this.lstЗаказ);
            this.Controls.Add(this.lstМеню);
            this.MainMenuStrip = this.mnuGeneral;
            this.Name = "frmРесторан";
            this.Text = "frmРесторан";
            this.Load += new System.EventHandler(this.frmРесторан_Load);
            this.mnuContext.ResumeLayout(false);
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstМеню;
        private System.Windows.Forms.CheckedListBox lstЗаказ;
        private System.Windows.Forms.Button cmdДобавить;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовоеБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказатьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьБлюдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьНазваниеБлюдаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuФайл;
        private System.Windows.Forms.ToolStripMenuItem mnuКухня;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

