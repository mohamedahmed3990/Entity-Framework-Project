namespace ITI_EF.PL
{
    partial class CourseForm
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
            cIdLbl = new TextBox();
            courseCompo = new ComboBox();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            topicCompo = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            durLbl = new TextBox();
            cnameLbl = new TextBox();
            LoadBtn = new Button();
            courseGrid = new DataGridView();
            deptCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)courseGrid).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1013, 326);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 59;
            label4.Text = "Id";
            // 
            // cIdLbl
            // 
            cIdLbl.Enabled = false;
            cIdLbl.Location = new Point(1108, 317);
            cIdLbl.Name = "cIdLbl";
            cIdLbl.Size = new Size(125, 27);
            cIdLbl.TabIndex = 58;
            // 
            // courseCompo
            // 
            courseCompo.FormattingEnabled = true;
            courseCompo.Location = new Point(1048, 102);
            courseCompo.Name = "courseCompo";
            courseCompo.Size = new Size(151, 28);
            courseCompo.TabIndex = 57;
            courseCompo.SelectedIndexChanged += courseCompo_SelectedIndexChanged;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(551, 567);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 56;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1010, 476);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 55;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1010, 428);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 54;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1010, 383);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 53;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // topicCompo
            // 
            topicCompo.FormattingEnabled = true;
            topicCompo.Location = new Point(1082, 273);
            topicCompo.Name = "topicCompo";
            topicCompo.Size = new Size(151, 28);
            topicCompo.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1003, 276);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 51;
            label6.Text = "Topic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(981, 219);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 49;
            label2.Text = "Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(999, 176);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 48;
            label1.Text = "Name";
            // 
            // durLbl
            // 
            durLbl.Location = new Point(1082, 219);
            durLbl.Name = "durLbl";
            durLbl.Size = new Size(154, 27);
            durLbl.TabIndex = 46;
            // 
            // cnameLbl
            // 
            cnameLbl.Location = new Point(1079, 169);
            cnameLbl.Name = "cnameLbl";
            cnameLbl.Size = new Size(154, 27);
            cnameLbl.TabIndex = 45;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(127, 567);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 44;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // courseGrid
            // 
            courseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseGrid.Location = new Point(12, 58);
            courseGrid.Name = "courseGrid";
            courseGrid.RowHeadersWidth = 51;
            courseGrid.Size = new Size(893, 447);
            courseGrid.TabIndex = 43;
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1142, 567);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 42;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 674);
            Controls.Add(label4);
            Controls.Add(cIdLbl);
            Controls.Add(courseCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(topicCompo);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(durLbl);
            Controls.Add(cnameLbl);
            Controls.Add(LoadBtn);
            Controls.Add(courseGrid);
            Controls.Add(deptCloseBtn);
            Name = "CourseForm";
            Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)courseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox cIdLbl;
        private ComboBox courseCompo;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private ComboBox topicCompo;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox durLbl;
        private TextBox cnameLbl;
        private Button LoadBtn;
        private DataGridView courseGrid;
        private Button deptCloseBtn;
    }
}