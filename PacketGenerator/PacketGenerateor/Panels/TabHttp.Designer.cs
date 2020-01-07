namespace PacketGenerateor.Panels
{
    partial class TabHttp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddDataLink = new System.Windows.Forms.Button();
            this.labelIPv4Protocol = new System.Windows.Forms.Label();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.labelNetSourceIP = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDataLink
            // 
            this.btnAddDataLink.Location = new System.Drawing.Point(421, 196);
            this.btnAddDataLink.Name = "btnAddDataLink";
            this.btnAddDataLink.Size = new System.Drawing.Size(100, 20);
            this.btnAddDataLink.TabIndex = 26;
            this.btnAddDataLink.Text = "Add";
            this.btnAddDataLink.UseVisualStyleBackColor = true;
            this.btnAddDataLink.Click += new System.EventHandler(this.btnAddDataLink_Click);
            // 
            // labelIPv4Protocol
            // 
            this.labelIPv4Protocol.AutoSize = true;
            this.labelIPv4Protocol.Location = new System.Drawing.Point(14, 12);
            this.labelIPv4Protocol.Name = "labelIPv4Protocol";
            this.labelIPv4Protocol.Size = new System.Drawing.Size(42, 13);
            this.labelIPv4Protocol.TabIndex = 39;
            this.labelIPv4Protocol.Text = "Version";
            // 
            // cmbVersion
            // 
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(17, 26);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(214, 21);
            this.cmbVersion.TabIndex = 38;
            // 
            // labelNetSourceIP
            // 
            this.labelNetSourceIP.AutoSize = true;
            this.labelNetSourceIP.Location = new System.Drawing.Point(14, 87);
            this.labelNetSourceIP.Name = "labelNetSourceIP";
            this.labelNetSourceIP.Size = new System.Drawing.Size(31, 13);
            this.labelNetSourceIP.TabIndex = 48;
            this.labelNetSourceIP.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(17, 103);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(504, 87);
            this.txtBody.TabIndex = 50;
            this.txtBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Method";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(237, 26);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(144, 21);
            this.cmbMethod.TabIndex = 51;
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(17, 64);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(364, 20);
            this.txtURI.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "URI";
            // 
            // TabHttp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.labelNetSourceIP);
            this.Controls.Add(this.labelIPv4Protocol);
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.btnAddDataLink);
            this.Name = "TabHttp";
            this.Size = new System.Drawing.Size(547, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDataLink;
        private System.Windows.Forms.Label labelIPv4Protocol;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label labelNetSourceIP;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label2;
    }
}
