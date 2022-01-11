using System;
using System.Windows.Forms;

namespace AdminAPP
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.autoRepairShopDataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.autoRepairShopDataSet.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.autoRepairShopDataSet.Worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.autoRepairShopDataSet.Post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.autoRepairShopDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.autoRepairShopDataSet.Auto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoRepairShopDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.autoRepairShopDataSet.Person);
        }

        private void searchByLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            if (lastNameToolStripTextBox.Text == "")
            {
                this.personTableAdapter.Fill(this.autoRepairShopDataSet.Person);
                return;
            }
            try
            {
                personTableAdapter.SearchByLastName(this.autoRepairShopDataSet.Person, lastNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
                {
                case 0:
                    BindingNavigator.BindingSource = personBindingSource;
                    break;
                case 1:
                    BindingNavigator.BindingSource = autoBindingSource;
                    break;
                case 2:
                    BindingNavigator.BindingSource = serviceBindingSource;
                    break;
                case 3:
                    BindingNavigator.BindingSource = postBindingSource;
                    break;
                case 4:
                    BindingNavigator.BindingSource = workerBindingSource;
                    break;
                case 5:
                    BindingNavigator.BindingSource = companyBindingSource;
                    break;
            }
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.autoRepairShopDataSet);
            }
            catch
            {
                MessageBox.Show("Сохранение выполнить невозможно нарушена целостность!");
                Edit_Load(null, null);
            }

        }
    }
}
