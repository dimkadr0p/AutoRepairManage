using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminAPP.Models;
using System.Windows.Forms;

namespace AdminAPP.Forms
{
    public partial class ViewAuto : Form
    {

        Auto _auto = new Auto();
        public ViewAuto(Auto auto)
        {
            InitializeComponent();
            _auto = auto;
        }

        private void ViewAuto_Load(object sender, EventArgs e)
        {
            textBoxCarTitle.Text = _auto.ToString();
            textBoxNumberValue.Text = _auto.VIN;
            dateTimePickerDate.Value = _auto.Date;
        }
    }
}
