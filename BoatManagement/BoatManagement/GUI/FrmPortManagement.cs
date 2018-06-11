using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceNational;
using BoatManagement.ServiceBoat;
using DevExpress.XtraMap;

namespace BoatManagement.GUI
{

    public partial class FrmPortManagement : UserControl
    {
        public FrmPortManagement()
        {
            InitializeComponent();
        }
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        private void FrmPortManagement_Load(object sender, EventArgs e)
        {
            LoaddgvPort();
            LoadUnitControl();
            LockControl();
        }

        private void LoaddgvPort()
        {
            var sv = new ServicePortNationalSoapClient();
            var listPort = (from p in sv.ListPort()
                            select new
                            {
                                ID = p.ID,
                                Name = p.Name,
                                Natinal = sv.GetNational((int)p.ID_Nation).Name,
                                Latitude = p.Latitude,
                                Longitude = p.Longitude
                            }).ToList();

            dgvPortList.DataSource = listPort;
        }
        private void LoadUnitControl()
        {
            var sv = new ServiceBoatSoapClient();
            cbbNational.DataSource = sv.GetAllNational().ToList();
            cbbNational.DisplayMember = "Name";
            cbbNational.ValueMember = "ID";
        }

        private void UnLockControl()
        {

            txtName.Enabled = true;
            txtLongiude.Enabled = true;
            txtLat.Enabled = true;
            cbbNational.Enabled = true;
            cbbOceanOfPort.Enabled = true;

          
        }

        private void LockControl()
        {
            
            txtName.Enabled = false;
            txtLongiude.Enabled = false;
            txtLat.Enabled = false;
            cbbNational.Enabled = false;
            cbbOceanOfPort.Enabled = false;
        }


        private void gridPort_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var sv = new ServicePortNationalSoapClient();
            int id = (int)gridPort.GetFocusedRowCellValue("ID");
            var port = sv.GetPortByID(id);
            ((MapItemStorage)vectorItemsLayer1.Data).Items.Clear();
            try
            {
                txtName.Text = port.Name;
                txtLat.Text = port.Latitude.ToString();
                txtLongiude.Text = port.Longitude.ToString();
                
                cbbOceanOfPort.Text = port.Ocean;

                cbbNational.SelectedValue = port.ID_Nation;

                ItemStorage.Items.Add(new MapCallout() { Location = new GeoPoint((float)port.Latitude, (float)port.Longitude), Text = port.Name.ToString() });
                ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)port.Latitude, (float)port.Longitude), Text ="" });
                map.CenterPoint = new GeoPoint((float)port.Latitude, (float)port.Longitude);
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sv = new ServicePortNationalSoapClient();
            if (btnAdd.Text == "Add")
            {
                btnUpdate.Enabled = false;
                btnAdd.Text = "Save";
             //   btnCancel.Text = "Delete";
                UnLockControl();
                panel1.Enabled = true;
                return;
            }

            if (btnAdd.Text == "Save")
            {
            
                if (txtName.Text == "" || txtLongiude.Text == "" || txtLat.Text == "")
                {
                    MessageBox.Show("You must enter all fields", "notification");
                    return;
                }
                else
                {
                    // panel1.Enabled = false;
                    btnAdd.Text = "Add";
                    btnUpdate.Enabled = true;
                    LockControl();
                  //  Port port = new Port();
                    double Latitude = Convert.ToDouble(txtLat.Text);
                    double Longitude = Convert.ToDouble(txtLongiude.Text);
                    int ID_Nation = Convert.ToInt32(cbbNational.SelectedValue);
                    string Ocean = cbbOceanOfPort.Text;
                    string Name = txtName.Text;
                    sv.InsertPort(Name, (float)Latitude,(float) Longitude, ID_Nation, Ocean);
                    MessageBox.Show("Add suceed!");
                    FrmPortManagement_Load(sender,e);
                }
            }

            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var sv = new ServicePortNationalSoapClient();

            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
          //      btnCancel.Text = "Cancel";
                btnAdd.Enabled = false;

                UnLockControl();

                return;
            }

            if (btnUpdate.Text == "Save")
            {

                btnUpdate.Text = "Update";
                
                btnAdd.Enabled = true;
                LockControl();
         
                int id = (int)gridPort.GetFocusedRowCellValue("ID");
             
                double Latitude = Convert.ToDouble(txtLat.Text);
                double Longitude = Convert.ToDouble(txtLongiude.Text);
                int ID_Nation = Convert.ToInt32(cbbNational.SelectedValue);
                string Ocean = cbbOceanOfPort.Text;
                string Name = txtName.Text;
                sv.UpdatePort(id, Name, (float)Latitude, (float)Longitude, ID_Nation, Ocean);
                MessageBox.Show("Update succeed!");
                FrmPortManagement_Load(sender, e);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            btnUpdate.Text = "Update";
            btnCancel.Text = "Cancel";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            LockControl();        
            LoaddgvPort();
        }
    }
}
