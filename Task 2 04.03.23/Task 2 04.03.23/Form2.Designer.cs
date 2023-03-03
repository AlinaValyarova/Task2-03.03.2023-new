
namespace Task_2_04._03._23
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfDays = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка гостя";
            // 
            // FIO
            // 
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(26, 90);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(347, 35);
            this.FIO.TabIndex = 1;
            this.FIO.Text = "ФИО";
            // 
            // Birthdate
            // 
            this.Birthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Birthdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthdate.Location = new System.Drawing.Point(26, 135);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(347, 35);
            this.Birthdate.TabIndex = 2;
            this.Birthdate.Text = "Дата рождения";
            // 
            // payment
            // 
            this.payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payment.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment.Location = new System.Drawing.Point(26, 180);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(347, 35);
            this.payment.TabIndex = 3;
            this.payment.Text = "Оплата";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество дней";
            // 
            // numberOfDays
            // 
            this.numberOfDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfDays.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfDays.Location = new System.Drawing.Point(254, 226);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(119, 35);
            this.numberOfDays.TabIndex = 5;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(26, 286);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(208, 21);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "Путешествую с животными";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 338);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.numberOfDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label FIO;
        public System.Windows.Forms.Label Birthdate;
        public System.Windows.Forms.Label payment;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label numberOfDays;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}