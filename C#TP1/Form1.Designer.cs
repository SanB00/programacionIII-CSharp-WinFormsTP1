namespace C_TP1
{
    partial class Form1
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
            this.btnEJERCICIO1 = new System.Windows.Forms.Button();
            this.btnEJERCICIO3 = new System.Windows.Forms.Button();
            this.btnEJERCICIO2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEJERCICIO1
            // 
            this.btnEJERCICIO1.Location = new System.Drawing.Point(12, 60);
            this.btnEJERCICIO1.Name = "btnEJERCICIO1";
            this.btnEJERCICIO1.Size = new System.Drawing.Size(85, 23);
            this.btnEJERCICIO1.TabIndex = 0;
            this.btnEJERCICIO1.Text = "EJERCICIO 1";
            this.btnEJERCICIO1.UseVisualStyleBackColor = true;
            this.btnEJERCICIO1.Click += new System.EventHandler(this.btnEJERCICIO1_Click);
            // 
            // btnEJERCICIO3
            // 
            this.btnEJERCICIO3.Location = new System.Drawing.Point(222, 60);
            this.btnEJERCICIO3.Name = "btnEJERCICIO3";
            this.btnEJERCICIO3.Size = new System.Drawing.Size(85, 23);
            this.btnEJERCICIO3.TabIndex = 1;
            this.btnEJERCICIO3.Text = "EJERCICIO 3";
            this.btnEJERCICIO3.UseVisualStyleBackColor = true;
            this.btnEJERCICIO3.Click += new System.EventHandler(this.btnEJERCICIO3_Click);
            // 
            // btnEJERCICIO2
            // 
            this.btnEJERCICIO2.Location = new System.Drawing.Point(120, 60);
            this.btnEJERCICIO2.Name = "btnEJERCICIO2";
            this.btnEJERCICIO2.Size = new System.Drawing.Size(85, 23);
            this.btnEJERCICIO2.TabIndex = 2;
            this.btnEJERCICIO2.Text = "EJERCICIO 2";
            this.btnEJERCICIO2.UseVisualStyleBackColor = true;
            this.btnEJERCICIO2.Click += new System.EventHandler(this.btnEJERCICIO2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integrantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 102);
            this.label2.TabIndex = 4;
            this.label2.Text = "Santiago Burgos\r\nDerly Yulieth Valencia\r\nElian Maspero\r\nGuillermo Maydana\r\nLautar" +
    "o Nehuel Gimenez\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEJERCICIO2);
            this.Controls.Add(this.btnEJERCICIO3);
            this.Controls.Add(this.btnEJERCICIO1);
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEJERCICIO1;
        private System.Windows.Forms.Button btnEJERCICIO3;
        private System.Windows.Forms.Button btnEJERCICIO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

