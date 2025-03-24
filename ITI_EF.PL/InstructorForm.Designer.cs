namespace ITI_EF.PL
{
    partial class InstructorForm
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
            label4 = new Label();
            idLbl = new TextBox();
            instructorCompo = new ComboBox();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            salaryLbl = new TextBox();
            degreeLbl = new TextBox();
            nameLbl = new TextBox();
            LoadBtn = new Button();
            instructorGrid = new DataGridView();
            deptCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)instructorGrid).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1063, 310);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 59;
            label4.Text = "Id";
            // 
            // idLbl
            // 
            idLbl.Enabled = false;
            idLbl.Location = new Point(1158, 301);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(125, 27);
            idLbl.TabIndex = 58;
            // 
            // instructorCompo
            // 
            instructorCompo.FormattingEnabled = true;
            instructorCompo.Location = new Point(1135, 63);
            instructorCompo.Name = "instructorCompo";
            instructorCompo.Size = new Size(151, 28);
            instructorCompo.TabIndex = 57;
            instructorCompo.SelectedIndexChanged += instructorCompo_SelectedIndexChanged;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(601, 551);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 56;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click_1;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1060, 460);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 55;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1060, 412);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 54;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1060, 367);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 53;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1034, 250);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 50;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1027, 193);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 49;
            label2.Text = "degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1027, 154);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 48;
            label1.Text = " Name";
            // 
            // salaryLbl
            // 
            salaryLbl.Location = new Point(1135, 243);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(154, 27);
            salaryLbl.TabIndex = 47;
            // 
            // degreeLbl
            // 
            degreeLbl.Location = new Point(1135, 193);
            degreeLbl.Name = "degreeLbl";
            degreeLbl.Size = new Size(154, 27);
            degreeLbl.TabIndex = 46;
            // 
            // nameLbl
            // 
            nameLbl.Location = new Point(1135, 147);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(154, 27);
            nameLbl.TabIndex = 45;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(177, 551);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 44;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // instructorGrid
            // 
            instructorGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            instructorGrid.Location = new Point(40, 63);
            instructorGrid.Name = "instructorGrid";
            instructorGrid.RowHeadersWidth = 51;
            instructorGrid.Size = new Size(893, 447);
            instructorGrid.TabIndex = 43;
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1286, 481);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 42;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 644);
            Controls.Add(label4);
            Controls.Add(idLbl);
            Controls.Add(instructorCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salaryLbl);
            Controls.Add(degreeLbl);
            Controls.Add(nameLbl);
            Controls.Add(LoadBtn);
            Controls.Add(instructorGrid);
            Controls.Add(deptCloseBtn);
            Name = "InstructorForm";
            Text = "InstructorForm";
            ((System.ComponentModel.ISupportInitialize)instructorGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox idLbl;
        private ComboBox instructorCompo;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox salaryLbl;
        private TextBox degreeLbl;
        private TextBox nameLbl;
        private Button LoadBtn;
        private DataGridView instructorGrid;
        private Button deptCloseBtn;
    }
}