namespace ITI_EF.PL
{
    partial class StudentCourseForm
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
            studentCompo = new ComboBox();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            label1 = new Label();
            gradeLbl = new TextBox();
            LoadBtn = new Button();
            studentCourseGrid = new DataGridView();
            deptCloseBtn = new Button();
            courseCompo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)studentCourseGrid).BeginInit();
            SuspendLayout();
            // 
            // studentCompo
            // 
            studentCompo.FormattingEnabled = true;
            studentCompo.Location = new Point(1202, 76);
            studentCompo.Name = "studentCompo";
            studentCompo.Size = new Size(151, 28);
            studentCompo.TabIndex = 73;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(651, 510);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 72;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1110, 419);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 71;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1110, 371);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 70;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1110, 326);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 69;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1110, 206);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 66;
            label1.Text = " Salary";
            // 
            // gradeLbl
            // 
            gradeLbl.Location = new Point(1202, 199);
            gradeLbl.Name = "gradeLbl";
            gradeLbl.Size = new Size(154, 27);
            gradeLbl.TabIndex = 63;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(227, 510);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 62;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // studentCourseGrid
            // 
            studentCourseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentCourseGrid.Location = new Point(90, 22);
            studentCourseGrid.Name = "studentCourseGrid";
            studentCourseGrid.RowHeadersWidth = 51;
            studentCourseGrid.Size = new Size(893, 447);
            studentCourseGrid.TabIndex = 61;
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1336, 440);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 60;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // courseCompo
            // 
            courseCompo.FormattingEnabled = true;
            courseCompo.Location = new Point(1202, 135);
            courseCompo.Name = "courseCompo";
            courseCompo.Size = new Size(151, 28);
            courseCompo.TabIndex = 76;
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 560);
            Controls.Add(courseCompo);
            Controls.Add(studentCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(gradeLbl);
            Controls.Add(LoadBtn);
            Controls.Add(studentCourseGrid);
            Controls.Add(deptCloseBtn);
            Name = "StudentCourseForm";
            Text = "StudentCourse";
            ((System.ComponentModel.ISupportInitialize)studentCourseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox idLbl;
        private ComboBox studentCompo;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox salaryLbl;
        private TextBox degreeLbl;
        private TextBox gradeLbl;
        private Button LoadBtn;
        private DataGridView studentCourseGrid;
        private Button deptCloseBtn;
        private ComboBox courseCompo;
    }
}