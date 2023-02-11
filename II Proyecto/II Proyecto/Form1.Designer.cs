namespace II_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota1textBox = new System.Windows.Forms.TextBox();
            this.Nota2textBox = new System.Windows.Forms.TextBox();
            this.Nota3textBox = new System.Windows.Forms.TextBox();
            this.Nota4textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nota del primer parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la nota del segundo parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la nota del tercer parcial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la nota del cuarto parcial";
            // 
            // Nota1textBox
            // 
            this.Nota1textBox.Location = new System.Drawing.Point(392, 92);
            this.Nota1textBox.Name = "Nota1textBox";
            this.Nota1textBox.Size = new System.Drawing.Size(100, 20);
            this.Nota1textBox.TabIndex = 4;
            // 
            // Nota2textBox
            // 
            this.Nota2textBox.Location = new System.Drawing.Point(392, 132);
            this.Nota2textBox.Name = "Nota2textBox";
            this.Nota2textBox.Size = new System.Drawing.Size(100, 20);
            this.Nota2textBox.TabIndex = 5;
            // 
            // Nota3textBox
            // 
            this.Nota3textBox.Location = new System.Drawing.Point(392, 176);
            this.Nota3textBox.Name = "Nota3textBox";
            this.Nota3textBox.Size = new System.Drawing.Size(100, 20);
            this.Nota3textBox.TabIndex = 6;
            // 
            // Nota4textBox
            // 
            this.Nota4textBox.Location = new System.Drawing.Point(392, 219);
            this.Nota4textBox.Name = "Nota4textBox";
            this.Nota4textBox.Size = new System.Drawing.Size(100, 20);
            this.Nota4textBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(392, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular Promedio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "CALCULAR EL PROMEDIO DEL ESTUDIANTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 357);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nota4textBox);
            this.Controls.Add(this.Nota3textBox);
            this.Controls.Add(this.Nota2textBox);
            this.Controls.Add(this.Nota1textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nota1textBox;
        private System.Windows.Forms.TextBox Nota2textBox;
        private System.Windows.Forms.TextBox Nota3textBox;
        private System.Windows.Forms.TextBox Nota4textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

