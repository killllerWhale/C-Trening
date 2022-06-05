namespace WinFormsApp1
{
    partial class frmРесторан
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstМеню = new System.Windows.Forms.CheckedListBox();
            this.cmdДобавить = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstЗаказ = new System.Windows.Forms.CheckedListBox();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНовоеБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказатьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБлюдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНазваниеБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContext.SuspendLayout();
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
            this.lstМеню.Location = new System.Drawing.Point(39, 107);
            this.lstМеню.Name = "lstМеню";
            this.lstМеню.Size = new System.Drawing.Size(259, 310);
            this.lstМеню.TabIndex = 1;
            this.lstМеню.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // cmdДобавить
            // 
            this.cmdДобавить.BackColor = System.Drawing.Color.GreenYellow;
            this.cmdДобавить.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdДобавить.Location = new System.Drawing.Point(347, 107);
            this.cmdДобавить.Name = "cmdДобавить";
            this.cmdДобавить.Size = new System.Drawing.Size(94, 23);
            this.cmdДобавить.TabIndex = 2;
            this.cmdДобавить.Text = "Добавить ->";
            this.cmdДобавить.UseVisualStyleBackColor = false;
            this.cmdДобавить.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(347, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Убрать < -";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Заказать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(489, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заказ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Меню";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstЗаказ
            // 
            this.lstЗаказ.FormattingEnabled = true;
            this.lstЗаказ.Location = new System.Drawing.Point(489, 107);
            this.lstЗаказ.Name = "lstЗаказ";
            this.lstЗаказ.Size = new System.Drawing.Size(259, 310);
            this.lstЗаказ.TabIndex = 7;
            this.lstЗаказ.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
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
            this.mnuContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuContext_Opening);
            // 
            // добавитьНовоеБлюдоToolStripMenuItem
            // 
            this.добавитьНовоеБлюдоToolStripMenuItem.Name = "добавитьНовоеБлюдоToolStripMenuItem";
            this.добавитьНовоеБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьНовоеБлюдоToolStripMenuItem.Text = "Добавить новое блюдо";
            // 
            // заказатьБлюдоToolStripMenuItem
            // 
            this.заказатьБлюдоToolStripMenuItem.Name = "заказатьБлюдоToolStripMenuItem";
            this.заказатьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.заказатьБлюдоToolStripMenuItem.Text = "Заказать блюдо";
            // 
            // удалитьБлюдоToolStripMenuItem
            // 
            this.удалитьБлюдоToolStripMenuItem.Name = "удалитьБлюдоToolStripMenuItem";
            this.удалитьБлюдоToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьБлюдоToolStripMenuItem.Text = "Удалить блюдо";
            // 
            // изменитьНазваниеБлюдаToolStripMenuItem
            // 
            this.изменитьНазваниеБлюдаToolStripMenuItem.Name = "изменитьНазваниеБлюдаToolStripMenuItem";
            this.изменитьНазваниеБлюдаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.изменитьНазваниеБлюдаToolStripMenuItem.Text = "Изменить название блюда";
            // 
            // frmРесторан
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.mnuContext;
            this.Controls.Add(this.lstЗаказ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdДобавить);
            this.Controls.Add(this.lstМеню);
            this.Name = "frmРесторан";
            this.Text = "frmРесторан";
            this.Load += new System.EventHandler(this.frmРесторан_Load);
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckedListBox lstМеню;
        private Button cmdДобавить;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private CheckedListBox lstЗаказ;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem добавитьНовоеБлюдоToolStripMenuItem;
        private ToolStripMenuItem заказатьБлюдоToolStripMenuItem;
        private ToolStripMenuItem удалитьБлюдоToolStripMenuItem;
        private ToolStripMenuItem изменитьНазваниеБлюдаToolStripMenuItem;
    }
}