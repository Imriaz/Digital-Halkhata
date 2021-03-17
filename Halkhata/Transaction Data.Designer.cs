
namespace Halkhata
{
    partial class Transaction_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Data));
            this.gobackmenu_button = new System.Windows.Forms.Button();
            this.transaction_data_listView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.from_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Load_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gobackmenu_button
            // 
            this.gobackmenu_button.BackColor = System.Drawing.Color.Firebrick;
            this.gobackmenu_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gobackmenu_button.FlatAppearance.BorderSize = 2;
            this.gobackmenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gobackmenu_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackmenu_button.ForeColor = System.Drawing.Color.White;
            this.gobackmenu_button.Location = new System.Drawing.Point(707, 37);
            this.gobackmenu_button.Name = "gobackmenu_button";
            this.gobackmenu_button.Size = new System.Drawing.Size(180, 30);
            this.gobackmenu_button.TabIndex = 21;
            this.gobackmenu_button.Text = "Go Back To Main Menu";
            this.gobackmenu_button.UseVisualStyleBackColor = false;
            this.gobackmenu_button.Click += new System.EventHandler(this.gobackmenu_button_Click);
            // 
            // transaction_data_listView
            // 
            this.transaction_data_listView.BackColor = System.Drawing.Color.Silver;
            this.transaction_data_listView.HideSelection = false;
            this.transaction_data_listView.Location = new System.Drawing.Point(227, 117);
            this.transaction_data_listView.Name = "transaction_data_listView";
            this.transaction_data_listView.Size = new System.Drawing.Size(660, 356);
            this.transaction_data_listView.TabIndex = 129;
            this.transaction_data_listView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(224, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 130;
            this.label4.Text = "Customer Transaction Data :\r\n\r\n\r\n";
            // 
            // from_dateTimePicker
            // 
            this.from_dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from_dateTimePicker.Location = new System.Drawing.Point(22, 117);
            this.from_dateTimePicker.Name = "from_dateTimePicker";
            this.from_dateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.from_dateTimePicker.TabIndex = 131;
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to_dateTimePicker.Location = new System.Drawing.Point(22, 175);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(114, 22);
            this.to_dateTimePicker.TabIndex = 132;
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Load_button.FlatAppearance.BorderSize = 2;
            this.Load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_button.Location = new System.Drawing.Point(22, 224);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(137, 29);
            this.Load_button.TabIndex = 133;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 134;
            this.label2.Text = "From Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 135;
            this.label1.Text = "To Date :";
            // 
            // Transaction_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.to_dateTimePicker);
            this.Controls.Add(this.from_dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transaction_data_listView);
            this.Controls.Add(this.gobackmenu_button);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transaction_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Data";
            this.Load += new System.EventHandler(this.Transaction_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gobackmenu_button;
        private System.Windows.Forms.ListView transaction_data_listView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker from_dateTimePicker;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}