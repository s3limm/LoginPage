namespace Login_Page
{
    partial class PageSignUp
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
            this.btnSignİn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignİn
            // 
            this.btnSignİn.AutoEllipsis = true;
            this.btnSignİn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignİn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignİn.Location = new System.Drawing.Point(265, 92);
            this.btnSignİn.Name = "btnSignİn";
            this.btnSignİn.Size = new System.Drawing.Size(153, 39);
            this.btnSignİn.TabIndex = 1;
            this.btnSignİn.Text = "Sign İn";
            this.btnSignİn.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoEllipsis = true;
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.Enabled = false;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Location = new System.Drawing.Point(413, 92);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(138, 39);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(347, 164);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 32);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(347, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 32);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(240, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(347, 274);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(204, 32);
            this.txtMail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(276, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Mail :";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoEllipsis = true;
            this.btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.ForeColor = System.Drawing.Color.Snow;
            this.btnCreate.Location = new System.Drawing.Point(280, 343);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(255, 52);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PageSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignİn);
            this.Name = "PageSignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignİn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.TextBox txtMail;
    }
}

