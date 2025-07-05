namespace OtoparkTakip
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtPlakaAra = new TextBox();
            btnAracBul = new Button();
            lblGirisTarihi = new Label();
            lblCikisTarihi = new Label();
            lblSure = new Label();
            lblUcret = new Label();
            btnCikisYap = new Button();
            dataGridViewCikanAraclar = new DataGridView();
            lblMesaj = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCikanAraclar).BeginInit();
            SuspendLayout();
            // 
            // txtPlakaAra
            // 
            txtPlakaAra.Location = new Point(231, 26);
            txtPlakaAra.Name = "txtPlakaAra";
            txtPlakaAra.Size = new Size(180, 27);
            txtPlakaAra.TabIndex = 0;
            // 
            // btnAracBul
            // 
            btnAracBul.Location = new Point(421, 24);
            btnAracBul.Name = "btnAracBul";
            btnAracBul.Size = new Size(100, 25);
            btnAracBul.TabIndex = 1;
            btnAracBul.Text = "Araç Bul";
            btnAracBul.UseVisualStyleBackColor = true;
            btnAracBul.Click += btnAracBul_Click;
            // 
            // lblGirisTarihi
            // 
            lblGirisTarihi.AutoSize = true;
            lblGirisTarihi.Location = new Point(231, 66);
            lblGirisTarihi.Name = "lblGirisTarihi";
            lblGirisTarihi.Size = new Size(90, 20);
            lblGirisTarihi.TabIndex = 2;
            lblGirisTarihi.Text = "Giriş Tarihi: -";
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.Location = new Point(231, 96);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(91, 20);
            lblCikisTarihi.TabIndex = 3;
            lblCikisTarihi.Text = "Çıkış Tarihi: -";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Location = new Point(231, 126);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(51, 20);
            lblSure.TabIndex = 4;
            lblSure.Text = "Süre: -";
            // 
            // lblUcret
            // 
            lblUcret.AutoSize = true;
            lblUcret.Location = new Point(231, 156);
            lblUcret.Name = "lblUcret";
            lblUcret.Size = new Size(57, 20);
            lblUcret.TabIndex = 5;
            lblUcret.Text = "Ücret: -";
            // 
            // btnCikisYap
            // 
            btnCikisYap.Location = new Point(231, 186);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(290, 30);
            btnCikisYap.TabIndex = 6;
            btnCikisYap.Text = "ÇIKIŞI TAMAMLA";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // dataGridViewCikanAraclar
            // 
            dataGridViewCikanAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCikanAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCikanAraclar.Location = new Point(30, 230);
            dataGridViewCikanAraclar.Name = "dataGridViewCikanAraclar";
            dataGridViewCikanAraclar.ReadOnly = true;
            dataGridViewCikanAraclar.RowHeadersWidth = 51;
            dataGridViewCikanAraclar.Size = new Size(700, 250);
            dataGridViewCikanAraclar.TabIndex = 7;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.ForeColor = Color.DarkRed;
            lblMesaj.Location = new Point(30, 490);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(0, 20);
            lblMesaj.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(161, 31);
            button1.TabIndex = 9;
            button1.Text = "Araç Girişe Dön ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(780, 520);
            Controls.Add(button1);
            Controls.Add(txtPlakaAra);
            Controls.Add(btnAracBul);
            Controls.Add(lblGirisTarihi);
            Controls.Add(lblCikisTarihi);
            Controls.Add(lblSure);
            Controls.Add(lblUcret);
            Controls.Add(btnCikisYap);
            Controls.Add(dataGridViewCikanAraclar);
            Controls.Add(lblMesaj);
            Name = "Form2";
            Text = "Araç Çıkışı";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCikanAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.Button btnAracBul;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.DataGridView dataGridViewCikanAraclar;
        private System.Windows.Forms.Label lblMesaj;
        private Button button1;
    }
}