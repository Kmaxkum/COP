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

namespace ClassLibraryControlOutputLists
{
    public partial class ControlListBoxOutput : UserControl
    {
        public string Pattern { get; set; }
        /// <summary> 
        /// Конструктор 
        /// </summary> 
        public ControlListBoxOutput()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Заполнение списка значениями из справочника 
        /// </summary> 
        /// <param name="type">тип-елемент</param> обоб
        public void LoadListBox(IEnumerable<object> list)
        {
            listBox.Items.AddRange(MakeStrings(list));
        }

        private string[] MakeStrings(IEnumerable<object> list) {
            var result = new List<string>();
            foreach (var i in list) {
                result.Add(MakeString(i));
            }
            return result.ToArray();
        }

        private string MakeString(Object obj) {
            var fieldsName = Regex.Matches(Pattern, @"{\w+}").Cast<Match>().Select(m => m.Value).ToArray();
            var obj_type = obj.GetType();
            var fields = obj_type.GetFields();

            var result = Pattern;
            foreach (var i in fieldsName) {
                if (fields.Any(x => "{" + x.Name + "}" == i)) {
                    var field = fields.First(x => "{" + x.Name + "}" == i);
                    var newValue = (string)field.GetValue(obj);
                    result = result.Replace(i, newValue);
                }
            }

            return result;
        }
    }
}
