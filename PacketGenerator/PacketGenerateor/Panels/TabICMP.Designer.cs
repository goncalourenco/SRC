namespace PacketGenerateor.Panels
{
    partial class TabICMP
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkBoxCheckSum = new System.Windows.Forms.CheckBox();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.labelNetworkCheckSum = new System.Windows.Forms.Label();
            this.txtidentification = new System.Windows.Forms.TextBox();
            this.labelNetworkID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 20);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkBoxCheckSum
            // 
            this.checkBoxCheckSum.AutoSize = true;
            this.checkBoxCheckSum.Checked = true;
            this.checkBoxCheckSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckSum.Location = new System.Drawing.Point(210, 38);
            this.checkBoxCheckSum.Name = "checkBoxCheckSum";
            this.checkBoxCheckSum.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCheckSum.TabIndex = 50;
            this.checkBoxCheckSum.Text = "AUTO";
            this.checkBoxCheckSum.UseVisualStyleBackColor = true;
            this.checkBoxCheckSum.CheckedChanged += new System.EventHandler(this.checkBoxCheckSum_CheckedChanged);
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Enabled = false;
            this.txtCheckSum.Location = new System.Drawing.Point(124, 35);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.Size = new System.Drawing.Size(80, 20);
            this.txtCheckSum.TabIndex = 49;
            // 
            // labelNetworkCheckSum
            // 
            this.labelNetworkCheckSum.AutoSize = true;
            this.labelNetworkCheckSum.Location = new System.Drawing.Point(121, 19);
            this.labelNetworkCheckSum.Name = "labelNetworkCheckSum";
            this.labelNetworkCheckSum.Size = new System.Drawing.Size(59, 13);
            this.labelNetworkCheckSum.TabIndex = 48;
            this.labelNetworkCheckSum.Text = "CheckSum";
            // 
            // txtidentification
            // 
            this.txtidentification.Location = new System.Drawing.Point(18, 35);
            this.txtidentification.Name = "txtidentification";
            this.txtidentification.Size = new System.Drawing.Size(100, 20);
            this.txtidentification.TabIndex = 47;
            this.txtidentification.Text = "456";
            // 
            // labelNetworkID
            // 
            this.labelNetworkID.AutoSize = true;
            this.labelNetworkID.Location = new System.Drawing.Point(15, 19);
            this.labelNetworkID.Name = "labelNetworkID";
            this.labelNetworkID.Size = new System.Drawing.Size(67, 13);
            this.labelNetworkID.TabIndex = 46;
            this.labelNetworkID.Text = "Identification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sequence Nº";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(18, 84);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(100, 20);
            this.txtSequence.TabIndex = 53;
            this.txtSequence.Text = "800";
            // 
            // TabICMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkBoxCheckSum);
            this.Controls.Add(this.txtCheckSum);
            this.Controls.Add(this.labelNetworkCheckSum);
            this.Controls.Add(this.txtidentification);
            this.Controls.Add(this.labelNetworkID);
            this.Name = "TabICMP";
            this.Size = new System.Drawing.Size(481, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkBoxCheckSum;
        private System.Windows.Forms.TextBox txtCheckSum;
        private System.Windows.Forms.Label labelNetworkCheckSum;
        private System.Windows.Forms.TextBox txtidentification;
        private System.Windows.Forms.Label labelNetworkID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSequence;
    }
}
