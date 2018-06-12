namespace BoatManagement.GUI
{
    partial class Boat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boat));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxstatus = new System.Windows.Forms.ComboBox();
            this.cbxNational = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxTypeBoat = new DevExpress.XtraEditors.LookUpEdit();
            this.btnTrip = new DevExpress.XtraEditors.SimpleButton();
            this.txthigh = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtTonnage = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtMMSI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtIMO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBoatList = new DevExpress.XtraGrid.GridControl();
            this.gridBoat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.imgList = new DevExpress.Utils.ImageCollection(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNational.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTypeBoat.Properties)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cbxstatus);
            this.panel4.Controls.Add(this.cbxNational);
            this.panel4.Controls.Add(this.cbxTypeBoat);
            this.panel4.Controls.Add(this.btnTrip);
            this.panel4.Controls.Add(this.txthigh);
            this.panel4.Controls.Add(this.txtLength);
            this.panel4.Controls.Add(this.txtTonnage);
            this.panel4.Controls.Add(this.txtVolume);
            this.panel4.Controls.Add(this.txtMMSI);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.panelTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(454, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 620);
            this.panel4.TabIndex = 2;
            // 
            // cbxstatus
            // 
            this.cbxstatus.FormattingEnabled = true;
            this.cbxstatus.Items.AddRange(new object[] {
            "Work",
            "Work Off"});
            this.cbxstatus.Location = new System.Drawing.Point(632, 418);
            this.cbxstatus.Name = "cbxstatus";
            this.cbxstatus.Size = new System.Drawing.Size(121, 25);
            this.cbxstatus.TabIndex = 11;
            // 
            // cbxNational
            // 
            this.cbxNational.Location = new System.Drawing.Point(632, 200);
            this.cbxNational.Name = "cbxNational";
            this.cbxNational.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNational.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNational.Properties.Appearance.Options.UseFont = true;
            this.cbxNational.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNational.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNational.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNational.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNational.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNational.Properties.ShowHeader = false;
            this.cbxNational.Size = new System.Drawing.Size(206, 26);
            this.cbxNational.TabIndex = 5;
            // 
            // cbxTypeBoat
            // 
            this.cbxTypeBoat.Location = new System.Drawing.Point(139, 280);
            this.cbxTypeBoat.Name = "cbxTypeBoat";
            this.cbxTypeBoat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxTypeBoat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxTypeBoat.Properties.Appearance.Options.UseFont = true;
            this.cbxTypeBoat.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxTypeBoat.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxTypeBoat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxTypeBoat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTypeBoat.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxTypeBoat.Properties.ShowHeader = false;
            this.cbxTypeBoat.Size = new System.Drawing.Size(268, 26);
            this.cbxTypeBoat.TabIndex = 6;
            // 
            // btnTrip
            // 
            this.btnTrip.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.Appearance.Options.UseFont = true;
            this.btnTrip.ImageUri.Uri = "Replace";
            this.btnTrip.Location = new System.Drawing.Point(356, 510);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(160, 36);
            this.btnTrip.TabIndex = 18;
            this.btnTrip.Text = "Journey";
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // txthigh
            // 
            this.txthigh.Location = new System.Drawing.Point(139, 443);
            this.txthigh.Name = "txthigh";
            this.txthigh.Size = new System.Drawing.Size(220, 24);
            this.txthigh.TabIndex = 10;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(632, 340);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(215, 24);
            this.txtLength.TabIndex = 9;
            // 
            // txtTonnage
            // 
            this.txtTonnage.Location = new System.Drawing.Point(139, 353);
            this.txtTonnage.Name = "txtTonnage";
            this.txtTonnage.Size = new System.Drawing.Size(220, 24);
            this.txtTonnage.TabIndex = 8;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(636, 268);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(211, 24);
            this.txtVolume.TabIndex = 7;
            // 
            // txtMMSI
            // 
            this.txtMMSI.Location = new System.Drawing.Point(139, 201);
            this.txtMMSI.Name = "txtMMSI";
            this.txtMMSI.Size = new System.Drawing.Size(220, 24);
            this.txtMMSI.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tonnage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(556, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lenght";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type Of Boat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "National";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(54, 205);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 21);
            this.label.TabIndex = 1;
            this.label.Text = "MMSI";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.simpleButton3);
            this.panelTitle.Controls.Add(this.txtIMO);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.txtName);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.panel3);
            this.panelTitle.Controls.Add(this.imgAnh);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(850, 195);
            this.panelTitle.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(723, 156);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Select Image";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtIMO
            // 
            this.txtIMO.Location = new System.Drawing.Point(138, 117);
            this.txtIMO.Name = "txtIMO";
            this.txtIMO.Size = new System.Drawing.Size(194, 24);
            this.txtIMO.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMO:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 24);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(401, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 233);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // imgAnh
            // 
            this.imgAnh.BackColor = System.Drawing.Color.White;
            this.imgAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAnh.Location = new System.Drawing.Point(672, 18);
            this.imgAnh.Name = "imgAnh";
            this.imgAnh.Size = new System.Drawing.Size(164, 123);
            this.imgAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAnh.TabIndex = 0;
            this.imgAnh.TabStop = false;
            this.imgAnh.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 620);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvBoatList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 576);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boat List";
            // 
            // dgvBoatList
            // 
            this.dgvBoatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoatList.Location = new System.Drawing.Point(3, 20);
            this.dgvBoatList.MainView = this.gridBoat;
            this.dgvBoatList.Name = "dgvBoatList";
            this.dgvBoatList.Size = new System.Drawing.Size(446, 553);
            this.dgvBoatList.TabIndex = 0;
            this.dgvBoatList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBoat});
            // 
            // gridBoat
            // 
            this.gridBoat.GridControl = this.dgvBoatList;
            this.gridBoat.Name = "gridBoat";
            this.gridBoat.OptionsFind.AlwaysVisible = true;
            this.gridBoat.OptionsView.ShowGroupPanel = false;
            this.gridBoat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridBoat_FocusedRowChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 42);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDelete.ImageUri.Uri = "Close";
            this.btnDelete.Location = new System.Drawing.Point(302, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnUpdate.ImageUri.Uri = "Customization";
            this.btnUpdate.Location = new System.Drawing.Point(151, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAdd.ImageUri.Uri = "Add";
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgList.ImageStream")));
            // 
            // Boat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Boat";
            this.Size = new System.Drawing.Size(1308, 620);
            this.Load += new System.EventHandler(this.Boat_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNational.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTypeBoat.Properties)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoat)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox imgAnh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.Utils.ImageCollection imgList;
        private DevExpress.XtraGrid.GridControl dgvBoatList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBoat;
        private System.Windows.Forms.TextBox txthigh;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtTonnage;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtMMSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtIMO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnTrip;
        private DevExpress.XtraEditors.LookUpEdit cbxNational;
        private DevExpress.XtraEditors.LookUpEdit cbxTypeBoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ComboBox cbxstatus;
    }
}
