using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using HardwareStoreContracts.ViewModels;

namespace HardwareStoreView
{
    public partial class FormCounterparty : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly ICounterpartyLogic _logicCounterparty;
        public FormCounterparty(ICounterpartyLogic logicCounterparty)
        {
            InitializeComponent();
            _logicCounterparty = logicCounterparty;
        }
        private void FormCounterparty_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CounterpartyVM view = _logicCounterparty.Read(new CounterpartyBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxCounterpartyName.Text = view.Name;
                        textBoxPhone.Text = view.Phone;
                        textBoxAddress.Text = view.Address;
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
            if (string.IsNullOrEmpty(textBoxCounterpartyName.Text))
            {
                MessageBox.Show("Заполните поле Наименование", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните поле Телефон", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните поле Адрес", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicCounterparty.CreateOrUpdate(new CounterpartyBM
                {
                    Name = textBoxCounterpartyName.Text,
                    Phone = textBoxPhone.Text,
                    Address = textBoxAddress.Text
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
