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
            DevExpress.XtraMap.SizeLegend sizeLegend1 = new DevExpress.XtraMap.SizeLegend();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgvBoat = new DevExpress.XtraGrid.GridControl();
            this.gridBoat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.map = new DevExpress.XtraMap.MapControl();
            this.imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
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
            this.map.CenterPoint = new DevExpress.XtraMap.GeoPoint(15.8D, 106.5D);
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Layers.Add(this.imageTilesLayer1);
            this.map.Layers.Add(this.vectorItemsLayer1);
            this.map.Legends.Add(sizeLegend1);
            this.map.Location = new System.Drawing.Point(505, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(807, 591);
            this.map.TabIndex = 4;
            this.map.ZoomLevel = 3D;
            this.imageTilesLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AlZpmZgk5S20pbDFbqlIvgb43FQnFr8gGdvTtGCTy4C8tg6xqbd09Qw93a-APF8V";
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette;
            this.vectorItemsLayer1.Colorizer = keyColorColorizer1;
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            this.vectorItemsLayer1.Name = "VectorLayer";
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
        private DevExpress.XtraMap.ImageLayer imageTilesLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
    }
}
