
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
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 180);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(609, 122);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAgregarList
            // 
            this.btnAgregarList.Enabled = false;
            this.btnAgregarList.Location = new System.Drawing.Point(405, 47);
            this.btnAgregarList.Name = "btnAgregarList";
            this.btnAgregarList.Size = new System.Drawing.Size(165, 26);
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
            this.gbPeliculaLista.Location = new System.Drawing.Point(64, 32);
            this.gbPeliculaLista.Name = "gbPeliculaLista";
            this.gbPeliculaLista.Size = new System.Drawing.Size(222, 112);
            this.gbPeliculaLista.TabIndex = 2;
            this.gbPeliculaLista.TabStop = false;
            this.gbPeliculaLista.Text = "Película";
            // 
            // lblCategoriaLista
            // 
            this.lblCategoriaLista.AutoSize = true;
            this.lblCategoriaLista.Location = new System.Drawing.Point(106, 79);
            this.lblCategoriaLista.Name = "lblCategoriaLista";
            this.lblCategoriaLista.Size = new System.Drawing.Size(0, 13);
            this.lblCategoriaLista.TabIndex = 5;
            // 
            // lblAnioLista
            // 
            this.lblAnioLista.AutoSize = true;
            this.lblAnioLista.Location = new System.Drawing.Point(106, 51);
            this.lblAnioLista.Name = "lblAnioLista";
            this.lblAnioLista.Size = new System.Drawing.Size(0, 13);
            this.lblAnioLista.TabIndex = 4;
            // 
            // lblNombreLista
            // 
            this.lblNombreLista.AutoSize = true;
            this.lblNombreLista.Location = new System.Drawing.Point(106, 22);
            this.lblNombreLista.Name = "lblNombreLista";
            this.lblNombreLista.Size = new System.Drawing.Size(0, 13);
            this.lblNombreLista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnVerPeli
            // 
            this.btnVerPeli.Enabled = false;
            this.btnVerPeli.Location = new System.Drawing.Point(405, 91);
            this.btnVerPeli.Name = "btnVerPeli";
            this.btnVerPeli.Size = new System.Drawing.Size(165, 26);
            this.btnVerPeli.TabIndex = 3;
            this.btnVerPeli.Text = "Ver Película";
            this.btnVerPeli.UseVisualStyleBackColor = true;
            this.btnVerPeli.Click += new System.EventHandler(this.btnVerPeli_Click);
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 314);
            this.Controls.Add(this.btnVerPeli);
            this.Controls.Add(this.gbPeliculaLista);
            this.Controls.Add(this.btnAgregarList);
            this.Controls.Add(this.listView1);
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
    }
}