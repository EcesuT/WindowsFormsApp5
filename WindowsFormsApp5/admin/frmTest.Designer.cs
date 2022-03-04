namespace WindowsFormsApp5.admin
{
    partial class frmTest
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
            this.btnKare = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTekmiCiftmi = new System.Windows.Forms.Button();
            this.btnBasamak = new System.Windows.Forms.Button();
            this.btnBactery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKare
            // 
            this.btnKare.Location = new System.Drawing.Point(209, 176);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(177, 23);
            this.btnKare.TabIndex = 0;
            this.btnKare.Text = "button1";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // btnTekmiCiftmi
            // 
            this.btnTekmiCiftmi.Location = new System.Drawing.Point(209, 205);
            this.btnTekmiCiftmi.Name = "btnTekmiCiftmi";
            this.btnTekmiCiftmi.Size = new System.Drawing.Size(177, 23);
            this.btnTekmiCiftmi.TabIndex = 5;
            this.btnTekmiCiftmi.Text = "button2";
            this.btnTekmiCiftmi.UseVisualStyleBackColor = true;
            this.btnTekmiCiftmi.Click += new System.EventHandler(this.btnTekmiCiftmi_Click);
            // 
            // btnBasamak
            // 
            this.btnBasamak.Location = new System.Drawing.Point(209, 234);
            this.btnBasamak.Name = "btnBasamak";
            this.btnBasamak.Size = new System.Drawing.Size(177, 23);
            this.btnBasamak.TabIndex = 6;
            this.btnBasamak.Text = "button3";
            this.btnBasamak.UseVisualStyleBackColor = true;
            // 
            // btnBactery
            // 
            this.btnBactery.Location = new System.Drawing.Point(209, 263);
            this.btnBactery.Name = "btnBactery";
            this.btnBactery.Size = new System.Drawing.Size(177, 23);
            this.btnBactery.TabIndex = 7;
            this.btnBactery.Text = "button4";
            this.btnBactery.UseVisualStyleBackColor = true;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 368);
            this.Controls.Add(this.btnBactery);
            this.Controls.Add(this.btnBasamak);
            this.Controls.Add(this.btnTekmiCiftmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKare);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTekmiCiftmi;
        private System.Windows.Forms.Button btnBasamak;
        private System.Windows.Forms.Button btnBactery;
    }
}