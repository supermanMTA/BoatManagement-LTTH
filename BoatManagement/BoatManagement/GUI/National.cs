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
using DevExpress.XtraMap;
using System.IO;
using System.Drawing.Imaging;

namespace BoatManagement.GUI
{
    public partial class National : UserControl
    {
        public National()
        {
            InitializeComponent();
        }


        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }

        #region cac ham chuc nang
        private void LockControl()
        {
            txtNameOfNational.Enabled = false;
            imgAnh.Enabled = false;
        }

        private void UnlockControl()
        {
            txtNameOfNational.Enabled = true;
            imgAnh.Enabled = true;
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

        void LoadNational()
        {
            int i = 1;
            var sv = new ServicePortNationalSoapClient();
            var listNational = sv.ListNational().ToList();
            gridNational.DataSource = (from p in listNational
                                       select new
                                       {
                                           STT = i++,
                                           ID = p.ID,
                                           Name = p.Name,
                                       }).ToList();
        }

        void LoadPortOfNational(int ID_National)
        {
            int i = 1;
            var sv = new ServicePortNationalSoapClient();
            var ListPort = sv.ListPortOfNational(ID_National).ToList();
            var List = (from p in ListPort
                        select new
                        {
                            STT = i++,
                            Name = p.Name,
                            Latitude = p.Latitude,
                            Longitude = p.Longitude

                        }).ToList();
            gridPort.DataSource = List;
            foreach (var p in List)
            {
                ItemStorage.Items.Add(new MapCallout() { Location = new GeoPoint((float)p.Latitude, (float)p.Longitude), Text = p.Name.ToString() });
                ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)p.Latitude, (float)p.Longitude), Text = p.STT.ToString() });
            }
        }

        #endregion

        #region Cac su kien

        private void National_Load(object sender, EventArgs e)
        {
            LoadNational();
        }


        private void gridListNational_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var sv = new ServicePortNationalSoapClient();
            ((MapItemStorage)vectorItemsLayer1.Data).Items.Clear();
            int id = (int)gridListNational.GetFocusedRowCellValue("ID");
            var national = sv.GetNational(id);
            txtNameOfNational.Text = gridListNational.GetFocusedRowCellValue("Name").ToString();
            imgAnh.Image = ConvertBinaryToImage(national.Image);
            LoadPortOfNational((int)gridListNational.GetFocusedRowCellValue("ID"));

        }


        private void imgAnh_Click(object sender, EventArgs e)
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
                MessageBox.Show("Image false", "communication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
                btnCancel.Text = "Cancel";
                btnAdd.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnUpdate.Text == "Save")
            {

                btnUpdate.Text = "Update";
                btnCancel.Text = "Delete";

                LockControl();

                var sv = new ServicePortNationalSoapClient();
                var name = txtNameOfNational.Text;
                int id = (int)gridListNational.GetFocusedRowCellValue("ID");
                byte[] avt = ConvertImageToBinary(imgAnh.Image);
                sv.UpdateNational(id,name, avt);
                MessageBox.Show("Update succeed!");
                LoadNational();

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sv = new ServicePortNationalSoapClient();
            if (btnAdd.Text == "Add")
            {
                btnUpdate.Enabled = false;
                btnAdd.Text = "Save";
                btnCancel.Text = "Cancel";

                txtNameOfNational.Text = "";
                imgAnh.Image = null;
                UnlockControl();

                return;
            }

            if (btnAdd.Text == "Save")
            {
                if (txtNameOfNational.Text==null || imgAnh.Image == null)
                {
                    MessageBox.Show("You must enter all fields", "notification");
                    return;
                }
                else
                {
                    btnAdd.Text = "Add";
                    btnCancel.Text = "Delete";
                    LockControl();
                    string name = txtNameOfNational.Text;
                    byte[] avt = ConvertImageToBinary(imgAnh.Image);
                    sv.InsertNational(name, avt);
                   
                    MessageBox.Show("Add suceed!");

                    LoadNational();

                }

                // return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnUpdate.Text = "Update";
            btnAdd.Text = "Add";
            LoadNational();
        }
        #endregion
    }
}
