namespace final_project_test
{
    partial class SetAccountForm
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
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbx_username.Location = new System.Drawing.Point(192, 118);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(246, 39);
            this.tbx_username.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbx_password.Location = new System.Drawing.Point(192, 216);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(246, 39);
            this.tbx_password.TabIndex = 1;
            this.tbx_password.UseSystemPasswordChar = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_username.Location = new System.Drawing.Point(70, 121);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 27);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_password.Location = new System.Drawing.Point(70, 219);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(115, 27);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(242, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Moodle";
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_confirm.Location = new System.Drawing.Point(208, 289);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(77, 30);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(323, 289);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 30);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // SetAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Name = "SetAccountForm";
            this.Text = "SetAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}