
namespace Halkhata
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.admin_emailtextBox = new System.Windows.Forms.TextBox();
            this.admin_passwordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminLogin_button = new System.Windows.Forms.Button();
            this.adminRegister_button = new System.Windows.Forms.Button();
            this.show_pwd_checkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_emailtextBox
            // 
            this.admin_emailtextBox.Location = new System.Drawing.Point(369, 158);
            this.admin_emailtextBox.Multiline = true;
            this.admin_emailtextBox.Name = "admin_emailtextBox";
            this.admin_emailtextBox.Size = new System.Drawing.Size(212, 28);
            this.admin_emailtextBox.TabIndex = 0;
            // 
            // admin_passwordtextBox
            // 
            this.admin_passwordtextBox.Location = new System.Drawing.Point(369, 235);
            this.admin_passwordtextBox.Multiline = true;
            this.admin_passwordtextBox.Name = "admin_passwordtextBox";
            this.admin_passwordtextBox.Size = new System.Drawing.Size(212, 28);
            this.admin_passwordtextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email or User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // adminLogin_button
            // 
            this.adminLogin_button.BackColor = System.Drawing.Color.YellowGreen;
            this.adminLogin_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.adminLogin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogin_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin_button.Location = new System.Drawing.Point(369, 324);
            this.adminLogin_button.Name = "adminLogin_button";
            this.adminLogin_button.Size = new System.Drawing.Size(212, 28);
            this.adminLogin_button.TabIndex = 4;
            this.adminLogin_button.Text = "Login";
            this.adminLogin_button.UseVisualStyleBackColor = false;
            this.adminLogin_button.Click += new System.EventHandler(this.adminLogin_button_Click);
            // 
            // adminRegister_button
            // 
            this.adminRegister_button.BackColor = System.Drawing.Color.DarkTurquoise;
            this.adminRegister_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.adminRegister_button.FlatAppearance.BorderSize = 2;
            this.adminRegister_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRegister_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRegister_button.Location = new System.Drawing.Point(747, 39);
            this.adminRegister_button.Name = "adminRegister_button";
            this.adminRegister_button.Size = new System.Drawing.Size(144, 29);
            this.adminRegister_button.TabIndex = 5;
            this.adminRegister_button.Text = "Register";
            this.adminRegister_button.UseVisualStyleBackColor = false;
            this.adminRegister_button.Click += new System.EventHandler(this.adminRegister_button_Click);
            // 
            // show_pwd_checkBox
            // 
            this.show_pwd_checkBox.AutoSize = true;
            this.show_pwd_checkBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pwd_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.show_pwd_checkBox.Location = new System.Drawing.Point(369, 299);
            this.show_pwd_checkBox.Name = "show_pwd_checkBox";
            this.show_pwd_checkBox.Size = new System.Drawing.Size(106, 19);
            this.show_pwd_checkBox.TabIndex = 6;
            this.show_pwd_checkBox.Text = "Show Password";
            this.show_pwd_checkBox.UseVisualStyleBackColor = true;
            this.show_pwd_checkBox.CheckedChanged += new System.EventHandler(this.show_pwd_checkBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 41;
            this.label4.Text = "Halkhata";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.show_pwd_checkBox);
            this.Controls.Add(this.adminRegister_button);
            this.Controls.Add(this.adminLogin_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_passwordtextBox);
            this.Controls.Add(this.admin_emailtextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Admin Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox admin_emailtextBox;
        private System.Windows.Forms.TextBox admin_passwordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adminLogin_button;
        private System.Windows.Forms.Button adminRegister_button;
        private System.Windows.Forms.CheckBox show_pwd_checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}