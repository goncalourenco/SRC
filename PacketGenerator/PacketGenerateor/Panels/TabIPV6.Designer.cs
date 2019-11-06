namespace PacketGenerateor.Panels
{
    partial class TabIPV6
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
            this.txtdestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.txtsource = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.txtflowlabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoplimit = new System.Windows.Forms.TextBox();
            this.labelNextHeader = new System.Windows.Forms.Label();
            this.cmbINextHeader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddDataLink
            // 
            this.btnAddDataLink.Location = new System.Drawing.Point(449, 93);
            this.btnAddDataLink.Name = "btnAddDataLink";
            this.btnAddDataLink.Size = new System.Drawing.Size(100, 20);
            this.btnAddDataLink.TabIndex = 25;
            this.btnAddDataLink.Text = "Add";
            this.btnAddDataLink.UseVisualStyleBackColor = true;
            this.btnAddDataLink.Click += new System.EventHandler(this.btnAddDataLink_Click);
            // 
            // txtdestination
            // 
            this.txtdestination.Location = new System.Drawing.Point(272, 47);
            this.txtdestination.Name = "txtdestination";
            this.txtdestination.Size = new System.Drawing.Size(239, 20);
            this.txtdestination.TabIndex = 24;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(272, 31);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 13);
            this.labelDestination.TabIndex = 23;
            this.labelDestination.Text = "Destination";
            // 
            // txtsource
            // 
            this.txtsource.Location = new System.Drawing.Point(24, 46);
            this.txtsource.Name = "txtsource";
            this.txtsource.Size = new System.Drawing.Size(242, 20);
            this.txtsource.TabIndex = 27;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(21, 30);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 26;
            this.labelSource.Text = "Source";
            // 
            // txtflowlabel
            // 
            this.txtflowlabel.Location = new System.Drawing.Point(24, 92);
            this.txtflowlabel.Name = "txtflowlabel";
            this.txtflowlabel.Size = new System.Drawing.Size(96, 20);
            this.txtflowlabel.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Flow Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hop Limit";
            // 
            // txthoplimit
            // 
            this.txthoplimit.Location = new System.Drawing.Point(126, 92);
            this.txthoplimit.Name = "txthoplimit";
            this.txthoplimit.Size = new System.Drawing.Size(97, 20);
            this.txthoplimit.TabIndex = 30;
            // 
            // labelNextHeader
            // 
            this.labelNextHeader.AutoSize = true;
            this.labelNextHeader.Location = new System.Drawing.Point(226, 76);
            this.labelNextHeader.Name = "labelNextHeader";
            this.labelNextHeader.Size = new System.Drawing.Size(67, 13);
            this.labelNextHeader.TabIndex = 39;
            this.labelNextHeader.Text = "Next Header";
            // 
            // cmbINextHeader
            // 
            this.cmbINextHeader.FormattingEnabled = true;
            this.cmbINextHeader.Location = new System.Drawing.Point(229, 92);
            this.cmbINextHeader.Name = "cmbINextHeader";
            this.cmbINextHeader.Size = new System.Drawing.Size(214, 21);
            this.cmbINextHeader.TabIndex = 38;
            // 
            // TabIPV6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNextHeader);
            this.Controls.Add(this.cmbINextHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoplimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtflowlabel);
            this.Controls.Add(this.txtsource);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.btnAddDataLink);
            this.Controls.Add(this.txtdestination);
            this.Controls.Add(this.labelDestination);
            this.Name = "TabIPV6";
            this.Size = new System.Drawing.Size(644, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDataLink;
        private System.Windows.Forms.TextBox txtdestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox txtsource;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox txtflowlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoplimit;
        private System.Windows.Forms.Label labelNextHeader;
        private System.Windows.Forms.ComboBox cmbINextHeader;
    }
}
