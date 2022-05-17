using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreView
{
    public partial class FormMovementType : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly IMovementTypeLogic _logicMovementType;
        public FormMovementType(IMovementTypeLogic logicMovementType)
        {
            InitializeComponent();
            _logicMovementType = logicMovementType;
        }
        private void FormMovementType_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    MovementTypeVM view = _logicMovementType.Read(new MovementTypeBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxMovementTypeName.Text = view.MovementTypeName;
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
            if (string.IsNullOrEmpty(textBoxMovementTypeName.Text))
            {
                MessageBox.Show("Заполните поле Вид движения", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicMovementType.CreateOrUpdate(new MovementTypeBM
                {
                    MovementTypeName = textBoxMovementTypeName.Text
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
