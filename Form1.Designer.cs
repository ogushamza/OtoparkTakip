
namespace OtoparkTakip
{
    partial class Form1
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
            txtPlaka = new TextBox();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            btnAracGiris = new Button();
            btnYenile = new Button();
            dataGridView1 = new DataGridView();
            lblPlaka = new Label();
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            btnForm2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(90, 20);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(150, 27);
            txtPlaka.TabIndex = 0;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(90, 50);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(150, 27);
            txtMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(90, 80);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 27);
            txtModel.TabIndex = 2;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(90, 110);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(150, 27);
            txtRenk.TabIndex = 3;
            // 
            // btnAracGiris
            // 
            btnAracGiris.Location = new Point(90, 150);
            btnAracGiris.Name = "btnAracGiris";
            btnAracGiris.Size = new Size(150, 30);
            btnAracGiris.TabIndex = 4;
            btnAracGiris.Text = "Araç Girişi";
            btnAracGiris.UseVisualStyleBackColor = true;
            btnAracGiris.Click += btnAracGiris_Click_1;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(260, 150);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(100, 30);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(20, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 250);
            dataGridView1.TabIndex = 6;
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Location = new Point(20, 23);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(47, 20);
            lblPlaka.TabIndex = 7;
            lblPlaka.Text = "Plaka:";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(20, 53);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(53, 20);
            lblMarka.TabIndex = 8;
            lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 83);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 9;
            lblModel.Text = "Model:";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(20, 113);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(44, 20);
            lblRenk.TabIndex = 10;
            lblRenk.Text = "Renk:";
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(581, 483);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(94, 29);
            btnForm2.TabIndex = 11;
            btnForm2.Text = "Araç Çıkış";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(687, 524);
            Controls.Add(btnForm2);
            Controls.Add(txtPlaka);
            Controls.Add(txtMarka);
            Controls.Add(txtModel);
            Controls.Add(txtRenk);
            Controls.Add(btnAracGiris);
            Controls.Add(btnYenile);
            Controls.Add(dataGridView1);
            Controls.Add(lblPlaka);
            Controls.Add(lblMarka);
            Controls.Add(lblModel);
            Controls.Add(lblRenk);
            Name = "Form1";
            Text = "Otopark Takip - Araç Girişi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Button btnAracGiris;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRenk;
        private Button btnForm2;
    }
}
