namespace PacketGenerateor.Panels
{
    partial class TabARP
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
            this.labelDestHardwareAddr = new System.Windows.Forms.Label();
            this.destProtocolAddr = new System.Windows.Forms.TextBox();
            this.destHardwareAddr = new System.Windows.Forms.TextBox();
            this.labeldestProtocolAddr = new System.Windows.Forms.Label();
            this.sourceProtocolAddr = new System.Windows.Forms.TextBox();
            this.labelSourceProtocolAddr = new System.Windows.Forms.Label();
            this.sourceHardwareAddr = new System.Windows.Forms.TextBox();
            this.labelSourceHardwareAddr = new System.Windows.Forms.Label();
            this.btnGetMy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDataLink
            // 
            this.btnAddDataLink.Location = new System.Drawing.Point(461, 30);
            this.btnAddDataLink.Name = "btnAddDataLink";
            this.btnAddDataLink.Size = new System.Drawing.Size(100, 20);
            this.btnAddDataLink.TabIndex = 22;
            this.btnAddDataLink.Text = "Add";
            this.btnAddDataLink.UseVisualStyleBackColor = true;
            this.btnAddDataLink.Click += new System.EventHandler(this.btnAddDataLink_Click);
            // 
            // labelDestHardwareAddr
            // 
            this.labelDestHardwareAddr.AutoSize = true;
            this.labelDestHardwareAddr.Location = new System.Drawing.Point(237, 14);
            this.labelDestHardwareAddr.Name = "labelDestHardwareAddr";
            this.labelDestHardwareAddr.Size = new System.Drawing.Size(97, 13);
            this.labelDestHardwareAddr.TabIndex = 21;
            this.labelDestHardwareAddr.Text = "DestHardwareAddr";
            // 
            // destProtocolAddr
            // 
            this.destProtocolAddr.Location = new System.Drawing.Point(355, 30);
            this.destProtocolAddr.Name = "destProtocolAddr";
            this.destProtocolAddr.Size = new System.Drawing.Size(100, 20);
            this.destProtocolAddr.TabIndex = 20;
            // 
            // destHardwareAddr
            // 
            this.destHardwareAddr.Location = new System.Drawing.Point(240, 30);
            this.destHardwareAddr.Name = "destHardwareAddr";
            this.destHardwareAddr.Size = new System.Drawing.Size(100, 20);
            this.destHardwareAddr.TabIndex = 18;
            // 
            // labeldestProtocolAddr
            // 
            this.labeldestProtocolAddr.AutoSize = true;
            this.labeldestProtocolAddr.Location = new System.Drawing.Point(352, 14);
            this.labeldestProtocolAddr.Name = "labeldestProtocolAddr";
            this.labeldestProtocolAddr.Size = new System.Drawing.Size(90, 13);
            this.labeldestProtocolAddr.TabIndex = 19;
            this.labeldestProtocolAddr.Text = "DestProtocolAddr";
            // 
            // sourceProtocolAddr
            // 
            this.sourceProtocolAddr.Location = new System.Drawing.Point(126, 30);
            this.sourceProtocolAddr.Name = "sourceProtocolAddr";
            this.sourceProtocolAddr.Size = new System.Drawing.Size(108, 20);
            this.sourceProtocolAddr.TabIndex = 17;
            // 
            // labelSourceProtocolAddr
            // 
            this.labelSourceProtocolAddr.AutoSize = true;
            this.labelSourceProtocolAddr.Location = new System.Drawing.Point(123, 14);
            this.labelSourceProtocolAddr.Name = "labelSourceProtocolAddr";
            this.labelSourceProtocolAddr.Size = new System.Drawing.Size(102, 13);
            this.labelSourceProtocolAddr.TabIndex = 16;
            this.labelSourceProtocolAddr.Text = "SourceProtocolAddr";
            // 
            // sourceHardwareAddr
            // 
            this.sourceHardwareAddr.Location = new System.Drawing.Point(11, 30);
            this.sourceHardwareAddr.Name = "sourceHardwareAddr";
            this.sourceHardwareAddr.Size = new System.Drawing.Size(106, 20);
            this.sourceHardwareAddr.TabIndex = 15;
            // 
            // labelSourceHardwareAddr
            // 
            this.labelSourceHardwareAddr.AutoSize = true;
            this.labelSourceHardwareAddr.Location = new System.Drawing.Point(8, 14);
            this.labelSourceHardwareAddr.Name = "labelSourceHardwareAddr";
            this.labelSourceHardwareAddr.Size = new System.Drawing.Size(109, 13);
            this.labelSourceHardwareAddr.TabIndex = 14;
            this.labelSourceHardwareAddr.Text = "SourceHardwareAddr";
            // 
            // btnGetMy
            // 
            this.btnGetMy.Location = new System.Drawing.Point(11, 56);
            this.btnGetMy.Name = "btnGetMy";
            this.btnGetMy.Size = new System.Drawing.Size(106, 20);
            this.btnGetMy.TabIndex = 23;
            this.btnGetMy.Text = "GET MY";
            this.btnGetMy.UseVisualStyleBackColor = true;
            this.btnGetMy.Click += new System.EventHandler(this.btnGetMy_Click);
            // 
            // TabARP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetMy);
            this.Controls.Add(this.btnAddDataLink);
            this.Controls.Add(this.labelDestHardwareAddr);
            this.Controls.Add(this.destProtocolAddr);
            this.Controls.Add(this.destHardwareAddr);
            this.Controls.Add(this.labeldestProtocolAddr);
            this.Controls.Add(this.sourceProtocolAddr);
            this.Controls.Add(this.labelSourceProtocolAddr);
            this.Controls.Add(this.sourceHardwareAddr);
            this.Controls.Add(this.labelSourceHardwareAddr);
            this.Name = "TabARP";
            this.Size = new System.Drawing.Size(607, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDataLink;
        private System.Windows.Forms.Label labelDestHardwareAddr;
        private System.Windows.Forms.TextBox destProtocolAddr;
        private System.Windows.Forms.TextBox destHardwareAddr;
        private System.Windows.Forms.Label labeldestProtocolAddr;
        private System.Windows.Forms.TextBox sourceProtocolAddr;
        private System.Windows.Forms.Label labelSourceProtocolAddr;
        public System.Windows.Forms.TextBox sourceHardwareAddr;
        private System.Windows.Forms.Label labelSourceHardwareAddr;
        private System.Windows.Forms.Button btnGetMy;
    }
}
