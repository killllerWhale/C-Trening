namespace WinFormsApp1
{
    public partial class frmРесторан : Form
    {
        public frmРесторан()
        {
            InitializeComponent();
        }


        private void frmРесторан_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedItems = lstМеню.CheckedItems.OfType<String>().ToList();
            if (checkedItems.Count > 0)
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    lstЗаказ.Items.Add(checkedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Выберети блюдо!", "Ресторан «Студент»", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            
            

        }     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lstЗаказ.Items.Count > 0)
            {
                for (int i = lstЗаказ.Items.Count - 1; i >= 0; i--)
                {
                    if (lstЗаказ.GetItemChecked(i))
                        lstЗаказ.Items.RemoveAt(i);
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда","Ресторан «Студент»", " < Новое блюдо > ");
            if (s == "") return;
            lstМеню.Items.Add(s);
        }

        private void mnuContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}