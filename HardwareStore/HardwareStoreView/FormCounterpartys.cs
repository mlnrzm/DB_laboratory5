using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using System;
using System.Windows.Forms;
using Unity;

namespace HardwareStoreView
{
    public partial class FormCounterpartys : Form
    {
        private readonly ICounterpartyLogic _counterpartyLogic;
        public FormCounterpartys(ICounterpartyLogic counterpartyLogic)
        {
            InitializeComponent();
            _counterpartyLogic = counterpartyLogic;
        }

        private void FormCounterpartys_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                var list = _counterpartyLogic.Read(null);
                if (list != null)
                {
                    dataGridViewCounterpartys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewCounterpartys.DataSource = list;
                    dataGridViewCounterpartys.Columns[0].Visible = false;
                    dataGridViewCounterpartys.Columns[1].AutoSizeMode =
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
            var form = Program.Container.Resolve<FormCounterparty>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewCounterpartys.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormCounterparty>();
                form.Id = Convert.ToInt32(dataGridViewCounterpartys.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewCounterpartys.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridViewCounterpartys.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _counterpartyLogic.Delete(new CounterpartyBM { Id = id });
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
