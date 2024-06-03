namespace csharp_tinhtong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btntinhhieu = new System.Windows.Forms.Button();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "số 1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(364, 84);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(132, 22);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "số 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(364, 140);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 22);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(364, 212);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(132, 22);
            this.txtKQ.TabIndex = 4;
            // 
            // btntinhtich
            // 
            this.btntinhtich.Location = new System.Drawing.Point(364, 314);
            this.btntinhtich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(100, 28);
            this.btntinhtich.TabIndex = 5;
            this.btntinhtich.Text = "Tích";
            this.btntinhtich.UseVisualStyleBackColor = true;
            this.btntinhtich.Click += new System.EventHandler(this.btntinhtich_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(361, 270);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(51, 16);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "kết quả";
            // 
            // btntinhhieu
            // 
            this.btntinhhieu.Location = new System.Drawing.Point(497, 314);
            this.btntinhhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btntinhhieu.Name = "btntinhhieu";
            this.btntinhhieu.Size = new System.Drawing.Size(100, 28);
            this.btntinhhieu.TabIndex = 7;
            this.btntinhhieu.Text = "Hiệu";
            this.btntinhhieu.UseVisualStyleBackColor = true;
            this.btntinhhieu.Click += new System.EventHandler(this.btntinhhieu_Click);
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(240, 313);
            this.btntinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(100, 28);
            this.btntinhtong.TabIndex = 8;
            this.btntinhtong.Text = "Tổng";
            this.btntinhtong.UseVisualStyleBackColor = true;
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.Location = new System.Drawing.Point(633, 314);
            this.btntinhthuong.Margin = new System.Windows.Forms.Padding(4);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(100, 28);
            this.btntinhthuong.TabIndex = 9;
            this.btntinhthuong.Text = "Thương";
            this.btntinhthuong.UseVisualStyleBackColor = true;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 354);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.btntinhhieu);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Chương trình tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btntinhtich;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btntinhhieu;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Button btntinhthuong;
    }
}

