using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatManagement.ServiceParameter;
using BoatManagement.ServicePosition;
using BoatManagement.ServiceBoat;
using DevExpress.XtraMap;

namespace BoatManagement.GUI
{
    public partial class NowPosition : Form
    {
        int IDBoat;
        public NowPosition(int ID_Boat)
        {
            InitializeComponent();
            IDBoat = ID_Boat;
        }
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        void LoadParameter()
        {
            var sv = new ServiceBoatSoapClient();
            var pos = new Position1SoapClient();
            var para = new ServiceParameterSoapClient();
           
            var boat = sv.GetAllBoat().ToList();
            var dgvBoat1 = (from p in boat where (p.ID == IDBoat)
                            select new
                            {
                                Lat = pos.ListPosition(p.ID).Latitude,
                                Long = pos.ListPosition(p.ID).Longitude,
                                ID = pos.ListPosition(p.ID).ID,
                                Name=p.Name
                            }).ToList().FirstOrDefault();

            ItemStorage.Items.Add(new MapCallout() { Location = new GeoPoint((float)dgvBoat1.Lat, (float)dgvBoat1.Long), Text ="" });
            ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)dgvBoat1.Lat, (float)dgvBoat1.Long), Text = "" });
            var parameter = para.parameter(dgvBoat1.ID);
            labelLat.Text = dgvBoat1.Lat.ToString();
            labelLong.Text = dgvBoat1.Long.ToString();
            
            labelSpeed.Text = parameter.Speed.ToString();
            labelweather.Text = parameter.Weather.ToString();
            labelwind.Text = parameter.Wind.ToString();
            string PositionPara = "Speed : " + parameter.Speed + "\n" + "Weather: " + parameter.Weather + "\n Wind: " + parameter.Wind + "\n";
        }
        private void NowPosition_Load(object sender, EventArgs e)
        {
            LoadParameter();
        }
    }
}
