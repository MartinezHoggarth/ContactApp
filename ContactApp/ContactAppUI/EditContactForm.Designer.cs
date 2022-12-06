namespace ContactAppUI
{
    partial class EditContactForm
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
            this.editCancel = new System.Windows.Forms.Button();
            this.editOk = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editCancel
            // 
            this.editCancel.Location = new System.Drawing.Point(151, 117);
            this.editCancel.Name = "editCancel";
            this.editCancel.Size = new System.Drawing.Size(104, 31);
            this.editCancel.TabIndex = 21;
            this.editCancel.Text = "Cancel";
            this.editCancel.UseVisualStyleBackColor = true;
            this.editCancel.Click += new System.EventHandler(this.editCancel_Click);
            // 
            // editOk
            // 
            this.editOk.Location = new System.Drawing.Point(23, 117);
            this.editOk.Name = "editOk";
            this.editOk.Size = new System.Drawing.Size(104, 31);
            this.editOk.TabIndex = 20;
            this.editOk.Text = "OK";
            this.editOk.UseVisualStyleBackColor = true;
            this.editOk.Click += new System.EventHandler(this.editOk_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(20, 68);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Phone";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(20, 42);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 17;
            this.labelSurname.Text = "Surname";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(75, 91);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(180, 20);
            this.emailBox.TabIndex = 16;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(75, 65);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(180, 20);
            this.phoneBox.TabIndex = 15;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(75, 39);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(180, 20);
            this.surnameBox.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(75, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 12;
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.editCancel);
            this.Controls.Add(this.editOk);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameBox);
            this.Name = "EditContactForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCancel;
        private System.Windows.Forms.Button editOk;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
    }
}