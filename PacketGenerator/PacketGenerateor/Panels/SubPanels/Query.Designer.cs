namespace PacketGenerateor.Panels.SubPanels
{
    partial class Query
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.labelNetworkID = new System.Windows.Forms.Label();
            this.labelOpCOde = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 20);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(12, 40);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(255, 20);
            this.txtDomainName.TabIndex = 50;
            this.txtDomainName.Text = "pcap.net";
            // 
            // labelNetworkID
            // 
            this.labelNetworkID.AutoSize = true;
            this.labelNetworkID.Location = new System.Drawing.Point(9, 24);
            this.labelNetworkID.Name = "labelNetworkID";
            this.labelNetworkID.Size = new System.Drawing.Size(74, 13);
            this.labelNetworkID.TabIndex = 49;
            this.labelNetworkID.Text = "Domain Name";
            // 
            // labelOpCOde
            // 
            this.labelOpCOde.AutoSize = true;
            this.labelOpCOde.Location = new System.Drawing.Point(274, 25);
            this.labelOpCOde.Name = "labelOpCOde";
            this.labelOpCOde.Size = new System.Drawing.Size(31, 13);
            this.labelOpCOde.TabIndex = 72;
            this.labelOpCOde.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(277, 39);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(168, 21);
            this.cmbType.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(277, 83);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(168, 21);
            this.cmbClass.TabIndex = 73;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.labelOpCOde);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.labelNetworkID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Query";
            this.Text = "Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Label labelNetworkID;
        private System.Windows.Forms.Label labelOpCOde;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
    }
}