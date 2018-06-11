namespace BoatManagement.GUI
{
    partial class StatisticsByNational
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
            this.dgvBoatByNational = new DevExpress.XtraGrid.GridControl();
            this.gridTypeBoat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatByNational)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoatByNational
            // 
            this.dgvBoatByNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBoatByNational.Location = new System.Drawing.Point(231, 96);
            this.dgvBoatByNational.MainView = this.gridTypeBoat;
            this.dgvBoatByNational.Name = "dgvBoatByNational";
            this.dgvBoatByNational.Size = new System.Drawing.Size(491, 382);
            this.dgvBoatByNational.TabIndex = 9;
            this.dgvBoatByNational.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTypeBoat});
            // 
            // gridTypeBoat
            // 
            this.gridTypeBoat.GridControl = this.dgvBoatByNational;
            this.gridTypeBoat.Name = "gridTypeBoat";
            this.gridTypeBoat.OptionsFind.AlwaysVisible = true;
            this.gridTypeBoat.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Statistics By Type Boat";
            // 
            // StatisticsByNational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBoatByNational);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StatisticsByNational";
            this.Size = new System.Drawing.Size(1081, 589);
            this.Load += new System.EventHandler(this.StatisticsByNational_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatByNational)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeBoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvBoatByNational;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTypeBoat;
        private System.Windows.Forms.Label label1;
    }
}
