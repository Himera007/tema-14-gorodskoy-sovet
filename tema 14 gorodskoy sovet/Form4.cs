using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace tema_14_gorodskoy_sovet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rbPokitika.Checked && !rbstort.Checked && !rdNovosti_goroda.Checked)
            {
                MessageBox.Show("Пожалуйста, выберите тип новости.");
            }
            else
            {
                string text = textBox1.Text;
                if (text.Length > 0)
                {
                    MessageBox.Show("Ваше предложение отправлено ");
                    Form3 form3 = new Form3();
                    if (form3 == null)
                    {
                        form3 = new Form3();
                    }
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите текст сообщения.");
                }
            }
        }
    }
}
