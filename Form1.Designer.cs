namespace proyecto_doble
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.lstDescripciones = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(32, 114);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(210, 303);
            this.lstLibros.TabIndex = 1;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(400, 44);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 2;
            this.btnBuscarLibro.Text = "btnBuscarLibro";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(286, 114);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(200, 303);
            this.lstAutores.TabIndex = 3;
            // 
            // lstDescripciones
            // 
            this.lstDescripciones.FormattingEnabled = true;
            this.lstDescripciones.Location = new System.Drawing.Point(532, 114);
            this.lstDescripciones.Name = "lstDescripciones";
            this.lstDescripciones.Size = new System.Drawing.Size(223, 303);
            this.lstDescripciones.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDescripciones);
            this.Controls.Add(this.lstAutores);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.ListBox lstAutores;
        private System.Windows.Forms.ListBox lstDescripciones;
        private System.Windows.Forms.Button button1;
    }
}

