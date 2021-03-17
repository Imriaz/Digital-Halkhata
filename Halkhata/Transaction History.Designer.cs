
namespace Halkhata
{
    partial class Transaction_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_History));
            this.gobackpage_button = new System.Windows.Forms.Button();
            this.t_purchase_amounttextBox = new System.Windows.Forms.TextBox();
            this.t_paymenttextBox = new System.Windows.Forms.TextBox();
            this.t_due_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_transaction_button = new System.Windows.Forms.Button();
            this.search_transaction_TextBox = new System.Windows.Forms.TextBox();
            this.transaction_listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // gobackpage_button
            // 
            this.gobackpage_button.BackColor = System.Drawing.Color.Firebrick;
            this.gobackpage_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gobackpage_button.FlatAppearance.BorderSize = 2;
            this.gobackpage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobackpage_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackpage_button.ForeColor = System.Drawing.Color.White;
            this.gobackpage_button.Location = new System.Drawing.Point(706, 37);
            this.gobackpage_button.Name = "gobackpage_button";
            this.gobackpage_button.Size = new System.Drawing.Size(180, 30);
            this.gobackpage_button.TabIndex = 22;
            this.gobackpage_button.Text = "Go Back To Previous Page\r\n";
            this.gobackpage_button.UseVisualStyleBackColor = false;
            this.gobackpage_button.Click += new System.EventHandler(this.gobackpage_button_Click);
            // 
            // t_purchase_amounttextBox
            // 
            this.t_purchase_amounttextBox.Location = new System.Drawing.Point(54, 154);
            this.t_purchase_amounttextBox.Multiline = true;
            this.t_purchase_amounttextBox.Name = "t_purchase_amounttextBox";
            this.t_purchase_amounttextBox.Size = new System.Drawing.Size(157, 30);
            this.t_purchase_amounttextBox.TabIndex = 24;
            // 
            // t_paymenttextBox
            // 
            this.t_paymenttextBox.Location = new System.Drawing.Point(385, 154);
            this.t_paymenttextBox.Multiline = true;
            this.t_paymenttextBox.Name = "t_paymenttextBox";
            this.t_paymenttextBox.Size = new System.Drawing.Size(157, 30);
            this.t_paymenttextBox.TabIndex = 25;
            // 
            // t_due_textBox
            // 
            this.t_due_textBox.Location = new System.Drawing.Point(728, 154);
            this.t_due_textBox.Multiline = true;
            this.t_due_textBox.Name = "t_due_textBox";
            this.t_due_textBox.Size = new System.Drawing.Size(157, 30);
            this.t_due_textBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(51, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Purchase (In Taka):\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(385, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Payment(In Taka):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(725, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Due(In Taka):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(54, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Transaction History:";
            // 
            // search_transaction_button
            // 
            this.search_transaction_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search_transaction_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_transaction_button.FlatAppearance.BorderSize = 2;
            this.search_transaction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_transaction_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_transaction_button.Location = new System.Drawing.Point(237, 36);
            this.search_transaction_button.Name = "search_transaction_button";
            this.search_transaction_button.Size = new System.Drawing.Size(98, 33);
            this.search_transaction_button.TabIndex = 127;
            this.search_transaction_button.Text = "Search";
            this.search_transaction_button.UseVisualStyleBackColor = false;
            this.search_transaction_button.Click += new System.EventHandler(this.search_transaction_button_Click);
            // 
            // search_transaction_TextBox
            // 
            this.search_transaction_TextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_transaction_TextBox.Location = new System.Drawing.Point(54, 42);
            this.search_transaction_TextBox.Name = "search_transaction_TextBox";
            this.search_transaction_TextBox.Size = new System.Drawing.Size(177, 25);
            this.search_transaction_TextBox.TabIndex = 126;
            // 
            // transaction_listView
            // 
            this.transaction_listView.BackColor = System.Drawing.Color.Silver;
            this.transaction_listView.HideSelection = false;
            this.transaction_listView.Location = new System.Drawing.Point(57, 239);
            this.transaction_listView.Name = "transaction_listView";
            this.transaction_listView.Size = new System.Drawing.Size(828, 245);
            this.transaction_listView.TabIndex = 128;
            this.transaction_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Transaction_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 531);
            this.Controls.Add(this.transaction_listView);
            this.Controls.Add(this.search_transaction_button);
            this.Controls.Add(this.search_transaction_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_due_textBox);
            this.Controls.Add(this.t_paymenttextBox);
            this.Controls.Add(this.t_purchase_amounttextBox);
            this.Controls.Add(this.gobackpage_button);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transaction_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.Transaction_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gobackpage_button;
        private System.Windows.Forms.TextBox t_purchase_amounttextBox;
        private System.Windows.Forms.TextBox t_paymenttextBox;
        private System.Windows.Forms.TextBox t_due_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_transaction_button;
        private System.Windows.Forms.TextBox search_transaction_TextBox;
        private System.Windows.Forms.ListView transaction_listView;
    }
}