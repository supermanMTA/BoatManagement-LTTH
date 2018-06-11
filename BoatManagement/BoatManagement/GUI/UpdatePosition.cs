using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServicePosition;
using BoatManagement.ServiceParameter;

namespace BoatManagement.GUI
{
    public partial class UpdatePosition : Form
    {
        public int IDtrip;
        public UpdatePosition(int id)
        {
            InitializeComponent();
            IDtrip = id;
        }
        private bool check()
        {
            if (txtLongitude.Text == "" || txLatitude.Text == "" || txtspeed.Text == "" || txtWeather.Text == "" || txtWater.Value.ToString() == null || txtWind.Value.ToString() == "")
            {
                MessageBox.Show("Not enough Information "); return false;
            }
            else return true;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            var sv = new Position1SoapClient();

            var sv1 = new ServiceParameterSoapClient();

            btnUpdate.Text = "Add";
          //  check();
            if ( txtLongitude.Text == "" || txLatitude.Text == "" || txtspeed.Text == "" || txtWeather.Text == "" || txtWater.Value.ToString() == null || txtWind.Value.ToString() == ""|| comboBoxOcean.Text=="")
            {
                MessageBox.Show("Not enought information");
            }
            else
            {
                sv.UpdatePosition(IDtrip, float.Parse(txtLongitude.Text), float.Parse(txLatitude.Text), dateTimePo.Value, comboBoxOcean.Text);

                var newPosition = sv.GetPosition().OrderByDescending(p => p.ID).FirstOrDefault();
                sv1.InsertParameter(newPosition.ID, Convert.ToInt32(txtspeed.Text), (int)txtWater.Value, (int)txtWind.Value, txtWeather.Text);

                MessageBox.Show("Add suceed!");
            }

        }
    }
}
