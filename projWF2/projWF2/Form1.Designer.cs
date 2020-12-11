namespace projWF2
{
    partial class frmSomar
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.btnGetN1 = new System.Windows.Forms.Button();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(288, 61);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 45);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(288, 109);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 45);
            this.txtN2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "1º número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "2º número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(289, 256);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(26, 39);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = ".";
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular1.Location = new System.Drawing.Point(37, 170);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(226, 63);
            this.btnCalcular1.TabIndex = 6;
            this.btnCalcular1.Text = "Calcular 1";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGetN1
            // 
            this.btnGetN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetN1.Location = new System.Drawing.Point(424, 311);
            this.btnGetN1.Name = "btnGetN1";
            this.btnGetN1.Size = new System.Drawing.Size(125, 47);
            this.btnGetN1.TabIndex = 7;
            this.btnGetN1.Text = "N1 ?";
            this.btnGetN1.UseVisualStyleBackColor = true;
            this.btnGetN1.Click += new System.EventHandler(this.btnGetN1_Click);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.Location = new System.Drawing.Point(298, 170);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(206, 62);
            this.btnCalcular2.TabIndex = 8;
            this.btnCalcular2.Text = "Calcular2";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // frmSomar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 398);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.btnGetN1);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmSomar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.Button btnGetN1;
        private System.Windows.Forms.Button btnCalcular2;
    }
}

