
namespace Halkhata
{
    partial class Customer_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Profile));
            this.label7 = new System.Windows.Forms.Label();
            this.c_contactnumtextBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.c_addresstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_lastnametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_firstnametextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.finish_update_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.transaction_history_button = new System.Windows.Forms.Button();
            this.dataGridViewcustomer = new System.Windows.Forms.DataGridView();
            this.c_email_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trasaction_board_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Contact No.";
            // 
            // c_contactnumtextBox
            // 
            this.c_contactnumtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_contactnumtextBox.Location = new System.Drawing.Point(127, 357);
            this.c_contactnumtextBox.Multiline = true;
            this.c_contactnumtextBox.Name = "c_contactnumtextBox";
            this.c_contactnumtextBox.ReadOnly = true;
            this.c_contactnumtextBox.Size = new System.Drawing.Size(177, 31);
            this.c_contactnumtextBox.TabIndex = 31;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Firebrick;
            this.back_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.back_button.FlatAppearance.BorderSize = 2;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(42, 29);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(166, 32);
            this.back_button.TabIndex = 30;
            this.back_button.Text = "Back To MainMenu";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address :";
            // 
            // c_addresstextBox
            // 
            this.c_addresstextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_addresstextBox.Location = new System.Drawing.Point(127, 307);
            this.c_addresstextBox.Multiline = true;
            this.c_addresstextBox.Name = "c_addresstextBox";
            this.c_addresstextBox.Size = new System.Drawing.Size(177, 31);
            this.c_addresstextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name :";
            // 
            // c_lastnametextBox
            // 
            this.c_lastnametextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_lastnametextBox.Location = new System.Drawing.Point(127, 255);
            this.c_lastnametextBox.Multiline = true;
            this.c_lastnametextBox.Name = "c_lastnametextBox";
            this.c_lastnametextBox.Size = new System.Drawing.Size(177, 31);
            this.c_lastnametextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name :";
            // 
            // c_firstnametextBox
            // 
            this.c_firstnametextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_firstnametextBox.Location = new System.Drawing.Point(127, 209);
            this.c_firstnametextBox.Multiline = true;
            this.c_firstnametextBox.Name = "c_firstnametextBox";
            this.c_firstnametextBox.Size = new System.Drawing.Size(177, 31);
            this.c_firstnametextBox.TabIndex = 19;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(615, 108);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(177, 25);
            this.searchTextBox.TabIndex = 120;
            // 
            // finish_update_button
            // 
            this.finish_update_button.BackColor = System.Drawing.Color.YellowGreen;
            this.finish_update_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finish_update_button.FlatAppearance.BorderSize = 2;
            this.finish_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_update_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_update_button.ForeColor = System.Drawing.Color.Black;
            this.finish_update_button.Location = new System.Drawing.Point(42, 428);
            this.finish_update_button.Name = "finish_update_button";
            this.finish_update_button.Size = new System.Drawing.Size(87, 37);
            this.finish_update_button.TabIndex = 121;
            this.finish_update_button.Text = "Update";
            this.finish_update_button.UseVisualStyleBackColor = false;
            this.finish_update_button.Click += new System.EventHandler(this.finish_update_button_Click);
            // 
            // find_button
            // 
            this.find_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.find_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.find_button.FlatAppearance.BorderSize = 2;
            this.find_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(798, 100);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(98, 33);
            this.find_button.TabIndex = 125;
            this.find_button.Text = "Search";
            this.find_button.UseVisualStyleBackColor = false;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Brown;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete_button.FlatAppearance.BorderSize = 2;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(217, 428);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(87, 37);
            this.delete_button.TabIndex = 126;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // transaction_history_button
            // 
            this.transaction_history_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.transaction_history_button.FlatAppearance.BorderSize = 0;
            this.transaction_history_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction_history_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_history_button.ForeColor = System.Drawing.Color.Yellow;
            this.transaction_history_button.Location = new System.Drawing.Point(705, 26);
            this.transaction_history_button.Name = "transaction_history_button";
            this.transaction_history_button.Size = new System.Drawing.Size(191, 36);
            this.transaction_history_button.TabIndex = 127;
            this.transaction_history_button.Text = "View Transaction History";
            this.transaction_history_button.UseVisualStyleBackColor = false;
            this.transaction_history_button.Click += new System.EventHandler(this.transaction_history_button_Click);
            // 
            // dataGridViewcustomer
            // 
            this.dataGridViewcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcustomer.Location = new System.Drawing.Point(333, 137);
            this.dataGridViewcustomer.Name = "dataGridViewcustomer";
            this.dataGridViewcustomer.Size = new System.Drawing.Size(563, 328);
            this.dataGridViewcustomer.TabIndex = 128;
            this.dataGridViewcustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcustomer_CellClick_1);
            // 
            // c_email_textBox
            // 
            this.c_email_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_email_textBox.Location = new System.Drawing.Point(127, 156);
            this.c_email_textBox.Multiline = true;
            this.c_email_textBox.Name = "c_email_textBox";
            this.c_email_textBox.Size = new System.Drawing.Size(177, 31);
            this.c_email_textBox.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 130;
            this.label3.Text = "Email :";
            // 
            // trasaction_board_button
            // 
            this.trasaction_board_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.trasaction_board_button.FlatAppearance.BorderSize = 0;
            this.trasaction_board_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trasaction_board_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasaction_board_button.ForeColor = System.Drawing.Color.Yellow;
            this.trasaction_board_button.Location = new System.Drawing.Point(491, 26);
            this.trasaction_board_button.Name = "trasaction_board_button";
            this.trasaction_board_button.Size = new System.Drawing.Size(191, 36);
            this.trasaction_board_button.TabIndex = 131;
            this.trasaction_board_button.Text = "Transaction DashBoard";
            this.trasaction_board_button.UseVisualStyleBackColor = false;
            this.trasaction_board_button.Click += new System.EventHandler(this.trasaction_board_button_Click);
            // 
            // Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.trasaction_board_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_email_textBox);
            this.Controls.Add(this.dataGridViewcustomer);
            this.Controls.Add(this.transaction_history_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.finish_update_button);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.c_contactnumtextBox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c_addresstextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_lastnametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_firstnametextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Customer_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.Customer_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox c_contactnumtextBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox c_addresstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_lastnametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_firstnametextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button finish_update_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button transaction_history_button;
        private System.Windows.Forms.DataGridView dataGridViewcustomer;
        private System.Windows.Forms.TextBox c_email_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button trasaction_board_button;
    }
}