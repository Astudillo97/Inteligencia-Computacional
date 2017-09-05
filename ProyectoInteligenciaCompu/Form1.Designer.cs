namespace ProyectoInteligenciaCompu
{
    partial class App
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
            this.CargarImg = new System.Windows.Forms.Button();
            this.Transformar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Salida = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CargarImg
            // 
            this.CargarImg.Location = new System.Drawing.Point(26, 227);
            this.CargarImg.Name = "CargarImg";
            this.CargarImg.Size = new System.Drawing.Size(75, 23);
            this.CargarImg.TabIndex = 0;
            this.CargarImg.Text = "Cargar Imagen";
            this.CargarImg.UseVisualStyleBackColor = true;
            this.CargarImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transformar
            // 
            this.Transformar.Location = new System.Drawing.Point(215, 227);
            this.Transformar.Name = "Transformar";
            this.Transformar.Size = new System.Drawing.Size(75, 23);
            this.Transformar.TabIndex = 1;
            this.Transformar.Text = "Transformar";
            this.Transformar.UseVisualStyleBackColor = true;
            this.Transformar.Click += new System.EventHandler(this.Transformar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Salida
            // 
            this.Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salida.FormattingEnabled = true;
            this.Salida.HorizontalScrollbar = true;
            this.Salida.ItemHeight = 7;
            this.Salida.Location = new System.Drawing.Point(26, 265);
            this.Salida.Name = "Salida";
            this.Salida.ScrollAlwaysVisible = true;
            this.Salida.Size = new System.Drawing.Size(474, 102);
            this.Salida.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 187);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(266, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 187);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 378);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Transformar);
            this.Controls.Add(this.CargarImg);
            this.Name = "App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CargarImg;
        private System.Windows.Forms.Button Transformar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Salida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

