
namespace WinFormAdatbazisAutok
{
    partial class FormAuto
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Marka = new System.Windows.Forms.TextBox();
            this.date_ForgalombaHelyezes = new System.Windows.Forms.DateTimePicker();
            this.button_Muvelet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Márka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forgalomba helyezés éve:";
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(200, 83);
            this.textBox_Rendszam.MaxLength = 7;
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rendszam.TabIndex = 4;
            // 
            // textBox_Marka
            // 
            this.textBox_Marka.Location = new System.Drawing.Point(200, 131);
            this.textBox_Marka.Name = "textBox_Marka";
            this.textBox_Marka.Size = new System.Drawing.Size(100, 20);
            this.textBox_Marka.TabIndex = 5;
            // 
            // date_ForgalombaHelyezes
            // 
            this.date_ForgalombaHelyezes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ForgalombaHelyezes.Location = new System.Drawing.Point(200, 179);
            this.date_ForgalombaHelyezes.Name = "date_ForgalombaHelyezes";
            this.date_ForgalombaHelyezes.Size = new System.Drawing.Size(100, 20);
            this.date_ForgalombaHelyezes.TabIndex = 7;
            // 
            // button_Muvelet
            // 
            this.button_Muvelet.Location = new System.Drawing.Point(146, 242);
            this.button_Muvelet.Name = "button_Muvelet";
            this.button_Muvelet.Size = new System.Drawing.Size(113, 48);
            this.button_Muvelet.TabIndex = 8;
            this.button_Muvelet.Text = "Végrahajt";
            this.button_Muvelet.UseVisualStyleBackColor = true;
            this.button_Muvelet.Click += new System.EventHandler(this.button_Muvelet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(200, 35);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id.TabIndex = 10;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Muvelet);
            this.Controls.Add(this.date_ForgalombaHelyezes);
            this.Controls.Add(this.textBox_Marka);
            this.Controls.Add(this.textBox_Rendszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autó adatai";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.TextBox textBox_Marka;
        private System.Windows.Forms.DateTimePicker date_ForgalombaHelyezes;
        private System.Windows.Forms.Button button_Muvelet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Id;
    }
}