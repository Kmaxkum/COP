using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibraryControlInput
{
    public partial class ControlTextBoxTemplate : UserControl
    {
        /// <summary> 
        /// Регулярное выражение для проверки почты
        /// </summary>
        private Regex _check = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z09]{2,17}))$");

        /// <summary> 
        /// Почта
        /// </summary>
        [Category("Спецификация"), Description("Почта")]
        public string Mail {
            get {
                if (!CheckMail())
                {
                    MessageBox.Show("Почта введена не верно");
                    return null;
                }
                return textBox.Text;
            }
            set {
                textBox.Text = value;
                CheckMail();
            }
        }
        /// <summary>
        /// Проверка почты
        /// </summary>
        private bool CheckMail() {
            if (!_check.IsMatch(textBox.Text)) {
                textBox.BackColor = Color.Red;
                return false;
            }
            textBox.BackColor = Color.Green;
            return true;
        }
        /// <summary> 
        /// Конструктор 
        /// </summary>
        public ControlTextBoxTemplate()
        {
            InitializeComponent();
        }
    }
}
