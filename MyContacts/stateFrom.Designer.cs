﻿
namespace MyContacts
{
    partial class stateFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stateFrom));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFile = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshFile = new System.Windows.Forms.ToolStripButton();
            this.labelSearch = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgState = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMalek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEddit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.labelSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgState)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFile,
            this.btnRefreshFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFile
            // 
            this.btnAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddFile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFile.Image")));
            this.btnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(44, 22);
            this.btnAddFile.Text = "افزودن";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRefreshFile
            // 
            this.btnRefreshFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefreshFile.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshFile.Image")));
            this.btnRefreshFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshFile.Name = "btnRefreshFile";
            this.btnRefreshFile.Size = new System.Drawing.Size(64, 22);
            this.btnRefreshFile.Text = "بروز رسانی";
            this.btnRefreshFile.Click += new System.EventHandler(this.btnRefreshFile_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Controls.Add(this.txtSearch);
            this.labelSearch.Controls.Add(this.label1);
            this.labelSearch.Location = new System.Drawing.Point(12, 28);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(875, 100);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.TabStop = false;
            this.labelSearch.Text = "جستجو";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgState);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست";
            // 
            // dgState
            // 
            this.dgState.AllowUserToAddRows = false;
            this.dgState.AllowUserToDeleteRows = false;
            this.dgState.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CodFile,
            this.Address,
            this.NameMalek,
            this.Price,
            this.Mobile,
            this.Status,
            this.categoryname});
            this.dgState.Location = new System.Drawing.Point(6, 21);
            this.dgState.Name = "dgState";
            this.dgState.ReadOnly = true;
            this.dgState.RowTemplate.Height = 25;
            this.dgState.Size = new System.Drawing.Size(863, 186);
            this.dgState.TabIndex = 0;
            this.dgState.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgState_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CodFile
            // 
            this.CodFile.DataPropertyName = "CodFile";
            this.CodFile.HeaderText = "کد فایل";
            this.CodFile.Name = "CodFile";
            this.CodFile.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // NameMalek
            // 
            this.NameMalek.DataPropertyName = "NameMalek";
            this.NameMalek.HeaderText = "مالک";
            this.NameMalek.Name = "NameMalek";
            this.NameMalek.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // categoryname
            // 
            this.categoryname.DataPropertyName = "categoryname";
            this.categoryname.HeaderText = "نام دسته بندی";
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            // 
            // btnEddit
            // 
            this.btnEddit.Location = new System.Drawing.Point(806, 357);
            this.btnEddit.Name = "btnEddit";
            this.btnEddit.Size = new System.Drawing.Size(75, 23);
            this.btnEddit.TabIndex = 3;
            this.btnEddit.Text = "ویرایش";
            this.btnEddit.UseVisualStyleBackColor = true;
            this.btnEddit.Click += new System.EventHandler(this.btnEddit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(725, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(582, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // stateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 392);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEddit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "stateFrom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ورود اطالاعات فایل ملک";
            this.Load += new System.EventHandler(this.stateFrom_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.labelSearch.ResumeLayout(false);
            this.labelSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox labelSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgState;
        private System.Windows.Forms.ToolStripButton btnRefreshFile;
        private System.Windows.Forms.ToolStripButton btnAddFile;
        private System.Windows.Forms.Button btnEddit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMalek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}