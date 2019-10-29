using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;

namespace MarketView
{
    public partial class FormCustomerAdd : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly ICustomerService customerService;
        private int? id;

        public FormCustomerAdd(ICustomerService customerService)
        {
            this.customerService = customerService;
            InitializeComponent();
            controlComboBox.LoadEnumeration(typeof(CustomerStatus));
        }

        private void FormCustomerAdd_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CustomerViewModel view = customerService.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.CustomerFIO;
                        foreach (var value in Enum.GetValues(typeof(CustomerStatus))) {
                            if (view.State == Enum.GetName(typeof(CustomerStatus), value)) {
                                controlComboBox.SelectedIndex = (int) value;
                                break;
                            }
                        }
                        controlSumBox.Sum = view.Sum;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните поле ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (controlComboBox.SelectedText == "")
            {
                MessageBox.Show("Выберите статус", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    customerService.UpdElement(new CustomerBindingModel
                    {
                        Id = id.Value,
                        CustomerFIO = textBoxFIO.Text,
                        State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), controlComboBox.SelectedText, true),
                        Sum = controlSumBox.Sum
                });
                }
                else
                {
                    customerService.AddElement(new CustomerBindingModel
                    {
                        CustomerFIO = textBoxFIO.Text,
                        State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), controlComboBox.SelectedText, true),
                        Sum = controlSumBox.Sum
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
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
