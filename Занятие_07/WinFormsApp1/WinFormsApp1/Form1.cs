namespace WinFormsApp1
{
    public partial class frm�������� : Form
    {
        public frm��������()
        {
            InitializeComponent();
        }


        private void frm��������_Load(object sender, EventArgs e)
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
            var checkedItems = lst����.CheckedItems.OfType<String>().ToList();
            if (checkedItems.Count > 0)
            {
                for (int i = 0; i < checkedItems.Count; i++)
                {
                    lst�����.Items.Add(checkedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("�������� �����!", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
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
            if (lst�����.Items.Count > 0)
            {
                for (int i = lst�����.Items.Count - 1; i >= 0; i--)
                {
                    if (lst�����.GetItemChecked(i))
                        lst�����.Items.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("������ ������ ����!", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lst�����.Items.Count > 0)
            {
                MessageBox.Show("��������� ��������!", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                MessageBox.Show("������ ������ ����!", "�������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("������� �������� ������ �����","�������� ��������", " < ����� ����� > ");
            if (s == "") return;
            lst����.Items.Add(s);
        }

        private void mnuContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}