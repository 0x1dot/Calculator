namespace Calculator
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtPanel = new System.Windows.Forms.TextBox();
            this.btnKok = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnCikartma = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPanel
            // 
            this.txtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPanel.ForeColor = System.Drawing.Color.White;
            this.txtPanel.HideSelection = false;
            this.txtPanel.Location = new System.Drawing.Point(12, 12);
            this.txtPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(452, 74);
            this.txtPanel.TabIndex = 1;
            this.txtPanel.TextChanged += new System.EventHandler(this.txtPanel_TextChanged);
            // 
            // btnKok
            // 
            this.btnKok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnKok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKok.ForeColor = System.Drawing.Color.White;
            this.btnKok.Location = new System.Drawing.Point(12, 91);
            this.btnKok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKok.Name = "btnKok";
            this.btnKok.Size = new System.Drawing.Size(109, 80);
            this.btnKok.TabIndex = 7;
            this.btnKok.Text = "²√ˣ";
            this.btnKok.UseVisualStyleBackColor = false;
            this.btnKok.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnKare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKare.ForeColor = System.Drawing.Color.White;
            this.btnKare.Location = new System.Drawing.Point(127, 91);
            this.btnKare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(109, 80);
            this.btnKare.TabIndex = 9;
            this.btnKare.Text = "X²";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(241, 91);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 80);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackSpace.ForeColor = System.Drawing.Color.White;
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(356, 91);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(109, 80);
            this.btnBackSpace.TabIndex = 11;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(12, 176);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 80);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(127, 176);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 80);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(241, 176);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 80);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.ForeColor = System.Drawing.Color.White;
            this.btnTopla.Location = new System.Drawing.Point(356, 431);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(109, 80);
            this.btnTopla.TabIndex = 15;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 261);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 80);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(127, 261);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 80);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(241, 261);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 80);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnCikartma
            // 
            this.btnCikartma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnCikartma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikartma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikartma.ForeColor = System.Drawing.Color.White;
            this.btnCikartma.Location = new System.Drawing.Point(356, 346);
            this.btnCikartma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikartma.Name = "btnCikartma";
            this.btnCikartma.Size = new System.Drawing.Size(109, 80);
            this.btnCikartma.TabIndex = 19;
            this.btnCikartma.Text = "-";
            this.btnCikartma.UseVisualStyleBackColor = false;
            this.btnCikartma.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(12, 346);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 80);
            this.btn1.TabIndex = 20;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(127, 346);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 80);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(241, 346);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 80);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnCarpma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpma.ForeColor = System.Drawing.Color.White;
            this.btnCarpma.Location = new System.Drawing.Point(356, 176);
            this.btnCarpma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(109, 80);
            this.btnCarpma.TabIndex = 23;
            this.btnCarpma.Text = "×";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(127, 431);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(109, 80);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnVirgul
            // 
            this.btnVirgul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnVirgul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVirgul.ForeColor = System.Drawing.Color.White;
            this.btnVirgul.Location = new System.Drawing.Point(12, 431);
            this.btnVirgul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(109, 80);
            this.btnVirgul.TabIndex = 25;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = false;
            this.btnVirgul.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnEsittir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsittir.ForeColor = System.Drawing.Color.White;
            this.btnEsittir.Location = new System.Drawing.Point(241, 431);
            this.btnEsittir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(109, 80);
            this.btnEsittir.TabIndex = 26;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = false;
            this.btnEsittir.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(92)))));
            this.btnBolme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolme.ForeColor = System.Drawing.Color.White;
            this.btnBolme.Location = new System.Drawing.Point(356, 261);
            this.btnBolme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(109, 80);
            this.btnBolme.TabIndex = 27;
            this.btnBolme.Text = "÷";
            this.btnBolme.UseVisualStyleBackColor = false;
            this.btnBolme.Click += new System.EventHandler(this.Hesap_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikartma);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnVirgul);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnKok);
            this.Controls.Add(this.txtPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPanel;
        private System.Windows.Forms.Button btnKok;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnCikartma;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgul;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnBolme;
    }
}

