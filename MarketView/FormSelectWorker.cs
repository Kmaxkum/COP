using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryChainOfResponsibilityWorker;

namespace MarketView
{
    public partial class FormSelectWorker : Form
    {
        Director director;

        Deputy deputy;

        Worker worker;

        Intern intern;

        public FormSelectWorker()
        {
            InitializeComponent();
            director = new Director();
            deputy = new Deputy();
            worker = new Worker();
            intern = new Intern();
            director.Successor = deputy;
            deputy.Successor = worker;
            worker.Successor = intern;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Reworker reworker= new Reworker(checkDirector.Checked, checkDeputy.Checked, checkWorker.Checked, checkBoxIntern.Checked);
            MessageBox.Show(director.Handle(reworker), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
