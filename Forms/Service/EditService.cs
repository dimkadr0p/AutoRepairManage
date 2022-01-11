using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using AdminAPP.Models;
namespace AdminAPP.Forms
{
    public partial class EditService : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        ServiceOrder ServicesOrders = new ServiceOrder();
        List<Worker> Workers { get; set; }
        List<Service> Services { get; set; }
        int _flag_delete = 0;

        public EditService(int orderID)
        {
            InitializeComponent();
            ServicesOrders.orderID = orderID;
            buttonAction.Text = "Создать";
        }

        public EditService(ServiceOrder service)
        {
            InitializeComponent();
            ServicesOrders = service;
            buttonAction.Text = "Изменить";
        }

        public EditService(ServiceOrder service, int flag)
        {
            InitializeComponent();
            _flag_delete = 1;
            ServicesOrders = service;
            buttonAction.Text = "Удалить";
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            if (_flag_delete == 1)
            {
                Worker worker = Worker.getWorkerByID(connection, ServicesOrders.workerID);
                comboBoxService.Items.Add(Service.getServiceByID(connection, ServicesOrders.serviceID).Name);
                comboBoxWorker.Items.Add($"{worker.Name.Trim()} {worker.LastName.Trim()}");
                numericUpDownPrice.Maximum = ServicesOrders.Price;
                numericUpDownPrice.Value = ServicesOrders.Price;
                comboBoxService.SelectedIndex = 0;
                comboBoxWorker.SelectedIndex = 0;
            }
            else
            {
                Workers = Worker.getAllWorker(connection);
                Services = Service.selectAllService(connection);
                foreach (Worker worker in Workers)
                {
                    comboBoxWorker.Items.Add($"{worker.Name.Trim()} {worker.LastName.Trim()}");
                    comboBoxWorker.SelectedIndex = 0;
                }
                foreach (Service service in Services)
                {
                    comboBoxService.Items.Add(service.Name.Trim());
                    comboBoxService.SelectedIndex = 0;
                }
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (_flag_delete == 1)
            {
                ServiceOrder.deleteServiceOrderCommand(connection, ServicesOrders);
            }
            else
            {

                ServicesOrders.workerID = Workers[comboBoxWorker.SelectedIndex].ID;
                ServicesOrders.serviceID = Services[comboBoxService.SelectedIndex].ID;
                ServicesOrders.Price = numericUpDownPrice.Value;
                if (ServicesOrders.ID != 0)
                {
                    ServiceOrder.updateServiceCommand(connection, ServicesOrders);
                }
                else
                {
                    ServiceOrder.insertServiceCommand(connection, ServicesOrders);
                }
            }
            this.Close();
        }
    }
}
