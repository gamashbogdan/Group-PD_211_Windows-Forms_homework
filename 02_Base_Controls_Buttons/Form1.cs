using System.Text;

namespace Dz_na._08._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private bool isValid()
        {
            int count = 3;
            if (textBox_Name.Text.Length == 0)
            {
                count = -1;
            }
            if (textBox_Last_Name.Text.Length == 0)
            {
                count = -1;
            }
            if (!(radioButton_Econom.Checked || radioButton_Standart.Checked || radioButton_Luxe.Checked))
            {
                count = -1;
            }
            return count == 3;
        }
        private void ClearForms()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
            foreach (var item in this.Controls.OfType<RadioButton>())
            {
                item.Checked = false;
            }
            foreach (var item in this.Controls.OfType<MonthCalendar>())
            {
                item.AccessibleDefaultActionDescription = null;
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btn_Order.Enabled = true;
            }
            else
            {
                btn_Order.Enabled = false;
                return;
            }
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("�������� �� ����'����� ����");
                return;
            }
            StringBuilder res = new StringBuilder("\t-------- ���� ���������� ---------\n");
            res.Append($"\t��'� : {textBox_Name.Text}, ������� : {textBox_Last_Name.Text}\n");
            res.Append($"\t����� �������� : {maskedTextBox1.Text}\n");
            res.Append($"\tʳ������ �������� ���� : {numericUpDown_People.Value}\n");
            if (radioButton_Econom.Checked)
            {
                res.Append($"\t��� ������ : Econom\n");
            }
            if (radioButton_Standart.Checked)
            {
                res.Append($"\t��� ������ : Standart\n");
            }
            if (radioButton_Luxe.Checked)
            {
                res.Append($"\t��� ������ : Luxe\n");
            }
            res.Append($"\t���� ��������� : {monthCalendar1.SelectionStart}\n");
            res.Append($"\t���� ��������� : {monthCalendar1.SelectionEnd}\n");
            res.Append($"\t�������� : {textBox_Comentar.Text}\n");
            MessageBox.Show(res.ToString());
            ClearForms();


        }
        private void Casel_Batton_Click(object sender, EventArgs e)
        {
            ClearForms();
        }

    }
}