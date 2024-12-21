namespace Simple_menu_design
{
    partial class frmSales
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
            this.lbltext = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DatagridshowSales = new System.Windows.Forms.DataGridView();
            this.dateTimePickerfrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelEmployeefrom = new System.Windows.Forms.Panel();
            this.datetimesale = new System.Windows.Forms.DateTimePicker();
            this.txtsale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridshowSales)).BeginInit();
            this.PanelEmployeefrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.Violet;
            this.lbltext.Location = new System.Drawing.Point(546, 328);
            this.lbltext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(152, 30);
            this.lbltext.TabIndex = 3;
            this.lbltext.Text = "Show All Sales ";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAll.Location = new System.Drawing.Point(866, 371);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(70, 30);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(777, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatagridshowSales
            // 
            this.DatagridshowSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridshowSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridshowSales.Location = new System.Drawing.Point(5, 409);
            this.DatagridshowSales.Name = "DatagridshowSales";
            this.DatagridshowSales.Size = new System.Drawing.Size(1157, 200);
            this.DatagridshowSales.TabIndex = 16;
            // 
            // dateTimePickerfrom
            // 
            this.dateTimePickerfrom.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dateTimePickerfrom.Location = new System.Drawing.Point(295, 374);
            this.dateTimePickerfrom.Name = "dateTimePickerfrom";
            this.dateTimePickerfrom.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerfrom.TabIndex = 17;
            this.dateTimePickerfrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerto
            // 
            this.dateTimePickerto.CalendarTitleBackColor = System.Drawing.Color.OliveDrab;
            this.dateTimePickerto.Location = new System.Drawing.Point(557, 374);
            this.dateTimePickerto.Name = "dateTimePickerto";
            this.dateTimePickerto.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerto.TabIndex = 17;
            this.dateTimePickerto.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "To :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(648, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(549, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 29);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Fuchsia;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(461, 248);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 29);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(-8, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 10);
            this.panel1.TabIndex = 24;
            // 
            // PanelEmployeefrom
            // 
            this.PanelEmployeefrom.BackColor = System.Drawing.Color.DarkKhaki;
            this.PanelEmployeefrom.Controls.Add(this.datetimesale);
            this.PanelEmployeefrom.Controls.Add(this.txtsale);
            this.PanelEmployeefrom.Controls.Add(this.label6);
            this.PanelEmployeefrom.Controls.Add(this.label3);
            this.PanelEmployeefrom.Controls.Add(this.txtid);
            this.PanelEmployeefrom.Controls.Add(this.label4);
            this.PanelEmployeefrom.Location = new System.Drawing.Point(5, 82);
            this.PanelEmployeefrom.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEmployeefrom.Name = "PanelEmployeefrom";
            this.PanelEmployeefrom.Size = new System.Drawing.Size(1157, 154);
            this.PanelEmployeefrom.TabIndex = 21;
            this.PanelEmployeefrom.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelEmployeefrom_Paint);
            // 
            // datetimesale
            // 
            this.datetimesale.Location = new System.Drawing.Point(495, 61);
            this.datetimesale.Name = "datetimesale";
            this.datetimesale.Size = new System.Drawing.Size(200, 25);
            this.datetimesale.TabIndex = 4;
            // 
            // txtsale
            // 
            this.txtsale.Location = new System.Drawing.Point(493, 90);
            this.txtsale.Name = "txtsale";
            this.txtsale.Size = new System.Drawing.Size(202, 25);
            this.txtsale.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Sale :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sale Date :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(493, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(202, 25);
            this.txtid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Violet;
            this.label5.Location = new System.Drawing.Point(511, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sale Entry";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelEmployeefrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerto);
            this.Controls.Add(this.dateTimePickerfrom);
            this.Controls.Add(this.DatagridshowSales);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltext);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridshowSales)).EndInit();
            this.PanelEmployeefrom.ResumeLayout(false);
            this.PanelEmployeefrom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DatagridshowSales;
        private System.Windows.Forms.DateTimePicker dateTimePickerfrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelEmployeefrom;
        private System.Windows.Forms.TextBox txtsale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimesale;
    }
}