using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;

namespace Plugins
{
    public partial class FormStatus : Form
    {
        public string GetState {
            get { return controlComboBox.SelectedText; }
        }

        public FormStatus(CustomerViewModel customer)
        {
            InitializeComponent();
            controlComboBox.LoadEnumeration(typeof(CustomerStatus));
            try
            {
                if (customer != null)
                {
                    foreach (var value in Enum.GetValues(typeof(CustomerStatus)))
                    {
                        if (customer.State == Enum.GetName(typeof(CustomerStatus), value))
                        {
                            controlComboBox.SelectedIndex = (int)value;
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (controlComboBox.SelectedText == "")
            {
                MessageBox.Show("Выберите статус", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                {
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
