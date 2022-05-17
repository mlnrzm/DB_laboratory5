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
    public partial class FormMovement : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly IMovementTypeLogic _logicMovementType;
        private readonly IMovementLogic _logicMovement;
        private readonly ICounterpartyLogic _logicCounterparty;
        public FormMovement(IMovementTypeLogic logicMovementType, IMovementLogic logicMovement, ICounterpartyLogic logicCounterparty)
        {
            InitializeComponent();
            _logicMovementType = logicMovementType;
            _logicMovement = logicMovement;
            _logicCounterparty = logicCounterparty;
        }
        private void FormMovement_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    MovementVM view = _logicMovement.Read(new MovementBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        comboBoxMovementType.SelectedValue = view.MovementTypeId;
                        comboBoxCounterparty.SelectedValue = view.CounterpartyId;
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
                List<MovementTypeVM> list = _logicMovementType.Read(null);
                if (list != null)
                {
                    comboBoxMovementType.DisplayMember = "MovementTypeName";
                    comboBoxMovementType.ValueMember = "Id";
                    comboBoxMovementType.DataSource = list;
                    comboBoxMovementType.SelectedItem = null;
                }

                List<CounterpartyVM> listT = _logicCounterparty.Read(null);
                if (listT != null)
                {
                    comboBoxCounterparty.DisplayMember = "Name";
                    comboBoxCounterparty.ValueMember = "Id";
                    comboBoxCounterparty.DataSource = listT;
                    comboBoxCounterparty.SelectedItem = null;
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
            if (comboBoxMovementType.SelectedValue == null)
            {
                MessageBox.Show("Выберите вид движения", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxCounterparty.SelectedValue == null)
            {
                MessageBox.Show("Выберите контрагента", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicMovement.CreateOrUpdate(new MovementBM
                {
                    MovementTypeId = Convert.ToInt32(comboBoxMovementType.SelectedValue),
                    CounterpartyId = Convert.ToInt32(comboBoxCounterparty.SelectedValue),
                    Date = DateTime.Now
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
