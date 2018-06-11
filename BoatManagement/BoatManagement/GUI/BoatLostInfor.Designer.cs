namespace BoatManagement.GUI
{
    partial class BoatLostInfor
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
            this.dgvBoatLost = new DevExpress.XtraGrid.GridControl();
            this.gridBoatLost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtjourney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbBoat = new DevExpress.XtraEditors.LookUpEdit();
            this.dateTimeLost = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbOcean = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoatLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBoat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoatLost
            // 
            this.dgvBoatLost.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBoatLost.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBoatLost.Location = new System.Drawing.Point(0, 0);
            this.dgvBoatLost.MainView = this.gridBoatLost;
            this.dgvBoatLost.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBoatLost.Name = "dgvBoatLost";
            this.dgvBoatLost.Size = new System.Drawing.Size(504, 801);
            this.dgvBoatLost.TabIndex = 2;
            this.dgvBoatLost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBoatLost});
            // 
            // gridBoatLost
            // 
            this.gridBoatLost.GridControl = this.dgvBoatLost;
            this.gridBoatLost.Name = "gridBoatLost";
            this.gridBoatLost.OptionsFind.AlwaysVisible = true;
            this.gridBoatLost.OptionsView.ShowGroupPanel = false;
            this.gridBoatLost.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridBoatLost_FocusedRowChanged);
            // 
            // txtLat
            // 
            this.txtLat.Enabled = false;
            this.txtLat.Location = new System.Drawing.Point(883, 114);
            this.txtLat.Margin = new System.Windows.Forms.Padding(4);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(233, 26);
            this.txtLat.TabIndex = 4;
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Location = new System.Drawing.Point(908, 178);
            this.txtLong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(233, 26);
            this.txtLong.TabIndex = 5;
            // 
            // txtjourney
            // 
            this.txtjourney.Enabled = false;
            this.txtjourney.Location = new System.Drawing.Point(886, 241);
            this.txtjourney.Margin = new System.Windows.Forms.Padding(4);
            this.txtjourney.Name = "txtjourney";
            this.txtjourney.Size = new System.Drawing.Size(233, 26);
            this.txtjourney.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name Of Boat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last time connect";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Journey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Longitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Latitude";
            // 
            // cbbBoat
            // 
            this.cbbBoat.Enabled = false;
            this.cbbBoat.Location = new System.Drawing.Point(883, 58);
            this.cbbBoat.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBoat.Name = "cbbBoat";
            this.cbbBoat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbBoat.Size = new System.Drawing.Size(236, 20);
            this.cbbBoat.TabIndex = 16;
            this.cbbBoat.EditValueChanged += new System.EventHandler(this.cbbBoat_EditValueChanged);
            // 
            // dateTimeLost
            // 
            this.dateTimeLost.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimeLost.Enabled = false;
            this.dateTimeLost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeLost.Location = new System.Drawing.Point(886, 358);
            this.dateTimeLost.Name = "dateTimeLost";
            this.dateTimeLost.Size = new System.Drawing.Size(221, 26);
            this.dateTimeLost.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Information of Boat";
            // 
            // cbbOcean
            // 
            this.cbbOcean.Enabled = false;
            this.cbbOcean.FormattingEnabled = true;
            this.cbbOcean.Items.AddRange(new object[] {
            "Arctic Ocean",
            "Atlantic Ocean",
            "Indian Ocean",
            "Pacific Ocean",
            "Southern Ocean"});
            this.cbbOcean.Location = new System.Drawing.Point(886, 298);
            this.cbbOcean.Name = "cbbOcean";
            this.cbbOcean.Size = new System.Drawing.Size(121, 27);
            this.cbbOcean.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ocean";
            // 
            // CbbStatus
            // 
            this.CbbStatus.Enabled = false;
            this.CbbStatus.FormattingEnabled = true;
            this.CbbStatus.Items.AddRange(new object[] {
            "Lost Infor",
            "Have Infor"});
            this.CbbStatus.Location = new System.Drawing.Point(883, 435);
            this.CbbStatus.Name = "CbbStatus";
            this.CbbStatus.Size = new System.Drawing.Size(121, 27);
            this.CbbStatus.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(705, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(836, 498);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(949, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BoatLostInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CbbStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbOcean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeLost);
            this.Controls.Add(this.cbbBoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjourney);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.dgvBoatLost);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoatLostInfor";
            this.Size = new System.Drawing.Size(1438, 801);
            this.Load += new System.EventHandler(this.BoatLostInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoatLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbBoat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvBoatLost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBoatLost;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtjourney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit cbbBoat;
        private System.Windows.Forms.DateTimePicker dateTimeLost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbOcean;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbbStatus;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
