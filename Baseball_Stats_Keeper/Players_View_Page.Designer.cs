namespace Baseball_Stats_Keeper
{
    partial class Players_View_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.BtnViewClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDatabaseDataSet = new Baseball_Stats_Keeper.practiceDatabaseDataSet();
            this.practiceDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atBatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeOutsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doublesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triplesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homerunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Last Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchName.Location = new System.Drawing.Point(195, 66);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(171, 20);
            this.txtSearchName.TabIndex = 1;
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.Lime;
            this.btnSearchName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchName.FlatAppearance.BorderSize = 2;
            this.btnSearchName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchName.Location = new System.Drawing.Point(390, 53);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(103, 43);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(273, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Or";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(212, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by:";
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "At Bats",
            "Hits",
            "Walks",
            "Strikeouts",
            "RBI",
            "Runs",
            "Singles",
            "Doubles",
            "Triples",
            "Home Runs"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(276, 293);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterBy.TabIndex = 7;
            // 
            // BtnViewClose
            // 
            this.BtnViewClose.BackColor = System.Drawing.Color.Red;
            this.BtnViewClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnViewClose.FlatAppearance.BorderSize = 2;
            this.BtnViewClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.BtnViewClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewClose.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnViewClose.Location = new System.Drawing.Point(432, 492);
            this.BtnViewClose.Name = "BtnViewClose";
            this.BtnViewClose.Size = new System.Drawing.Size(103, 43);
            this.BtnViewClose.TabIndex = 8;
            this.BtnViewClose.Text = "Close";
            this.BtnViewClose.UseVisualStyleBackColor = false;
            this.BtnViewClose.Click += new System.EventHandler(this.BtnViewClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Baseball_Stats_Keeper.Player);
            // 
            // practiceDatabaseDataSet
            // 
            this.practiceDatabaseDataSet.DataSetName = "practiceDatabaseDataSet";
            this.practiceDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practiceDatabaseDataSetBindingSource
            // 
            this.practiceDatabaseDataSetBindingSource.DataSource = this.practiceDatabaseDataSet;
            this.practiceDatabaseDataSetBindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.atBatsDataGridViewTextBoxColumn,
            this.hitsDataGridViewTextBoxColumn,
            this.strikeOutsDataGridViewTextBoxColumn,
            this.walksDataGridViewTextBoxColumn,
            this.singlesDataGridViewTextBoxColumn,
            this.doublesDataGridViewTextBoxColumn,
            this.triplesDataGridViewTextBoxColumn,
            this.homerunsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.statBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(527, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // atBatsDataGridViewTextBoxColumn
            // 
            this.atBatsDataGridViewTextBoxColumn.DataPropertyName = "AtBats";
            this.atBatsDataGridViewTextBoxColumn.HeaderText = "AtBats";
            this.atBatsDataGridViewTextBoxColumn.Name = "atBatsDataGridViewTextBoxColumn";
            // 
            // hitsDataGridViewTextBoxColumn
            // 
            this.hitsDataGridViewTextBoxColumn.DataPropertyName = "Hits";
            this.hitsDataGridViewTextBoxColumn.HeaderText = "Hits";
            this.hitsDataGridViewTextBoxColumn.Name = "hitsDataGridViewTextBoxColumn";
            // 
            // strikeOutsDataGridViewTextBoxColumn
            // 
            this.strikeOutsDataGridViewTextBoxColumn.DataPropertyName = "StrikeOuts";
            this.strikeOutsDataGridViewTextBoxColumn.HeaderText = "StrikeOuts";
            this.strikeOutsDataGridViewTextBoxColumn.Name = "strikeOutsDataGridViewTextBoxColumn";
            // 
            // walksDataGridViewTextBoxColumn
            // 
            this.walksDataGridViewTextBoxColumn.DataPropertyName = "Walks";
            this.walksDataGridViewTextBoxColumn.HeaderText = "Walks";
            this.walksDataGridViewTextBoxColumn.Name = "walksDataGridViewTextBoxColumn";
            // 
            // singlesDataGridViewTextBoxColumn
            // 
            this.singlesDataGridViewTextBoxColumn.DataPropertyName = "Singles";
            this.singlesDataGridViewTextBoxColumn.HeaderText = "Singles";
            this.singlesDataGridViewTextBoxColumn.Name = "singlesDataGridViewTextBoxColumn";
            // 
            // doublesDataGridViewTextBoxColumn
            // 
            this.doublesDataGridViewTextBoxColumn.DataPropertyName = "Doubles";
            this.doublesDataGridViewTextBoxColumn.HeaderText = "Doubles";
            this.doublesDataGridViewTextBoxColumn.Name = "doublesDataGridViewTextBoxColumn";
            // 
            // triplesDataGridViewTextBoxColumn
            // 
            this.triplesDataGridViewTextBoxColumn.DataPropertyName = "Triples";
            this.triplesDataGridViewTextBoxColumn.HeaderText = "Triples";
            this.triplesDataGridViewTextBoxColumn.Name = "triplesDataGridViewTextBoxColumn";
            // 
            // homerunsDataGridViewTextBoxColumn
            // 
            this.homerunsDataGridViewTextBoxColumn.DataPropertyName = "Homeruns";
            this.homerunsDataGridViewTextBoxColumn.HeaderText = "Homeruns";
            this.homerunsDataGridViewTextBoxColumn.Name = "homerunsDataGridViewTextBoxColumn";
            // 
            // statBindingSource
            // 
            this.statBindingSource.DataSource = typeof(Baseball_Stats_Keeper.Stat);
            // 
            // Players_View_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnViewClose);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Players_View_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Players";
            this.Load += new System.EventHandler(this.Players_View_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.Button BtnViewClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource practiceDatabaseDataSetBindingSource;
        private practiceDatabaseDataSet practiceDatabaseDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource statBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atBatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeOutsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn walksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doublesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn triplesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homerunsDataGridViewTextBoxColumn;
    }
}