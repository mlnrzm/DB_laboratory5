using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormMovements : Form
    {
        private readonly IMovementLogic _movementLogic;
        public FormMovements(IMovementLogic movementLogic)
        {
            InitializeComponent();
            _movementLogic = movementLogic;
        }

        private void FormMovements_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                var list = _movementLogic.Read(null);
                if (list != null)
                {
                    dataGridViewMovements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewMovements.DataSource = list;
                    dataGridViewMovements.Columns[0].Visible = false;
                    dataGridViewMovements.Columns[1].Visible = false;
                    dataGridViewMovements.Columns[2].Visible = false;
                    dataGridViewMovements.Columns[3].AutoSizeMode =
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
            var form = Program.Container.Resolve<FormMovement>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovements.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormMovement>();
                form.Id = Convert.ToInt32(dataGridViewMovements.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovements.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewMovements.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _movementLogic.Delete(new MovementBM { Id = id });
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
