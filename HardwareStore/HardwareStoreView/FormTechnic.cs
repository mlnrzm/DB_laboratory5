using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using HardwareStoreContracts.ViewModels;
using System.Linq;
using System.Data;

namespace HardwareStoreView
{
    public partial class FormTechnic : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly ICategoryLogic _logicCategory;
        private readonly ITechnicLogic _logicTechnic;
        public FormTechnic(ICategoryLogic categoryLogic, ITechnicLogic technicLogic)
        {
            InitializeComponent();
            _logicCategory = categoryLogic;
            _logicTechnic = technicLogic;
        }
        private void FormTechnic_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    TechnicVM view = _logicTechnic.Read(new TechnicBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxTechnicName.Text = view.TechnicName;
                        textBoxProduction.Text = view.Production;
                        textBoxWarranty.Text = view.Warranty;

                        comboBoxCategory.SelectedValue = view.CategoryId;

                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void LoadData()
        {
            try
            {
                List<CategoryVM> list = _logicCategory.Read(null);
                if (list != null)
                {
                    comboBoxCategory.DisplayMember = "CategoryName";
                    comboBoxCategory.ValueMember = "Id";
                    comboBoxCategory.DataSource = list;
                    comboBoxCategory.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTechnicName.Text))
            {
                MessageBox.Show("Заполните поле Наименование", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxProduction.Text))
            {
                MessageBox.Show("Заполните поле Производство", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxWarranty.Text))
            {
                MessageBox.Show("Заполните поле Гарантия", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Выберите категорию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicTechnic.CreateOrUpdate(new TechnicBM
                {
                    CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue),
                    TechnicName = textBoxTechnicName.Text,
                    Production = textBoxProduction.Text,
                    Warranty = textBoxWarranty.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
