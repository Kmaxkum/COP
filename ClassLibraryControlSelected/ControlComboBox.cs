using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryControlSelected
{
    public partial class ControlComboBox : UserControl
    {
        /// <summary> 
        /// Порядковый номер выбранного элемента 
        /// </summary> 
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return comboBox.SelectedIndex; }
            set {
                if (value > -2 && value < comboBox.Items.Count)
                {
                    comboBox.SelectedIndex = value;
                }
            }
        }

        /// <summary> 
        /// Текст выбранной записи 
        /// </summary> 
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return comboBox.Text; }
        }

        /// <summary> 
        /// Конструктор 
        /// </summary> 
        public ControlComboBox()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Заполнение списка значениями из справочника 
        /// </summary> 
        /// <param name="type">тип-справочник</param> 
        public void LoadEnumeration(Type type)
        {
            foreach (var elem in Enum.GetValues(type))
            {
                comboBox.Items.Add(elem.ToString());
            }
        }
    }
}
