namespace ITI_EF.PL
{
    partial class DepartmentForm
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
            deptCloseBtn = new Button();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            managerCompo = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dlocLbl = new TextBox();
            ddescLbl = new TextBox();
            dnameLbl = new TextBox();
            LoadBtn = new Button();
            deptGrid = new DataGridView();
            deptCompo = new ComboBox();
            dIdLbl = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)deptGrid).BeginInit();
            SuspendLayout();
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1348, 460);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 0;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(663, 530);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 38;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1122, 439);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 37;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1122, 391);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 36;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1122, 346);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 35;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // managerCompo
            // 
            managerCompo.FormattingEnabled = true;
            managerCompo.Location = new Point(1194, 236);
            managerCompo.Name = "managerCompo";
            managerCompo.Size = new Size(151, 28);
            managerCompo.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1091, 239);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 32;
            label6.Text = "Manager";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1093, 185);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 29;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1044, 135);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 28;
            label2.Text = "Department Desc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1044, 85);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 27;
            label1.Text = "Department Name";
            // 
            // dlocLbl
            // 
            dlocLbl.Location = new Point(1194, 178);
            dlocLbl.Name = "dlocLbl";
            dlocLbl.Size = new Size(154, 27);
            dlocLbl.TabIndex = 25;
            // 
            // ddescLbl
            // 
            ddescLbl.Location = new Point(1194, 128);
            ddescLbl.Name = "ddescLbl";
            ddescLbl.Size = new Size(154, 27);
            ddescLbl.TabIndex = 24;
            // 
            // dnameLbl
            // 
            dnameLbl.Location = new Point(1194, 82);
            dnameLbl.Name = "dnameLbl";
            dnameLbl.Size = new Size(154, 27);
            dnameLbl.TabIndex = 23;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(239, 530);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 22;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // deptGrid
            // 
            deptGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deptGrid.Location = new Point(102, 42);
            deptGrid.Name = "deptGrid";
            deptGrid.RowHeadersWidth = 51;
            deptGrid.Size = new Size(893, 447);
            deptGrid.TabIndex = 21;
            // 
            // deptCompo
            // 
            deptCompo.FormattingEnabled = true;
            deptCompo.Location = new Point(1197, 42);
            deptCompo.Name = "deptCompo";
            deptCompo.Size = new Size(151, 28);
            deptCompo.TabIndex = 39;
            deptCompo.SelectedIndexChanged += deptCompo_SelectedIndexChanged;
            // 
            // dIdLbl
            // 
            dIdLbl.Enabled = false;
            dIdLbl.Location = new Point(1220, 280);
            dIdLbl.Name = "dIdLbl";
            dIdLbl.Size = new Size(125, 27);
            dIdLbl.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1125, 289);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 41;
            label4.Text = "Id";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 606);
            Controls.Add(label4);
            Controls.Add(dIdLbl);
            Controls.Add(deptCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(managerCompo);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dlocLbl);
            Controls.Add(ddescLbl);
            Controls.Add(dnameLbl);
            Controls.Add(LoadBtn);
            Controls.Add(deptGrid);
            Controls.Add(deptCloseBtn);
            Name = "DepartmentForm";
            Text = "Department";
            ((System.ComponentModel.ISupportInitialize)deptGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deptCloseBtn;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private ComboBox managerCompo;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox dlocLbl;
        private TextBox ddescLbl;
        private TextBox dnameLbl;
        private Button LoadBtn;
        private DataGridView deptGrid;
        private ComboBox deptCompo;
        private TextBox dIdLbl;
        private Label label4;
    }
}