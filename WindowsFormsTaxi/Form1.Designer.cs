namespace WindowsFormsTaxi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_kq = new System.Windows.Forms.Label();
            this.quangduong = new System.Windows.Forms.TextBox();
            this.giatien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "App tính toán tiền Taxi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập giá tiền mỗi km:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập quãng đường (đơn vị km):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thành tiền ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_kq
            // 
            this.text_kq.AutoSize = true;
            this.text_kq.Location = new System.Drawing.Point(201, 306);
            this.text_kq.Name = "text_kq";
            this.text_kq.Size = new System.Drawing.Size(0, 16);
            this.text_kq.TabIndex = 6;
            // 
            // quangduong
            // 
            this.quangduong.Location = new System.Drawing.Point(396, 121);
            this.quangduong.Name = "quangduong";
            this.quangduong.Size = new System.Drawing.Size(141, 22);
            this.quangduong.TabIndex = 7;
            // 
            // giatien
            // 
            this.giatien.Location = new System.Drawing.Point(396, 162);
            this.giatien.Name = "giatien";
            this.giatien.Size = new System.Drawing.Size(141, 22);
            this.giatien.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giatien);
            this.Controls.Add(this.quangduong);
            this.Controls.Add(this.text_kq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính tiền Taxi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text_kq;
        private System.Windows.Forms.TextBox quangduong;
        private System.Windows.Forms.TextBox giatien;
    }
}

