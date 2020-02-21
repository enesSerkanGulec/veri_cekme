namespace json
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
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çekilecekVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fiyat0DanBüyükOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelDurumlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kullanılanAlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.örnekGelenVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.örnekGidenVeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.gidenDosyaAlanlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 163);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 68);
            this.button3.TabIndex = 10;
            this.button3.Text = "Verileri Çek";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Xml Dosyası|*.xml";
            this.saveFileDialog2.Title = "Dönüştürülen dosya nereye ve hangi isimle kaydedilecek?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(154, 83);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 29);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blok";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(154, 35);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(138, 29);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "End";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çekilecekVeriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çekilecekVeriToolStripMenuItem
            // 
            this.çekilecekVeriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümVeriToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fiyat0DanBüyükOlanlarToolStripMenuItem,
            this.resmiOlanlarToolStripMenuItem});
            this.çekilecekVeriToolStripMenuItem.Name = "çekilecekVeriToolStripMenuItem";
            this.çekilecekVeriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.çekilecekVeriToolStripMenuItem.Text = "Çekilecek Veri";
            // 
            // tümVeriToolStripMenuItem
            // 
            this.tümVeriToolStripMenuItem.Checked = true;
            this.tümVeriToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tümVeriToolStripMenuItem.Name = "tümVeriToolStripMenuItem";
            this.tümVeriToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.tümVeriToolStripMenuItem.Text = "Tüm Veri";
            this.tümVeriToolStripMenuItem.Click += new System.EventHandler(this.tümVeriToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // fiyat0DanBüyükOlanlarToolStripMenuItem
            // 
            this.fiyat0DanBüyükOlanlarToolStripMenuItem.Name = "fiyat0DanBüyükOlanlarToolStripMenuItem";
            this.fiyat0DanBüyükOlanlarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fiyat0DanBüyükOlanlarToolStripMenuItem.Text = "Fiyat 0 dan büyük olanlar";
            this.fiyat0DanBüyükOlanlarToolStripMenuItem.Click += new System.EventHandler(this.fiyat0DanBüyükOlanlarToolStripMenuItem_Click);
            // 
            // resmiOlanlarToolStripMenuItem
            // 
            this.resmiOlanlarToolStripMenuItem.Name = "resmiOlanlarToolStripMenuItem";
            this.resmiOlanlarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.resmiOlanlarToolStripMenuItem.Text = "Resmi olanlar";
            this.resmiOlanlarToolStripMenuItem.Click += new System.EventHandler(this.resmiOlanlarToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelDurumlarToolStripMenuItem,
            this.toolStripSeparator1,
            this.kullanılanAlanlarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.örnekGelenVeriToolStripMenuItem,
            this.örnekGidenVeriToolStripMenuItem,
            this.toolStripMenuItem3,
            this.gidenDosyaAlanlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Visible = false;
            // 
            // özelDurumlarToolStripMenuItem
            // 
            this.özelDurumlarToolStripMenuItem.Name = "özelDurumlarToolStripMenuItem";
            this.özelDurumlarToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.özelDurumlarToolStripMenuItem.Text = "Özel Durumları düzenle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // kullanılanAlanlarToolStripMenuItem
            // 
            this.kullanılanAlanlarToolStripMenuItem.Name = "kullanılanAlanlarToolStripMenuItem";
            this.kullanılanAlanlarToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.kullanılanAlanlarToolStripMenuItem.Text = "Gelen Dosyada olması gereken zorunlu alanlar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(313, 6);
            // 
            // örnekGelenVeriToolStripMenuItem
            // 
            this.örnekGelenVeriToolStripMenuItem.Name = "örnekGelenVeriToolStripMenuItem";
            this.örnekGelenVeriToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.örnekGelenVeriToolStripMenuItem.Text = "Örnek Gelen Veri Göster";
            // 
            // örnekGidenVeriToolStripMenuItem
            // 
            this.örnekGidenVeriToolStripMenuItem.Name = "örnekGidenVeriToolStripMenuItem";
            this.örnekGidenVeriToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.örnekGidenVeriToolStripMenuItem.Text = "Örnek Giden Veri Göster";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(313, 6);
            // 
            // gidenDosyaAlanlarıToolStripMenuItem
            // 
            this.gidenDosyaAlanlarıToolStripMenuItem.Name = "gidenDosyaAlanlarıToolStripMenuItem";
            this.gidenDosyaAlanlarıToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.gidenDosyaAlanlarıToolStripMenuItem.Text = "Giden Dosya Alanları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 343);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netten Gelsin veri çekme ve dönüştürme";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çekilecekVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fiyat0DanBüyükOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelDurumlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanılanAlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem örnekGelenVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem örnekGidenVeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gidenDosyaAlanlarıToolStripMenuItem;
    }
}

