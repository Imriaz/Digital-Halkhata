
namespace Halkhata
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.add_button = new System.Windows.Forms.Button();
            this.transaction_statement_button = new System.Windows.Forms.Button();
            this.Customer_DashBoardbutton = new System.Windows.Forms.Button();
            this.halkhata_purchase_textBox = new System.Windows.Forms.TextBox();
            this.halakhata_balance_textBox = new System.Windows.Forms.TextBox();
            this.halkhata_due_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.view_transaction_Data_button = new System.Windows.Forms.Button();
            this.Send_reminderbutton = new System.Windows.Forms.Button();
            this.circularButton = new Halkhata.CircularButton();
            this.logout_Button = new Halkhata.CircularButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Gold;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_button.FlatAppearance.BorderSize = 2;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(720, 205);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(166, 30);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add New Customer";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // transaction_statement_button
            // 
            this.transaction_statement_button.BackColor = System.Drawing.Color.Gold;
            this.transaction_statement_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transaction_statement_button.FlatAppearance.BorderSize = 2;
            this.transaction_statement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_statement_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_statement_button.Location = new System.Drawing.Point(720, 317);
            this.transaction_statement_button.Name = "transaction_statement_button";
            this.transaction_statement_button.Size = new System.Drawing.Size(166, 30);
            this.transaction_statement_button.TabIndex = 20;
            this.transaction_statement_button.Text = "Transaction DashBoard";
            this.transaction_statement_button.UseVisualStyleBackColor = false;
            this.transaction_statement_button.Click += new System.EventHandler(this.transaction_statement_button_Click);
            // 
            // Customer_DashBoardbutton
            // 
            this.Customer_DashBoardbutton.BackColor = System.Drawing.Color.Gold;
            this.Customer_DashBoardbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Customer_DashBoardbutton.FlatAppearance.BorderSize = 2;
            this.Customer_DashBoardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_DashBoardbutton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_DashBoardbutton.Location = new System.Drawing.Point(720, 259);
            this.Customer_DashBoardbutton.Name = "Customer_DashBoardbutton";
            this.Customer_DashBoardbutton.Size = new System.Drawing.Size(166, 30);
            this.Customer_DashBoardbutton.TabIndex = 21;
            this.Customer_DashBoardbutton.Text = "Customer DashBoard";
            this.Customer_DashBoardbutton.UseVisualStyleBackColor = false;
            this.Customer_DashBoardbutton.Click += new System.EventHandler(this.Customer_DashBoardbutton_Click_1);
            // 
            // halkhata_purchase_textBox
            // 
            this.halkhata_purchase_textBox.Location = new System.Drawing.Point(57, 255);
            this.halkhata_purchase_textBox.Multiline = true;
            this.halkhata_purchase_textBox.Name = "halkhata_purchase_textBox";
            this.halkhata_purchase_textBox.Size = new System.Drawing.Size(176, 30);
            this.halkhata_purchase_textBox.TabIndex = 22;
            // 
            // halakhata_balance_textBox
            // 
            this.halakhata_balance_textBox.Location = new System.Drawing.Point(57, 318);
            this.halakhata_balance_textBox.Multiline = true;
            this.halakhata_balance_textBox.Name = "halakhata_balance_textBox";
            this.halakhata_balance_textBox.Size = new System.Drawing.Size(176, 30);
            this.halakhata_balance_textBox.TabIndex = 23;
            // 
            // halkhata_due_textBox
            // 
            this.halkhata_due_textBox.Location = new System.Drawing.Point(57, 378);
            this.halkhata_due_textBox.Multiline = true;
            this.halkhata_due_textBox.Name = "halkhata_due_textBox";
            this.halkhata_due_textBox.Size = new System.Drawing.Size(176, 30);
            this.halkhata_due_textBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(57, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Clientele Purchase :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(57, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Balance  Recieved :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(54, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Clientele Due :";
            // 
            // view_transaction_Data_button
            // 
            this.view_transaction_Data_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.view_transaction_Data_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.view_transaction_Data_button.FlatAppearance.BorderSize = 0;
            this.view_transaction_Data_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_transaction_Data_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_transaction_Data_button.ForeColor = System.Drawing.Color.Azure;
            this.view_transaction_Data_button.Location = new System.Drawing.Point(595, 10);
            this.view_transaction_Data_button.Name = "view_transaction_Data_button";
            this.view_transaction_Data_button.Size = new System.Drawing.Size(140, 30);
            this.view_transaction_Data_button.TabIndex = 31;
            this.view_transaction_Data_button.Text = "View Transaction Data";
            this.view_transaction_Data_button.UseVisualStyleBackColor = false;
            this.view_transaction_Data_button.Click += new System.EventHandler(this.view_transaction_Data_button_Click);
            // 
            // Send_reminderbutton
            // 
            this.Send_reminderbutton.BackColor = System.Drawing.Color.Gold;
            this.Send_reminderbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Send_reminderbutton.FlatAppearance.BorderSize = 2;
            this.Send_reminderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_reminderbutton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_reminderbutton.Location = new System.Drawing.Point(720, 377);
            this.Send_reminderbutton.Name = "Send_reminderbutton";
            this.Send_reminderbutton.Size = new System.Drawing.Size(166, 30);
            this.Send_reminderbutton.TabIndex = 32;
            this.Send_reminderbutton.Text = "Send Reminder";
            this.Send_reminderbutton.UseVisualStyleBackColor = false;
            this.Send_reminderbutton.Click += new System.EventHandler(this.Send_reminderbutton_Click);
            // 
            // circularButton
            // 
            this.circularButton.FlatAppearance.BorderSize = 0;
            this.circularButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton.Location = new System.Drawing.Point(382, 147);
            this.circularButton.Name = "circularButton";
            this.circularButton.Size = new System.Drawing.Size(76, 60);
            this.circularButton.TabIndex = 33;
            this.circularButton.UseVisualStyleBackColor = true;
            // 
            // logout_Button
            // 
            this.logout_Button.FlatAppearance.BorderSize = 0;
            this.logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("logout_Button.Image")));
            this.logout_Button.Location = new System.Drawing.Point(753, 0);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(65, 50);
            this.logout_Button.TabIndex = 34;
            this.logout_Button.UseVisualStyleBackColor = true;
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.logout_Button);
            this.panel1.Controls.Add(this.view_transaction_Data_button);
            this.panel1.Location = new System.Drawing.Point(80, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 56);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(-6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 36;
            this.label4.Text = "Halkhata";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularButton);
            this.Controls.Add(this.Send_reminderbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.halkhata_due_textBox);
            this.Controls.Add(this.halakhata_balance_textBox);
            this.Controls.Add(this.halkhata_purchase_textBox);
            this.Controls.Add(this.Customer_DashBoardbutton);
            this.Controls.Add(this.transaction_statement_button);
            this.Controls.Add(this.add_button);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button transaction_statement_button;
        private System.Windows.Forms.Button Customer_DashBoardbutton;
        private System.Windows.Forms.TextBox halkhata_purchase_textBox;
        private System.Windows.Forms.TextBox halakhata_balance_textBox;
        private System.Windows.Forms.TextBox halkhata_due_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view_transaction_Data_button;
        private System.Windows.Forms.Button Send_reminderbutton;
        private CircularButton circularButton;
        private CircularButton logout_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}