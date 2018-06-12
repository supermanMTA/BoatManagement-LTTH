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
using BoatManagement.ServicePosition;
using BoatManagement.ServiceJourney;
using System.Windows.Forms.DataVisualization.Charting;

namespace BoatManagement.GUI
{
  
    public partial class StatisticsByOcean : UserControl
    {
        public StatisticsByOcean()
        {
            InitializeComponent();
        }
      
        private void LoadDgv()
        {
            int i = 1,j=1;
            var sv_boat = new ServiceBoatSoapClient();
            var sv_position = new Position1SoapClient();
            var sv_journey = new Journey1SoapClient();
            var boat = sv_boat.GetAllBoat().ToList();

            //  var position = new Position1SoapClient();

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
                                  ID_Journey = a.ID
                              }).ToList();
            var InforBoatActive = (from p in BoatActive
                                        select new
                                        {
                                            STT = i++,
                                            ID = p.ID,
                                            Name = p.Name,
                                            IMO = p.IMO,
                                            Lat = sv_position.ListPosition(p.ID_Journey).Latitude,
                                            Long = sv_position.ListPosition(p.ID_Journey).Longitude,
                                            Oceans = sv_position.ListPosition(p.ID_Journey).Oceans
                                            
                                        }).ToList();

            var list = InforBoatActive.GroupBy(p => p.Oceans).Select(p => new { STT = j++, Name = p.Key, count = p.Count() });
            
            int tong= InforBoatActive.Count();
            dgvOcean.DataSource = list;
            chartThongKe.DataSource = list;
            chartThongKe.Series[0].XValueMember = "Name";
            chartThongKe.Series[0].XValueType = ChartValueType.String;
            chartThongKe.Series[0].YValueMembers ="count";
            chartThongKe.Series[0].YValueType = ChartValueType.Int32;
            label_Tong.Text = tong.ToString();

           
            

        }

        private void StatisticsByOcean_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        
    }
}
