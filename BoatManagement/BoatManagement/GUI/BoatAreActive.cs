using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BoatManagement.ServicePosition;
using DevExpress.XtraMap;
using BoatManagement.ServiceBoat;

using BoatManagement.ServiceJourney;
using BoatManagement.ServiceParameter;

namespace BoatManagement.GUI
{
    public partial class BoatAreActive : UserControl
    {
        public BoatAreActive()
        {
            InitializeComponent();
        }
        
        VectorItemsLayer VectorLayer { get { return (VectorItemsLayer)map.Layers["VectorLayer"]; } }
        MapItemStorage ItemStorage { get { return (MapItemStorage)VectorLayer.Data; } }
        void LoadDgv()
        {
            int i = 1;
            var sv_boat = new ServiceBoatSoapClient();
            var sv_position = new Position1SoapClient();
            var sv_journey = new Journey1SoapClient();
            var boat = sv_boat.GetAllBoat().ToList();           
            var position = sv_position.GetPosition().ToList();
            var journey = sv_journey.LoadJourneyActive().ToList();
            var BoatActive = (from a in journey
                              join b in boat
                              on a.IDBoat equals b.ID
                              select new
                              {
                                  ID = b.ID,
                                  Name = b.Name,
                                  IMO = b.IMO, 
                                  ID_Journey=a.ID
                              }).ToList();
            var PositionOfBoatActive = (from p in BoatActive
                                        select new
                                        {
                                            STT = i++,
                                            Name = p.Name,
                                            IMO = p.IMO,
                                            Latitude = sv_position.ListPosition(p.ID_Journey).Latitude,
                                            Longitude = sv_position.ListPosition(p.ID_Journey).Longitude,
                                            Ocean=sv_position.ListPosition(p.ID_Journey).Oceans,
                                            IDPosition=sv_position.ListPosition(p.ID_Journey).ID
                                        }).ToList();
                   dgvBoat.DataSource = PositionOfBoatActive;
            
            foreach (var p in PositionOfBoatActive)
            {
                
                var para = new ServiceParameterSoapClient();
                var parameter = para.parameter(p.IDPosition);
                if (parameter == null)
                {                  
                    ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)p.Latitude, (float)p.Longitude), Text = p.STT.ToString() });
                }
                
                    else {
                    string PositionPara = "Parameter\nSpeed : " + parameter.Speed.ToString() + "   ( km/h)" + "\n Wind: " + parameter.Wind.ToString() + "  ( mph ) " + "\nWater Level: " + parameter.Waterlevel.ToString() + "  ( m )\nWeather: " + parameter.Weather.ToString();

                    ItemStorage.Items.Add(new MapCallout() { Location = new GeoPoint((float)p.Latitude, (float)p.Longitude), Text = PositionPara });
                   
                   
                    ItemStorage.Items.Add(new MapPushpin() { Location = new GeoPoint((float)p.Latitude, (float)p.Longitude), Text = p.STT.ToString(),TextColor=Color.Red });
                }               
            }
        }

        private void BoatAreActive_Load(object sender, EventArgs e)
        {
            LoadDgv();
        
        }

        private void gridBoat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            double lat = Convert.ToDouble(gridBoat.GetFocusedRowCellValue("Latitude"));
            double Long = Convert.ToDouble(gridBoat.GetFocusedRowCellValue("Longitude"));
            map.CenterPoint = new GeoPoint(lat, Long);
            map.Zoom(8);
        }
    }
}
