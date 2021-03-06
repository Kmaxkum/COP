﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using Unity;
using ClassLibraryPluginsInterface;

namespace MarketView
{
    public partial class FormCustomerList : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }
        private readonly ICustomerService service;
        private Manager manager;

        public FormCustomerList(ICustomerService service)
        {
            InitializeComponent();
            manager = new Manager();
            if (manager.Headers != null && manager.Headers.Length != 0)
            {
                foreach (var elem in manager.Headers)
                {
                    listViewPlugins.Items.Add(elem);
                }
            }
            this.service = service;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = service.GetList();
                if (list == null) return;

                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCustomerAdd>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormCustomerAdd>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (manager == null) {
                    return;
                }
                CustomerBindingModel customer = manager.Plg["PluginStatus"](service.GetElement(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)));
                service.UpdElement(customer);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (manager == null)
                {
                    return;
                }
                CustomerBindingModel customer = manager.Plg["PluginSum"](service.GetElement(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)));
                service.UpdElement(customer);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (manager == null)
                {
                    return;
                }
                CustomerBindingModel customer = manager.Plg["PluginCheck"](service.GetElement(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)));
            }
            LoadData();
        }
    }
}
