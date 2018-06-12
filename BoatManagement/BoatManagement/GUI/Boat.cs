using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceBoat;
using System.IO;
using System.Drawing.Imaging;
using BoatManagement.GUI;
using System.Text.RegularExpressions;

namespace BoatManagement.GUI
{
    public partial class Boat : UserControl
    {
        private int index = 0, index1 = 0;
        public Boat()
        {
            InitializeComponent();
        }
      
        #region Ham chuc nang
        public void LoagDgvBoat()
        {
            int i = 0;
            var sv = new ServiceBoatSoapClient();
            var boat = sv.GetAllBoat().ToList();
            //   var po = sv.GetAllPosition().ToList();
            var national = sv.GetAllNational().ToList();
            var type = sv.GetAllType().ToList();
            var ShowBoat = (from b in boat

                            select new
                            {
                                STT = ++i,
                                ID = b.ID,
                                Name = b.Name,
                                IMO = b.IMO,                                
                            }).ToList();
            dgvBoatList.DataSource = ShowBoat;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (var ms = new MemoryStream())
            {
                try
                {
                    Bitmap bmp = new Bitmap(img);
                    bmp.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                catch
                {
                    return null;
                }
            }



        }

        Image ConvertBinaryToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void LoadInitControl()
        {
            var sv = new ServiceBoatSoapClient();
            cbxNational.Properties.DataSource = sv.GetAllNational().Select(p => new { p.ID, p.Name }).ToList();
            cbxNational.Properties.DisplayMember = "Name";
            cbxNational.Properties.ValueMember = "ID";
            cbxTypeBoat.Properties.DataSource = sv.GetAllType().ToList();
            cbxTypeBoat.Properties.DisplayMember = "Name";
            cbxTypeBoat.Properties.ValueMember = "ID";
            ClearControl();
        }

        private void ClearControl()
        {
            //cbxNXB.ItemIndex = 0;
            cbxNational.ItemIndex = 0;
            cbxTypeBoat.ItemIndex = 0;
            txthigh.Text = "";
            txtIMO.Text = "";
            txtLength.Text = "";
            txtMMSI.Text = "";
            txtName.Text = "";
            
            txtTonnage.Text = "";
            txtVolume.Text = "";

            imgAnh.Image = null;
        }

        private void UpdateDetail()
        {
            try
            {
                var sv = new ServiceBoatSoapClient();
                int id = (int)gridBoat.GetFocusedRowCellValue("ID");
                //   int id= (int)dgvBoatList.get
                var boat = sv.GetBoat(id);
                cbxNational.EditValue = boat.IDNational;
                cbxTypeBoat.EditValue = boat.IDTypeBoat;
                txtName.Text = boat.Name;
                txtIMO.Text = boat.IMO;
                txtLength.Text = boat.Length.ToString();
                txtMMSI.Text = boat.MMSI;
                txtTonnage.Text = boat.Tonnage.ToString();
                txthigh.Text = boat.High.ToString();
                //  txtStatus.Text = boat.Status.ToString();
                if (boat.Status == true) cbxstatus.Text = "Work";
                else cbxstatus.Text = "Work Off";

                txtVolume.Text = boat.Volume.ToString();
                imgAnh.Image = ConvertBinaryToImage(boat.Image);

            }
            catch
            {

            }
        }

        private void LockControl()
        {
            txtName.Enabled = false;
            cbxTypeBoat.Enabled = false;
            cbxTypeBoat.Enabled = false;
            // txtGiaBan.Enabled = false;
            txthigh.Enabled = false;
            imgAnh.Enabled = false;
            txtIMO.Enabled = false;
            txtLength.Enabled = false;
            cbxstatus.Enabled = false;
            txtTonnage.Enabled = false;
            txtVolume.Enabled = false;
            txtMMSI.Enabled = false;
            dgvBoatList.Enabled = true;
            //  txtTimKiem.Enabled = true;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void UnlockControl()
        {
            txtName.Enabled = true;
            cbxTypeBoat.Enabled = true;
            cbxTypeBoat.Enabled = true;
            // txtGiaBan.Enabled = false;
            txthigh.Enabled = true;
            imgAnh.Enabled = true;
            txtIMO.Enabled = true;
            txtLength.Enabled = true;
            //txtStatus.Enabled = true;
            cbxstatus.Enabled = true;
            txtTonnage.Enabled = true;
            txtVolume.Enabled = true;
            txtMMSI.Enabled = true;
            dgvBoatList.Enabled = false;
            //  txtTimKiem.Enabled = false;
        }
        #endregion


        #region KiemtraDL
        public bool CheckAll()
        {
            int id = (int)gridBoat.GetFocusedRowCellValue("ID");
            string imo = txtIMO.Text;
            string mmsi = txtMMSI.Text;
            string V = txtVolume.Text;
            string T = txtTonnage.Text;
            string H = txthigh.Text;
            string L = txtLength.Text;

            if (checkIMO(id, imo) == false) { MessageBox.Show("You Incorrect", "IMO number is only and must have IMO + 7 character int"); return false; }
            else if (checkMMSI(id, mmsi) == false) { MessageBox.Show("You Incorrect", "MMSI number is only and must have 9 character int"); return false; }
            else if (IsNumber(V) == false) { MessageBox.Show("You Incorrect", "Volume is int or float"); return false; }
            else if (IsNumber(T) == false) { MessageBox.Show("You Incorrect", "Tonnage is int or float"); return false; }
            else if (IsNumber(H) == false) { MessageBox.Show("You Incorrect", "High is int or float"); return false; }
            else if (IsNumber(L) == false) { MessageBox.Show("You Incorrect", "Length is int or float"); return false; }
            return true;
        }

        public bool checkIMO(int id, string str)
        {
            string str1 = "";
            string str2 = "";

            if (str.Length == 10)
            {
                str1 = str.Substring(0, 2);
                str2 = str.Substring(str.Length - 7, 7);
                return true;
            }


            else if (checkDefIMO(id, str) == false) return false;
            else if (string.Compare(str1, "IMO", true) == 0 && IsInt(str2) == true) return true;
            else return false;
        }

        public bool checkMMSI(int id, string str)
        {
            if (str.Length != 9) return false;
            else if (checkDefIMO(id, str) == false) return false;
            else if (IsInt(str) == true) return true;
            else return false;

        }

        public bool IsNumber(string pText) //kiểm tra xem string là int hay float không
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        public bool IsInt(string pValue)// kiểm tra xem string là int không
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool checkDefIMO(int id, string str)
        {
            var sv = new ServiceBoatSoapClient();
            foreach (var b in sv.GetAllBoat().ToList())
            {
                if (string.Compare(str, b.IMO, true) == 0 && id != b.ID) return false;
                else return true;
            }

            return false;
        }

        public bool checkDefMMIS(int id, string str)
        {
            var sv = new ServiceBoatSoapClient();
            foreach (var b in sv.GetAllBoat().ToList())
            {
                if (string.Compare(str, b.MMSI, true) == 0 && id == b.ID) return false;
                else return true;
            }

            return false;
        }
        private bool Check()
        {
            if (imgAnh.Image == null)
            {
                MessageBox.Show("Image must not be empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Name of boat must not be empty!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtIMO.Text == "")
            {
                MessageBox.Show("IMO of boat must not be empty!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }
        #endregion


        #region Su kien
        private void Boat_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoagDgvBoat();
            LockControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sv = new ServiceBoatSoapClient();
            var boat = sv.GetAllBoat().ToList();
            if (btnAdd.Text == "Add")
            {
                btnUpdate.Enabled = false;
                btnAdd.Text = "Save";
                btnDelete.Text = "Cancel";
                ClearControl();
                UnlockControl();

                return;
            }

            if (btnAdd.Text == "Save")
            {
                if (txtMMSI.Text == "" || txtName.Text == "" || txtIMO.Text == "" || txthigh.Text == "" || txtTonnage.Text == ""
                     || txtVolume.Text == "" || imgAnh.Image == null)
                {
                    MessageBox.Show("You must enter all fields", "notification");
                    return;
                }
               
               
                else
                {
                    if (CheckAll() == true)
                    {
                        btnAdd.Text = "Add";
                        btnDelete.Text = "Delete";
                        LockControl();
                        int idnational = (int)cbxNational.EditValue;
                        int idtypeboat = (int)cbxTypeBoat.EditValue;
                        float volume = float.Parse(txtVolume.Text);
                        float tonnage = float.Parse(txtTonnage.Text);
                        float length = float.Parse(txtLength.Text);
                        float high = float.Parse(txthigh.Text);
                        bool status = true;
                        if (cbxstatus.Text == "Work")
                        {
                            status = true;
                        }
                        else status = false;
                        byte[] avt = ConvertImageToBinary(imgAnh.Image);
                        sv.insertboat(txtName.Text, txtIMO.Text, txtMMSI.Text, idnational, idtypeboat, volume, tonnage, high, length, status, avt);

                        MessageBox.Show("Add successfully!");

                        LoagDgvBoat();
                    }

                }

                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
                btnDelete.Text = "Cancel";
                btnAdd.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnUpdate.Text == "Save")
            {
                if (CheckAll() == true)
                {
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";

                    LockControl();

                    var sv = new ServiceBoatSoapClient();
                    int id = (int)gridBoat.GetFocusedRowCellValue("ID");
                    int idnational = (int)cbxNational.EditValue;
                    int idtypeboat = (int)cbxTypeBoat.EditValue;
                    float volume = float.Parse(txtVolume.Text);
                    float tonnage = float.Parse(txtTonnage.Text);
                    float length = float.Parse(txtLength.Text);
                    float high = float.Parse(txthigh.Text);
                    bool status = true;
                    if (cbxstatus.Text == "Work")
                    {
                        status = true;
                    }
                    else status = false;
                    byte[] avt = ConvertImageToBinary(imgAnh.Image);
                       sv.UpdateBoat(id, txtName.Text, txtIMO.Text, txtMMSI.Text, idnational, idtypeboat, volume, tonnage, high, length, status, avt);
                    MessageBox.Show("Update successfully!");
                    LoagDgvBoat();
                }
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Cancel")
            {
                LoagDgvBoat();
                btnDelete.Text = "Delete";
                btnAdd.Text = "Add";
                btnUpdate.Text = "Update";
                LockControl();
            }
            else
            {
                var sv = new ServiceBoatSoapClient();
                int id = (int)gridBoat.GetFocusedRowCellValue("ID");
                DialogResult rs = MessageBox.Show("Do you want to delete this boat?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;
                sv.DeleteBoat(id);
                MessageBox.Show("Delete successfully!");
                LoagDgvBoat();
            }
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            var sv = new ServiceBoatSoapClient();
            int id = (int)gridBoat.GetFocusedRowCellValue("ID");
            FrmJourney form = new FrmJourney(id);
            form.ShowDialog();
        }
       
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
            }
            catch
            {

            }

            try
            {
                Image image = Image.FromFile(path);

                imgAnh.Image = image;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }      

        private void gridBoat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();

            try
            {
                index = index1;
                index = gridBoat.FocusedRowHandle;
            }
            catch { }
        }
        #endregion


      
    }
}
