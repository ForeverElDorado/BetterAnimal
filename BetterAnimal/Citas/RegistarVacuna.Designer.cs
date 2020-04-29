namespace BetterAnimal.Citas
{
    partial class RegistarVacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarVacuna));
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.tsss = new System.Windows.Forms.Label();
            this.textNombreVacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEmision = new System.Windows.Forms.DateTimePicker();
            this.datecaducidad = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxChip
            // 
            this.textBoxChip.Location = new System.Drawing.Point(157, 73);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(117, 20);
            this.textBoxChip.TabIndex = 9;
            // 
            // tsss
            // 
            this.tsss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsss.Location = new System.Drawing.Point(34, 70);
            this.tsss.Name = "tsss";
            this.tsss.Size = new System.Drawing.Size(147, 23);
            this.tsss.TabIndex = 8;
            this.tsss.Text = "Chip Mascota:";
            this.tsss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textNombreVacuna
            // 
            this.textNombreVacuna.Location = new System.Drawing.Point(175, 110);
            this.textNombreVacuna.Name = "textNombreVacuna";
            this.textNombreVacuna.Size = new System.Drawing.Size(117, 20);
            this.textNombreVacuna.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Vacuna:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Día Emisión:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Día Caducidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateEmision
            // 
            this.dateEmision.Location = new System.Drawing.Point(22, 226);
            this.dateEmision.Name = "dateEmision";
            this.dateEmision.Size = new System.Drawing.Size(252, 20);
            this.dateEmision.TabIndex = 14;
            // 
            // datecaducidad
            // 
            this.datecaducidad.Location = new System.Drawing.Point(514, 226);
            this.datecaducidad.Name = "datecaducidad";
            this.datecaducidad.Size = new System.Drawing.Size(252, 20);
            this.datecaducidad.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datecaducidad);
            this.Controls.Add(this.dateEmision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreVacuna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChip);
            this.Controls.Add(this.tsss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistarVacuna";
            this.Text = "Vacunas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChip;
        private System.Windows.Forms.Label tsss;
        private System.Windows.Forms.TextBox textNombreVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEmision;
        private System.Windows.Forms.DateTimePicker datecaducidad;
        private System.Windows.Forms.Button button1;
    }
}