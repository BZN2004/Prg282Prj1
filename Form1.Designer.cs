namespace Prg282Prj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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




        private void InitializeComponent()
        {
            lblAnimalID = new Label();
            Nametxt = new TextBox();
            IDtxt = new TextBox();
            lblAnimalName = new Label();
            lblSpecies = new Label();
            Agetxt = new TextBox();
            Speciestxt = new TextBox();
            Scoretxt = new TextBox();
            lblAge = new Label();
            lblRecoveryScore = new Label();
            btnAdd = new Button();
            dgvAnimals = new DataGridView();
            btnDelete = new Button();
            btnSummary = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            lblSearchID = new Label();
            txtSearchID = new TextBox();
            grpSummary = new GroupBox();
            txtSummary = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(16, 14);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(59, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(362, 9);
            Nametxt.Margin = new Padding(3, 2, 3, 2);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(110, 23);
            Nametxt.TabIndex = 1;
            // 
            // IDtxt
            // 
            IDtxt.Location = new Point(87, 14);
            IDtxt.Margin = new Padding(3, 2, 3, 2);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(110, 23);
            IDtxt.TabIndex = 2;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(291, 9);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(39, 15);
            lblAnimalName.TabIndex = 3;
            lblAnimalName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(16, 41);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(362, 41);
            Agetxt.Margin = new Padding(3, 2, 3, 2);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(110, 23);
            Agetxt.TabIndex = 5;
            // 
            // Speciestxt
            // 
            Speciestxt.Location = new Point(87, 41);
            Speciestxt.Margin = new Padding(3, 2, 3, 2);
            Speciestxt.Name = "Speciestxt";
            Speciestxt.Size = new Size(110, 23);
            Speciestxt.TabIndex = 6;
            // 
            // Scoretxt
            // 
            Scoretxt.Location = new Point(603, 14);
            Scoretxt.Margin = new Padding(3, 2, 3, 2);
            Scoretxt.Name = "Scoretxt";
            Scoretxt.Size = new Size(110, 23);
            Scoretxt.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(291, 44);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(66, 15);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age (Years)";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(501, 14);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(87, 15);
            lblRecoveryScore.TabIndex = 9;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 76);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 32);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(33, 113);
            dgvAnimals.Margin = new Padding(3, 2, 3, 2);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(728, 207);
            dgvAnimals.TabIndex = 11;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(125, 76);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 32);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(0, 161);
            btnSummary.Margin = new Padding(3, 2, 3, 2);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(127, 23);
            btnSummary.TabIndex = 13;
            btnSummary.Text = "Generate Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(344, 344);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 32);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(217, 76);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 32);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // lblSearchID
            // 
            lblSearchID.AutoSize = true;
            lblSearchID.Location = new Point(39, 352);
            lblSearchID.Name = "lblSearchID";
            lblSearchID.Size = new Size(114, 15);
            lblSearchID.TabIndex = 15;
            lblSearchID.Text = "Search  by animal ID";
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(172, 352);
            txtSearchID.Margin = new Padding(3, 2, 3, 2);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(163, 23);
            txtSearchID.TabIndex = 16;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(txtSummary);
            grpSummary.Controls.Add(btnSummary);
            grpSummary.Location = new Point(39, 412);
            grpSummary.Margin = new Padding(3, 2, 3, 2);
            grpSummary.Name = "grpSummary";
            grpSummary.Padding = new Padding(3, 2, 3, 2);
            grpSummary.Size = new Size(673, 189);
            grpSummary.TabIndex = 18;
            grpSummary.TabStop = false;
            grpSummary.Text = "SummaryBox";
            // 
            // txtSummary
            // 
            txtSummary.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSummary.Location = new Point(14, 21);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(644, 135);
            txtSummary.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(310, 77);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 32);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 664);
            Controls.Add(btnUpdate);
            Controls.Add(grpSummary);
            Controls.Add(txtSearchID);
            Controls.Add(lblSearchID);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(dgvAnimals);
            Controls.Add(btnAdd);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblAge);
            Controls.Add(Scoretxt);
            Controls.Add(Speciestxt);
            Controls.Add(Agetxt);
            Controls.Add(lblSpecies);
            Controls.Add(lblAnimalName);
            Controls.Add(IDtxt);
            Controls.Add(Nametxt);
            Controls.Add(lblAnimalID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Baobab Ridge Wildlife Rehabilitation Records";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        private Label lblAnimalID;
        private TextBox Nametxt;
        private TextBox IDtxt;
        private Label lblAnimalName;
        private Label lblSpecies;
        private TextBox Agetxt;
        private TextBox Speciestxt;
        private TextBox Scoretxt;
        private Label lblAge;
        private Label lblRecoveryScore;
        private Button btnAdd;
        private DataGridView dgvAnimals;
        private Button btnDelete;
        private Button btnSummary;
        private Button btnSearch;
        private Button btnClear;
        private Label lblSearchID;
        private TextBox txtSearchID;
        private GroupBox grpSummary;
        private Button btnUpdate;
        private TextBox txtSummary;
    }
}
