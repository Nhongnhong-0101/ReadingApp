namespace ReadingApp.UserControls
{
    partial class UCLibrary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnLasted = new Panel();
            flowRLs = new FlowLayoutPanel();
            label1 = new Label();
            pnSearch = new Panel();
            txtSearch = new TextBox();
            flowMain = new FlowLayoutPanel();
            picAvat = new PictureBox();
            btnAdd = new Button();
            pnNewList = new Panel();
            txtNewListName = new TextBox();
            btnAddStoryIntoRL = new Button();
            lbReadlingListName = new Label();
            btnDeleteAll = new Button();
            pnLasted.SuspendLayout();
            pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvat).BeginInit();
            pnNewList.SuspendLayout();
            SuspendLayout();
            // 
            // pnLasted
            // 
            pnLasted.BackgroundImage = Properties.Resources.bg_lasted;
            pnLasted.BackgroundImageLayout = ImageLayout.Stretch;
            pnLasted.Controls.Add(flowRLs);
            pnLasted.Controls.Add(label1);
            pnLasted.Location = new Point(30, 140);
            pnLasted.Name = "pnLasted";
            pnLasted.Size = new Size(750, 1323);
            pnLasted.TabIndex = 12;
            // 
            // flowRLs
            // 
            flowRLs.AutoScroll = true;
            flowRLs.BackColor = Color.Transparent;
            flowRLs.Location = new Point(30, 90);
            flowRLs.Name = "flowRLs";
            flowRLs.Size = new Size(680, 1215);
            flowRLs.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(724, 55);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đọc\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnSearch
            // 
            pnSearch.BackColor = Color.Transparent;
            pnSearch.BackgroundImage = Properties.Resources.bg_search;
            pnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            pnSearch.Controls.Add(txtSearch);
            pnSearch.Location = new Point(1191, 99);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(846, 70);
            pnSearch.TabIndex = 9;
            pnSearch.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(15, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm truyện thêm vào ";
            txtSearch.Size = new Size(828, 38);
            txtSearch.TabIndex = 4;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // flowMain
            // 
            flowMain.AutoScroll = true;
            flowMain.BackColor = Color.White;
            flowMain.Location = new Point(786, 189);
            flowMain.Name = "flowMain";
            flowMain.Size = new Size(1364, 1276);
            flowMain.TabIndex = 11;
            // 
            // picAvat
            // 
            picAvat.Image = Properties.Resources.image_user;
            picAvat.Location = new Point(2060, 30);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(90, 90);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 8;
            picAvat.TabStop = false;
            picAvat.Click += pictureBox1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 60);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Tạo mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnNewList
            // 
            pnNewList.BackColor = Color.Transparent;
            pnNewList.BackgroundImage = Properties.Resources.bg_search;
            pnNewList.BackgroundImageLayout = ImageLayout.Stretch;
            pnNewList.Controls.Add(txtNewListName);
            pnNewList.Location = new Point(210, 40);
            pnNewList.Name = "pnNewList";
            pnNewList.Size = new Size(539, 70);
            pnNewList.TabIndex = 10;
            pnNewList.Visible = false;
            // 
            // txtNewListName
            // 
            txtNewListName.BorderStyle = BorderStyle.None;
            txtNewListName.Font = new Font("Segoe UI", 12F);
            txtNewListName.ForeColor = Color.Black;
            txtNewListName.Location = new Point(15, 16);
            txtNewListName.Name = "txtNewListName";
            txtNewListName.PlaceholderText = "Tên danh sách đọc mới";
            txtNewListName.Size = new Size(510, 38);
            txtNewListName.TabIndex = 4;
            txtNewListName.KeyPress += txtNewListName_KeyPress;
            // 
            // btnAddStoryIntoRL
            // 
            btnAddStoryIntoRL.BackColor = Color.ForestGreen;
            btnAddStoryIntoRL.FlatStyle = FlatStyle.Flat;
            btnAddStoryIntoRL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddStoryIntoRL.ForeColor = Color.White;
            btnAddStoryIntoRL.Location = new Point(993, 102);
            btnAddStoryIntoRL.Name = "btnAddStoryIntoRL";
            btnAddStoryIntoRL.Size = new Size(182, 60);
            btnAddStoryIntoRL.TabIndex = 15;
            btnAddStoryIntoRL.Text = "Thêm truyện";
            btnAddStoryIntoRL.UseVisualStyleBackColor = false;
            btnAddStoryIntoRL.Click += btnAddStoryIntoRL_Click;
            // 
            // lbReadlingListName
            // 
            lbReadlingListName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbReadlingListName.ForeColor = Color.DarkGreen;
            lbReadlingListName.Location = new Point(800, 45);
            lbReadlingListName.Name = "lbReadlingListName";
            lbReadlingListName.Size = new Size(555, 54);
            lbReadlingListName.TabIndex = 1;
            lbReadlingListName.Text = "Danh sách đọc\r\n";
            lbReadlingListName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.ForestGreen;
            btnDeleteAll.FlatStyle = FlatStyle.Flat;
            btnDeleteAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(800, 102);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(182, 60);
            btnDeleteAll.TabIndex = 16;
            btnDeleteAll.Text = "Xóa tất cả";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // UCLibrary
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDeleteAll);
            Controls.Add(lbReadlingListName);
            Controls.Add(btnAddStoryIntoRL);
            Controls.Add(pnNewList);
            Controls.Add(btnAdd);
            Controls.Add(pnLasted);
            Controls.Add(pnSearch);
            Controls.Add(flowMain);
            Controls.Add(picAvat);
            Name = "UCLibrary";
            Size = new Size(2190, 1475);
            Load += UCLibrary_Load;
            pnLasted.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvat).EndInit();
            pnNewList.ResumeLayout(false);
            pnNewList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLasted;
        private Panel pnSearch;
        private TextBox txtSearch;
        private FlowLayoutPanel flowMain;
        private PictureBox picAvat;
        private Label label1;
        private Button btnAdd;
        private Panel pnNewList;
        private TextBox txtNewListName;
        private Button btnAddStoryIntoRL;
        private Label lbReadlingListName;
        private FlowLayoutPanel flowRLs;
        private Button btnDeleteAll;
    }
}
