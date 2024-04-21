namespace poker_cliente
{
    partial class register_form
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
            this.Pass = new System.Windows.Forms.Label();
            this.Pass_box = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.Mail_box = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.User_box = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(351, 168);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(200, 40);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Contraseña";
            // 
            // Pass_box
            // 
            this.Pass_box.Location = new System.Drawing.Point(355, 241);
            this.Pass_box.Name = "Pass_box";
            this.Pass_box.Size = new System.Drawing.Size(170, 26);
            this.Pass_box.TabIndex = 2;
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(351, 283);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(200, 40);
            this.mail.TabIndex = 5;
            this.mail.Text = "Email";
            // 
            // Mail_box
            // 
            this.Mail_box.Location = new System.Drawing.Point(355, 356);
            this.Mail_box.Name = "Mail_box";
            this.Mail_box.Size = new System.Drawing.Size(170, 26);
            this.Mail_box.TabIndex = 4;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(351, 43);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(200, 40);
            this.user.TabIndex = 7;
            this.user.Text = "Nombre";
            // 
            // User_box
            // 
            this.User_box.Location = new System.Drawing.Point(355, 116);
            this.User_box.Name = "User_box";
            this.User_box.Size = new System.Drawing.Size(170, 26);
            this.User_box.TabIndex = 6;
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(355, 440);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(205, 89);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 586);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.user);
            this.Controls.Add(this.User_box);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.Mail_box);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Pass_box);
            this.Name = "register_form";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox Pass_box;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox Mail_box;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox User_box;
        private System.Windows.Forms.Button register_btn;
    }
}