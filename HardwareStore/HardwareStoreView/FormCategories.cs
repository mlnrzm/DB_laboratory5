using System;
using System.Collections.Generic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormCategories : Form
    {
        private readonly ICategoryLogic _categoryLogic;
        public FormCategories(ICategoryLogic categoryLogic)
        {
            InitializeComponent();
            _categoryLogic = categoryLogic;
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _categoryLogic.Read(null);
                if (list != null)
                {
                    dataGridViewCategorys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewCategorys.DataSource = list;
                    dataGridViewCategorys.Columns[0].Visible = false;
                    dataGridViewCategorys.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormCategory>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorys.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormCategory>();
                form.Id = Convert.ToInt32(dataGridViewCategorys.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorys.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewCategorys.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _categoryLogic.Delete(new CategoryBM { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
