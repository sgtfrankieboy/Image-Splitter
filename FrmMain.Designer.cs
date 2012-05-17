namespace ImageConverter
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblx = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.comboExtension = new System.Windows.Forms.ComboBox();
            this.lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(188, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(43, 20);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.tip.SetToolTip(this.btnLoad, "Load the image to split in smaller images");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 20);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.tip.SetToolTip(this.btnSave, "Path to where the images are saved");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(219, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start!";
            this.tip.SetToolTip(this.btnStart, "Start splitting the image");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(166, 97);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(65, 20);
            this.numHeight.TabIndex = 3;
            this.tip.SetToolTip(this.numHeight, "height of the small images");
            this.numHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(148, 99);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(12, 13);
            this.lblx.TabIndex = 4;
            this.lblx.Text = "x";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(77, 97);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(65, 20);
            this.numWidth.TabIndex = 3;
            this.tip.SetToolTip(this.numWidth, "Width of the small images");
            this.numWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(12, 99);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(59, 13);
            this.lblImageSize.TabIndex = 5;
            this.lblImageSize.Text = "Image Size";
            this.tip.SetToolTip(this.lblImageSize, "Size of the small images");
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(12, 12);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.ReadOnly = true;
            this.txtLoad.Size = new System.Drawing.Size(170, 20);
            this.txtLoad.TabIndex = 6;
            this.tip.SetToolTip(this.txtLoad, "Load the image to split in smaller images");
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(12, 38);
            this.txtSave.Name = "txtSave";
            this.txtSave.ReadOnly = true;
            this.txtSave.Size = new System.Drawing.Size(170, 20);
            this.txtSave.TabIndex = 6;
            this.tip.SetToolTip(this.txtSave, "Path to where the images are saved");
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(70, 64);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(112, 20);
            this.txtFilename.TabIndex = 8;
            this.txtFilename.Text = "ic_{num}";
            this.tip.SetToolTip(this.txtFilename, "Name of the small images.");
            // 
            // comboExtension
            // 
            this.comboExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExtension.FormattingEnabled = true;
            this.comboExtension.Items.AddRange(new object[] {
            "png",
            "jpg",
            "bmp"});
            this.comboExtension.Location = new System.Drawing.Point(188, 64);
            this.comboExtension.Name = "comboExtension";
            this.comboExtension.Size = new System.Drawing.Size(43, 21);
            this.comboExtension.TabIndex = 9;
            this.tip.SetToolTip(this.comboExtension, "File type off the small images");
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 67);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(52, 13);
            this.lblFilename.TabIndex = 7;
            this.lblFilename.Text = "Filename:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 158);
            this.Controls.Add(this.comboExtension);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Image Splitter";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmMain_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox comboExtension;
    }
}

