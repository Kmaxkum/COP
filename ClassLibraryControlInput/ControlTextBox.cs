using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryControlInput
{
    public partial class ControlTextBox : UserControl
    {
        public ControlTextBox()
        {
            InitializeComponent();
        }

        public int? Sum {
            get {
                if (textBox.Text == "") {
                    return null;
                }
                return Int32.Parse(textBox.Text);
            }
            set {
                if (value == null)
                {
                    textBox.Text = "";
                }
                else
                {
                    textBox.Text = value.ToString();
                    CheckSum();
                }
            }
        }

        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Введите только цифры");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private bool CheckSum() {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Введите только цифры");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                return false;
            }
            return true;
        }
    }
}
