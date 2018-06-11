using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BoatManagement.GUI;
namespace BoatManagement
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Boat uc = new Boat();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            Boat uc = new Boat();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            BoatAreActive uc = new BoatAreActive();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

   

        private void barButtonNational_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            National uc = new National();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            FrmPortManagement uc = new FrmPortManagement();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            StatisticsByOcean uc = new StatisticsByOcean();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnStatisticsByTypeBoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            StatisticsByTypeBoat uc = new StatisticsByTypeBoat();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnStatisticsByNational_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            StatisticsByNational uc = new StatisticsByNational();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            BoatLostInfor uc = new BoatLostInfor();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
    }
}