namespace ITI_EF.PL
{
    partial class TopicForm
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
            tIdLbl = new TextBox();
            topicCompo = new ComboBox();
            resetBtn = new Button();
            delBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            label1 = new Label();
            topicNameLbl = new TextBox();
            LoadBtn = new Button();
            topicGrid = new DataGridView();
            deptCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)topicGrid).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1027, 255);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 75;
            label4.Text = "Id";
            // 
            // tIdLbl
            // 
            tIdLbl.Enabled = false;
            tIdLbl.Location = new Point(1122, 246);
            tIdLbl.Name = "tIdLbl";
            tIdLbl.Size = new Size(125, 27);
            tIdLbl.TabIndex = 74;
            // 
            // topicCompo
            // 
            topicCompo.FormattingEnabled = true;
            topicCompo.Location = new Point(1093, 118);
            topicCompo.Name = "topicCompo";
            topicCompo.Size = new Size(151, 28);
            topicCompo.TabIndex = 73;
            topicCompo.SelectedIndexChanged += topicCompo_SelectedIndexChanged;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(779, 514);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 29);
            resetBtn.TabIndex = 72;
            resetBtn.Text = "reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(1189, 359);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 71;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(1080, 359);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 70;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(968, 359);
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
            label1.Location = new Point(1013, 192);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 65;
            label1.Text = "Name";
            // 
            // topicNameLbl
            // 
            topicNameLbl.Location = new Point(1093, 185);
            topicNameLbl.Name = "topicNameLbl";
            topicNameLbl.Size = new Size(154, 27);
            topicNameLbl.TabIndex = 63;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(606, 514);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 62;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // topicGrid
            // 
            topicGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            topicGrid.Location = new Point(32, 35);
            topicGrid.Name = "topicGrid";
            topicGrid.RowHeadersWidth = 51;
            topicGrid.Size = new Size(893, 447);
            topicGrid.TabIndex = 61;
            // 
            // deptCloseBtn
            // 
            deptCloseBtn.Location = new Point(1093, 453);
            deptCloseBtn.Name = "deptCloseBtn";
            deptCloseBtn.Size = new Size(94, 29);
            deptCloseBtn.TabIndex = 60;
            deptCloseBtn.Text = "Close";
            deptCloseBtn.UseVisualStyleBackColor = true;
            deptCloseBtn.Click += deptCloseBtn_Click;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 582);
            Controls.Add(label4);
            Controls.Add(tIdLbl);
            Controls.Add(topicCompo);
            Controls.Add(resetBtn);
            Controls.Add(delBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(topicNameLbl);
            Controls.Add(LoadBtn);
            Controls.Add(topicGrid);
            Controls.Add(deptCloseBtn);
            Name = "TopicForm";
            Text = "TopicForm";
            ((System.ComponentModel.ISupportInitialize)topicGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tIdLbl;
        private ComboBox topicCompo;
        private Button resetBtn;
        private Button delBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label label1;
        private TextBox topicNameLbl;
        private Button LoadBtn;
        private DataGridView topicGrid;
        private Button deptCloseBtn;
    }
}