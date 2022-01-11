using System;
using System.Collections.Generic;
using AdminAPP.Models;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdminAPP.Forms
{
    public partial class CreateOrderForm : Form
    {
        Order _order;
        Worker _worker = null;
        List<Client> _clients = null;
        List<Auto> _autoes = null;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        
        public CreateOrderForm(Order order, List<Client> clients, List<Auto> autoes)
        {
            InitializeComponent();
            _order = order;
            buttonAction.Text = "Редактировать";
            _clients = clients;
            _autoes = autoes;
        }
        public CreateOrderForm(List<Client> clients, List<Auto> autoes, Worker worker)
        {
            InitializeComponent();
            buttonAction.Text = "Создать";
            _worker = worker;
            _clients = clients;
            _autoes = autoes;
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            if (_order == null && _clients == null)
            {
                comboBoxCar.Items.Add(Auto.getAutoByID(connection, _order.AutoID).ToString());
                comboBoxPerson.Items.Add(Client.getClientByID(connection,_order.ClientID));
                comboBoxCar.SelectedIndex = 0;
                comboBoxPerson.SelectedIndex = 0;
                checkBoxStatus.Checked = _order.Status;
                dateTimePickerDate.Value = _order.Date;
            }
            else
            {
                foreach (Auto auto in _autoes)
                {
                    comboBoxCar.Items.Add(auto.ToString());
                    comboBoxCar.SelectedIndex = 0;
                }
                foreach (Client client in _clients)
                {
                    comboBoxPerson.Items.Add(client.ToString());
                    comboBoxPerson.SelectedIndex = 0;
                }
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (_order == null)
            {
                _order = new Order {
                    ClientID = _clients[comboBoxPerson.SelectedIndex].ID,
                    AutoID = _autoes[comboBoxCar.SelectedIndex].ID,
                    Date = dateTimePickerDate.Value,
                    Status = checkBoxStatus.Checked,
                    CompanyID = _worker.CompanyID,
                };
                int oder_id = Order.insertOrderCommand(connection, _order);
                new EditService(oder_id).ShowDialog();
            }
            else
            {
                _order.AutoID = _autoes[comboBoxCar.SelectedIndex].ID;
                _order.ClientID = _clients[comboBoxPerson.SelectedIndex].ID;
                _order.Date = dateTimePickerDate.Value;
                _order.Status = checkBoxStatus.Checked;
                _order.CompanyID = _order.CompanyID;
                Order.updateOrderCommand(connection, _order);
            }
        }
    }
}
