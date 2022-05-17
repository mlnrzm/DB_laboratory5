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
    public partial class FormContent : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly IContentLogic _logicContent;
        private readonly IMovementLogic _logicMovement;
        private readonly ITechnicLogic _logicTechnic;
        public FormContent(IContentLogic logicContent, IMovementLogic logicMovement, ITechnicLogic logicTechnic)
        {
            InitializeComponent();
            _logicContent = logicContent;
            _logicMovement = logicMovement;
            _logicTechnic = logicTechnic;
        }
        private void FormContent_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ContentVM view = _logicContent.Read(new ContentBM
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxCount.Text = Convert.ToString(view.Count);
                        textBoxCost.Text = Convert.ToString(view.Cost);

                        comboBoxMovement.SelectedValue = view.MovementId;
                        comboBoxTechnic.SelectedValue = view.TechnicId;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            LoadData();
        }
        private void LoadData() 
        {
            try
            {
                List<MovementVM> list = _logicMovement.Read(null);
                if (list != null)
                {
                    comboBoxMovement.DisplayMember = "Date";
                    comboBoxMovement.ValueMember = "Id";
                    comboBoxMovement.DataSource = list;
                    comboBoxMovement.SelectedItem = null;
                }

                List<TechnicVM> listT = _logicTechnic.Read(null);
                if (listT != null)
                {
                    comboBoxTechnic.DisplayMember = "TechnicName";
                    comboBoxTechnic.ValueMember = "Id";
                    comboBoxTechnic.DataSource = listT;
                    comboBoxTechnic.SelectedItem = null;
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
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCost.Text))
            {
                MessageBox.Show("Заполните поле Стоимость единицы", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxMovement.SelectedValue == null)
            {
                MessageBox.Show("Выберите движение", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxTechnic.SelectedValue == null)
            {
                MessageBox.Show("Выберите технику", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicContent.CreateOrUpdate(new ContentBM
                {
                    MovementId = Convert.ToInt32(comboBoxMovement.SelectedValue),
                    TechnicId = Convert.ToInt32(comboBoxTechnic.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Cost = Convert.ToInt32(textBoxCost.Text)
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
