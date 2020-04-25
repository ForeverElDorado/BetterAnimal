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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tablaMascotas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMascotas)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tablaMascotas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mis Mascotas";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mis Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inicio";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(893, 492);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tienda";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(893, 492);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Citas";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // VentanaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "VentanaCliente";
            this.Text = "Bienvenido";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMascotas)).EndInit();
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
    }
}