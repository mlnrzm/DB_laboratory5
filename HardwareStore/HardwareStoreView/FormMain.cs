using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormMain : Form
    {
        private readonly IContentLogic _contentLogic;
        public FormMain(IContentLogic contentLogic)
        {
            InitializeComponent();
            _contentLogic = contentLogic;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                var list = _contentLogic.Read(null);
                if (list != null)
                {
                    dataGridViewContents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewContents.DataSource = list;
                    dataGridViewContents.Columns[0].Visible = false;
                    dataGridViewContents.Columns[1].Visible = false;
                    dataGridViewContents.Columns[2].Visible = false;
                    dataGridViewContents.Columns[3].AutoSizeMode =
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
            var form = Program.Container.Resolve<FormContent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewContents.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormContent>();
                form.Id = Convert.ToInt32(dataGridViewContents.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewContents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewContents.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _contentLogic.Delete(new ContentBM { Id = id });
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

        private void категорииТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormCategories>();
            form.ShowDialog();
        }

        private void техникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormTechnics>();
            form.ShowDialog();
        }

        private void видыДвиженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormMovementTypes>();
            form.ShowDialog();
        }

        private void движенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormMovements>();
            form.ShowDialog();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormCounterpartys>();
            form.ShowDialog();
        }
    }
}
