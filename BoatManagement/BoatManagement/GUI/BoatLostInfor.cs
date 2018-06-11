using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceBoatLostInfor;
using BoatManagement.ServiceBoat;
using System.IO;
namespace BoatManagement.GUI
{
    public partial class BoatLostInfor : UserControl
    {
        public BoatLostInfor()
        {
            InitializeComponent();
        }

        private void BoatLostInfor_Load(object sender, EventArgs e)
        {
            var sv = new ServiceBoatSoapClient();
            LoadInitControl();
            dgvBoatLost.DataSource = (from p in sv.AllBoatLostInfor()
                                      from q in sv.GetAllBoat()
                                      where p.IDBoat == q.ID
                                      select new
                                      {
                                          ID = p.ID,
                                          IDBoat = q.ID,
                                          NameOfBoat = q.Name,
                                          LastConnect = p.LastConnect,
                                          Latitude = p.Latitude,
                                          Longitude = p.Longitude,
                                          IDJourney = p.IDJourney,
                                          Ocean=p.Ocean
                                      }).ToList();
            
        }

       private void LoadInitControl()
        {
            var sv = new ServiceBoatSoapClient();
            var list=sv.BoatAreActive();
            cbbBoat.Properties.DataSource = sv.BoatAreActive().Select(p => new { p.ID, p.Name }).ToList();
            cbbBoat.Properties.ValueMember = "ID";
            cbbBoat.Properties.DisplayMember = "Name";
        }
        private void gridBoatLost_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                cbbBoat.EditValue = gridBoatLost.GetFocusedRowCellValue("IDBoat");
                txtLat.Text = gridBoatLost.GetFocusedRowCellValue("Latitude").ToString();
                txtLong.Text= gridBoatLost.GetFocusedRowCellValue("Longitude").ToString();
                dateTimeLost.Value = (DateTime) gridBoatLost.GetFocusedRowCellValue("LastConnect");
                txtjourney.Text= gridBoatLost.GetFocusedRowCellValue("IDJourney").ToString();
                CbbStatus.Text = "Lost infor";
                cbbOcean.Text= gridBoatLost.GetFocusedRowCellValue("Ocean").ToString();
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                cbbBoat.Enabled = true;
                btnAdd.Text = "Save";
                btnUpdate.Enabled = false;
            }
            else
            {
                cbbBoat.Enabled = false;
                btnAdd.Text = "Add";
                btnUpdate.Enabled = true;
                cbbBoat.Enabled = false;
                try
                {
                    var sv = new BoatLostInfor1SoapClient();
                    sv.Insert(dateTimeLost.Value, float.Parse(txtLat.Text), float.Parse(txtLong.Text), Convert.ToInt32(txtjourney.Text), true, (int)cbbBoat.EditValue, cbbOcean.Text);
                    MessageBox.Show("Add successfully");
                    BoatLostInfor_Load(sender,e);
                }
                catch { }
            }
        }

        private void cbbBoat_EditValueChanged(object sender, EventArgs e)
        {
            var sv = new ServiceBoatSoapClient();
            var list = sv.BoatAreActive();
            var Bien = list.Where(p => p.ID == (int)cbbBoat.EditValue).FirstOrDefault();
            txtjourney.Text = Bien.ID_Journey.ToString();
            txtLat.Text = Bien.Latiude.ToString();
            txtLong.Text = Bien.Longiude.ToString();
            cbbOcean.Text = Bien.Ocean;
            dateTimeLost.Value = Bien.Time;
            CbbStatus.Text = "Lost Infor";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                MessageBox.Show("Update Positon for boat");
                txtLat.Enabled = true;
                txtLong.Enabled = true;
                cbbOcean.Enabled = true;
                dateTimeLost.Enabled = true;
                btnUpdate.Text = "Save";
                btnAdd.Enabled = false;
            }
            else
            {
                try
                {
                    txtLat.Enabled = false;
                    txtLong.Enabled = false;
                    btnAdd.Enabled = true;
                    cbbOcean.Enabled = false;
                    dateTimeLost.Enabled = false;
                    btnUpdate.Text = "Update";
                    var sv = new BoatLostInfor1SoapClient();
                    sv.Update(Convert.ToInt32(gridBoatLost.GetFocusedRowCellValue("ID")), dateTimeLost.Value, float.Parse(txtLat.Text), float.Parse(txtLong.Text), Convert.ToInt32(gridBoatLost.GetFocusedRowCellValue("IDJourney")), cbbOcean.Text);

                    MessageBox.Show("Update succeessfuly");
                    BoatLostInfor_Load(sender, e);
                }
                catch { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Text = "Update";
            btnAdd.Text = "Add";
            btnCancel.Text = "Cancel";
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
            cbbBoat.Enabled = false;
            BoatLostInfor_Load(sender,e);
        }
    }
}
