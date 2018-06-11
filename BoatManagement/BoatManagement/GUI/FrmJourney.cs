using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceJourney;
using BoatManagement.ServicePosition;
using BoatManagement.ServiceNational;
using DevExpress.XtraMap;

namespace BoatManagement.GUI
{
    public partial class FrmJourney : Form
    {

        const string imageFilePath = @"C:\Users\Administrator\Desktop\boat.png";
        private int index = 0, index1 = 0;
        public int IDboat;

        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }

        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }

        public FrmJourney(int idboat)
        {
            InitializeComponent();

            IDboat = idboat;
        }


        #region Sự kiện
        private void FrmJourney_Load(object sender, EventArgs e)
        {
            LoaDgvTrip(IDboat);
            LoadUnitControl();
            LockControl();
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            var sv = new Journey1SoapClient();
            int id = (int)gridTrip.GetFocusedRowCellValue("ID");
            GUI.UpdatePosition form = new GUI.UpdatePosition(id);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sv = new Journey1SoapClient();
            if (btnAdd.Text == "Add")
            {
                btnUpdate.Enabled = false;
                btnAdd.Text = "Save";
                btnExit.Text = "Cancel";

                ClearControl();
                UnlockControl();

                return;
            }

            if (btnAdd.Text == "Save")
            {
                if (txtTimeProvide.Text == "")
                {
                    MessageBox.Show("You must enter all fields", "notification");
                    return;
                }
                else
                {
                    btnAdd.Text = "Add";
                    btnExit.Text = "Exit";
                    LockControl();
                    bool status = false;
                    int idbeginPo = (int)cbxBeginpo.EditValue;
                    int idendPo = (int)cbxEndPo.EditValue;
                    float timepro = float.Parse(txtTimeProvide.Text);
               //     bool status = false;
             
                    sv.inserttrip(IDboat, idbeginPo,idendPo , timepro, dateTimeBegin.Value, dateTimeEnd.Value, status);
                    if (status == false)
                    {
                        var sv1 = new Position1SoapClient();
                        var sv2 = new Journey1SoapClient();
                        var sv3 = new ServicePortNationalSoapClient();
                        var journeyNew = sv2.GetTrip(IDboat).OrderByDescending(p => p.ID).FirstOrDefault();
                        var port = sv3.GetPortByID((int)journeyNew.BeginPosition);
                        sv1.UpdatePosition(journeyNew.ID, (float)(port.Longitude),(float)(port.Latitude),DateTime.Now,port.Ocean);                        
                        
                    }

                    MessageBox.Show("Add successfully!");

                    LoaDgvTrip(IDboat);

                }
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var sv = new Journey1SoapClient();
            int idtrip = (int)gridTrip.GetFocusedRowCellValue("ID");
            var trip = sv.GetTripId(idtrip);
            if (btnUpdate.Text == "Update")
            {
                
                btnUpdate.Text = "Save";
                btnExit.Text = "Cancel";


                UnlockControl();

                return;
            }

            if (btnUpdate.Text == "Save")
            {

                btnUpdate.Text = "Update";
                btnExit.Text = "Exit";
                LockControl();
                bool status = false;
                int idbeginPo = (int)cbxBeginpo.EditValue;
                int idendPo = (int)cbxEndPo.EditValue;
                float timepro = float.Parse(txtTimeProvide.Text);
                if (cbxSatus.Text == "Complete")
                {
                    status = true;
                    var sv1 = new Position1SoapClient();
                
                    var sv3 = new ServicePortNationalSoapClient();
                    
                    var port = sv3.GetPortByID((int)trip.EndPosition);
                    sv1.UpdatePosition((int)trip.ID, (float)(port.Longitude), (float)(port.Latitude), DateTime.Now, port.Ocean);

                }
                else status = false;
                
                sv.UpdateTrip(idtrip, IDboat, idbeginPo, idendPo, timepro, dateTimeBegin.Value, dateTimeEnd.Value, status);
                MessageBox.Show("Update successfully!");

                FrmJourney_Load(sender,e);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Exit")
            {
                this.Close();
            }
            else { FrmJourney_Load(sender, e); btnUpdate.Text = "Update"; btnAdd.Text = "Add"; btnExit.Text = "Exit"; }
        }

        private void gridTrip_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            UpdateDetail();
           

            try
            {
                index = index1;
                index = gridTrip.FocusedRowHandle;
            }
            catch { }
        }
        #endregion

        #region Hàm chức năng
        public void LoaDgvTrip(int IDBoat)
        {
            int i = 0;
            var sv = new Journey1SoapClient();
            var trip = sv.GetTrip(IDBoat).ToList();
            var port = sv.GetAllPort().ToList();
            foreach(var p in trip)
            {
                if (p.Status == false) { btnAdd.Enabled = false;break; }
            }
            
            var ShowTrip = (from t in trip
                            from p in port
                            from pt in port
                            where p.ID == t.BeginPosition
                            where pt.ID == t.EndPosition
                            select new
                            {
                                STT = ++i,
                                ID = t.ID,
                                BeginPosition = p.Name,
                                EndPosition = pt.Name,
                                Status=t.Status
                            }).ToList();
            dgvTripList.DataSource = ShowTrip;

            if (ShowTrip.Where(p => p.Status == false).ToList().Count() == 0) { btnUpdate.Enabled = false;btnAdd.Enabled = true; }
            if (ShowTrip.Count() == 0) { btnUpdatePosition.Enabled = false;btnUpdate.Enabled = false; }

        }

        private void LoadUnitControl()
        {
            var sv = new Journey1SoapClient();
            cbxBeginpo.Properties.DataSource = sv.GetAllPort().Select(p=>new { p.ID, p.Name }).ToList();
            cbxBeginpo.Properties.DisplayMember = "Name";
            cbxBeginpo.Properties.ValueMember = "ID";
            cbxEndPo.Properties.DataSource = sv.GetAllPort().Select(p => new { p.ID, p.Name }).ToList();
            cbxEndPo.Properties.DisplayMember = "Name";
            cbxEndPo.Properties.ValueMember = "ID";
            //ClearControl();
        }

        private void UpdateDetail()
        {
            try
            {
                var sv = new Journey1SoapClient();
                var sv1 = new ServicePortNationalSoapClient();
               
                int id = (int)gridTrip.GetFocusedRowCellValue("ID");               
                var trip = sv.GetTripId(id);
                #region Detail
               

                cbxBeginpo.EditValue = trip.BeginPosition;
                cbxEndPo.EditValue = trip.EndPosition;
                dateTimeBegin.Value = trip.TimeBegin.Value;
                dateTimeEnd.Value = trip.TimeEnd.Value;
                
                txtTimeProvide.Text = trip.TimeProvide.ToString();
                
           
                bool status = (bool)trip.Status;

                if (status == true)
                {
                    cbxSatus.Text = "Complete";
                    btnUpdatePosition.Enabled = false;
                }
                else
                {
                    cbxSatus.Text = "Not Complete";
                    btnUpdatePosition.Enabled = true;
                }


                #endregion

                #region Load Map
                ((MapItemStorage)vectorItemsLayer1.Data).Items.Clear();
                var portBegin = sv1.GetPortByID((int)trip.BeginPosition);
                var portEnd = sv1.GetPortByID((int)trip.EndPosition);
                
                ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)portBegin.Latitude, (float)portBegin.Longitude), Text = "Begin" });

                ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)portEnd.Latitude, (float)portEnd.Longitude), Text = "End" });
                map.CenterPoint=new GeoPoint((float)portBegin.Latitude, (float)portBegin.Longitude);
                map.Zoom(7);
                LoadMap(id);
                #endregion

            }
            catch
            {

            }
        }

        private void LockControl()
        {

            dateTimeBegin.Enabled = false;
            dateTimeEnd.Enabled = false;
           
            txtTimeProvide.Enabled = false;
            cbxBeginpo.Enabled = false;
            cbxEndPo.Enabled = false;
            cbxSatus.Enabled = false;
            dgvTripList.Enabled = true;
           
          //  btnUpdate.Enabled = true;
           // btnExit.Enabled = true;
        }

        private void UnlockControl()
        {
            dateTimeBegin.Enabled = true;
            dateTimeEnd.Enabled = true;           
            txtTimeProvide.Enabled = true;
            cbxBeginpo.Enabled = true;
            cbxEndPo.Enabled = true;
            cbxSatus.Enabled = true;
            dgvTripList.Enabled = false;
        }

        private void ClearControl()
        {           
            cbxEndPo.ItemIndex = 0;
            cbxBeginpo.ItemIndex = 0;
            txtTimeProvide.Text = "";            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoaDgvTrip(IDboat);
        }

        private void LoadMap(int IDTrip)
        {
            
            var image = new Bitmap(imageFilePath);           
            var sv = new Position1SoapClient();
            var listPosition = sv.GetAllPo(IDTrip).ToList();
            MapPolyline mp = new MapPolyline();
            mp.Fill = Color.White;
            listPosition.OrderBy(p => p.Time).ToList();
            foreach (var p in listPosition)
            {
                

                    mp.Points.Add(new GeoPoint(Convert.ToDouble(p.Latitude), Convert.ToDouble(p.Longitude)));
                    var customElement = new MapCustomElement() { Location = new GeoPoint(Convert.ToDouble(p.Latitude), Convert.ToDouble(p.Longitude)), Text = "" };
                    customElement.Image = new Bitmap(image, new Size(40, 40));
                    mapItemStorage1.Items.Add(customElement);
                
            }
              ((MapItemStorage)VectorLayer.Data).Items.Add(mp);
               
            

        }
        #endregion
    }
}
