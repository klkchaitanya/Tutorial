﻿namespace PresentationLayer
{
    partial class Customer_SearchHotel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCountry = new System.Windows.Forms.ComboBox();
            this.cboxCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datepickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.datepickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxRoomType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CITY:";
            // 
            // cboxCountry
            // 
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.Location = new System.Drawing.Point(286, 109);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(162, 21);
            this.cboxCountry.TabIndex = 2;
            this.cboxCountry.SelectedIndexChanged += new System.EventHandler(this.cboxCountry_SelectedIndexChanged);
            // 
            // cboxCity
            // 
            this.cboxCity.FormattingEnabled = true;
            this.cboxCity.Location = new System.Drawing.Point(286, 139);
            this.cboxCity.Name = "cboxCity";
            this.cboxCity.Size = new System.Drawing.Size(162, 21);
            this.cboxCity.TabIndex = 3;
            this.cboxCity.SelectedIndexChanged += new System.EventHandler(this.cboxCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HOTEL NAME:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(286, 288);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(162, 20);
            this.txtHotelName.TabIndex = 5;
            this.txtHotelName.TextChanged += new System.EventHandler(this.txtHotelName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1409, 233);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "SEARCH HOTELS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FROM DATE:";
            // 
            // datepickerFromDate
            // 
            this.datepickerFromDate.CalendarFont = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepickerFromDate.CustomFormat = "yyyy-MM-dd";
            this.datepickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickerFromDate.Location = new System.Drawing.Point(286, 173);
            this.datepickerFromDate.MinDate = new System.DateTime(2014, 10, 26, 0, 0, 0, 0);
            this.datepickerFromDate.Name = "datepickerFromDate";
            this.datepickerFromDate.Size = new System.Drawing.Size(162, 20);
            this.datepickerFromDate.TabIndex = 9;
            this.datepickerFromDate.Value = new System.DateTime(2014, 10, 26, 0, 0, 0, 0);
            this.datepickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datepickerToDate
            // 
            this.datepickerToDate.CustomFormat = "yyyy-MM-dd";
            this.datepickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickerToDate.Location = new System.Drawing.Point(286, 202);
            this.datepickerToDate.MinDate = new System.DateTime(2014, 10, 26, 0, 0, 0, 0);
            this.datepickerToDate.Name = "datepickerToDate";
            this.datepickerToDate.Size = new System.Drawing.Size(162, 20);
            this.datepickerToDate.TabIndex = 11;
            this.datepickerToDate.Value = new System.DateTime(2014, 10, 26, 0, 0, 0, 0);
            this.datepickerToDate.ValueChanged += new System.EventHandler(this.datepickerToDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TO DATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ROOM TYPE:";
            // 
            // cboxRoomType
            // 
            this.cboxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRoomType.FormattingEnabled = true;
            this.cboxRoomType.Items.AddRange(new object[] {
            "AC",
            "NON-AC"});
            this.cboxRoomType.Location = new System.Drawing.Point(286, 232);
            this.cboxRoomType.Name = "cboxRoomType";
            this.cboxRoomType.Size = new System.Drawing.Size(162, 21);
            this.cboxRoomType.TabIndex = 13;
            this.cboxRoomType.SelectedIndexChanged += new System.EventHandler(this.cboxRoomType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(435, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "BOOK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(530, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 253);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Customer_SearchHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datepickerToDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datepickerFromDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxCity);
            this.Controls.Add(this.cboxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_SearchHotel";
            this.Text = "Customer_SearchHotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_SearchHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCountry;
        private System.Windows.Forms.ComboBox cboxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datepickerFromDate;
        private System.Windows.Forms.DateTimePicker datepickerToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxRoomType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}