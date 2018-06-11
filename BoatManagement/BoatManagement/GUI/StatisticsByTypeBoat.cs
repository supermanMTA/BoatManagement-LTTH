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
using System.Windows.Forms.DataVisualization.Charting;

namespace BoatManagement.GUI
{
    public partial class StatisticsByTypeBoat : UserControl
    {
        public StatisticsByTypeBoat()
        {
            InitializeComponent();
        }

        private void LoadDgv()
        {
            int i = 1;
            var sv = new ServiceBoatSoapClient();
            var listBoat = sv.GetAllBoat();
            var listType = sv.GetAllType();
            var listBoatAndNameType = (from a in listBoat

                                       select new
                                       {
                                           ID = a.ID,
                                           Name = a.Name,
                                           NameYpeBoat = sv.GetTypeBoat((int)a.IDTypeBoat).Name

                                       }).ToList();
            var list = listBoatAndNameType.GroupBy(p => p.NameYpeBoat).Select(p => new { STT = i++, Name = p.Key, Quantity = p.Count() });

            dgvTypeBoat.DataSource = list;

            
            chartThongKe.DataSource = list;
            chartThongKe.Series[0].XValueMember = "Name";
            chartThongKe.Series[0].XValueType = ChartValueType.String;
            chartThongKe.Series[0].YValueMembers = "Quantity";
            chartThongKe.Series[0].YValueType = ChartValueType.Int32;
        }

        private void StatisticsByTypeBoat_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        public static implicit operator StatisticsByTypeBoat(StatisticsByOcean v)
        {
            throw new NotImplementedException();
        }
    }
}
