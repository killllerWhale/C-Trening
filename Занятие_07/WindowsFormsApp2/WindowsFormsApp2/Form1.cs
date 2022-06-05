using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmРесторан : Form
    {
        string dirKitchen = Directory.GetCurrentDirectory() + "\\Кухня";
        string fileKitchen;
        bool changes;

        public frmРесторан()
        {
            InitializeComponent();
        }

        void menuLoad()
        {
            if (!Directory.Exists(dirKitchen))
            {
                MessageBox.Show("Каталог «Кухня» отсутствует!",

                "Ресторан «Студент»", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }
            string[] files = Directory.GetFiles(dirKitchen, "*.khn");
            mnuКухня.DropDownItems.Clear();
            foreach (string s in files)
            {
                string f = new FileInfo(s).Name.ToString();
                f = f.Remove(f.Length - 4);
                mnuКухня.DropDownItems.Add(f);
            }
        }

        public void saveKitchen()
        {
            changes = false;
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения ? ", "Ресторан «Студент»",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            StreamWriter f = new StreamWriter(fileKitchen, false);
            for (int i = 0; i < lstМеню.Items.Count; i++) f.WriteLine(lstМеню.Items[i]);
            f.Close();
        }

        private void frmРесторан_Load(object sender, EventArgs e)
        {
            menuLoad();
            //toolStripStatusLabel1_Click(sender,e,)
        }

        public void mnuКухня_DropDownItemClicked(object sender,ToolStripItemClickedEventArgs e)

        {
            Console.WriteLine("changes");
            if (changes) saveKitchen();
            fileKitchen = dirKitchen + "\\" + e.ClickedItem.Text + ".khn";
            toolStripStatusLabel1.Text = e.ClickedItem.Text+" "+"кухня";
            if (new FileInfo(fileKitchen).Exists == false)
            {
                MessageBox.Show("Данных об этой кухне нет!",
                "Ресторан «Студент»", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            StreamReader f = new StreamReader(fileKitchen);
            lstМеню.Items.Clear();
            while (!f.EndOfStream) lstМеню.Items.Add(f.ReadLine());
            f.Close();

        }



        private void lstМеню_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdДобавить_Click(object sender, EventArgs e)
        {
            var checkedItems = lstМеню.CheckedItems.OfType<String>().ToList();
            if (checkedItems.Count > 0)
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    lstЗаказ.Items.Add(checkedItems[i]);
                    changes = true;
                }
            }
            else
            {
                MessageBox.Show("Выберети блюдо!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstЗаказ.Items.Count > 0)
            {
                for (int i = lstЗаказ.Items.Count - 1; i >= 0; i--)
                {
                    if (lstЗаказ.GetItemChecked(i))
                        lstЗаказ.Items.RemoveAt(i);
                        changes = true;
                }
            }
            else
            {
                MessageBox.Show("Список заказа пуст!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstЗаказ.Items.Count > 0)
            {
                MessageBox.Show("Приятного аппетита!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                MessageBox.Show("Список заказа пуст!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void добавитьНовоеБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда","Ресторан «Студент»", " < Новое блюдо > ");
            if (s == "") return;
            lstМеню.Items.Add(s);
            changes = true;
        }

        private void заказатьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkedItems = lstМеню.CheckedItems.OfType<String>().ToList();
            if (checkedItems.Count > 0)
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    lstЗаказ.Items.Add(checkedItems[i]);
                    changes = true;
                }
            }
            else
            {
                MessageBox.Show("Выберети блюдо!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void удалитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstМеню.CheckedItems.OfType<string>().ToList().ForEach(lstМеню.Items.Remove);
            changes = true;
        }

        private void изменитьНазваниеБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название ", "Ресторан «Студент»", " < Новое блюдо > ");
            if (s == "") return;
            for (int x = 0; x < lstМеню.CheckedItems.Count; x++)
            {
                lstМеню.Items[x] = s;
                changes = true;
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuКухня_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
