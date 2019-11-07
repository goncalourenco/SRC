namespace PacketGenerateor.Panels
{
    partial class TabDNS
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
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.labelNetworkID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckResponse = new System.Windows.Forms.CheckBox();
            this.ckAutoritativeAnswer = new System.Windows.Forms.CheckBox();
            this.ckTruncated = new System.Windows.Forms.CheckBox();
            this.ckRecursionDesired = new System.Windows.Forms.CheckBox();
            this.ckRecursionAvailable = new System.Windows.Forms.CheckBox();
            this.ckFutureUse = new System.Windows.Forms.CheckBox();
            this.ckAuthenticData = new System.Windows.Forms.CheckBox();
            this.ckCheckingDisabled = new System.Windows.Forms.CheckBox();
            this.labelOpCOde = new System.Windows.Forms.Label();
            this.cmbOpCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResponseCode = new System.Windows.Forms.ComboBox();
            this.ckQuery = new System.Windows.Forms.CheckBox();
            this.listQueries = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAnswers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listAuthorities = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listAdditional = new System.Windows.Forms.ListBox();
            this.btnAddQuery = new System.Windows.Forms.Button();
            this.btnRmQuery = new System.Windows.Forms.Button();
            this.btnRmAnswers = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.btnRmAuthorities = new System.Windows.Forms.Button();
            this.btnAddAuthorities = new System.Windows.Forms.Button();
            this.btnRmAdditional = new System.Windows.Forms.Button();
            this.btnAddAdditional = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCompression = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(11, 20);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(100, 20);
            this.txtIdentification.TabIndex = 37;
            this.txtIdentification.Text = "10012";
            // 
            // labelNetworkID
            // 
            this.labelNetworkID.AutoSize = true;
            this.labelNetworkID.Location = new System.Drawing.Point(8, 4);
            this.labelNetworkID.Name = "labelNetworkID";
            this.labelNetworkID.Size = new System.Drawing.Size(67, 13);
            this.labelNetworkID.TabIndex = 36;
            this.labelNetworkID.Text = "Identification";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(482, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 20);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ckResponse
            // 
            this.ckResponse.AutoSize = true;
            this.ckResponse.Checked = true;
            this.ckResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckResponse.Location = new System.Drawing.Point(329, 20);
            this.ckResponse.Name = "ckResponse";
            this.ckResponse.Size = new System.Drawing.Size(74, 17);
            this.ckResponse.TabIndex = 61;
            this.ckResponse.Text = "Response";
            this.ckResponse.UseVisualStyleBackColor = true;
            // 
            // ckAutoritativeAnswer
            // 
            this.ckAutoritativeAnswer.AutoSize = true;
            this.ckAutoritativeAnswer.Checked = true;
            this.ckAutoritativeAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAutoritativeAnswer.Location = new System.Drawing.Point(329, 43);
            this.ckAutoritativeAnswer.Name = "ckAutoritativeAnswer";
            this.ckAutoritativeAnswer.Size = new System.Drawing.Size(123, 17);
            this.ckAutoritativeAnswer.TabIndex = 62;
            this.ckAutoritativeAnswer.Text = "Authoritative Answer";
            this.ckAutoritativeAnswer.UseVisualStyleBackColor = true;
            // 
            // ckTruncated
            // 
            this.ckTruncated.AutoSize = true;
            this.ckTruncated.Location = new System.Drawing.Point(329, 66);
            this.ckTruncated.Name = "ckTruncated";
            this.ckTruncated.Size = new System.Drawing.Size(75, 17);
            this.ckTruncated.TabIndex = 63;
            this.ckTruncated.Text = "Truncated";
            this.ckTruncated.UseVisualStyleBackColor = true;
            // 
            // ckRecursionDesired
            // 
            this.ckRecursionDesired.AutoSize = true;
            this.ckRecursionDesired.Checked = true;
            this.ckRecursionDesired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRecursionDesired.Location = new System.Drawing.Point(329, 89);
            this.ckRecursionDesired.Name = "ckRecursionDesired";
            this.ckRecursionDesired.Size = new System.Drawing.Size(113, 17);
            this.ckRecursionDesired.TabIndex = 64;
            this.ckRecursionDesired.Text = "Recursion Desired";
            this.ckRecursionDesired.UseVisualStyleBackColor = true;
            // 
            // ckRecursionAvailable
            // 
            this.ckRecursionAvailable.AutoSize = true;
            this.ckRecursionAvailable.Checked = true;
            this.ckRecursionAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRecursionAvailable.Location = new System.Drawing.Point(448, 20);
            this.ckRecursionAvailable.Name = "ckRecursionAvailable";
            this.ckRecursionAvailable.Size = new System.Drawing.Size(120, 17);
            this.ckRecursionAvailable.TabIndex = 65;
            this.ckRecursionAvailable.Text = "Recursion Available";
            this.ckRecursionAvailable.UseVisualStyleBackColor = true;
            // 
            // ckFutureUse
            // 
            this.ckFutureUse.AutoSize = true;
            this.ckFutureUse.Location = new System.Drawing.Point(448, 43);
            this.ckFutureUse.Name = "ckFutureUse";
            this.ckFutureUse.Size = new System.Drawing.Size(78, 17);
            this.ckFutureUse.TabIndex = 66;
            this.ckFutureUse.Text = "Future Use";
            this.ckFutureUse.UseVisualStyleBackColor = true;
            // 
            // ckAuthenticData
            // 
            this.ckAuthenticData.AutoSize = true;
            this.ckAuthenticData.Checked = true;
            this.ckAuthenticData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAuthenticData.Location = new System.Drawing.Point(448, 66);
            this.ckAuthenticData.Name = "ckAuthenticData";
            this.ckAuthenticData.Size = new System.Drawing.Size(97, 17);
            this.ckAuthenticData.TabIndex = 67;
            this.ckAuthenticData.Text = "Authentic Data";
            this.ckAuthenticData.UseVisualStyleBackColor = true;
            // 
            // ckCheckingDisabled
            // 
            this.ckCheckingDisabled.AutoSize = true;
            this.ckCheckingDisabled.Location = new System.Drawing.Point(448, 89);
            this.ckCheckingDisabled.Name = "ckCheckingDisabled";
            this.ckCheckingDisabled.Size = new System.Drawing.Size(115, 17);
            this.ckCheckingDisabled.TabIndex = 68;
            this.ckCheckingDisabled.Text = "Checking Disabled";
            this.ckCheckingDisabled.UseVisualStyleBackColor = true;
            // 
            // labelOpCOde
            // 
            this.labelOpCOde.AutoSize = true;
            this.labelOpCOde.Location = new System.Drawing.Point(114, 6);
            this.labelOpCOde.Name = "labelOpCOde";
            this.labelOpCOde.Size = new System.Drawing.Size(45, 13);
            this.labelOpCOde.TabIndex = 70;
            this.labelOpCOde.Text = "Opcode";
            // 
            // cmbOpCode
            // 
            this.cmbOpCode.FormattingEnabled = true;
            this.cmbOpCode.Location = new System.Drawing.Point(117, 20);
            this.cmbOpCode.Name = "cmbOpCode";
            this.cmbOpCode.Size = new System.Drawing.Size(186, 21);
            this.cmbOpCode.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "ResponseCode";
            // 
            // cmbResponseCode
            // 
            this.cmbResponseCode.FormattingEnabled = true;
            this.cmbResponseCode.Location = new System.Drawing.Point(117, 62);
            this.cmbResponseCode.Name = "cmbResponseCode";
            this.cmbResponseCode.Size = new System.Drawing.Size(186, 21);
            this.cmbResponseCode.TabIndex = 71;
            // 
            // ckQuery
            // 
            this.ckQuery.AutoSize = true;
            this.ckQuery.Location = new System.Drawing.Point(448, 112);
            this.ckQuery.Name = "ckQuery";
            this.ckQuery.Size = new System.Drawing.Size(54, 17);
            this.ckQuery.TabIndex = 73;
            this.ckQuery.Text = "Query";
            this.ckQuery.UseVisualStyleBackColor = true;
            // 
            // listQueries
            // 
            this.listQueries.FormattingEnabled = true;
            this.listQueries.Location = new System.Drawing.Point(11, 146);
            this.listQueries.Name = "listQueries";
            this.listQueries.Size = new System.Drawing.Size(111, 69);
            this.listQueries.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Queries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Answers";
            // 
            // listAnswers
            // 
            this.listAnswers.FormattingEnabled = true;
            this.listAnswers.Location = new System.Drawing.Point(130, 146);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(111, 69);
            this.listAnswers.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Authorities";
            // 
            // listAuthorities
            // 
            this.listAuthorities.FormattingEnabled = true;
            this.listAuthorities.Location = new System.Drawing.Point(247, 146);
            this.listAuthorities.Name = "listAuthorities";
            this.listAuthorities.Size = new System.Drawing.Size(111, 69);
            this.listAuthorities.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Additional";
            // 
            // listAdditional
            // 
            this.listAdditional.FormattingEnabled = true;
            this.listAdditional.Location = new System.Drawing.Point(364, 146);
            this.listAdditional.Name = "listAdditional";
            this.listAdditional.Size = new System.Drawing.Size(115, 69);
            this.listAdditional.TabIndex = 80;
            // 
            // btnAddQuery
            // 
            this.btnAddQuery.Location = new System.Drawing.Point(11, 221);
            this.btnAddQuery.Name = "btnAddQuery";
            this.btnAddQuery.Size = new System.Drawing.Size(40, 20);
            this.btnAddQuery.TabIndex = 82;
            this.btnAddQuery.Text = "Add";
            this.btnAddQuery.UseVisualStyleBackColor = true;
            this.btnAddQuery.Click += new System.EventHandler(this.btnAddQuery_Click);
            // 
            // btnRmQuery
            // 
            this.btnRmQuery.Location = new System.Drawing.Point(57, 221);
            this.btnRmQuery.Name = "btnRmQuery";
            this.btnRmQuery.Size = new System.Drawing.Size(65, 20);
            this.btnRmQuery.TabIndex = 83;
            this.btnRmQuery.Text = "Remove";
            this.btnRmQuery.UseVisualStyleBackColor = true;
            this.btnRmQuery.Click += new System.EventHandler(this.btnRmQuery_Click);
            // 
            // btnRmAnswers
            // 
            this.btnRmAnswers.Location = new System.Drawing.Point(176, 221);
            this.btnRmAnswers.Name = "btnRmAnswers";
            this.btnRmAnswers.Size = new System.Drawing.Size(65, 20);
            this.btnRmAnswers.TabIndex = 85;
            this.btnRmAnswers.Text = "Remove";
            this.btnRmAnswers.UseVisualStyleBackColor = true;
            this.btnRmAnswers.Click += new System.EventHandler(this.btnRmAnswers_Click);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(130, 221);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(40, 20);
            this.btnAddAnswer.TabIndex = 84;
            this.btnAddAnswer.Text = "Add";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // btnRmAuthorities
            // 
            this.btnRmAuthorities.Location = new System.Drawing.Point(293, 221);
            this.btnRmAuthorities.Name = "btnRmAuthorities";
            this.btnRmAuthorities.Size = new System.Drawing.Size(65, 20);
            this.btnRmAuthorities.TabIndex = 87;
            this.btnRmAuthorities.Text = "Remove";
            this.btnRmAuthorities.UseVisualStyleBackColor = true;
            this.btnRmAuthorities.Click += new System.EventHandler(this.btnRmAuthorities_Click);
            // 
            // btnAddAuthorities
            // 
            this.btnAddAuthorities.Location = new System.Drawing.Point(247, 221);
            this.btnAddAuthorities.Name = "btnAddAuthorities";
            this.btnAddAuthorities.Size = new System.Drawing.Size(40, 20);
            this.btnAddAuthorities.TabIndex = 86;
            this.btnAddAuthorities.Text = "Add";
            this.btnAddAuthorities.UseVisualStyleBackColor = true;
            // 
            // btnRmAdditional
            // 
            this.btnRmAdditional.Location = new System.Drawing.Point(411, 221);
            this.btnRmAdditional.Name = "btnRmAdditional";
            this.btnRmAdditional.Size = new System.Drawing.Size(65, 20);
            this.btnRmAdditional.TabIndex = 89;
            this.btnRmAdditional.Text = "Remove";
            this.btnRmAdditional.UseVisualStyleBackColor = true;
            this.btnRmAdditional.Click += new System.EventHandler(this.btnRmAdditional_Click);
            // 
            // btnAddAdditional
            // 
            this.btnAddAdditional.Location = new System.Drawing.Point(365, 221);
            this.btnAddAdditional.Name = "btnAddAdditional";
            this.btnAddAdditional.Size = new System.Drawing.Size(40, 20);
            this.btnAddAdditional.TabIndex = 88;
            this.btnAddAdditional.Text = "Add";
            this.btnAddAdditional.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Compression";
            // 
            // cmbCompression
            // 
            this.cmbCompression.FormattingEnabled = true;
            this.cmbCompression.Location = new System.Drawing.Point(11, 62);
            this.cmbCompression.Name = "cmbCompression";
            this.cmbCompression.Size = new System.Drawing.Size(100, 21);
            this.cmbCompression.TabIndex = 90;
            // 
            // TabDNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCompression);
            this.Controls.Add(this.btnRmAdditional);
            this.Controls.Add(this.btnAddAdditional);
            this.Controls.Add(this.btnRmAuthorities);
            this.Controls.Add(this.btnAddAuthorities);
            this.Controls.Add(this.btnRmAnswers);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.btnRmQuery);
            this.Controls.Add(this.btnAddQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listAdditional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listAuthorities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listQueries);
            this.Controls.Add(this.ckQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResponseCode);
            this.Controls.Add(this.labelOpCOde);
            this.Controls.Add(this.cmbOpCode);
            this.Controls.Add(this.ckCheckingDisabled);
            this.Controls.Add(this.ckAuthenticData);
            this.Controls.Add(this.ckFutureUse);
            this.Controls.Add(this.ckRecursionAvailable);
            this.Controls.Add(this.ckRecursionDesired);
            this.Controls.Add(this.ckTruncated);
            this.Controls.Add(this.ckAutoritativeAnswer);
            this.Controls.Add(this.ckResponse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.labelNetworkID);
            this.Name = "TabDNS";
            this.Size = new System.Drawing.Size(568, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Label labelNetworkID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox ckResponse;
        private System.Windows.Forms.CheckBox ckAutoritativeAnswer;
        private System.Windows.Forms.CheckBox ckTruncated;
        private System.Windows.Forms.CheckBox ckRecursionDesired;
        private System.Windows.Forms.CheckBox ckRecursionAvailable;
        private System.Windows.Forms.CheckBox ckFutureUse;
        private System.Windows.Forms.CheckBox ckAuthenticData;
        private System.Windows.Forms.CheckBox ckCheckingDisabled;
        private System.Windows.Forms.Label labelOpCOde;
        private System.Windows.Forms.ComboBox cmbOpCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbResponseCode;
        private System.Windows.Forms.CheckBox ckQuery;
        private System.Windows.Forms.ListBox listQueries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listAuthorities;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listAdditional;
        private System.Windows.Forms.Button btnAddQuery;
        private System.Windows.Forms.Button btnRmQuery;
        private System.Windows.Forms.Button btnRmAnswers;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.Button btnRmAuthorities;
        private System.Windows.Forms.Button btnAddAuthorities;
        private System.Windows.Forms.Button btnRmAdditional;
        private System.Windows.Forms.Button btnAddAdditional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCompression;
    }
}
