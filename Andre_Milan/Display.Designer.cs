namespace Andre_Milan
{
    partial class Display
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dbCoach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSpesialize = new System.Windows.Forms.ComboBox();
            this.coachDBDataSet = new Andre_Milan.CoachDBDataSet();
            this.tblCoachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoachTableAdapter = new Andre_Milan.CoachDBDataSetTableAdapters.tblCoachTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.coachDBDataSet1 = new Andre_Milan.CoachDBDataSet1();
            this.tblCoachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCoachTableAdapter1 = new Andre_Milan.CoachDBDataSet1TableAdapters.tblCoachTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCoach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbCoach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoachBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbCoach
            // 
            this.dbCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbCoach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dbCoach.Location = new System.Drawing.Point(19, 34);
            this.dbCoach.Name = "dbCoach";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dbCoach.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dbCoach.Size = new System.Drawing.Size(555, 150);
            this.dbCoach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReDisplay);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dbCoach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COACH";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbSpesialize);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(19, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTER";
            // 
            // cbSpesialize
            // 
            this.cbSpesialize.FormattingEnabled = true;
            this.cbSpesialize.Items.AddRange(new object[] {
            "Drive",
            "Putting",
            "Chipping",
            "Long shots",
            "Short game"});
            this.cbSpesialize.Location = new System.Drawing.Point(15, 31);
            this.cbSpesialize.Name = "cbSpesialize";
            this.cbSpesialize.Size = new System.Drawing.Size(121, 24);
            this.cbSpesialize.TabIndex = 0;
            // 
            // coachDBDataSet
            // 
            this.coachDBDataSet.DataSetName = "CoachDBDataSet";
            this.coachDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCoachBindingSource
            // 
            this.tblCoachBindingSource.DataMember = "tblCoach";
            this.tblCoachBindingSource.DataSource = this.coachDBDataSet;
            // 
            // tblCoachTableAdapter
            // 
            this.tblCoachTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(779, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coachDBDataSet1
            // 
            this.coachDBDataSet1.DataSetName = "CoachDBDataSet1";
            this.coachDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCoachBindingSource1
            // 
            this.tblCoachBindingSource1.DataMember = "tblCoach";
            this.tblCoachBindingSource1.DataSource = this.coachDBDataSet1;
            // 
            // tblCoachTableAdapter1
            // 
            this.tblCoachTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(61, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBook.Location = new System.Drawing.Point(597, 34);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 76);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Make a booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDelete);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(572, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE";
            // 
            // cbDelete
            // 
            this.cbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cbDelete.Location = new System.Drawing.Point(6, 36);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(121, 24);
            this.cbDelete.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(114, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPrice);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbRating);
            this.groupBox4.Controls.Add(this.tbName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbCoach);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(216, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 189);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ADD";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(132, 113);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(97, 22);
            this.tbPrice.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Spesialize";
            // 
            // tbRating
            // 
            this.tbRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRating.Location = new System.Drawing.Point(132, 55);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(97, 22);
            this.tbRating.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(132, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(97, 22);
            this.tbName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rating:";
            // 
            // cbCoach
            // 
            this.cbCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoach.FormattingEnabled = true;
            this.cbCoach.Items.AddRange(new object[] {
            "Drive",
            "Putting",
            "Long shots",
            "Short game",
            "Chipping"});
            this.cbCoach.Location = new System.Drawing.Point(132, 83);
            this.cbCoach.Name = "cbCoach";
            this.cbCoach.Size = new System.Drawing.Size(97, 24);
            this.cbCoach.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coach Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(236, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReDisplay
            // 
            this.btnReDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReDisplay.Location = new System.Drawing.Point(597, 132);
            this.btnReDisplay.Name = "btnReDisplay";
            this.btnReDisplay.Size = new System.Drawing.Size(75, 32);
            this.btnReDisplay.TabIndex = 16;
            this.btnReDisplay.Text = "Display";
            this.btnReDisplay.UseVisualStyleBackColor = true;
            this.btnReDisplay.Click += new System.EventHandler(this.btnReDisplay_Click);
            // 
            // Display
            // 
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(884, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "Display";
            this.Text = "COACH DATA";
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbCoach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coachDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCoachBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dgCoach;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dbCoach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CoachDBDataSet coachDBDataSet;
        private System.Windows.Forms.BindingSource tblCoachBindingSource;
        private CoachDBDataSetTableAdapters.tblCoachTableAdapter tblCoachTableAdapter;
        public System.Windows.Forms.ComboBox cbSpesialize;
        private System.Windows.Forms.Button button1;
        private CoachDBDataSet1 coachDBDataSet1;
        private System.Windows.Forms.BindingSource tblCoachBindingSource1;
        private CoachDBDataSet1TableAdapters.tblCoachTableAdapter tblCoachTableAdapter1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCoach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReDisplay;
    }
}