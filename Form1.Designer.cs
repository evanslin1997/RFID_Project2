using System.Linq;

namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.Sector = new System.Windows.Forms.ComboBox();
            this.Block = new System.Windows.Forms.ComboBox();
            this.KeyAB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tebReadData = new System.Windows.Forms.TextBox();
            this.BtnReadData = new System.Windows.Forms.Button();
            this.label_point4 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.but_CleanCard = new System.Windows.Forms.Button();
            this.but_SignCard = new System.Windows.Forms.Button();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.textBox_SignDay = new System.Windows.Forms.TextBox();
            this.textBox_MemName = new System.Windows.Forms.TextBox();
            this.textBox_MemID = new System.Windows.Forms.TextBox();
            this.label_point = new System.Windows.Forms.Label();
            this.label_SignDay = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_member = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.but_ReadCard = new System.Windows.Forms.Button();
            this.textBox_Point2 = new System.Windows.Forms.TextBox();
            this.textBox_SignDay2 = new System.Windows.Forms.TextBox();
            this.textBox_MemName2 = new System.Windows.Forms.TextBox();
            this.textBox_MemID2 = new System.Windows.Forms.TextBox();
            this.label_point2 = new System.Windows.Forms.Label();
            this.label_SignDay2 = new System.Windows.Forms.Label();
            this.label_name2 = new System.Windows.Forms.Label();
            this.label_member2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_message3 = new System.Windows.Forms.Label();
            this.but_AddPoint = new System.Windows.Forms.Button();
            this.textBox_Point3 = new System.Windows.Forms.TextBox();
            this.label_point3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbl_message4 = new System.Windows.Forms.Label();
            this.but_SpendPoint = new System.Windows.Forms.Button();
            this.textBox_Point4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tebWriteData = new System.Windows.Forms.TextBox();
            this.BtnWriteData = new System.Windows.Forms.Button();
            this.label_point4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Sector
            // 
            this.Sector.FormattingEnabled = true;
            this.Sector.Location = new System.Drawing.Point(19, 46);
            this.Sector.Margin = new System.Windows.Forms.Padding(4);
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(63, 23);
            this.Sector.TabIndex = 14;
            this.Sector.SelectedIndexChanged += new System.EventHandler(this.Sector_SelectedIndexChanged);
            // 
            // Block
            // 
            this.Block.FormattingEnabled = true;
            this.Block.Location = new System.Drawing.Point(104, 46);
            this.Block.Margin = new System.Windows.Forms.Padding(4);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(63, 23);
            this.Block.TabIndex = 15;
            this.Block.SelectedIndexChanged += new System.EventHandler(this.Block_SelectedIndexChanged);
            // 
            // KeyAB
            // 
            this.KeyAB.FormattingEnabled = true;
            this.KeyAB.Location = new System.Drawing.Point(188, 46);
            this.KeyAB.Margin = new System.Windows.Forms.Padding(4);
            this.KeyAB.Name = "KeyAB";
            this.KeyAB.Size = new System.Drawing.Size(63, 23);
            this.KeyAB.TabIndex = 16;
            this.KeyAB.SelectedIndexChanged += new System.EventHandler(this.KeyAB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sector :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Block :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "KeyAB :";
            // 
            // LoadKey
            // 
            this.LoadKey.Location = new System.Drawing.Point(276, 46);
            this.LoadKey.Margin = new System.Windows.Forms.Padding(4);
            this.LoadKey.Name = "LoadKey";
            this.LoadKey.Size = new System.Drawing.Size(132, 25);
            this.LoadKey.TabIndex = 20;
            this.LoadKey.Text = "FFFFFFFFFFFF";
            this.LoadKey.TextChanged += new System.EventHandler(this.LoadKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load Key :";
            // 
            // tebReadData
            // 
            this.tebReadData.Location = new System.Drawing.Point(19, 92);
            this.tebReadData.Margin = new System.Windows.Forms.Padding(4);
            this.tebReadData.Name = "tebReadData";
            this.tebReadData.Size = new System.Drawing.Size(291, 25);
            this.tebReadData.TabIndex = 22;
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(324, 92);
            this.BtnReadData.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(100, 29);
            this.BtnReadData.TabIndex = 23;
            this.BtnReadData.Text = "Read data";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // label_point4
            // 
            this.label_point4.Controls.Add(this.tabPage1);
            this.label_point4.Controls.Add(this.tabPage2);
            this.label_point4.Controls.Add(this.tabPage3);
            this.label_point4.Controls.Add(this.tabPage4);
            this.label_point4.Location = new System.Drawing.Point(21, 176);
            this.label_point4.Margin = new System.Windows.Forms.Padding(4);
            this.label_point4.Name = "label_point4";
            this.label_point4.SelectedIndex = 0;
            this.label_point4.Size = new System.Drawing.Size(403, 248);
            this.label_point4.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGreen;
            this.tabPage1.Controls.Add(this.but_CleanCard);
            this.tabPage1.Controls.Add(this.but_SignCard);
            this.tabPage1.Controls.Add(this.textBox_Point);
            this.tabPage1.Controls.Add(this.textBox_SignDay);
            this.tabPage1.Controls.Add(this.textBox_MemName);
            this.tabPage1.Controls.Add(this.textBox_MemID);
            this.tabPage1.Controls.Add(this.label_point);
            this.tabPage1.Controls.Add(this.label_SignDay);
            this.tabPage1.Controls.Add(this.label_name);
            this.tabPage1.Controls.Add(this.label_member);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(395, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "發卡";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // but_CleanCard
            // 
            this.but_CleanCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_CleanCard.Location = new System.Drawing.Point(271, 105);
            this.but_CleanCard.Margin = new System.Windows.Forms.Padding(4);
            this.but_CleanCard.Name = "but_CleanCard";
            this.but_CleanCard.Size = new System.Drawing.Size(100, 29);
            this.but_CleanCard.TabIndex = 9;
            this.but_CleanCard.Text = "清空卡片";
            this.but_CleanCard.UseVisualStyleBackColor = true;
            this.but_CleanCard.Click += new System.EventHandler(this.but_CleanCard_Click);
            // 
            // but_SignCard
            // 
            this.but_SignCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_SignCard.Location = new System.Drawing.Point(271, 64);
            this.but_SignCard.Margin = new System.Windows.Forms.Padding(4);
            this.but_SignCard.Name = "but_SignCard";
            this.but_SignCard.Size = new System.Drawing.Size(100, 29);
            this.but_SignCard.TabIndex = 8;
            this.but_SignCard.Text = "卡片製作";
            this.but_SignCard.UseVisualStyleBackColor = true;
            this.but_SignCard.Click += new System.EventHandler(this.but_SignCard_Click);
            // 
            // textBox_Point
            // 
            this.textBox_Point.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point.Location = new System.Drawing.Point(113, 138);
            this.textBox_Point.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point.TabIndex = 7;
            this.textBox_Point.Text = "9999";
            // 
            // textBox_SignDay
            // 
            this.textBox_SignDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_SignDay.Location = new System.Drawing.Point(113, 101);
            this.textBox_SignDay.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SignDay.Name = "textBox_SignDay";
            this.textBox_SignDay.Size = new System.Drawing.Size(132, 30);
            this.textBox_SignDay.TabIndex = 6;
            this.textBox_SignDay.Text = "2019/11/20";
            this.textBox_SignDay.TextChanged += new System.EventHandler(this.textBox_SignDay_TextChanged);
            // 
            // textBox_MemName
            // 
            this.textBox_MemName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_MemName.Location = new System.Drawing.Point(113, 66);
            this.textBox_MemName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemName.Name = "textBox_MemName";
            this.textBox_MemName.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemName.TabIndex = 5;
            this.textBox_MemName.Text = "林雅姿";
            this.textBox_MemName.TextChanged += new System.EventHandler(this.textBox_MemName_TextChanged);
            // 
            // textBox_MemID
            // 
            this.textBox_MemID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_MemID.Location = new System.Drawing.Point(113, 31);
            this.textBox_MemID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemID.Name = "textBox_MemID";
            this.textBox_MemID.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemID.TabIndex = 4;
            this.textBox_MemID.Text = "C5303246";
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point.Location = new System.Drawing.Point(27, 141);
            this.label_point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(44, 22);
            this.label_point.TabIndex = 3;
            this.label_point.Text = "點數";
            // 
            // label_SignDay
            // 
            this.label_SignDay.AutoSize = true;
            this.label_SignDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_SignDay.Location = new System.Drawing.Point(27, 105);
            this.label_SignDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SignDay.Name = "label_SignDay";
            this.label_SignDay.Size = new System.Drawing.Size(78, 22);
            this.label_SignDay.TabIndex = 2;
            this.label_SignDay.Text = "申請日期";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_name.Location = new System.Drawing.Point(27, 70);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 22);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓名";
            // 
            // label_member
            // 
            this.label_member.AutoSize = true;
            this.label_member.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_member.Location = new System.Drawing.Point(27, 35);
            this.label_member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_member.Name = "label_member";
            this.label_member.Size = new System.Drawing.Size(78, 22);
            this.label_member.TabIndex = 0;
            this.label_member.Text = "會員編號";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Plum;
            this.tabPage2.Controls.Add(this.but_ReadCard);
            this.tabPage2.Controls.Add(this.textBox_Point2);
            this.tabPage2.Controls.Add(this.textBox_SignDay2);
            this.tabPage2.Controls.Add(this.textBox_MemName2);
            this.tabPage2.Controls.Add(this.textBox_MemID2);
            this.tabPage2.Controls.Add(this.label_point2);
            this.tabPage2.Controls.Add(this.label_SignDay2);
            this.tabPage2.Controls.Add(this.label_name2);
            this.tabPage2.Controls.Add(this.label_member2);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(395, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查詢";
            // 
            // but_ReadCard
            // 
            this.but_ReadCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_ReadCard.Location = new System.Drawing.Point(268, 64);
            this.but_ReadCard.Margin = new System.Windows.Forms.Padding(4);
            this.but_ReadCard.Name = "but_ReadCard";
            this.but_ReadCard.Size = new System.Drawing.Size(100, 29);
            this.but_ReadCard.TabIndex = 9;
            this.but_ReadCard.Text = "讀取卡片";
            this.but_ReadCard.UseVisualStyleBackColor = true;
            this.but_ReadCard.Click += new System.EventHandler(this.but_ReadCard_Click);
            // 
            // textBox_Point2
            // 
            this.textBox_Point2.Location = new System.Drawing.Point(113, 138);
            this.textBox_Point2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point2.Name = "textBox_Point2";
            this.textBox_Point2.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point2.TabIndex = 8;
            // 
            // textBox_SignDay2
            // 
            this.textBox_SignDay2.Location = new System.Drawing.Point(113, 101);
            this.textBox_SignDay2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SignDay2.Name = "textBox_SignDay2";
            this.textBox_SignDay2.Size = new System.Drawing.Size(132, 30);
            this.textBox_SignDay2.TabIndex = 7;
            // 
            // textBox_MemName2
            // 
            this.textBox_MemName2.Location = new System.Drawing.Point(113, 66);
            this.textBox_MemName2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemName2.Name = "textBox_MemName2";
            this.textBox_MemName2.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemName2.TabIndex = 6;
            // 
            // textBox_MemID2
            // 
            this.textBox_MemID2.Location = new System.Drawing.Point(113, 31);
            this.textBox_MemID2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemID2.Name = "textBox_MemID2";
            this.textBox_MemID2.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemID2.TabIndex = 5;
            // 
            // label_point2
            // 
            this.label_point2.AutoSize = true;
            this.label_point2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point2.Location = new System.Drawing.Point(27, 141);
            this.label_point2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point2.Name = "label_point2";
            this.label_point2.Size = new System.Drawing.Size(44, 22);
            this.label_point2.TabIndex = 4;
            this.label_point2.Text = "點數";
            // 
            // label_SignDay2
            // 
            this.label_SignDay2.AutoSize = true;
            this.label_SignDay2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_SignDay2.Location = new System.Drawing.Point(27, 105);
            this.label_SignDay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SignDay2.Name = "label_SignDay2";
            this.label_SignDay2.Size = new System.Drawing.Size(78, 22);
            this.label_SignDay2.TabIndex = 3;
            this.label_SignDay2.Text = "申請日期";
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_name2.Location = new System.Drawing.Point(27, 70);
            this.label_name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(44, 22);
            this.label_name2.TabIndex = 2;
            this.label_name2.Text = "姓名";
            // 
            // label_member2
            // 
            this.label_member2.AutoSize = true;
            this.label_member2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_member2.Location = new System.Drawing.Point(27, 35);
            this.label_member2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_member2.Name = "label_member2";
            this.label_member2.Size = new System.Drawing.Size(78, 22);
            this.label_member2.TabIndex = 1;
            this.label_member2.Text = "會員編號";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage3.Controls.Add(this.lbl_message3);
            this.tabPage3.Controls.Add(this.but_AddPoint);
            this.tabPage3.Controls.Add(this.textBox_Point3);
            this.tabPage3.Controls.Add(this.label_point3);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(395, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "儲值";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lbl_message3
            // 
            this.lbl_message3.AutoSize = true;
            this.lbl_message3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_message3.ForeColor = System.Drawing.Color.Blue;
            this.lbl_message3.Location = new System.Drawing.Point(43, 119);
            this.lbl_message3.Name = "lbl_message3";
            this.lbl_message3.Size = new System.Drawing.Size(266, 31);
            this.lbl_message3.TabIndex = 3;
            this.lbl_message3.Text = "~您好，歡迎儲值點數~";
            // 
            // but_AddPoint
            // 
            this.but_AddPoint.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_AddPoint.Location = new System.Drawing.Point(252, 65);
            this.but_AddPoint.Margin = new System.Windows.Forms.Padding(4);
            this.but_AddPoint.Name = "but_AddPoint";
            this.but_AddPoint.Size = new System.Drawing.Size(100, 29);
            this.but_AddPoint.TabIndex = 2;
            this.but_AddPoint.Text = "加值點數";
            this.but_AddPoint.UseVisualStyleBackColor = true;
            this.but_AddPoint.Click += new System.EventHandler(this.but_AddPoint_Click);
            // 
            // textBox_Point3
            // 
            this.textBox_Point3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point3.Location = new System.Drawing.Point(95, 65);
            this.textBox_Point3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point3.Name = "textBox_Point3";
            this.textBox_Point3.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point3.TabIndex = 1;
            this.textBox_Point3.Text = "100";
            // 
            // label_point3
            // 
            this.label_point3.AutoSize = true;
            this.label_point3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point3.Location = new System.Drawing.Point(32, 70);
            this.label_point3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point3.Name = "label_point3";
            this.label_point3.Size = new System.Drawing.Size(44, 22);
            this.label_point3.TabIndex = 0;
            this.label_point3.Text = "點數";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Pink;
            this.tabPage4.Controls.Add(this.lbl_message4);
            this.tabPage4.Controls.Add(this.but_SpendPoint);
            this.tabPage4.Controls.Add(this.textBox_Point4);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(395, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "消費";
            // 
            // lbl_message4
            // 
            this.lbl_message4.AutoSize = true;
            this.lbl_message4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_message4.ForeColor = System.Drawing.Color.Blue;
            this.lbl_message4.Location = new System.Drawing.Point(32, 103);
            this.lbl_message4.Name = "lbl_message4";
            this.lbl_message4.Size = new System.Drawing.Size(218, 31);
            this.lbl_message4.TabIndex = 3;
            this.lbl_message4.Text = "~您好，歡迎消費~";
            // 
            // but_SpendPoint
            // 
            this.but_SpendPoint.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_SpendPoint.Location = new System.Drawing.Point(252, 65);
            this.but_SpendPoint.Margin = new System.Windows.Forms.Padding(4);
            this.but_SpendPoint.Name = "but_SpendPoint";
            this.but_SpendPoint.Size = new System.Drawing.Size(100, 29);
            this.but_SpendPoint.TabIndex = 2;
            this.but_SpendPoint.Text = "消費點數";
            this.but_SpendPoint.UseVisualStyleBackColor = true;
            this.but_SpendPoint.Click += new System.EventHandler(this.but_SpendPoint_Click);
            // 
            // textBox_Point4
            // 
            this.textBox_Point4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point4.Location = new System.Drawing.Point(95, 65);
            this.textBox_Point4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point4.Name = "textBox_Point4";
            this.textBox_Point4.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point4.TabIndex = 1;
            this.textBox_Point4.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "點數";
            // 
            // tebWriteData
            // 
            this.tebWriteData.Location = new System.Drawing.Point(19, 128);
            this.tebWriteData.Margin = new System.Windows.Forms.Padding(4);
            this.tebWriteData.Name = "tebWriteData";
            this.tebWriteData.Size = new System.Drawing.Size(291, 25);
            this.tebWriteData.TabIndex = 25;
            this.tebWriteData.TextChanged += new System.EventHandler(this.tebWriteData_TextChanged);
            // 
            // BtnWriteData
            // 
            this.BtnWriteData.Location = new System.Drawing.Point(324, 129);
            this.BtnWriteData.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWriteData.Name = "BtnWriteData";
            this.BtnWriteData.Size = new System.Drawing.Size(100, 29);
            this.BtnWriteData.TabIndex = 26;
            this.BtnWriteData.Text = "Write data";
            this.BtnWriteData.UseVisualStyleBackColor = true;
            this.BtnWriteData.Click += new System.EventHandler(this.BtnWriteData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.BtnWriteData);
            this.Controls.Add(this.tebWriteData);
            this.Controls.Add(this.label_point4);
            this.Controls.Add(this.BtnReadData);
            this.Controls.Add(this.tebReadData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyAB);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.Sector);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab2電子錢包";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.label_point4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox Sector;
        private System.Windows.Forms.ComboBox Block;
        private System.Windows.Forms.ComboBox KeyAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoadKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tebReadData;
        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.TabControl label_point4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button but_CleanCard;
        private System.Windows.Forms.Button but_SignCard;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.TextBox textBox_SignDay;
        private System.Windows.Forms.TextBox textBox_MemName;
        private System.Windows.Forms.TextBox textBox_MemID;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.Label label_SignDay;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_member;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button but_ReadCard;
        private System.Windows.Forms.TextBox textBox_Point2;
        private System.Windows.Forms.TextBox textBox_SignDay2;
        private System.Windows.Forms.TextBox textBox_MemName2;
        private System.Windows.Forms.TextBox textBox_MemID2;
        private System.Windows.Forms.Label label_point2;
        private System.Windows.Forms.Label label_SignDay2;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.Label label_member2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button but_AddPoint;
        private System.Windows.Forms.TextBox textBox_Point3;
        private System.Windows.Forms.Label label_point3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button but_SpendPoint;
        private System.Windows.Forms.TextBox textBox_Point4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tebWriteData;
        private System.Windows.Forms.Button BtnWriteData;
        private System.Windows.Forms.Label lbl_message3;
        private System.Windows.Forms.Label lbl_message4;
    }
}

