
namespace linq_deneme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lst_ekle = new System.Windows.Forms.Button();
            this.lstbx_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.satir_sayi = new System.Windows.Forms.Label();
            this.radioBTNlinq = new System.Windows.Forms.RadioButton();
            this.buttonLNQ = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(486, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 344);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lst_ekle
            // 
            this.lst_ekle.Location = new System.Drawing.Point(31, 90);
            this.lst_ekle.Name = "lst_ekle";
            this.lst_ekle.Size = new System.Drawing.Size(94, 29);
            this.lst_ekle.TabIndex = 3;
            this.lst_ekle.Text = "Listeye Ekle";
            this.lst_ekle.UseVisualStyleBackColor = true;
            this.lst_ekle.Click += new System.EventHandler(this.lst_ekle_Click);
            // 
            // lstbx_btn
            // 
            this.lstbx_btn.Location = new System.Drawing.Point(31, 141);
            this.lstbx_btn.Name = "lstbx_btn";
            this.lstbx_btn.Size = new System.Drawing.Size(94, 29);
            this.lstbx_btn.TabIndex = 4;
            this.lstbx_btn.Text = "List Box\'a Ekle";
            this.lstbx_btn.UseVisualStyleBackColor = true;
            this.lstbx_btn.Click += new System.EventHandler(this.lstbx_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(31, 194);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(94, 29);
            this.sil_btn.TabIndex = 5;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Satır Sayısı : ";
            // 
            // satir_sayi
            // 
            this.satir_sayi.AutoSize = true;
            this.satir_sayi.Location = new System.Drawing.Point(602, 403);
            this.satir_sayi.Name = "satir_sayi";
            this.satir_sayi.Size = new System.Drawing.Size(17, 20);
            this.satir_sayi.TabIndex = 7;
            this.satir_sayi.Text = "0";
            this.satir_sayi.Click += new System.EventHandler(this.Satir_sayi_Click);
            // 
            // radioBTNlinq
            // 
            this.radioBTNlinq.AutoSize = true;
            this.radioBTNlinq.Location = new System.Drawing.Point(755, 40);
            this.radioBTNlinq.Name = "radioBTNlinq";
            this.radioBTNlinq.Size = new System.Drawing.Size(63, 24);
            this.radioBTNlinq.TabIndex = 8;
            this.radioBTNlinq.TabStop = true;
            this.radioBTNlinq.Text = "LINQ";
            this.radioBTNlinq.UseVisualStyleBackColor = true;
            // 
            // buttonLNQ
            // 
            this.buttonLNQ.Location = new System.Drawing.Point(755, 90);
            this.buttonLNQ.Name = "buttonLNQ";
            this.buttonLNQ.Size = new System.Drawing.Size(94, 29);
            this.buttonLNQ.TabIndex = 9;
            this.buttonLNQ.Text = "LINQ";
            this.buttonLNQ.UseVisualStyleBackColor = true;
            this.buttonLNQ.Click += new System.EventHandler(this.buttonLNQ_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(755, 141);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(196, 244);
            this.listBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "A>Z İsimleri Sırala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonLNQ);
            this.Controls.Add(this.radioBTNlinq);
            this.Controls.Add(this.satir_sayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.lstbx_btn);
            this.Controls.Add(this.lst_ekle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button lst_ekle;
        private System.Windows.Forms.Button lstbx_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label satir_sayi;
        private System.Windows.Forms.RadioButton radioBTNlinq;
        public System.Windows.Forms.Button buttonLNQ;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
    }
}

