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

namespace BoatManagement.GUI
{
    public partial class StatisticsByNational : UserControl
    {
        public StatisticsByNational()
        {
            InitializeComponent();
        }
/*
        private void Loaddgv()
        {
            int i = 1;
            var sv = new ServiceBoatSoapClient();
            var listBoat = sv.GetAllBoat();
            var National = sv.GetAllNational();

            var listBoatAndNameType = (from a in listBoat

                                       select new
                                       {
                                           ID = a.ID,
                                           Name = a.Name,
                                           NameNational = sv.GetNational((int)a.IDNational).Name

                                       }).ToList();
            var list = listBoatAndNameType.GroupBy(p => p.NameNational).Select(p => new { STT = i++, Name = p.Key, Quantity = p.Count() });

            dgvBoatByNational.DataSource = list;
        }
        */



        private void StatisticsByNational_Load(object sender, EventArgs e)
        {
            var a = new ServiceBoatSoapClient();
            dgvBoatByNational.DataSource = a.CountBoat();

        }
    }
}
