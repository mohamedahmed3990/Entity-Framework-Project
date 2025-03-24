namespace ITI_EF.PL
{
    partial class InstructorCourseForm
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
            courseCompo = new ComboBox();
            instructorCompo = new ComboBox();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            label1 = new Label();
            evalLbl = new TextBox();
            LoadBtn = new Button();
            instructorCourseGrid = new DataGridView();
            deptCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)instructorCourseGrid).BeginInit();
            SuspendLayout();
            // 
            // courseCompo
            // 
            courseCompo.FormattingEnabled = true;
            courseCompo.Location = new Point(1115, 130);
            courseCompo.Name = "courseCompo";
            courseCompo.Size = new Size(151, 28);
            courseCompo.TabIndex = 87;
            // 
            // instructorCompo
            // 
            instructorCompo.FormattingEnabled = true;
            instructorCompo.Location = new Point(1115, 71);
            instructorCompo.Name = "instructorCompo";
            instructorCompo.Size = new Size(151, 28);
            instructorCompo.TabIndex = 86;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(564, 505);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 85;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1023, 414);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 84;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1023, 366);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 83;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1023, 321);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 82;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1023, 201);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 81;
            label1.Text = "Evaluation";
            // 
            // evalLbl
            // 
            evalLbl.Location = new Point(1115, 194);
            evalLbl.Name = "evalLbl";
            evalLbl.Size = new Size(154, 27);
            evalLbl.TabIndex = 80;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(140, 505);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 79;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // instructorCourseGrid
            // 
            instructorCourseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            instructorCourseGrid.Location = new Point(31, 17);
            instructorCourseGrid.Name = "instructorCourseGrid";
            instructorCourseGrid.RowHeadersWidth = 51;
            instructorCourseGrid.Size = new Size(893, 447);
            instructorCourseGrid.TabIndex = 78;
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1249, 435);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 77;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // InstructorCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 550);
            Controls.Add(courseCompo);
            Controls.Add(instructorCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(evalLbl);
            Controls.Add(LoadBtn);
            Controls.Add(instructorCourseGrid);
            Controls.Add(deptCloseBtn);
            Name = "InstructorCourseForm";
            Text = "InstructorCourseForm";
            ((System.ComponentModel.ISupportInitialize)instructorCourseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseCompo;
        private ComboBox instructorCompo;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label label1;
        private TextBox evalLbl;
        private Button LoadBtn;
        private DataGridView instructorCourseGrid;
        private Button deptCloseBtn;
    }
}