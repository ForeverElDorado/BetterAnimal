namespace BetterAnimal
{
    partial class VentanaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaMascotas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridTienda = new System.Windows.Forms.DataGridView();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMascotas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tablaMascotas);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mis Mascotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aqui deberían salir las mascotas del usuario logeado";
            // 
            // tablaMascotas
            // 
            this.tablaMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMascotas.Location = new System.Drawing.Point(50, 34);
            this.tablaMascotas.Name = "tablaMascotas";
            this.tablaMascotas.Size = new System.Drawing.Size(793, 385);
            this.tablaMascotas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.labelTelefono);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.labelDNI);
            this.tabPage2.Controls.Add(this.labelApellidos);
            this.tabPage2.Controls.Add(this.labelNombre);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mis Datos";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(198, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui se mostraria la info del usuario logeado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(76, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 85);
            this.button7.TabIndex = 3;
            this.button7.Text = "Solicitar una Vacuna";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.botonSolicitarVacuna);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(644, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 85);
            this.button6.TabIndex = 2;
            this.button6.Text = "Solicitar Revision";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.botonSolicitarRevision);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(644, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 85);
            this.button5.TabIndex = 1;
            this.button5.Text = "Registrar una mascota";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.botonRegistrarMascota);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 85);
            this.button4.TabIndex = 0;
            this.button4.Text = "Solicitar tratamiento de peluqueria";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.botonSolicitarPeluqueria);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dataGridTienda);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(893, 485);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tienda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Catalogo de la tienda:";
            // 
            // dataGridTienda
            // 
            this.dataGridTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTienda.Location = new System.Drawing.Point(50, 66);
            this.dataGridTienda.Name = "dataGridTienda";
            this.dataGridTienda.Size = new System.Drawing.Size(256, 217);
            this.dataGridTienda.TabIndex = 0;
            // 
            // labelTelefono
            // 
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTelefono.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTelefono.Location = new System.Drawing.Point(219, 267);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(262, 30);
            this.labelTelefono.TabIndex = 24;
            this.labelTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEmail.Location = new System.Drawing.Point(219, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(431, 30);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDNI
            // 
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDNI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDNI.Location = new System.Drawing.Point(219, 175);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(262, 30);
            this.labelDNI.TabIndex = 22;
            this.labelDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelApellidos
            // 
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelApellidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelApellidos.Location = new System.Drawing.Point(219, 133);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(262, 30);
            this.labelApellidos.TabIndex = 21;
            this.labelApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNombre.Location = new System.Drawing.Point(219, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(262, 30);
            this.labelNombre.TabIndex = 20;
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 515);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMascotas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tablaMascotas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridTienda;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}