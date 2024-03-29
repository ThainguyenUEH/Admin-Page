namespace Admin
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.QuestionsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectButtonQ = new System.Windows.Forms.Button();
            this.SaveButtonQ = new System.Windows.Forms.Button();
            this.QuestionsDataView = new System.Windows.Forms.DataGridView();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.StudentsDataView = new System.Windows.Forms.DataGridView();
            this.AccountsPage = new System.Windows.Forms.TabPage();
            this.AccountsDataView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StartServerBut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayingTimeTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Access = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.QuestionsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataView)).BeginInit();
            this.StudentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).BeginInit();
            this.AccountsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.QuestionsPage);
            this.Tabs.Controls.Add(this.StudentsPage);
            this.Tabs.Controls.Add(this.AccountsPage);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1099, 564);
            this.Tabs.TabIndex = 0;
            // 
            // QuestionsPage
            // 
            this.QuestionsPage.Controls.Add(this.groupBox2);
            this.QuestionsPage.Controls.Add(this.QuestionsDataView);
            this.QuestionsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuestionsPage.Location = new System.Drawing.Point(4, 25);
            this.QuestionsPage.Name = "QuestionsPage";
            this.QuestionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuestionsPage.Size = new System.Drawing.Size(1091, 535);
            this.QuestionsPage.TabIndex = 0;
            this.QuestionsPage.Text = "Questions";
            this.QuestionsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectButtonQ);
            this.groupBox2.Controls.Add(this.SaveButtonQ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // ConnectButtonQ
            // 
            this.ConnectButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButtonQ.Location = new System.Drawing.Point(36, 26);
            this.ConnectButtonQ.Name = "ConnectButtonQ";
            this.ConnectButtonQ.Size = new System.Drawing.Size(250, 70);
            this.ConnectButtonQ.TabIndex = 9;
            this.ConnectButtonQ.Text = "Kết nối";
            this.ConnectButtonQ.UseVisualStyleBackColor = true;
            this.ConnectButtonQ.Click += new System.EventHandler(this.ConnectButtonQ_Click);
            // 
            // SaveButtonQ
            // 
            this.SaveButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButtonQ.Location = new System.Drawing.Point(700, 26);
            this.SaveButtonQ.Name = "SaveButtonQ";
            this.SaveButtonQ.Size = new System.Drawing.Size(250, 70);
            this.SaveButtonQ.TabIndex = 3;
            this.SaveButtonQ.Text = "Lưu";
            this.SaveButtonQ.UseVisualStyleBackColor = true;
            this.SaveButtonQ.Click += new System.EventHandler(this.SaveButtonQ_Click);
            // 
            // QuestionsDataView
            // 
            this.QuestionsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsDataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.QuestionsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.QuestionsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuestionsDataView.Location = new System.Drawing.Point(3, 3);
            this.QuestionsDataView.Name = "QuestionsDataView";
            this.QuestionsDataView.RowHeadersWidth = 51;
            this.QuestionsDataView.RowTemplate.Height = 24;
            this.QuestionsDataView.Size = new System.Drawing.Size(1085, 510);
            this.QuestionsDataView.TabIndex = 0;
            this.QuestionsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionsDataView_CellValueChanged);
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.StudentsDataView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 25);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsPage.Size = new System.Drawing.Size(1091, 535);
            this.StudentsPage.TabIndex = 1;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // StudentsDataView
            // 
            this.StudentsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StudentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataView.DefaultCellStyle = dataGridViewCellStyle5;
            this.StudentsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StudentsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentsDataView.Location = new System.Drawing.Point(3, 3);
            this.StudentsDataView.Name = "StudentsDataView";
            this.StudentsDataView.RowHeadersWidth = 51;
            this.StudentsDataView.RowTemplate.Height = 24;
            this.StudentsDataView.Size = new System.Drawing.Size(1085, 510);
            this.StudentsDataView.TabIndex = 1;
            this.StudentsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataView_CellValueChanged);
            // 
            // AccountsPage
            // 
            this.AccountsPage.Controls.Add(this.AccountsDataView);
            this.AccountsPage.Location = new System.Drawing.Point(4, 25);
            this.AccountsPage.Name = "AccountsPage";
            this.AccountsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPage.Size = new System.Drawing.Size(1091, 535);
            this.AccountsPage.TabIndex = 2;
            this.AccountsPage.Text = "Accounts";
            this.AccountsPage.UseVisualStyleBackColor = true;
            // 
            // AccountsDataView
            // 
            this.AccountsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AccountsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccountsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AccountsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountsDataView.Location = new System.Drawing.Point(3, 3);
            this.AccountsDataView.Name = "AccountsDataView";
            this.AccountsDataView.RowHeadersWidth = 51;
            this.AccountsDataView.RowTemplate.Height = 24;
            this.AccountsDataView.Size = new System.Drawing.Size(1085, 510);
            this.AccountsDataView.TabIndex = 1;
            this.AccountsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsDataView_CellValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StartServerBut);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 535);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Game Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StartServerBut
            // 
            this.StartServerBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerBut.Location = new System.Drawing.Point(399, 417);
            this.StartServerBut.Name = "StartServerBut";
            this.StartServerBut.Size = new System.Drawing.Size(299, 77);
            this.StartServerBut.TabIndex = 4;
            this.StartServerBut.Text = "Bắt đầu máy chủ";
            this.StartServerBut.UseVisualStyleBackColor = true;
            this.StartServerBut.Click += new System.EventHandler(this.StartServerBut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.PlayingTimeTxtBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.GamePasswordTxtBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1085, 529);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Các cài đặt trong game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian phòng game:";
            // 
            // PlayingTimeTxtBox
            // 
            this.PlayingTimeTxtBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PlayingTimeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingTimeTxtBox.Location = new System.Drawing.Point(508, 241);
            this.PlayingTimeTxtBox.Name = "PlayingTimeTxtBox";
            this.PlayingTimeTxtBox.Size = new System.Drawing.Size(195, 34);
            this.PlayingTimeTxtBox.TabIndex = 1;
            this.PlayingTimeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayingTimeTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu phòng game:";
            // 
            // GamePasswordTxtBox
            // 
            this.GamePasswordTxtBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.GamePasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePasswordTxtBox.Location = new System.Drawing.Point(508, 180);
            this.GamePasswordTxtBox.Name = "GamePasswordTxtBox";
            this.GamePasswordTxtBox.Size = new System.Drawing.Size(267, 34);
            this.GamePasswordTxtBox.TabIndex = 0;
            this.GamePasswordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GamePasswordTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(726, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giây";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Access);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 113);
            this.panel1.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(906, 28);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 60);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(266, 28);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 60);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // btn_Access
            // 
            this.btn_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Access.Location = new System.Drawing.Point(52, 28);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.Size = new System.Drawing.Size(140, 60);
            this.btn_Access.TabIndex = 0;
            this.btn_Access.Text = "Kết nối";
            this.btn_Access.UseVisualStyleBackColor = true;
            this.btn_Access.Click += new System.EventHandler(this.Connect_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_Delete.Location = new System.Drawing.Point(487, 28);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 60);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabs);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị TreasureGame";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Tabs.ResumeLayout(false);
            this.QuestionsPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataView)).EndInit();
            this.StudentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).EndInit();
            this.AccountsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage QuestionsPage;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.TabPage AccountsPage;
        private System.Windows.Forms.DataGridView QuestionsDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveButtonQ;
        private System.Windows.Forms.Button ConnectButtonQ;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox GamePasswordTxtBox;
        private System.Windows.Forms.TextBox PlayingTimeTxtBox;
        private System.Windows.Forms.Button StartServerBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Access;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView StudentsDataView;
        private System.Windows.Forms.DataGridView AccountsDataView;
        private System.Windows.Forms.Button btn_Delete;
    }
}