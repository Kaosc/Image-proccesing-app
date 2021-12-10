
namespace ImageProcessingApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.BrightBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dosyaAçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiKaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImageToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.düzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastIncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageBox3 = new Emgu.CV.UI.ImageBox();
            this.ımageBox2 = new Emgu.CV.UI.ImageBox();
            this.ımageBox1 = new Emgu.CV.UI.ImageBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // ContrastBar
            // 
            resources.ApplyResources(this.ContrastBar, "ContrastBar");
            this.ContrastBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContrastBar.Maximum = 15;
            this.ContrastBar.Minimum = -15;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Scroll += new System.EventHandler(this.ContrastBar_Scroll);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Name = "label5";
            // 
            // BrightBar
            // 
            resources.ApplyResources(this.BrightBar, "BrightBar");
            this.BrightBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrightBar.Maximum = 15;
            this.BrightBar.Minimum = -15;
            this.BrightBar.Name = "BrightBar";
            this.BrightBar.Scroll += new System.EventHandler(this.BrightBar_Scroll);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Name = "label6";
            // 
            // BlueBar
            // 
            resources.ApplyResources(this.BlueBar, "BlueBar");
            this.BlueBar.Maximum = 30;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // GreenBar
            // 
            resources.ApplyResources(this.GreenBar, "GreenBar");
            this.GreenBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.GreenBar.Maximum = 30;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Name = "label2";
            // 
            // RedBar
            // 
            resources.ApplyResources(this.RedBar, "RedBar");
            this.RedBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RedBar.Maximum = 30;
            this.RedBar.Name = "RedBar";
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // contextMenuStrip2
            // 
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.resmiKaydetToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            // 
            // dosyaAçToolStripMenuItem
            // 
            resources.ApplyResources(this.dosyaAçToolStripMenuItem, "dosyaAçToolStripMenuItem");
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            // 
            // resmiKaydetToolStripMenuItem
            // 
            resources.ApplyResources(this.resmiKaydetToolStripMenuItem, "resmiKaydetToolStripMenuItem");
            this.resmiKaydetToolStripMenuItem.Name = "resmiKaydetToolStripMenuItem";
            // 
            // contextMenuStrip3
            // 
            resources.ApplyResources(this.contextMenuStrip3, "contextMenuStrip3");
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem1,
            this.resmiKaydetToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            // 
            // dosyaAçToolStripMenuItem1
            // 
            resources.ApplyResources(this.dosyaAçToolStripMenuItem1, "dosyaAçToolStripMenuItem1");
            this.dosyaAçToolStripMenuItem1.Name = "dosyaAçToolStripMenuItem1";
            // 
            // resmiKaydetToolStripMenuItem1
            // 
            resources.ApplyResources(this.resmiKaydetToolStripMenuItem1, "resmiKaydetToolStripMenuItem1");
            this.resmiKaydetToolStripMenuItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resmiKaydetToolStripMenuItem1.Name = "resmiKaydetToolStripMenuItem1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenlemeToolStripMenuItem,
            this.FiltersToolStripMenuItem,
            this.ConvertToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            resources.ApplyResources(this.dosyaToolStripMenuItem, "dosyaToolStripMenuItem");
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageToolStripMenuItem,
            this.SaveImageToolStripMenuItem2,
            this.toolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            // 
            // OpenImageToolStripMenuItem
            // 
            resources.ApplyResources(this.OpenImageToolStripMenuItem, "OpenImageToolStripMenuItem");
            this.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem";
            this.OpenImageToolStripMenuItem.Click += new System.EventHandler(this.OpenImageToolStripMenuItem_Click);
            // 
            // SaveImageToolStripMenuItem2
            // 
            resources.ApplyResources(this.SaveImageToolStripMenuItem2, "SaveImageToolStripMenuItem2");
            this.SaveImageToolStripMenuItem2.Name = "SaveImageToolStripMenuItem2";
            this.SaveImageToolStripMenuItem2.Click += new System.EventHandler(this.SaveImageToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // düzenlemeToolStripMenuItem
            // 
            resources.ApplyResources(this.düzenlemeToolStripMenuItem, "düzenlemeToolStripMenuItem");
            this.düzenlemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.UndoAllToolStripMenuItem});
            this.düzenlemeToolStripMenuItem.Name = "düzenlemeToolStripMenuItem";
            // 
            // UndoToolStripMenuItem
            // 
            resources.ApplyResources(this.UndoToolStripMenuItem, "UndoToolStripMenuItem");
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // UndoAllToolStripMenuItem
            // 
            resources.ApplyResources(this.UndoAllToolStripMenuItem, "UndoAllToolStripMenuItem");
            this.UndoAllToolStripMenuItem.Name = "UndoAllToolStripMenuItem";
            this.UndoAllToolStripMenuItem.Click += new System.EventHandler(this.UndoAllToolStripMenuItem_Click);
            // 
            // FiltersToolStripMenuItem
            // 
            resources.ApplyResources(this.FiltersToolStripMenuItem, "FiltersToolStripMenuItem");
            this.FiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertGrayToolStripMenuItem,
            this.SharpenToolStripMenuItem,
            this.ContrastIncToolStripMenuItem,
            this.BlurToolStripMenuItem,
            this.EdgesToolStripMenuItem});
            this.FiltersToolStripMenuItem.Name = "FiltersToolStripMenuItem";
            // 
            // ConvertGrayToolStripMenuItem
            // 
            resources.ApplyResources(this.ConvertGrayToolStripMenuItem, "ConvertGrayToolStripMenuItem");
            this.ConvertGrayToolStripMenuItem.Name = "ConvertGrayToolStripMenuItem";
            this.ConvertGrayToolStripMenuItem.Click += new System.EventHandler(this.ConvertGrayToolStripMenuItem_Click);
            // 
            // SharpenToolStripMenuItem
            // 
            resources.ApplyResources(this.SharpenToolStripMenuItem, "SharpenToolStripMenuItem");
            this.SharpenToolStripMenuItem.Name = "SharpenToolStripMenuItem";
            this.SharpenToolStripMenuItem.Click += new System.EventHandler(this.SharpenToolStripMenuItem_Click);
            // 
            // ContrastIncToolStripMenuItem
            // 
            resources.ApplyResources(this.ContrastIncToolStripMenuItem, "ContrastIncToolStripMenuItem");
            this.ContrastIncToolStripMenuItem.Name = "ContrastIncToolStripMenuItem";
            this.ContrastIncToolStripMenuItem.Click += new System.EventHandler(this.ContrastIncToolStripMenuItem_Click);
            // 
            // BlurToolStripMenuItem
            // 
            resources.ApplyResources(this.BlurToolStripMenuItem, "BlurToolStripMenuItem");
            this.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem";
            this.BlurToolStripMenuItem.Click += new System.EventHandler(this.BlurToolStripMenuItem_Click);
            // 
            // EdgesToolStripMenuItem
            // 
            resources.ApplyResources(this.EdgesToolStripMenuItem, "EdgesToolStripMenuItem");
            this.EdgesToolStripMenuItem.Name = "EdgesToolStripMenuItem";
            this.EdgesToolStripMenuItem.Click += new System.EventHandler(this.EdgesToolStripMenuItem_Click);
            // 
            // ConvertToolStripMenuItem
            // 
            resources.ApplyResources(this.ConvertToolStripMenuItem, "ConvertToolStripMenuItem");
            this.ConvertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ımageBox3);
            this.panel1.Controls.Add(this.ımageBox2);
            this.panel1.Controls.Add(this.ımageBox1);
            this.panel1.Controls.Add(this.histogramBox3);
            this.panel1.Controls.Add(this.histogramBox2);
            this.panel1.Controls.Add(this.histogramBox1);
            this.panel1.Controls.Add(this.ContrastBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RedBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GreenBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BlueBar);
            this.panel1.Controls.Add(this.BrightBar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Name = "panel1";
            // 
            // ımageBox3
            // 
            resources.ApplyResources(this.ımageBox3, "ımageBox3");
            this.ımageBox3.BackColor = System.Drawing.Color.Blue;
            this.ımageBox3.Name = "ımageBox3";
            this.ımageBox3.TabStop = false;
            // 
            // ımageBox2
            // 
            resources.ApplyResources(this.ımageBox2, "ımageBox2");
            this.ımageBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.ımageBox2.Name = "ımageBox2";
            this.ımageBox2.TabStop = false;
            // 
            // ımageBox1
            // 
            resources.ApplyResources(this.ımageBox1, "ımageBox1");
            this.ımageBox1.BackColor = System.Drawing.Color.Red;
            this.ımageBox1.Name = "ımageBox1";
            this.ımageBox1.TabStop = false;
            // 
            // histogramBox3
            // 
            resources.ApplyResources(this.histogramBox3, "histogramBox3");
            this.histogramBox3.BackColor = System.Drawing.Color.Black;
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.TabStop = false;
            // 
            // histogramBox2
            // 
            resources.ApplyResources(this.histogramBox2, "histogramBox2");
            this.histogramBox2.BackColor = System.Drawing.Color.Black;
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.TabStop = false;
            // 
            // histogramBox1
            // 
            resources.ApplyResources(this.histogramBox1, "histogramBox1");
            this.histogramBox1.BackColor = System.Drawing.Color.Black;
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar BrightBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiKaydetToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resmiKaydetToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveImageToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem düzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdgesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.ToolStripMenuItem ContrastIncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private Emgu.CV.UI.ImageBox ımageBox1;
        private Emgu.CV.UI.ImageBox ımageBox3;
        private Emgu.CV.UI.ImageBox ımageBox2;
    }
}

