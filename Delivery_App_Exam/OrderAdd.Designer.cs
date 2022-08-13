namespace Delivery_App_Exam
{
    partial class OrderAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_descr = new System.Windows.Forms.TextBox();
            this.dtp_bd = new System.Windows.Forms.DateTimePicker();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.CB_carrier = new System.Windows.Forms.ComboBox();
            this.CB_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "ГОТОВО";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "ОТМЕНА";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес доставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание доставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость доставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Курьер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Статус заказа";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(209, 24);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(375, 48);
            this.tb_address.TabIndex = 8;
            // 
            // tb_descr
            // 
            this.tb_descr.Location = new System.Drawing.Point(209, 98);
            this.tb_descr.Multiline = true;
            this.tb_descr.Name = "tb_descr";
            this.tb_descr.Size = new System.Drawing.Size(375, 48);
            this.tb_descr.TabIndex = 9;
            // 
            // dtp_bd
            // 
            this.dtp_bd.Location = new System.Drawing.Point(209, 184);
            this.dtp_bd.MaxDate = new System.DateTime(2022, 8, 11, 0, 0, 0, 0);
            this.dtp_bd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_bd.Name = "dtp_bd";
            this.dtp_bd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_bd.Size = new System.Drawing.Size(375, 20);
            this.dtp_bd.TabIndex = 10;
            this.dtp_bd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(209, 240);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(375, 20);
            this.tb_cost.TabIndex = 11;
            // 
            // CB_carrier
            // 
            this.CB_carrier.FormattingEnabled = true;
            this.CB_carrier.Location = new System.Drawing.Point(209, 313);
            this.CB_carrier.Name = "CB_carrier";
            this.CB_carrier.Size = new System.Drawing.Size(375, 21);
            this.CB_carrier.TabIndex = 12;
            // 
            // CB_status
            // 
            this.CB_status.FormattingEnabled = true;
            this.CB_status.Location = new System.Drawing.Point(209, 391);
            this.CB_status.Name = "CB_status";
            this.CB_status.Size = new System.Drawing.Size(375, 21);
            this.CB_status.TabIndex = 13;
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 505);
            this.Controls.Add(this.CB_status);
            this.Controls.Add(this.CB_carrier);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.dtp_bd);
            this.Controls.Add(this.tb_descr);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "OrderAdd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_descr;
        private System.Windows.Forms.DateTimePicker dtp_bd;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.ComboBox CB_carrier;
        private System.Windows.Forms.ComboBox CB_status;
    }
}