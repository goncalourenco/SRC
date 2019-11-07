namespace PacketGenerateor.Panels.SubPanels
{
    partial class Answer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.labelOpCOde = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.labelNetworkID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(277, 76);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(168, 21);
            this.cmbClass.TabIndex = 81;
            // 
            // labelOpCOde
            // 
            this.labelOpCOde.AutoSize = true;
            this.labelOpCOde.Location = new System.Drawing.Point(274, 18);
            this.labelOpCOde.Name = "labelOpCOde";
            this.labelOpCOde.Size = new System.Drawing.Size(31, 13);
            this.labelOpCOde.TabIndex = 80;
            this.labelOpCOde.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(277, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(168, 21);
            this.cmbType.TabIndex = 79;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(12, 33);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(255, 20);
            this.txtDomainName.TabIndex = 78;
            this.txtDomainName.Text = "pcap.net";
            // 
            // labelNetworkID
            // 
            this.labelNetworkID.AutoSize = true;
            this.labelNetworkID.Location = new System.Drawing.Point(9, 17);
            this.labelNetworkID.Name = "labelNetworkID";
            this.labelNetworkID.Size = new System.Drawing.Size(74, 13);
            this.labelNetworkID.TabIndex = 77;
            this.labelNetworkID.Text = "Domain Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 76;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 20);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(12, 77);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(79, 20);
            this.txtTTL.TabIndex = 84;
            this.txtTTL.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "TTL";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(100, 76);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(168, 21);
            this.cmbDataType.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Data Type";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(13, 124);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(432, 20);
            this.txtData.TabIndex = 88;
            this.txtData.Text = "pcap.net";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Data";
            // 
            // Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 260);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDataType);
            this.Controls.Add(this.txtTTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.labelOpCOde);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.labelNetworkID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Answer";
            this.Text = "Answers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label labelOpCOde;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Label labelNetworkID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label4;
    }
}