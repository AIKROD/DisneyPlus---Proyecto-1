
namespace Estructura_De_Datos
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
            this.btn_ListaDoble = new System.Windows.Forms.Button();
            this.btn_ListaEnlazada = new System.Windows.Forms.Button();
            this.btn_Colas = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ListaDoble
            // 
            this.btn_ListaDoble.Location = new System.Drawing.Point(220, 204);
            this.btn_ListaDoble.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_ListaDoble.Name = "btn_ListaDoble";
            this.btn_ListaDoble.Size = new System.Drawing.Size(80, 26);
            this.btn_ListaDoble.TabIndex = 0;
            this.btn_ListaDoble.Text = "Lista Doble";
            this.btn_ListaDoble.UseVisualStyleBackColor = true;
            this.btn_ListaDoble.Click += new System.EventHandler(this.btn_ListaDoble_Click);
            // 
            // btn_ListaEnlazada
            // 
            this.btn_ListaEnlazada.Location = new System.Drawing.Point(72, 204);
            this.btn_ListaEnlazada.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_ListaEnlazada.Name = "btn_ListaEnlazada";
            this.btn_ListaEnlazada.Size = new System.Drawing.Size(80, 26);
            this.btn_ListaEnlazada.TabIndex = 1;
            this.btn_ListaEnlazada.Text = "Lista Enlazada";
            this.btn_ListaEnlazada.UseVisualStyleBackColor = true;
            this.btn_ListaEnlazada.Click += new System.EventHandler(this.btn_ListaEnlazada_Click);
            // 
            // btn_Colas
            // 
            this.btn_Colas.Location = new System.Drawing.Point(374, 204);
            this.btn_Colas.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_Colas.Name = "btn_Colas";
            this.btn_Colas.Size = new System.Drawing.Size(82, 26);
            this.btn_Colas.TabIndex = 2;
            this.btn_Colas.Text = "Colas";
            this.btn_Colas.UseVisualStyleBackColor = true;
            this.btn_Colas.Click += new System.EventHandler(this.btn_Colas_Click);
            // 
            // btnPila
            // 
            this.btnPila.Location = new System.Drawing.Point(540, 204);
            this.btnPila.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(75, 26);
            this.btnPila.TabIndex = 3;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 354);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btn_Colas);
            this.Controls.Add(this.btn_ListaEnlazada);
            this.Controls.Add(this.btn_ListaDoble);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListaDoble;
        private System.Windows.Forms.Button btn_ListaEnlazada;
        private System.Windows.Forms.Button btn_Colas;
        private System.Windows.Forms.Button btnPila;
    }
}

