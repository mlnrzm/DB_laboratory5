using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormTechnics : Form
    {
        private readonly ITechnicLogic _technicLogic;
        public FormTechnics(ITechnicLogic technicLogic)
        {
            InitializeComponent();
            _technicLogic = technicLogic;
        }
        private void FormTechnics_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {

                var list = _technicLogic.Read(null);
                if (list != null)
                {
                    dataGridViewTechnics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewTechnics.DataSource = list;
                    dataGridViewTechnics.Columns[0].Visible = false;
                    dataGridViewTechnics.Columns[1].Visible = false;
                    dataGridViewTechnics.Columns[2].AutoSizeMode =
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
            var form = Program.Container.Resolve<FormTechnic>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnics.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormTechnic>();
                form.Id = Convert.ToInt32(dataGridViewTechnics.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnics.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewTechnics.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _technicLogic.Delete(new TechnicBM { Id = id });
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
