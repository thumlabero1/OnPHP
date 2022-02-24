
namespace BaiTapLTQL
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.TxtHoTen = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BTnRESET = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RdNam = new System.Windows.Forms.RadioButton();
            this.RdNu = new System.Windows.Forms.RadioButton();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtHoTen
            // 
            this.TxtHoTen.Location = new System.Drawing.Point(204, 73);
            this.TxtHoTen.Name = "TxtHoTen";
            this.TxtHoTen.Size = new System.Drawing.Size(280, 27);
            this.TxtHoTen.TabIndex = 0;
            this.TxtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm";
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(204, 342);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(81, 41);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTnRESET
            // 
            this.BTnRESET.Location = new System.Drawing.Point(403, 342);
            this.BTnRESET.Name = "BTnRESET";
            this.BTnRESET.Size = new System.Drawing.Size(81, 41);
            this.BTnRESET.TabIndex = 2;
            this.BTnRESET.Text = "RESET";
            this.BTnRESET.UseVisualStyleBackColor = true;
            this.BTnRESET.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // RdNam
            // 
            this.RdNam.AutoSize = true;
            this.RdNam.Location = new System.Drawing.Point(204, 202);
            this.RdNam.Name = "RdNam";
            this.RdNam.Size = new System.Drawing.Size(67, 23);
            this.RdNam.TabIndex = 4;
            this.RdNam.TabStop = true;
            this.RdNam.Text = "Nam";
            this.RdNam.UseVisualStyleBackColor = true;
            // 
            // RdNu
            // 
            this.RdNu.AutoSize = true;
            this.RdNu.Location = new System.Drawing.Point(335, 202);
            this.RdNu.Name = "RdNu";
            this.RdNu.Size = new System.Drawing.Size(55, 23);
            this.RdNu.TabIndex = 4;
            this.RdNu.TabStop = true;
            this.RdNu.Text = "Nữ";
            this.RdNu.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(37, 1);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(83, 42);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 576);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RdNu);
            this.Controls.Add(this.RdNam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTnRESET);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtHoTen);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormAdd.IconOptions.LargeImage")));
            this.Name = "FormAdd";
            this.Text = "Thêm học sinh";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHoTen;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BTnRESET;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RdNam;
        private System.Windows.Forms.RadioButton RdNu;
        private System.Windows.Forms.Button BtnBack;
    }
}