namespace BoatManagement.GUI
{
    partial class StatisticsByTypeBoat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvTypeBoat = new DevExpress.XtraGrid.GridControl();
            this.gridTypeBoat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeBoat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTypeBoat
            // 
            this.dgvTypeBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTypeBoat.Location = new System.Drawing.Point(15, 111);
            this.dgvTypeBoat.MainView = this.gridTypeBoat;
            this.dgvTypeBoat.Name = "dgvTypeBoat";
            this.dgvTypeBoat.Size = new System.Drawing.Size(491, 355);
            this.dgvTypeBoat.TabIndex = 8;
            this.dgvTypeBoat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTypeBoat});
            // 
            // gridTypeBoat
            // 
            this.gridTypeBoat.GridControl = this.dgvTypeBoat;
            this.gridTypeBoat.Name = "gridTypeBoat";
            this.gridTypeBoat.OptionsFind.AlwaysVisible = true;
            this.gridTypeBoat.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartThongKe);
            this.groupBox2.Location = new System.Drawing.Point(591, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(577, 432);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // chartThongKe
            // 
            this.chartThongKe.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartThongKe.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea2);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend2);
            this.chartThongKe.Location = new System.Drawing.Point(4, 17);
            this.chartThongKe.Name = "chartThongKe";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Times New Roman", 9F);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.chartThongKe.Series.Add(series2);
            this.chartThongKe.Size = new System.Drawing.Size(569, 411);
            this.chartThongKe.TabIndex = 5;
            this.chartThongKe.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Statistics By Type Boat";
            // 
            // StatisticsByTypeBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTypeBoat);
            this.Name = "StatisticsByTypeBoat";
            this.Size = new System.Drawing.Size(1188, 572);
            this.Load += new System.EventHandler(this.StatisticsByTypeBoat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeBoat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvTypeBoat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTypeBoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Label label1;
    }
}
