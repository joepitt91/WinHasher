namespace JoePitt.WinHasher.GUI
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputFilePath = new System.Windows.Forms.TextBox();
            this.inputFileBrowse = new System.Windows.Forms.Button();
            this.hashingGroup = new System.Windows.Forms.GroupBox();
            this.computeHashes = new System.Windows.Forms.Button();
            this.sha512Hash = new System.Windows.Forms.TextBox();
            this.computeSHA512 = new System.Windows.Forms.CheckBox();
            this.sha384Hash = new System.Windows.Forms.TextBox();
            this.computeSHA384 = new System.Windows.Forms.CheckBox();
            this.sha256Hash = new System.Windows.Forms.TextBox();
            this.computeSHA256 = new System.Windows.Forms.CheckBox();
            this.sha1Hash = new System.Windows.Forms.TextBox();
            this.computeSHA1 = new System.Windows.Forms.CheckBox();
            this.md5Hash = new System.Windows.Forms.TextBox();
            this.computeMD5 = new System.Windows.Forms.CheckBox();
            this.verifyHashGroup = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.verifyResult = new System.Windows.Forms.TextBox();
            this.expectedHash = new System.Windows.Forms.TextBox();
            this.expectedHashLabel = new System.Windows.Forms.Label();
            this.verifyHash = new System.Windows.Forms.Button();
            this.hashTypeLabel = new System.Windows.Forms.Label();
            this.hashType = new System.Windows.Forms.ComboBox();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.projectPageLink = new System.Windows.Forms.LinkLabel();
            this.sourceCodeLink = new System.Windows.Forms.LinkLabel();
            this.hashingGroup.SuspendLayout();
            this.verifyHashGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 9);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(50, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input File";
            // 
            // inputFilePath
            // 
            this.inputFilePath.AccessibleName = "Input File";
            this.inputFilePath.Location = new System.Drawing.Point(12, 25);
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.ReadOnly = true;
            this.inputFilePath.Size = new System.Drawing.Size(916, 20);
            this.inputFilePath.TabIndex = 1;
            // 
            // inputFileBrowse
            // 
            this.inputFileBrowse.Location = new System.Drawing.Point(934, 23);
            this.inputFileBrowse.Name = "inputFileBrowse";
            this.inputFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.inputFileBrowse.TabIndex = 2;
            this.inputFileBrowse.Text = "&Browse...";
            this.inputFileBrowse.UseVisualStyleBackColor = true;
            this.inputFileBrowse.Click += new System.EventHandler(this.InputFileBrowse_Click);
            // 
            // hashingGroup
            // 
            this.hashingGroup.Controls.Add(this.computeHashes);
            this.hashingGroup.Controls.Add(this.sha512Hash);
            this.hashingGroup.Controls.Add(this.computeSHA512);
            this.hashingGroup.Controls.Add(this.sha384Hash);
            this.hashingGroup.Controls.Add(this.computeSHA384);
            this.hashingGroup.Controls.Add(this.sha256Hash);
            this.hashingGroup.Controls.Add(this.computeSHA256);
            this.hashingGroup.Controls.Add(this.sha1Hash);
            this.hashingGroup.Controls.Add(this.computeSHA1);
            this.hashingGroup.Controls.Add(this.md5Hash);
            this.hashingGroup.Controls.Add(this.computeMD5);
            this.hashingGroup.Location = new System.Drawing.Point(12, 66);
            this.hashingGroup.Name = "hashingGroup";
            this.hashingGroup.Size = new System.Drawing.Size(997, 179);
            this.hashingGroup.TabIndex = 3;
            this.hashingGroup.TabStop = false;
            this.hashingGroup.Text = "Compute Hashes";
            // 
            // computeHashes
            // 
            this.computeHashes.Location = new System.Drawing.Point(78, 147);
            this.computeHashes.Name = "computeHashes";
            this.computeHashes.Size = new System.Drawing.Size(910, 23);
            this.computeHashes.TabIndex = 5;
            this.computeHashes.Text = "&Compute Hashes";
            this.computeHashes.UseVisualStyleBackColor = true;
            this.computeHashes.Click += new System.EventHandler(this.ComputeHashes_Click);
            // 
            // sha512Hash
            // 
            this.sha512Hash.AccessibleName = "S H A 512 Hash";
            this.sha512Hash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha512Hash.Location = new System.Drawing.Point(78, 121);
            this.sha512Hash.Name = "sha512Hash";
            this.sha512Hash.ReadOnly = true;
            this.sha512Hash.Size = new System.Drawing.Size(910, 20);
            this.sha512Hash.TabIndex = 10;
            // 
            // computeSHA512
            // 
            this.computeSHA512.AutoSize = true;
            this.computeSHA512.Location = new System.Drawing.Point(6, 123);
            this.computeSHA512.Name = "computeSHA512";
            this.computeSHA512.Size = new System.Drawing.Size(66, 17);
            this.computeSHA512.TabIndex = 4;
            this.computeSHA512.Text = "SHA512";
            this.computeSHA512.UseVisualStyleBackColor = true;
            // 
            // sha384Hash
            // 
            this.sha384Hash.AccessibleName = "S H A 384 Hash";
            this.sha384Hash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha384Hash.Location = new System.Drawing.Point(78, 95);
            this.sha384Hash.Name = "sha384Hash";
            this.sha384Hash.ReadOnly = true;
            this.sha384Hash.Size = new System.Drawing.Size(910, 20);
            this.sha384Hash.TabIndex = 9;
            // 
            // computeSHA384
            // 
            this.computeSHA384.AutoSize = true;
            this.computeSHA384.Location = new System.Drawing.Point(6, 97);
            this.computeSHA384.Name = "computeSHA384";
            this.computeSHA384.Size = new System.Drawing.Size(66, 17);
            this.computeSHA384.TabIndex = 3;
            this.computeSHA384.Text = "SHA384";
            this.computeSHA384.UseVisualStyleBackColor = true;
            // 
            // sha256Hash
            // 
            this.sha256Hash.AccessibleName = "S H A 256 Hash";
            this.sha256Hash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha256Hash.Location = new System.Drawing.Point(78, 69);
            this.sha256Hash.Name = "sha256Hash";
            this.sha256Hash.ReadOnly = true;
            this.sha256Hash.Size = new System.Drawing.Size(910, 20);
            this.sha256Hash.TabIndex = 8;
            // 
            // computeSHA256
            // 
            this.computeSHA256.AutoSize = true;
            this.computeSHA256.Location = new System.Drawing.Point(6, 71);
            this.computeSHA256.Name = "computeSHA256";
            this.computeSHA256.Size = new System.Drawing.Size(66, 17);
            this.computeSHA256.TabIndex = 2;
            this.computeSHA256.Text = "SHA256";
            this.computeSHA256.UseVisualStyleBackColor = true;
            // 
            // sha1Hash
            // 
            this.sha1Hash.AccessibleName = "S H A 1 Hash";
            this.sha1Hash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha1Hash.Location = new System.Drawing.Point(78, 43);
            this.sha1Hash.Name = "sha1Hash";
            this.sha1Hash.ReadOnly = true;
            this.sha1Hash.Size = new System.Drawing.Size(910, 20);
            this.sha1Hash.TabIndex = 7;
            // 
            // computeSHA1
            // 
            this.computeSHA1.AutoSize = true;
            this.computeSHA1.Location = new System.Drawing.Point(6, 45);
            this.computeSHA1.Name = "computeSHA1";
            this.computeSHA1.Size = new System.Drawing.Size(54, 17);
            this.computeSHA1.TabIndex = 1;
            this.computeSHA1.Text = "SHA1";
            this.computeSHA1.UseVisualStyleBackColor = true;
            // 
            // md5Hash
            // 
            this.md5Hash.AccessibleName = "M D 5 Hash";
            this.md5Hash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md5Hash.Location = new System.Drawing.Point(78, 17);
            this.md5Hash.Name = "md5Hash";
            this.md5Hash.ReadOnly = true;
            this.md5Hash.Size = new System.Drawing.Size(910, 20);
            this.md5Hash.TabIndex = 6;
            // 
            // computeMD5
            // 
            this.computeMD5.AutoSize = true;
            this.computeMD5.Location = new System.Drawing.Point(6, 19);
            this.computeMD5.Name = "computeMD5";
            this.computeMD5.Size = new System.Drawing.Size(49, 17);
            this.computeMD5.TabIndex = 0;
            this.computeMD5.Text = "MD5";
            this.computeMD5.UseVisualStyleBackColor = true;
            // 
            // verifyHashGroup
            // 
            this.verifyHashGroup.Controls.Add(this.resultLabel);
            this.verifyHashGroup.Controls.Add(this.verifyResult);
            this.verifyHashGroup.Controls.Add(this.expectedHash);
            this.verifyHashGroup.Controls.Add(this.expectedHashLabel);
            this.verifyHashGroup.Controls.Add(this.verifyHash);
            this.verifyHashGroup.Controls.Add(this.hashTypeLabel);
            this.verifyHashGroup.Controls.Add(this.hashType);
            this.verifyHashGroup.Location = new System.Drawing.Point(12, 251);
            this.verifyHashGroup.Name = "verifyHashGroup";
            this.verifyHashGroup.Size = new System.Drawing.Size(997, 135);
            this.verifyHashGroup.TabIndex = 4;
            this.verifyHashGroup.TabStop = false;
            this.verifyHashGroup.Text = "Verify Hash";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 105);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result";
            // 
            // verifyResult
            // 
            this.verifyResult.AccessibleName = "Verification Result";
            this.verifyResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyResult.Location = new System.Drawing.Point(78, 102);
            this.verifyResult.Name = "verifyResult";
            this.verifyResult.ReadOnly = true;
            this.verifyResult.Size = new System.Drawing.Size(910, 20);
            this.verifyResult.TabIndex = 6;
            // 
            // expectedHash
            // 
            this.expectedHash.AccessibleName = "Expected Hash";
            this.expectedHash.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectedHash.Location = new System.Drawing.Point(78, 46);
            this.expectedHash.Name = "expectedHash";
            this.expectedHash.Size = new System.Drawing.Size(910, 20);
            this.expectedHash.TabIndex = 3;
            // 
            // expectedHashLabel
            // 
            this.expectedHashLabel.AutoSize = true;
            this.expectedHashLabel.Location = new System.Drawing.Point(6, 49);
            this.expectedHashLabel.Name = "expectedHashLabel";
            this.expectedHashLabel.Size = new System.Drawing.Size(32, 13);
            this.expectedHashLabel.TabIndex = 2;
            this.expectedHashLabel.Text = "Hash";
            // 
            // verifyHash
            // 
            this.verifyHash.Location = new System.Drawing.Point(78, 72);
            this.verifyHash.Name = "verifyHash";
            this.verifyHash.Size = new System.Drawing.Size(910, 23);
            this.verifyHash.TabIndex = 4;
            this.verifyHash.Text = "&Verify Hash";
            this.verifyHash.UseVisualStyleBackColor = true;
            this.verifyHash.Click += new System.EventHandler(this.VerifyHash_Click);
            // 
            // hashTypeLabel
            // 
            this.hashTypeLabel.AutoSize = true;
            this.hashTypeLabel.Location = new System.Drawing.Point(6, 22);
            this.hashTypeLabel.Name = "hashTypeLabel";
            this.hashTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.hashTypeLabel.TabIndex = 0;
            this.hashTypeLabel.Text = "Hash Type";
            // 
            // hashType
            // 
            this.hashType.AccessibleName = "Hash Type";
            this.hashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashType.FormattingEnabled = true;
            this.hashType.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashType.Location = new System.Drawing.Point(78, 19);
            this.hashType.Name = "hashType";
            this.hashType.Size = new System.Drawing.Size(910, 21);
            this.hashType.TabIndex = 1;
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(12, 389);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(35, 13);
            this.aboutLink.TabIndex = 5;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "About";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // projectPageLink
            // 
            this.projectPageLink.AutoSize = true;
            this.projectPageLink.Location = new System.Drawing.Point(53, 389);
            this.projectPageLink.Name = "projectPageLink";
            this.projectPageLink.Size = new System.Drawing.Size(68, 13);
            this.projectPageLink.TabIndex = 6;
            this.projectPageLink.TabStop = true;
            this.projectPageLink.Text = "Project Page";
            this.projectPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProjectPageLink_LinkClicked);
            // 
            // sourceCodeLink
            // 
            this.sourceCodeLink.AutoSize = true;
            this.sourceCodeLink.Location = new System.Drawing.Point(127, 389);
            this.sourceCodeLink.Name = "sourceCodeLink";
            this.sourceCodeLink.Size = new System.Drawing.Size(69, 13);
            this.sourceCodeLink.TabIndex = 7;
            this.sourceCodeLink.TabStop = true;
            this.sourceCodeLink.Text = "Source Code";
            this.sourceCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCodeLink_LinkClicked);
            // 
            // MainUI
            // 
            this.AcceptButton = this.computeHashes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 410);
            this.Controls.Add(this.sourceCodeLink);
            this.Controls.Add(this.projectPageLink);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.verifyHashGroup);
            this.Controls.Add(this.hashingGroup);
            this.Controls.Add(this.inputFileBrowse);
            this.Controls.Add(this.inputFilePath);
            this.Controls.Add(this.inputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinHasher GUI";
            this.hashingGroup.ResumeLayout(false);
            this.hashingGroup.PerformLayout();
            this.verifyHashGroup.ResumeLayout(false);
            this.verifyHashGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputFilePath;
        private System.Windows.Forms.Button inputFileBrowse;
        private System.Windows.Forms.GroupBox hashingGroup;
        private System.Windows.Forms.Button computeHashes;
        private System.Windows.Forms.TextBox sha512Hash;
        private System.Windows.Forms.CheckBox computeSHA512;
        private System.Windows.Forms.TextBox sha384Hash;
        private System.Windows.Forms.CheckBox computeSHA384;
        private System.Windows.Forms.TextBox sha256Hash;
        private System.Windows.Forms.CheckBox computeSHA256;
        private System.Windows.Forms.TextBox sha1Hash;
        private System.Windows.Forms.CheckBox computeSHA1;
        private System.Windows.Forms.TextBox md5Hash;
        private System.Windows.Forms.CheckBox computeMD5;
        private System.Windows.Forms.GroupBox verifyHashGroup;
        private System.Windows.Forms.Button verifyHash;
        private System.Windows.Forms.Label hashTypeLabel;
        private System.Windows.Forms.ComboBox hashType;
        private System.Windows.Forms.TextBox expectedHash;
        private System.Windows.Forms.Label expectedHashLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox verifyResult;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.LinkLabel projectPageLink;
        private System.Windows.Forms.LinkLabel sourceCodeLink;
    }
}