namespace FindFiles
{
    partial class MainForm
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
            this.txtBxFirstCatalog = new System.Windows.Forms.TextBox();
            this.txtBxSecondCatalog = new System.Windows.Forms.TextBox();
            this.btnStartCount = new System.Windows.Forms.Button();
            this.lblFirstCatalog = new System.Windows.Forms.Label();
            this.lblSecondCatalog = new System.Windows.Forms.Label();
            this.txtBoxCountCatalogsInFirst = new System.Windows.Forms.TextBox();
            this.txtBoxCountCatalogsInSecond = new System.Windows.Forms.TextBox();
            this.lblCountCatalogs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownCountFiles = new System.Windows.Forms.NumericUpDown();
            this.lblCountFiles = new System.Windows.Forms.Label();
            this.cmbBxCatalogsInFirst = new System.Windows.Forms.ComboBox();
            this.cmbBxCatalogsInSecond = new System.Windows.Forms.ComboBox();
            this.chckBxRecursive = new System.Windows.Forms.CheckBox();
            this.fldBrwsrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetDir1 = new System.Windows.Forms.Button();
            this.btnGetDir2 = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCountFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxFirstCatalog
            // 
            this.txtBxFirstCatalog.Location = new System.Drawing.Point(103, 33);
            this.txtBxFirstCatalog.Name = "txtBxFirstCatalog";
            this.txtBxFirstCatalog.Size = new System.Drawing.Size(280, 20);
            this.txtBxFirstCatalog.TabIndex = 0;
            // 
            // txtBxSecondCatalog
            // 
            this.txtBxSecondCatalog.Location = new System.Drawing.Point(103, 59);
            this.txtBxSecondCatalog.Name = "txtBxSecondCatalog";
            this.txtBxSecondCatalog.Size = new System.Drawing.Size(280, 20);
            this.txtBxSecondCatalog.TabIndex = 1;
            // 
            // btnStartCount
            // 
            this.btnStartCount.Location = new System.Drawing.Point(15, 152);
            this.btnStartCount.Name = "btnStartCount";
            this.btnStartCount.Size = new System.Drawing.Size(75, 23);
            this.btnStartCount.TabIndex = 2;
            this.btnStartCount.Text = "DO";
            this.btnStartCount.UseVisualStyleBackColor = true;
            this.btnStartCount.Click += new System.EventHandler(this.btnStartCount_Click);
            // 
            // lblFirstCatalog
            // 
            this.lblFirstCatalog.AutoSize = true;
            this.lblFirstCatalog.Location = new System.Drawing.Point(12, 36);
            this.lblFirstCatalog.Name = "lblFirstCatalog";
            this.lblFirstCatalog.Size = new System.Drawing.Size(67, 13);
            this.lblFirstCatalog.TabIndex = 4;
            this.lblFirstCatalog.Text = "First catalog:";
            // 
            // lblSecondCatalog
            // 
            this.lblSecondCatalog.AutoSize = true;
            this.lblSecondCatalog.Location = new System.Drawing.Point(12, 62);
            this.lblSecondCatalog.Name = "lblSecondCatalog";
            this.lblSecondCatalog.Size = new System.Drawing.Size(85, 13);
            this.lblSecondCatalog.TabIndex = 5;
            this.lblSecondCatalog.Text = "Second catalog:";
            // 
            // txtBoxCountCatalogsInFirst
            // 
            this.txtBoxCountCatalogsInFirst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxCountCatalogsInFirst.Location = new System.Drawing.Point(510, 32);
            this.txtBoxCountCatalogsInFirst.Name = "txtBoxCountCatalogsInFirst";
            this.txtBoxCountCatalogsInFirst.ReadOnly = true;
            this.txtBoxCountCatalogsInFirst.Size = new System.Drawing.Size(64, 20);
            this.txtBoxCountCatalogsInFirst.TabIndex = 6;
            // 
            // txtBoxCountCatalogsInSecond
            // 
            this.txtBoxCountCatalogsInSecond.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxCountCatalogsInSecond.Location = new System.Drawing.Point(510, 58);
            this.txtBoxCountCatalogsInSecond.Name = "txtBoxCountCatalogsInSecond";
            this.txtBoxCountCatalogsInSecond.ReadOnly = true;
            this.txtBoxCountCatalogsInSecond.Size = new System.Drawing.Size(64, 20);
            this.txtBoxCountCatalogsInSecond.TabIndex = 7;
            // 
            // lblCountCatalogs
            // 
            this.lblCountCatalogs.AutoSize = true;
            this.lblCountCatalogs.Location = new System.Drawing.Point(422, 49);
            this.lblCountCatalogs.Name = "lblCountCatalogs";
            this.lblCountCatalogs.Size = new System.Drawing.Size(82, 13);
            this.lblCountCatalogs.TabIndex = 8;
            this.lblCountCatalogs.Text = "Count Catalogs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // numUpDownCountFiles
            // 
            this.numUpDownCountFiles.Location = new System.Drawing.Point(135, 118);
            this.numUpDownCountFiles.Name = "numUpDownCountFiles";
            this.numUpDownCountFiles.Size = new System.Drawing.Size(120, 20);
            this.numUpDownCountFiles.TabIndex = 10;
            // 
            // lblCountFiles
            // 
            this.lblCountFiles.AutoSize = true;
            this.lblCountFiles.Location = new System.Drawing.Point(12, 120);
            this.lblCountFiles.Name = "lblCountFiles";
            this.lblCountFiles.Size = new System.Drawing.Size(117, 13);
            this.lblCountFiles.TabIndex = 11;
            this.lblCountFiles.Text = "Count files in a catalog:";
            // 
            // cmbBxCatalogsInFirst
            // 
            this.cmbBxCatalogsInFirst.FormattingEnabled = true;
            this.cmbBxCatalogsInFirst.Location = new System.Drawing.Point(580, 32);
            this.cmbBxCatalogsInFirst.Name = "cmbBxCatalogsInFirst";
            this.cmbBxCatalogsInFirst.Size = new System.Drawing.Size(237, 21);
            this.cmbBxCatalogsInFirst.TabIndex = 12;
            // 
            // cmbBxCatalogsInSecond
            // 
            this.cmbBxCatalogsInSecond.FormattingEnabled = true;
            this.cmbBxCatalogsInSecond.Location = new System.Drawing.Point(580, 58);
            this.cmbBxCatalogsInSecond.Name = "cmbBxCatalogsInSecond";
            this.cmbBxCatalogsInSecond.Size = new System.Drawing.Size(237, 21);
            this.cmbBxCatalogsInSecond.TabIndex = 13;
            // 
            // chckBxRecursive
            // 
            this.chckBxRecursive.AutoSize = true;
            this.chckBxRecursive.Checked = true;
            this.chckBxRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckBxRecursive.Location = new System.Drawing.Point(15, 91);
            this.chckBxRecursive.Name = "chckBxRecursive";
            this.chckBxRecursive.Size = new System.Drawing.Size(75, 17);
            this.chckBxRecursive.TabIndex = 14;
            this.chckBxRecursive.Text = "Recursivly";
            this.chckBxRecursive.UseVisualStyleBackColor = true;
            this.chckBxRecursive.CheckedChanged += new System.EventHandler(this.chckBxRecursive_CheckedChanged);
            // 
            // btnGetDir1
            // 
            this.btnGetDir1.Location = new System.Drawing.Point(389, 32);
            this.btnGetDir1.Name = "btnGetDir1";
            this.btnGetDir1.Size = new System.Drawing.Size(27, 21);
            this.btnGetDir1.TabIndex = 15;
            this.btnGetDir1.Text = "...";
            this.btnGetDir1.UseVisualStyleBackColor = true;
            this.btnGetDir1.Click += new System.EventHandler(this.btnGetDir1_Click);
            // 
            // btnGetDir2
            // 
            this.btnGetDir2.Location = new System.Drawing.Point(389, 59);
            this.btnGetDir2.Name = "btnGetDir2";
            this.btnGetDir2.Size = new System.Drawing.Size(27, 21);
            this.btnGetDir2.TabIndex = 16;
            this.btnGetDir2.Text = "...";
            this.btnGetDir2.UseVisualStyleBackColor = true;
            this.btnGetDir2.Click += new System.EventHandler(this.btnGetDir2_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(117, 152);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 200);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGetDir2);
            this.Controls.Add(this.btnGetDir1);
            this.Controls.Add(this.chckBxRecursive);
            this.Controls.Add(this.cmbBxCatalogsInSecond);
            this.Controls.Add(this.cmbBxCatalogsInFirst);
            this.Controls.Add(this.lblCountFiles);
            this.Controls.Add(this.numUpDownCountFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCountCatalogs);
            this.Controls.Add(this.txtBoxCountCatalogsInSecond);
            this.Controls.Add(this.txtBoxCountCatalogsInFirst);
            this.Controls.Add(this.lblSecondCatalog);
            this.Controls.Add(this.lblFirstCatalog);
            this.Controls.Add(this.btnStartCount);
            this.Controls.Add(this.txtBxSecondCatalog);
            this.Controls.Add(this.txtBxFirstCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "FindFiles";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCountFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFirstCatalog;
        private System.Windows.Forms.TextBox txtBxSecondCatalog;
        private System.Windows.Forms.Button btnStartCount;
        private System.Windows.Forms.Label lblFirstCatalog;
        private System.Windows.Forms.Label lblSecondCatalog;
        private System.Windows.Forms.TextBox txtBoxCountCatalogsInFirst;
        private System.Windows.Forms.TextBox txtBoxCountCatalogsInSecond;
        private System.Windows.Forms.Label lblCountCatalogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownCountFiles;
        private System.Windows.Forms.Label lblCountFiles;
        private System.Windows.Forms.ComboBox cmbBxCatalogsInFirst;
        private System.Windows.Forms.ComboBox cmbBxCatalogsInSecond;
        private System.Windows.Forms.CheckBox chckBxRecursive;
        private System.Windows.Forms.FolderBrowserDialog fldBrwsrDlg;
        private System.Windows.Forms.Button btnGetDir1;
        private System.Windows.Forms.Button btnGetDir2;
        private System.Windows.Forms.Button btnHelp;
    }
}

