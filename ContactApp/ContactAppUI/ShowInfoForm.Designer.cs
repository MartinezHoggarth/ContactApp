namespace ContactAppUI
{
    partial class ShowInfoForm
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
            this.nameStaticLabel = new System.Windows.Forms.Label();
            this.surnameStaticLabel = new System.Windows.Forms.Label();
            this.phoneStaticLabel = new System.Windows.Forms.Label();
            this.emailStaticLabel = new System.Windows.Forms.Label();
            this.contactidStaticLabel = new System.Windows.Forms.Label();
            this.nameDynamicLabel = new System.Windows.Forms.Label();
            this.surnameDynamicLabel = new System.Windows.Forms.Label();
            this.phoneDynamicLabel = new System.Windows.Forms.Label();
            this.emailDynamicLabel = new System.Windows.Forms.Label();
            this.contactidDynamicLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameStaticLabel
            // 
            this.nameStaticLabel.AutoSize = true;
            this.nameStaticLabel.Location = new System.Drawing.Point(50, 9);
            this.nameStaticLabel.Name = "nameStaticLabel";
            this.nameStaticLabel.Size = new System.Drawing.Size(38, 13);
            this.nameStaticLabel.TabIndex = 0;
            this.nameStaticLabel.Text = "Name:";
            // 
            // surnameStaticLabel
            // 
            this.surnameStaticLabel.AutoSize = true;
            this.surnameStaticLabel.Location = new System.Drawing.Point(50, 33);
            this.surnameStaticLabel.Name = "surnameStaticLabel";
            this.surnameStaticLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameStaticLabel.TabIndex = 1;
            this.surnameStaticLabel.Text = "Surname:";
            // 
            // phoneStaticLabel
            // 
            this.phoneStaticLabel.AutoSize = true;
            this.phoneStaticLabel.Location = new System.Drawing.Point(50, 57);
            this.phoneStaticLabel.Name = "phoneStaticLabel";
            this.phoneStaticLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneStaticLabel.TabIndex = 2;
            this.phoneStaticLabel.Text = "Phone:";
            // 
            // emailStaticLabel
            // 
            this.emailStaticLabel.AutoSize = true;
            this.emailStaticLabel.Location = new System.Drawing.Point(50, 81);
            this.emailStaticLabel.Name = "emailStaticLabel";
            this.emailStaticLabel.Size = new System.Drawing.Size(35, 13);
            this.emailStaticLabel.TabIndex = 3;
            this.emailStaticLabel.Text = "Email:";
            // 
            // contactidStaticLabel
            // 
            this.contactidStaticLabel.AutoSize = true;
            this.contactidStaticLabel.Location = new System.Drawing.Point(50, 104);
            this.contactidStaticLabel.Name = "contactidStaticLabel";
            this.contactidStaticLabel.Size = new System.Drawing.Size(61, 13);
            this.contactidStaticLabel.TabIndex = 4;
            this.contactidStaticLabel.Text = "Contact ID:";
            // 
            // nameDynamicLabel
            // 
            this.nameDynamicLabel.AutoSize = true;
            this.nameDynamicLabel.Location = new System.Drawing.Point(117, 9);
            this.nameDynamicLabel.Name = "nameDynamicLabel";
            this.nameDynamicLabel.Size = new System.Drawing.Size(35, 13);
            this.nameDynamicLabel.TabIndex = 5;
            this.nameDynamicLabel.Text = "label6";
            // 
            // surnameDynamicLabel
            // 
            this.surnameDynamicLabel.AutoSize = true;
            this.surnameDynamicLabel.Location = new System.Drawing.Point(117, 33);
            this.surnameDynamicLabel.Name = "surnameDynamicLabel";
            this.surnameDynamicLabel.Size = new System.Drawing.Size(35, 13);
            this.surnameDynamicLabel.TabIndex = 6;
            this.surnameDynamicLabel.Text = "label7";
            // 
            // phoneDynamicLabel
            // 
            this.phoneDynamicLabel.AutoSize = true;
            this.phoneDynamicLabel.Location = new System.Drawing.Point(117, 57);
            this.phoneDynamicLabel.Name = "phoneDynamicLabel";
            this.phoneDynamicLabel.Size = new System.Drawing.Size(35, 13);
            this.phoneDynamicLabel.TabIndex = 7;
            this.phoneDynamicLabel.Text = "label8";
            // 
            // emailDynamicLabel
            // 
            this.emailDynamicLabel.AutoSize = true;
            this.emailDynamicLabel.Location = new System.Drawing.Point(117, 81);
            this.emailDynamicLabel.Name = "emailDynamicLabel";
            this.emailDynamicLabel.Size = new System.Drawing.Size(35, 13);
            this.emailDynamicLabel.TabIndex = 8;
            this.emailDynamicLabel.Text = "label9";
            // 
            // contactidDynamicLabel
            // 
            this.contactidDynamicLabel.AutoSize = true;
            this.contactidDynamicLabel.Location = new System.Drawing.Point(117, 104);
            this.contactidDynamicLabel.Name = "contactidDynamicLabel";
            this.contactidDynamicLabel.Size = new System.Drawing.Size(41, 13);
            this.contactidDynamicLabel.TabIndex = 9;
            this.contactidDynamicLabel.Text = "label10";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(77, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 25);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ShowInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.contactidDynamicLabel);
            this.Controls.Add(this.emailDynamicLabel);
            this.Controls.Add(this.phoneDynamicLabel);
            this.Controls.Add(this.surnameDynamicLabel);
            this.Controls.Add(this.nameDynamicLabel);
            this.Controls.Add(this.contactidStaticLabel);
            this.Controls.Add(this.emailStaticLabel);
            this.Controls.Add(this.phoneStaticLabel);
            this.Controls.Add(this.surnameStaticLabel);
            this.Controls.Add(this.nameStaticLabel);
            this.MaximumSize = new System.Drawing.Size(290, 200);
            this.MinimumSize = new System.Drawing.Size(290, 200);
            this.Name = "ShowInfoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameStaticLabel;
        private System.Windows.Forms.Label surnameStaticLabel;
        private System.Windows.Forms.Label phoneStaticLabel;
        private System.Windows.Forms.Label emailStaticLabel;
        private System.Windows.Forms.Label contactidStaticLabel;
        private System.Windows.Forms.Label nameDynamicLabel;
        private System.Windows.Forms.Label surnameDynamicLabel;
        private System.Windows.Forms.Label phoneDynamicLabel;
        private System.Windows.Forms.Label emailDynamicLabel;
        private System.Windows.Forms.Label contactidDynamicLabel;
        private System.Windows.Forms.Button okButton;
    }
}