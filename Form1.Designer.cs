namespace EJERCICIO_EN_CLASE_1
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
            this.Prueba = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.botoncargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNivel_De_poder = new System.Windows.Forms.NumericUpDown();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_De_poder)).BeginInit();
            this.SuspendLayout();
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(634, 210);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 0;
            this.Prueba.Text = "PRUEBA";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(30, 181);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(496, 148);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // botoncargar
            // 
            this.botoncargar.Location = new System.Drawing.Point(634, 239);
            this.botoncargar.Name = "botoncargar";
            this.botoncargar.Size = new System.Drawing.Size(75, 23);
            this.botoncargar.TabIndex = 2;
            this.botoncargar.Text = "Cargar";
            this.botoncargar.UseVisualStyleBackColor = true;
            this.botoncargar.Click += new System.EventHandler(this.botoncargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel de poder";
            // 
            // numericUpDownNivel_De_poder
            // 
            this.numericUpDownNivel_De_poder.Location = new System.Drawing.Point(162, 144);
            this.numericUpDownNivel_De_poder.Name = "numericUpDownNivel_De_poder";
            this.numericUpDownNivel_De_poder.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNivel_De_poder.TabIndex = 7;
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(162, 12);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(100, 20);
            this.textboxID.TabIndex = 8;
            this.textboxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(162, 56);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 9;
            // 
            // textBoxraza
            // 
            this.textBoxraza.Location = new System.Drawing.Point(162, 97);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(100, 20);
            this.textBoxraza.TabIndex = 10;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(434, 144);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 11;
            this.insertar.Text = "CREAR";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.textBoxraza);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.numericUpDownNivel_De_poder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botoncargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.Prueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel_De_poder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button botoncargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNivel_De_poder;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxraza;
        private System.Windows.Forms.Button insertar;
    }
}

