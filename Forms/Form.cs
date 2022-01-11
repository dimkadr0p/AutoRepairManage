using AdminAPP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdminAPP
{
    public partial class FormMain : Form
    {
        SqlConnection connection = new SqlConnection(AppSettings.Instance.getConnectionString(1));
        List<ServiceOrder> curentServiceOrders { get; set; }
        List<Service> currentService = new List<Service>();
        List<Worker> currentWorker = new List<Worker>();
        Worker userWorker;
        public FormMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            if (authorization.ShowDialog() is DialogResult.OK)
            {
                if (authorization.user.Username.Trim() != "admin")
                {
                    editToolStripMenuItem.Enabled = false;
                    userWorker = Worker.getWorkerByID(connection, authorization.user.WorkerID);
                    this.Text = $"{userWorker.Name.Trim()} {userWorker.LastName.Trim()} - {Company.getCompanyByID(connection,userWorker.CompanyID)}";
                    order_ViewTableAdapter.FillByComanyId(autoRepairShopDataSet.Order_View,userWorker.CompanyID);
                }
                else
                {
                    order_ViewTableAdapter.Fill(autoRepairShopDataSet.Order_View);
                    this.Text = "Администратор";
                }
            }
            else
            {
                Close();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Edit().ShowDialog();
        }


        private void fillListService()
        {
            int order_id = Convert.ToInt32(order_ViewDataGridView.SelectedRows[0].Cells[0].Value);
            curentServiceOrders = ServiceOrder.getServiceByOrder(connection, order_id);
            foreach (ServiceOrder serviceOrder in curentServiceOrders)
            {
                Service service = Service.getServiceByID(connection, serviceOrder.serviceID);
                if (service != null)
                {
                    comboBoxListService.Items.Add(service.Name);
                    currentService.Add(service);
                }
                currentWorker.Add(Worker.getWorkerByID(connection, serviceOrder.workerID));
            }
            if (comboBoxListService.Items.Count > 0)
            {
                comboBoxListService.SelectedIndex = 0;
            }
        }

        private void order_ViewDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (order_ViewDataGridView.SelectedRows.Count == 1)
            {
                comboBoxListService.Items.Clear();
                currentService.Clear();
                currentWorker.Clear();
                fillListService();
                UpdateDetailPanel();
            }
        }

        private void UpdateDetailPanel()
        {
            ServiceOrder serviceOrder = curentServiceOrders[comboBoxListService.SelectedIndex];
            Worker worker = currentWorker[comboBoxListService.SelectedIndex];
            labelPriceValue.Text = Convert.ToString(serviceOrder.Price);
            labelWorkerValue.Text = Convert.ToString($"{worker.Name.Trim()} {worker.LastName}");
        }

        private void comboBoxListService_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetailPanel();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.EditService(curentServiceOrders[comboBoxListService.SelectedIndex]).ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.EditService(curentServiceOrders[comboBoxListService.SelectedIndex].orderID).ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.EditService(curentServiceOrders[comboBoxListService.SelectedIndex], 1).ShowDialog();
        }

        private void linkLabelClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int user_id = Convert.ToInt32(order_ViewDataGridView.SelectedRows[0].Cells[6].Value);
                new Forms.ViewPerson(Client.getClientByID(connection, user_id)).ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку заказа!");
            }
        }


        private void linkLabelAuto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

            int auto_id = Convert.ToInt32(order_ViewDataGridView.SelectedRows[0].Cells[5].Value);
            new Forms.ViewAuto(Auto.getAutoByID(connection, auto_id)).ShowDialog();
               }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку заказа!");
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int order_id = Convert.ToInt32(order_ViewDataGridView.SelectedRows[0].Cells[0].Value);
                Order.deleteOrderByID(connection, order_id);
                MessageBox.Show("Удаление успешно завершено!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку заказа!");
            }
        }

        private void toolStripButtonUploadBase_Click(object sender, EventArgs e)
        {
            if (userWorker == null)
                order_ViewTableAdapter.Fill(autoRepairShopDataSet.Order_View);
            else
                order_ViewTableAdapter.FillByComanyId(autoRepairShopDataSet.Order_View,userWorker.CompanyID);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            new Forms.CreateOrderForm(Client.selectAllClient(connection), Auto.selectAllAutoes(connection),userWorker).ShowDialog();
        }

        private void buttonChangeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int order_id = Convert.ToInt32(order_ViewDataGridView.SelectedRows[0].Cells[0].Value);
                new Forms.CreateOrderForm(Order.getOrderByID(connection, order_id), Client.selectAllClient(connection), Auto.selectAllAutoes(connection)).ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку заказа!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
