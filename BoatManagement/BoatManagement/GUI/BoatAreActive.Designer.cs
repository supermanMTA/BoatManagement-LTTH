namespace BoatManagement.GUI
{
    partial class BoatAreActive
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgvBoat = new DevExpress.XtraGrid.GridControl();
            this.gridBoat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.map = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingSearchDataProvider1 = new DevExpress.XtraMap.BingSearchDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "View";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "View";
            // 
            // dgvBoat
            // 
            this.dgvBoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBoat.Location = new System.Drawing.Point(0, 0);
            this.dgvBoat.MainView = this.gridBoat;
            this.dgvBoat.Name = "dgvBoat";
            this.dgvBoat.Size = new System.Drawing.Size(505, 591);
            this.dgvBoat.TabIndex = 1;
            this.dgvBoat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBoat});
            // 
            // gridBoat
            // 
            this.gridBoat.GridControl = this.dgvBoat;
            this.gridBoat.Name = "gridBoat";
            this.gridBoat.OptionsFind.AlwaysVisible = true;
            this.gridBoat.OptionsView.ShowGroupPanel = false;
            this.gridBoat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridBoat_FocusedRowChanged);
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Layers.Add(this.imageLayer1);
            this.map.Layers.Add(this.informationLayer1);
            this.map.Layers.Add(this.vectorItemsLayer1);
            this.map.Location = new System.Drawing.Point(505, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(807, 591);
            this.map.TabIndex = 2;
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            this.vectorItemsLayer1.Name = "VectorLayer";
            this.vectorItemsLayer1.SelectedItemStyle.Fill = System.Drawing.Color.Red;
            this.informationLayer1.DataProvider = this.bingSearchDataProvider1;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AlZpmZgk5S20pbDFbqlIvgb43FQnFr8gGdvTtGCTy4C8tg6xqbd09Qw93a-APF8V";
            // 
            // BoatAreActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.map);
            this.Controls.Add(this.dgvBoat);
            this.Name = "BoatAreActive";
            this.Size = new System.Drawing.Size(1312, 591);
            this.Load += new System.EventHandler(this.BoatAreActive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dgvBoat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBoat;
        private DevExpress.XtraMap.MapControl map;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.InformationLayer informationLayer1;
        private DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
    }
}
