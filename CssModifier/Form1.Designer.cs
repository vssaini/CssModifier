namespace CssModifier
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
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.txtBannerColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifyColor = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(335, 14);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(87, 27);
            this.btnBrowseFile.TabIndex = 0;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse file path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(112, 18);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(217, 23);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "E:\\Users\\V.S. Saini\\Documents\\AD Lab\\BaseStyle.css";
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(15, 85);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbFileContent.Size = new System.Drawing.Size(407, 230);
            this.rtbFileContent.TabIndex = 3;
            this.rtbFileContent.Text = "";
            // 
            // txtBannerColor
            // 
            this.txtBannerColor.Location = new System.Drawing.Point(112, 336);
            this.txtBannerColor.Name = "txtBannerColor";
            this.txtBannerColor.Size = new System.Drawing.Size(217, 23);
            this.txtBannerColor.TabIndex = 5;
            this.txtBannerColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBannerColor_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set banner color:";
            // 
            // btnModifyColor
            // 
            this.btnModifyColor.Location = new System.Drawing.Point(338, 332);
            this.btnModifyColor.Name = "btnModifyColor";
            this.btnModifyColor.Size = new System.Drawing.Size(87, 27);
            this.btnModifyColor.TabIndex = 6;
            this.btnModifyColor.Text = "Modify Color";
            this.btnModifyColor.UseVisualStyleBackColor = true;
            this.btnModifyColor.Click += new System.EventHandler(this.btnModifyColor_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(335, 52);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(87, 27);
            this.btnReadFile.TabIndex = 7;
            this.btnReadFile.Text = "Read file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "StyleSheet";
            this.openFileDialog.Filter = "CSS files|*.css";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 383);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnModifyColor);
            this.Controls.Add(this.txtBannerColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbFileContent);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSS Modifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.TextBox txtBannerColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifyColor;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

