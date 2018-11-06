namespace BrowSec
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chromeExtractButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.operaExtractButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.braveExtractButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.browseAndExtractButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1198, 527);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passwords";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1184, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // chromeExtractButton
            // 
            this.chromeExtractButton.Depth = 0;
            this.chromeExtractButton.Location = new System.Drawing.Point(1236, 89);
            this.chromeExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.chromeExtractButton.Name = "chromeExtractButton";
            this.chromeExtractButton.Primary = true;
            this.chromeExtractButton.Size = new System.Drawing.Size(108, 34);
            this.chromeExtractButton.TabIndex = 2;
            this.chromeExtractButton.Text = "Chrome";
            this.chromeExtractButton.UseVisualStyleBackColor = true;
            this.chromeExtractButton.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // operaExtractButton
            // 
            this.operaExtractButton.Depth = 0;
            this.operaExtractButton.Location = new System.Drawing.Point(1236, 159);
            this.operaExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.operaExtractButton.Name = "operaExtractButton";
            this.operaExtractButton.Primary = true;
            this.operaExtractButton.Size = new System.Drawing.Size(108, 34);
            this.operaExtractButton.TabIndex = 3;
            this.operaExtractButton.Text = "Opera";
            this.operaExtractButton.UseVisualStyleBackColor = true;
            this.operaExtractButton.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // braveExtractButton
            // 
            this.braveExtractButton.Depth = 0;
            this.braveExtractButton.Location = new System.Drawing.Point(1236, 238);
            this.braveExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.braveExtractButton.Name = "braveExtractButton";
            this.braveExtractButton.Primary = true;
            this.braveExtractButton.Size = new System.Drawing.Size(108, 34);
            this.braveExtractButton.TabIndex = 4;
            this.braveExtractButton.Text = "Brave";
            this.braveExtractButton.UseVisualStyleBackColor = true;
            this.braveExtractButton.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // browseAndExtractButton
            // 
            this.browseAndExtractButton.Depth = 0;
            this.browseAndExtractButton.Location = new System.Drawing.Point(1236, 314);
            this.browseAndExtractButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseAndExtractButton.Name = "browseAndExtractButton";
            this.browseAndExtractButton.Primary = true;
            this.browseAndExtractButton.Size = new System.Drawing.Size(108, 34);
            this.browseAndExtractButton.TabIndex = 5;
            this.browseAndExtractButton.Text = "Browse";
            this.browseAndExtractButton.UseVisualStyleBackColor = true;
            this.browseAndExtractButton.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 603);
            this.Controls.Add(this.browseAndExtractButton);
            this.Controls.Add(this.braveExtractButton);
            this.Controls.Add(this.operaExtractButton);
            this.Controls.Add(this.chromeExtractButton);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "ChromDump";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton chromeExtractButton;
        private MaterialSkin.Controls.MaterialRaisedButton operaExtractButton;
        private MaterialSkin.Controls.MaterialRaisedButton braveExtractButton;
        private MaterialSkin.Controls.MaterialRaisedButton browseAndExtractButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

