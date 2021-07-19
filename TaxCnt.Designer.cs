
namespace TaxFormHW
{
    partial class TaxCnt
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.from_dtp = new System.Windows.Forms.DateTimePicker();
            this.to_dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl_ans = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cc_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cartype_cbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton1.Location = new System.Drawing.Point(12, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全年度";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButton2.Location = new System.Drawing.Point(111, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "自選期間";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // from_dtp
            // 
            this.from_dtp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.from_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_dtp.Location = new System.Drawing.Point(231, 21);
            this.from_dtp.Name = "from_dtp";
            this.from_dtp.Size = new System.Drawing.Size(159, 29);
            this.from_dtp.TabIndex = 2;
            this.from_dtp.Visible = false;
            // 
            // to_dtp
            // 
            this.to_dtp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.to_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_dtp.Location = new System.Drawing.Point(438, 21);
            this.to_dtp.Name = "to_dtp";
            this.to_dtp.Size = new System.Drawing.Size(159, 29);
            this.to_dtp.TabIndex = 3;
            this.to_dtp.Visible = false;
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ans.Location = new System.Drawing.Point(16, 16);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(73, 20);
            this.lbl_ans.TabIndex = 4;
            this.lbl_ans.Text = "輸出欄位";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DimGray;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_start.Location = new System.Drawing.Point(410, 83);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 44);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "開始計算";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbl_ans);
            this.panel1.Location = new System.Drawing.Point(131, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 180);
            this.panel1.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(456, 215);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 180);
            this.vScrollBar1.TabIndex = 11;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_reset.Location = new System.Drawing.Point(410, 152);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(126, 44);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "重設";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(401, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(15, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "㊣車輛牌照稅試算表-包含電動車版本";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(367, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "資料庫版本號：20181030";
            // 
            // cc_cbx
            // 
            this.cc_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cc_cbx.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cc_cbx.FormattingEnabled = true;
            this.cc_cbx.Items.AddRange(new object[] {
            "150以下",
            "150~250",
            "251~500",
            "501~600",
            "601~1200",
            "1201~1800",
            "1801或以上"});
            this.cc_cbx.Location = new System.Drawing.Point(145, 76);
            this.cc_cbx.Name = "cc_cbx";
            this.cc_cbx.Size = new System.Drawing.Size(179, 35);
            this.cc_cbx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "用途";
            // 
            // cartype_cbx
            // 
            this.cartype_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartype_cbx.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cartype_cbx.FormattingEnabled = true;
            this.cartype_cbx.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車",
            "自用電動小客車",
            "營業電動小客車",
            "電動機車",
            "電動貨車/大客車"});
            this.cartype_cbx.Location = new System.Drawing.Point(145, 21);
            this.cartype_cbx.Name = "cartype_cbx";
            this.cartype_cbx.Size = new System.Drawing.Size(179, 35);
            this.cartype_cbx.TabIndex = 6;
            this.cartype_cbx.SelectedIndexChanged += new System.EventHandler(this.cartype_cbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "汽缸CC數";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cc_cbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cartype_cbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 138);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.to_dtp);
            this.groupBox2.Controls.Add(this.from_dtp);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(102, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 180);
            this.label6.TabIndex = 18;
            this.label6.Text = "稅金總額結果顯示";
            // 
            // TaxCnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(610, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_start);
            this.Name = "TaxCnt";
            this.Text = "VehicleTax";
            this.Load += new System.EventHandler(this.TaxCnt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker from_dtp;
        private System.Windows.Forms.DateTimePicker to_dtp;
        private System.Windows.Forms.Label lbl_ans;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cc_cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cartype_cbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}

