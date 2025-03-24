namespace ITI_EF.PL
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studGrid = new DataGridView();
            LoadBtn = new Button();
            fnameLbl = new TextBox();
            lnameLbl = new TextBox();
            ageLbl = new TextBox();
            addLbl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            deptCompo = new ComboBox();
            addBtn = new Button();
            updateBtn = new Button();
            delBtn = new Button();
            resetBtn = new Button();
            deptBtn = new Button();
            fillStud = new ComboBox();
            label7 = new Label();
            idLbl = new TextBox();
            CrsBtn = new Button();
            insBtn = new Button();
            studCrsBtn = new Button();
            insCrsBtn = new Button();
            topicBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studGrid).BeginInit();
            SuspendLayout();
            // 
            // studGrid
            // 
            studGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studGrid.Location = new Point(3, 40);
            studGrid.Name = "studGrid";
            studGrid.RowHeadersWidth = 51;
            studGrid.Size = new Size(893, 447);
            studGrid.TabIndex = 0;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(953, 485);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // fnameLbl
            // 
            fnameLbl.Location = new Point(1047, 146);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new Size(154, 27);
            fnameLbl.TabIndex = 2;
            // 
            // lnameLbl
            // 
            lnameLbl.Location = new Point(1047, 196);
            lnameLbl.Name = "lnameLbl";
            lnameLbl.Size = new Size(154, 27);
            lnameLbl.TabIndex = 3;
            // 
            // ageLbl
            // 
            ageLbl.Location = new Point(1047, 246);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(154, 27);
            ageLbl.TabIndex = 4;
            // 
            // addLbl
            // 
            addLbl.Location = new Point(1047, 311);
            addLbl.Name = "addLbl";
            addLbl.Size = new Size(154, 27);
            addLbl.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(953, 153);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(953, 203);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(968, 253);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 10;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(953, 311);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(935, 369);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 12;
            label5.Text = "Department Id";
            // 
            // deptCompo
            // 
            deptCompo.FormattingEnabled = true;
            deptCompo.Location = new Point(1047, 366);
            deptCompo.Name = "deptCompo";
            deptCompo.Size = new Size(151, 28);
            deptCompo.TabIndex = 14;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(921, 432);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 16;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1021, 432);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 17;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1121, 432);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 18;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(1074, 485);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 19;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // deptBtn
            // 
            deptBtn.Location = new Point(30, 521);
            deptBtn.Name = "deptBtn";
            deptBtn.Size = new Size(122, 29);
            deptBtn.TabIndex = 20;
            deptBtn.Text = "Department";
            deptBtn.UseVisualStyleBackColor = true;
            deptBtn.Click += deptBtn_Click;
            // 
            // fillStud
            // 
            fillStud.FormattingEnabled = true;
            fillStud.Location = new Point(994, 27);
            fillStud.Name = "fillStud";
            fillStud.Size = new Size(151, 28);
            fillStud.TabIndex = 21;
            fillStud.SelectedIndexChanged += fillStud_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(973, 111);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 22;
            label7.Text = "Id";
            // 
            // idLbl
            // 
            idLbl.Enabled = false;
            idLbl.Location = new Point(1061, 104);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(125, 27);
            idLbl.TabIndex = 23;
            // 
            // CrsBtn
            // 
            CrsBtn.Location = new Point(199, 521);
            CrsBtn.Name = "CrsBtn";
            CrsBtn.Size = new Size(94, 29);
            CrsBtn.TabIndex = 24;
            CrsBtn.Text = "Course";
            CrsBtn.UseVisualStyleBackColor = true;
            CrsBtn.Click += CrsBtn_Click;
            // 
            // insBtn
            // 
            insBtn.Location = new Point(322, 521);
            insBtn.Name = "insBtn";
            insBtn.Size = new Size(94, 29);
            insBtn.TabIndex = 25;
            insBtn.Text = "Instructor";
            insBtn.UseVisualStyleBackColor = true;
            insBtn.Click += insBtn_Click;
            // 
            // studCrsBtn
            // 
            studCrsBtn.Location = new Point(440, 521);
            studCrsBtn.Name = "studCrsBtn";
            studCrsBtn.Size = new Size(122, 29);
            studCrsBtn.TabIndex = 26;
            studCrsBtn.Text = "StudentCourse";
            studCrsBtn.UseVisualStyleBackColor = true;
            studCrsBtn.Click += studCrsBtn_Click;
            // 
            // insCrsBtn
            // 
            insCrsBtn.Location = new Point(580, 521);
            insCrsBtn.Name = "insCrsBtn";
            insCrsBtn.Size = new Size(147, 29);
            insCrsBtn.TabIndex = 27;
            insCrsBtn.Text = "Instructor Course";
            insCrsBtn.UseVisualStyleBackColor = true;
            insCrsBtn.Click += insCrsBtn_Click;
            // 
            // topicBtn
            // 
            topicBtn.Location = new Point(746, 521);
            topicBtn.Name = "topicBtn";
            topicBtn.Size = new Size(122, 29);
            topicBtn.TabIndex = 28;
            topicBtn.Text = "Topic";
            topicBtn.UseVisualStyleBackColor = true;
            topicBtn.Click += topicBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 609);
            Controls.Add(topicBtn);
            Controls.Add(insCrsBtn);
            Controls.Add(studCrsBtn);
            Controls.Add(insBtn);
            Controls.Add(CrsBtn);
            Controls.Add(idLbl);
            Controls.Add(label7);
            Controls.Add(fillStud);
            Controls.Add(deptBtn);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(deptCompo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addLbl);
            Controls.Add(ageLbl);
            Controls.Add(lnameLbl);
            Controls.Add(fnameLbl);
            Controls.Add(LoadBtn);
            Controls.Add(studGrid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studGrid;
        private Button LoadBtn;
        private TextBox fnameLbl;
        private TextBox lnameLbl;
        private TextBox ageLbl;
        private TextBox addLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox deptCompo;
        private Button addBtn;
        private Button updateBtn;
        private Button delBtn;
        private Button resetBtn;
        private Button deptBtn;
        private ComboBox fillStud;
        private Label label7;
        private TextBox idLbl;
        private Button CrsBtn;
        private Button insBtn;
        private Button studCrsBtn;
        private Button insCrsBtn;
        private Button topicBtn;
    }
}
