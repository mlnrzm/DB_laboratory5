using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormMovementTypes : Form
    {
        private readonly IMovementTypeLogic _movementTypeLogic;
        public FormMovementTypes(IMovementTypeLogic movementTypeLogic)
        {
            InitializeComponent();
            _movementTypeLogic = movementTypeLogic;
        }

        private void FormMovementTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                var list = _movementTypeLogic.Read(null);
                if (list != null)
                {
                    dataGridViewMovementTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewMovementTypes.DataSource = list;
                    dataGridViewMovementTypes.Columns[0].Visible = false;
                    dataGridViewMovementTypes.Columns[1].AutoSizeMode =
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
            var form = Program.Container.Resolve<FormMovementType>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovementTypes.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormMovementType>();
                form.Id = Convert.ToInt32(dataGridViewMovementTypes.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovementTypes.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewMovementTypes.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _movementTypeLogic.Delete(new MovementTypeBM { Id = id });
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
