
namespace DisneyPlus___Proyecto_1
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPeli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria_Eliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar_Eliminar = new System.Windows.Forms.Button();
            this.lbCategorias_Eliminar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarPeli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Nueva Película";
            // 
            // btnAgregarPeli
            // 
            this.btnAgregarPeli.Enabled = false;
            this.btnAgregarPeli.Location = new System.Drawing.Point(46, 185);
            this.btnAgregarPeli.Name = "btnAgregarPeli";
            this.btnAgregarPeli.Size = new System.Drawing.Size(226, 23);
            this.btnAgregarPeli.TabIndex = 8;
            this.btnAgregarPeli.Text = "Aceptar";
            this.btnAgregarPeli.UseVisualStyleBackColor = true;
            this.btnAgregarPeli.Click += new System.EventHandler(this.btnAgregarPeli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(151, 88);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(121, 20);
            this.txtAnio.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Disney",
            "Pixar",
            "Marvel",
            "Star Wars",
            "National Geographic"});
            this.cmbCategoria.Location = new System.Drawing.Point(151, 131);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCategorias_Eliminar);
            this.groupBox2.Controls.Add(this.btnEliminar_Eliminar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbCategoria_Eliminar);
            this.groupBox2.Location = new System.Drawing.Point(408, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 227);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Película De";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categoría";
            // 
            // cmbCategoria_Eliminar
            // 
            this.cmbCategoria_Eliminar.FormattingEnabled = true;
            this.cmbCategoria_Eliminar.Items.AddRange(new object[] {
            "Disney",
            "Pixar",
            "Marvel",
            "Star Wars",
            "National Geographic"});
            this.cmbCategoria_Eliminar.Location = new System.Drawing.Point(93, 52);
            this.cmbCategoria_Eliminar.Name = "cmbCategoria_Eliminar";
            this.cmbCategoria_Eliminar.Size = new System.Drawing.Size(169, 21);
            this.cmbCategoria_Eliminar.TabIndex = 5;
            this.cmbCategoria_Eliminar.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_Eliminar_SelectedIndexChanged);
            // 
            // btnEliminar_Eliminar
            // 
            this.btnEliminar_Eliminar.Enabled = false;
            this.btnEliminar_Eliminar.Location = new System.Drawing.Point(36, 188);
            this.btnEliminar_Eliminar.Name = "btnEliminar_Eliminar";
            this.btnEliminar_Eliminar.Size = new System.Drawing.Size(226, 23);
            this.btnEliminar_Eliminar.TabIndex = 9;
            this.btnEliminar_Eliminar.Text = "Eliminar";
            this.btnEliminar_Eliminar.UseVisualStyleBackColor = true;
            this.btnEliminar_Eliminar.Click += new System.EventHandler(this.btnEliminar_Eliminar_Click);
            // 
            // lbCategorias_Eliminar
            // 
            this.lbCategorias_Eliminar.FormattingEnabled = true;
            this.lbCategorias_Eliminar.Location = new System.Drawing.Point(292, 21);
            this.lbCategorias_Eliminar.Name = "lbCategorias_Eliminar";
            this.lbCategorias_Eliminar.Size = new System.Drawing.Size(224, 186);
            this.lbCategorias_Eliminar.TabIndex = 10;
            this.lbCategorias_Eliminar.SelectedIndexChanged += new System.EventHandler(this.lbCategorias_Eliminar_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarPeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoria_Eliminar;
        private System.Windows.Forms.ListBox lbCategorias_Eliminar;
        private System.Windows.Forms.Button btnEliminar_Eliminar;
    }
}