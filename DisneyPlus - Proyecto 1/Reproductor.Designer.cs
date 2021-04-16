
namespace DisneyPlus___Proyecto_1
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNombreRep = new System.Windows.Forms.Label();
            this.lblCategoriaRep = new System.Windows.Forms.Label();
            this.lblAnioRep = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reproduciendo...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continuar Viendo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Finalizar Reproducción";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNombreRep
            // 
            this.lblNombreRep.AutoSize = true;
            this.lblNombreRep.Location = new System.Drawing.Point(18, 9);
            this.lblNombreRep.Name = "lblNombreRep";
            this.lblNombreRep.Size = new System.Drawing.Size(51, 13);
            this.lblNombreRep.TabIndex = 3;
            this.lblNombreRep.Text = "categoria";
            // 
            // lblCategoriaRep
            // 
            this.lblCategoriaRep.AutoSize = true;
            this.lblCategoriaRep.Location = new System.Drawing.Point(112, 9);
            this.lblCategoriaRep.Name = "lblCategoriaRep";
            this.lblCategoriaRep.Size = new System.Drawing.Size(42, 13);
            this.lblCategoriaRep.TabIndex = 4;
            this.lblCategoriaRep.Text = "nombre";
            // 
            // lblAnioRep
            // 
            this.lblAnioRep.AutoSize = true;
            this.lblAnioRep.Location = new System.Drawing.Point(232, 9);
            this.lblAnioRep.Name = "lblAnioRep";
            this.lblAnioRep.Size = new System.Drawing.Size(25, 13);
            this.lblAnioRep.TabIndex = 5;
            this.lblAnioRep.Text = "año";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 135);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAnioRep);
            this.Controls.Add(this.lblCategoriaRep);
            this.Controls.Add(this.lblNombreRep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombreRep;
        private System.Windows.Forms.Label lblCategoriaRep;
        private System.Windows.Forms.Label lblAnioRep;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}