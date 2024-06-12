namespace Calculadora_Simple
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
            this.Resultado = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.multiplicado = new System.Windows.Forms.Button();
            this.dividido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.SystemColors.InfoText;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.Control;
            this.Resultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resultado.Location = new System.Drawing.Point(80, 70);
            this.Resultado.Margin = new System.Windows.Forms.Padding(3);
            this.Resultado.MaximumSize = new System.Drawing.Size(440, 67);
            this.Resultado.MinimumSize = new System.Drawing.Size(440, 67);
            this.Resultado.Name = "Resultado";
            this.Resultado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Resultado.Size = new System.Drawing.Size(440, 67);
            this.Resultado.TabIndex = 0;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // number1
            // 
            this.number1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number1.Location = new System.Drawing.Point(80, 150);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(77, 67);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(170, 150);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(77, 67);
            this.number2.TabIndex = 2;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(260, 150);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(77, 67);
            this.number3.TabIndex = 3;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(80, 230);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(77, 67);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(170, 230);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(77, 67);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(260, 230);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(77, 67);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(80, 310);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(77, 67);
            this.number7.TabIndex = 7;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(170, 310);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(77, 67);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(260, 310);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(77, 67);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(80, 390);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(77, 67);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(350, 230);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(77, 67);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(440, 230);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(77, 67);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(170, 390);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(167, 67);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(350, 150);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(77, 67);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(440, 150);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 67);
            this.delete.TabIndex = 15;
            this.delete.Text = "<-";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplicado
            // 
            this.multiplicado.Location = new System.Drawing.Point(350, 310);
            this.multiplicado.Name = "multiplicado";
            this.multiplicado.Size = new System.Drawing.Size(77, 67);
            this.multiplicado.TabIndex = 16;
            this.multiplicado.Text = "x";
            this.multiplicado.UseVisualStyleBackColor = true;
            this.multiplicado.Click += new System.EventHandler(this.multiplicado_Click);
            // 
            // dividido
            // 
            this.dividido.Location = new System.Drawing.Point(440, 310);
            this.dividido.Name = "dividido";
            this.dividido.Size = new System.Drawing.Size(77, 67);
            this.dividido.TabIndex = 17;
            this.dividido.Text = "/";
            this.dividido.UseVisualStyleBackColor = true;
            this.dividido.Click += new System.EventHandler(this.dividido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(615, 492);
            this.Controls.Add(this.dividido);
            this.Controls.Add(this.multiplicado);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.Resultado);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "CalculadoraSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button multiplicado;
        private System.Windows.Forms.Button dividido;
    }
}

