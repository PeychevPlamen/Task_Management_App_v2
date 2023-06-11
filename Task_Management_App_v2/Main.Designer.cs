namespace Task_Management_App_v2
{
    partial class Main
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
            this.allTasks = new System.Windows.Forms.TabControl();
            this.CreatePage = new System.Windows.Forms.TabPage();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.btnLogOutCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportToFile = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Task_Management_App_v2.AppData();
            this.editPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescriptionEdit = new System.Windows.Forms.TextBox();
            this.textBoxTitleEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogoutEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchDel = new System.Windows.Forms.Button();
            this.btnLogoutDel = new System.Windows.Forms.Button();
            this.textBoxTitleDel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdDel = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.userTasksTableAdapter = new Task_Management_App_v2.AppDataTableAdapters.UserTasksTableAdapter();
            this.allTasks.SuspendLayout();
            this.CreatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.editPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // allTasks
            // 
            this.allTasks.Controls.Add(this.CreatePage);
            this.allTasks.Controls.Add(this.editPage);
            this.allTasks.Controls.Add(this.deletePage);
            this.allTasks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTasks.Location = new System.Drawing.Point(2, 1);
            this.allTasks.Name = "allTasks";
            this.allTasks.SelectedIndex = 0;
            this.allTasks.Size = new System.Drawing.Size(1363, 517);
            this.allTasks.TabIndex = 1;
            // 
            // CreatePage
            // 
            this.CreatePage.Controls.Add(this.textDescription);
            this.CreatePage.Controls.Add(this.textTitle);
            this.CreatePage.Controls.Add(this.btnLogOutCreate);
            this.CreatePage.Controls.Add(this.btnSave);
            this.CreatePage.Controls.Add(this.btnExportToFile);
            this.CreatePage.Controls.Add(this.Description);
            this.CreatePage.Controls.Add(this.title);
            this.CreatePage.Controls.Add(this.label1);
            this.CreatePage.Controls.Add(this.dataGridView1);
            this.CreatePage.Location = new System.Drawing.Point(4, 32);
            this.CreatePage.Name = "CreatePage";
            this.CreatePage.Padding = new System.Windows.Forms.Padding(3);
            this.CreatePage.Size = new System.Drawing.Size(1355, 481);
            this.CreatePage.TabIndex = 0;
            this.CreatePage.Text = "Create";
            this.CreatePage.UseVisualStyleBackColor = true;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDescription.Location = new System.Drawing.Point(986, 272);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDescription.Size = new System.Drawing.Size(331, 120);
            this.textDescription.TabIndex = 8;
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTitle.Location = new System.Drawing.Point(986, 141);
            this.textTitle.Multiline = true;
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textTitle.Size = new System.Drawing.Size(331, 65);
            this.textTitle.TabIndex = 7;
            // 
            // btnLogOutCreate
            // 
            this.btnLogOutCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogOutCreate.Location = new System.Drawing.Point(1187, 10);
            this.btnLogOutCreate.Name = "btnLogOutCreate";
            this.btnLogOutCreate.Size = new System.Drawing.Size(161, 37);
            this.btnLogOutCreate.TabIndex = 6;
            this.btnLogOutCreate.Text = "Logout";
            this.btnLogOutCreate.UseVisualStyleBackColor = true;
            this.btnLogOutCreate.Click += new System.EventHandler(this.btnLogOutCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1187, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExportToFile
            // 
            this.btnExportToFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportToFile.Location = new System.Drawing.Point(986, 431);
            this.btnExportToFile.Name = "btnExportToFile";
            this.btnExportToFile.Size = new System.Drawing.Size(142, 29);
            this.btnExportToFile.TabIndex = 4;
            this.btnExportToFile.Text = "&Export";
            this.btnExportToFile.UseVisualStyleBackColor = true;
            this.btnExportToFile.Click += new System.EventHandler(this.btnExportToFile_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(986, 234);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(142, 35);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(986, 103);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(61, 35);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Tasks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTasksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // userTasksBindingSource
            // 
            this.userTasksBindingSource.DataMember = "UserTasks";
            this.userTasksBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editPage
            // 
            this.editPage.Controls.Add(this.label2);
            this.editPage.Controls.Add(this.textBoxDescriptionEdit);
            this.editPage.Controls.Add(this.textBoxTitleEdit);
            this.editPage.Controls.Add(this.label7);
            this.editPage.Controls.Add(this.label5);
            this.editPage.Controls.Add(this.btnLogoutEdit);
            this.editPage.Controls.Add(this.btnEdit);
            this.editPage.Controls.Add(this.btnSearch);
            this.editPage.Controls.Add(this.labelID);
            this.editPage.Controls.Add(this.textBoxID);
            this.editPage.Controls.Add(this.dataGridView2);
            this.editPage.Location = new System.Drawing.Point(4, 32);
            this.editPage.Name = "editPage";
            this.editPage.Padding = new System.Windows.Forms.Padding(3);
            this.editPage.Size = new System.Drawing.Size(1355, 481);
            this.editPage.TabIndex = 1;
            this.editPage.Text = "Edit";
            this.editPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(989, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Description";
            // 
            // textBoxDescriptionEdit
            // 
            this.textBoxDescriptionEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescriptionEdit.Location = new System.Drawing.Point(989, 293);
            this.textBoxDescriptionEdit.Multiline = true;
            this.textBoxDescriptionEdit.Name = "textBoxDescriptionEdit";
            this.textBoxDescriptionEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescriptionEdit.Size = new System.Drawing.Size(331, 120);
            this.textBoxDescriptionEdit.TabIndex = 15;
            // 
            // textBoxTitleEdit
            // 
            this.textBoxTitleEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleEdit.Location = new System.Drawing.Point(989, 175);
            this.textBoxTitleEdit.Multiline = true;
            this.textBoxTitleEdit.Name = "textBoxTitleEdit";
            this.textBoxTitleEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTitleEdit.Size = new System.Drawing.Size(331, 65);
            this.textBoxTitleEdit.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(989, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "All Tasks";
            // 
            // btnLogoutEdit
            // 
            this.btnLogoutEdit.Location = new System.Drawing.Point(1187, 11);
            this.btnLogoutEdit.Name = "btnLogoutEdit";
            this.btnLogoutEdit.Size = new System.Drawing.Size(161, 37);
            this.btnLogoutEdit.TabIndex = 10;
            this.btnLogoutEdit.Text = "Logout";
            this.btnLogoutEdit.UseVisualStyleBackColor = true;
            this.btnLogoutEdit.Click += new System.EventHandler(this.btnLogoutEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Location = new System.Drawing.Point(1190, 431);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 29);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(989, 431);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelID.Location = new System.Drawing.Point(989, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(40, 35);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxID.Location = new System.Drawing.Point(989, 98);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 30);
            this.textBoxID.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(930, 400);
            this.dataGridView2.TabIndex = 0;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.label6);
            this.deletePage.Controls.Add(this.btnDelete);
            this.deletePage.Controls.Add(this.btnSearchDel);
            this.deletePage.Controls.Add(this.btnLogoutDel);
            this.deletePage.Controls.Add(this.textBoxTitleDel);
            this.deletePage.Controls.Add(this.label3);
            this.deletePage.Controls.Add(this.label4);
            this.deletePage.Controls.Add(this.textBoxIdDel);
            this.deletePage.Controls.Add(this.dataGridView3);
            this.deletePage.Location = new System.Drawing.Point(4, 32);
            this.deletePage.Name = "deletePage";
            this.deletePage.Padding = new System.Windows.Forms.Padding(3);
            this.deletePage.Size = new System.Drawing.Size(1355, 481);
            this.deletePage.TabIndex = 2;
            this.deletePage.Text = "Delete";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 35);
            this.label6.TabIndex = 22;
            this.label6.Text = "All Tasks";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(1190, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 29);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchDel
            // 
            this.btnSearchDel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchDel.Location = new System.Drawing.Point(989, 431);
            this.btnSearchDel.Name = "btnSearchDel";
            this.btnSearchDel.Size = new System.Drawing.Size(130, 29);
            this.btnSearchDel.TabIndex = 20;
            this.btnSearchDel.Text = "Search";
            this.btnSearchDel.UseVisualStyleBackColor = true;
            this.btnSearchDel.Click += new System.EventHandler(this.btnSearchDel_Click);
            // 
            // btnLogoutDel
            // 
            this.btnLogoutDel.Location = new System.Drawing.Point(1187, 11);
            this.btnLogoutDel.Name = "btnLogoutDel";
            this.btnLogoutDel.Size = new System.Drawing.Size(161, 37);
            this.btnLogoutDel.TabIndex = 19;
            this.btnLogoutDel.Text = "Logout";
            this.btnLogoutDel.UseVisualStyleBackColor = true;
            this.btnLogoutDel.Click += new System.EventHandler(this.btnLogoutDel_Click);
            // 
            // textBoxTitleDel
            // 
            this.textBoxTitleDel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitleDel.Location = new System.Drawing.Point(989, 326);
            this.textBoxTitleDel.Multiline = true;
            this.textBoxTitleDel.Name = "textBoxTitleDel";
            this.textBoxTitleDel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTitleDel.Size = new System.Drawing.Size(331, 65);
            this.textBoxTitleDel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(989, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(989, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID";
            // 
            // textBoxIdDel
            // 
            this.textBoxIdDel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxIdDel.Location = new System.Drawing.Point(989, 241);
            this.textBoxIdDel.Name = "textBoxIdDel";
            this.textBoxIdDel.Size = new System.Drawing.Size(125, 30);
            this.textBoxIdDel.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(20, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(930, 400);
            this.dataGridView3.TabIndex = 0;
            // 
            // userTasksTableAdapter
            // 
            this.userTasksTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 517);
            this.Controls.Add(this.allTasks);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Main_Load);
            this.allTasks.ResumeLayout(false);
            this.CreatePage.ResumeLayout(false);
            this.CreatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.editPage.ResumeLayout(false);
            this.editPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl allTasks;
        private System.Windows.Forms.TabPage CreatePage;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button btnLogOutCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportToFile;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage editPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescriptionEdit;
        private System.Windows.Forms.TextBox textBoxTitleEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogoutEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchDel;
        private System.Windows.Forms.Button btnLogoutDel;
        private System.Windows.Forms.TextBox textBoxTitleDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdDel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AppData appData;
        private System.Windows.Forms.BindingSource userTasksBindingSource;
        private AppDataTableAdapters.UserTasksTableAdapter userTasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}