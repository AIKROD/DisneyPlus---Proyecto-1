
namespace DisneyPlus___Proyecto_1
{
    partial class Feed
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarList = new System.Windows.Forms.Button();
            this.gbPeliculaLista = new System.Windows.Forms.GroupBox();
            this.lblCategoriaLista = new System.Windows.Forms.Label();
            this.lblAnioLista = new System.Windows.Forms.Label();
            this.lblNombreLista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerPeli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPeliculaLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 425);
            this.listView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1624, 291);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAgregarList
            // 
            this.btnAgregarList.Enabled = false;
            this.btnAgregarList.Location = new System.Drawing.Point(1080, 112);
            this.btnAgregarList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregarList.Name = "btnAgregarList";
            this.btnAgregarList.Size = new System.Drawing.Size(440, 62);
            this.btnAgregarList.TabIndex = 1;
            this.btnAgregarList.Text = "Agregar a mi Lista";
            this.btnAgregarList.UseVisualStyleBackColor = true;
            this.btnAgregarList.Click += new System.EventHandler(this.btnAgregarList_Click);
            // 
            // gbPeliculaLista
            // 
            this.gbPeliculaLista.Controls.Add(this.lblCategoriaLista);
            this.gbPeliculaLista.Controls.Add(this.lblAnioLista);
            this.gbPeliculaLista.Controls.Add(this.lblNombreLista);
            this.gbPeliculaLista.Controls.Add(this.label3);
            this.gbPeliculaLista.Controls.Add(this.label2);
            this.gbPeliculaLista.Controls.Add(this.label1);
            this.gbPeliculaLista.Location = new System.Drawing.Point(171, 76);
            this.gbPeliculaLista.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbPeliculaLista.Name = "gbPeliculaLista";
            this.gbPeliculaLista.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbPeliculaLista.Size = new System.Drawing.Size(592, 267);
            this.gbPeliculaLista.TabIndex = 2;
            this.gbPeliculaLista.TabStop = false;
            this.gbPeliculaLista.Text = "Película";
            // 
            // lblCategoriaLista
            // 
            this.lblCategoriaLista.AutoSize = true;
            this.lblCategoriaLista.Location = new System.Drawing.Point(283, 188);
            this.lblCategoriaLista.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCategoriaLista.Name = "lblCategoriaLista";
            this.lblCategoriaLista.Size = new System.Drawing.Size(0, 32);
            this.lblCategoriaLista.TabIndex = 5;
            // 
            // lblAnioLista
            // 
            this.lblAnioLista.AutoSize = true;
            this.lblAnioLista.Location = new System.Drawing.Point(283, 122);
            this.lblAnioLista.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAnioLista.Name = "lblAnioLista";
            this.lblAnioLista.Size = new System.Drawing.Size(0, 32);
            this.lblAnioLista.TabIndex = 4;
            // 
            // lblNombreLista
            // 
            this.lblNombreLista.AutoSize = true;
            this.lblNombreLista.Location = new System.Drawing.Point(283, 52);
            this.lblNombreLista.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNombreLista.Name = "lblNombreLista";
            this.lblNombreLista.Size = new System.Drawing.Size(0, 32);
            this.lblNombreLista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnVerPeli
            // 
            this.btnVerPeli.Enabled = false;
            this.btnVerPeli.Location = new System.Drawing.Point(1080, 217);
            this.btnVerPeli.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVerPeli.Name = "btnVerPeli";
            this.btnVerPeli.Size = new System.Drawing.Size(440, 62);
            this.btnVerPeli.TabIndex = 3;
            this.btnVerPeli.Text = "Ver Película";
            this.btnVerPeli.UseVisualStyleBackColor = true;
            this.btnVerPeli.Click += new System.EventHandler(this.btnVerPeli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(30, 753);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1624, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1893, 1329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerPeli);
            this.Controls.Add(this.gbPeliculaLista);
            this.Controls.Add(this.btnAgregarList);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Feed";
            this.Text = "Feed";
            this.Load += new System.EventHandler(this.Feed_Load);
            this.gbPeliculaLista.ResumeLayout(false);
            this.gbPeliculaLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAgregarList;
        private System.Windows.Forms.GroupBox gbPeliculaLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoriaLista;
        private System.Windows.Forms.Label lblAnioLista;
        private System.Windows.Forms.Label lblNombreLista;
        private System.Windows.Forms.Button btnVerPeli;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}