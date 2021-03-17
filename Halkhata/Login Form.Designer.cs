
namespace Halkhata
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.adminPanel_button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminPanel_button
            // 
            this.adminPanel_button.BackColor = System.Drawing.Color.Transparent;
            this.adminPanel_button.FlatAppearance.BorderSize = 0;
            this.adminPanel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanel_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanel_button.ForeColor = System.Drawing.Color.Lime;
            this.adminPanel_button.Location = new System.Drawing.Point(807, 23);
            this.adminPanel_button.Name = "adminPanel_button";
            this.adminPanel_button.Size = new System.Drawing.Size(106, 30);
            this.adminPanel_button.TabIndex = 6;
            this.adminPanel_button.Text = "Admin Panel";
            this.adminPanel_button.UseVisualStyleBackColor = false;
            this.adminPanel_button.Click += new System.EventHandler(this.adminPanel_button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.Cyan;
            this.time_label.Location = new System.Drawing.Point(624, 186);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(231, 54);
            this.time_label.TabIndex = 7;
            this.time_label.Text = "5 : 27 PM";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.BackColor = System.Drawing.Color.Transparent;
            this.day_label.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_label.ForeColor = System.Drawing.Color.DarkKhaki;
            this.day_label.Location = new System.Drawing.Point(703, 240);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(116, 40);
            this.day_label.TabIndex = 9;
            this.day_label.Text = "Sunday";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.BackColor = System.Drawing.Color.Transparent;
            this.date_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.LightGreen;
            this.date_label.Location = new System.Drawing.Point(704, 294);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(174, 34);
            this.date_label.TabIndex = 10;
            this.date_label.Text = "February 28, 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(76, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 33);
            this.label3.TabIndex = 140;
            this.label3.Text = "Halkhata";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.adminPanel_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halkhata";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminPanel_button;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

