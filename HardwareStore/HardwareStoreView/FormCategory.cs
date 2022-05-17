using System;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System.Windows.Forms;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreView
{
    public partial class FormCategory : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly ICategoryLogic _logicCategory;
        public FormCategory(ICategoryLogic categoryLogic)
        {
            InitializeComponent();
            _logicCategory = categoryLogic;
        }
        private void FormCategory_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CategoryVM view = _logicCategory.Read(new CategoryBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxCategoryName.Text = view.CategoryName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategoryName.Text))
            {
                MessageBox.Show("Заполните поле Наименование", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _logicCategory.CreateOrUpdate(new CategoryBM
                {
                    CategoryName = textBoxCategoryName.Text
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
