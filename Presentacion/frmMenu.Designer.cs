
namespace Presentacion
{
    partial class frmMenu
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.cmdAddRuta = new System.Windows.Forms.Button();
            this.cmdAddBus = new System.Windows.Forms.Button();
            this.cmdAddChofere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Image = global::Presentacion.Properties.Resources.gnome_application_exit;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(218, 493);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(169, 84);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAsignar.Image = global::Presentacion.Properties.Resources.icons8_bus_driver_64;
            this.cmdAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAsignar.Location = new System.Drawing.Point(186, 364);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(234, 99);
            this.cmdAsignar.TabIndex = 3;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAsignar.UseVisualStyleBackColor = false;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // cmdAddRuta
            // 
            this.cmdAddRuta.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdAddRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddRuta.Image = global::Presentacion.Properties.Resources.icons8_ruta_64;
            this.cmdAddRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddRuta.Location = new System.Drawing.Point(186, 261);
            this.cmdAddRuta.Name = "cmdAddRuta";
            this.cmdAddRuta.Size = new System.Drawing.Size(234, 99);
            this.cmdAddRuta.TabIndex = 2;
            this.cmdAddRuta.Text = "Agregar Ruta";
            this.cmdAddRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddRuta.UseVisualStyleBackColor = false;
            this.cmdAddRuta.Click += new System.EventHandler(this.cmdAddRuta_Click);
            // 
            // cmdAddBus
            // 
            this.cmdAddBus.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdAddBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddBus.Image = global::Presentacion.Properties.Resources.icons8_bus_66;
            this.cmdAddBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddBus.Location = new System.Drawing.Point(186, 161);
            this.cmdAddBus.Name = "cmdAddBus";
            this.cmdAddBus.Size = new System.Drawing.Size(234, 99);
            this.cmdAddBus.TabIndex = 1;
            this.cmdAddBus.Text = "Agregar Autobus";
            this.cmdAddBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddBus.UseVisualStyleBackColor = false;
            this.cmdAddBus.Click += new System.EventHandler(this.cmdAddBus_Click);
            // 
            // cmdAddChofere
            // 
            this.cmdAddChofere.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdAddChofere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddChofere.Image = global::Presentacion.Properties.Resources.icons8_driver_64;
            this.cmdAddChofere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddChofere.Location = new System.Drawing.Point(186, 59);
            this.cmdAddChofere.Name = "cmdAddChofere";
            this.cmdAddChofere.Size = new System.Drawing.Size(234, 99);
            this.cmdAddChofere.TabIndex = 0;
            this.cmdAddChofere.Text = "Agregar Choferes";
            this.cmdAddChofere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddChofere.UseVisualStyleBackColor = false;
            this.cmdAddChofere.Click += new System.EventHandler(this.cmdAddChofere_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(608, 637);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.cmdAddRuta);
            this.Controls.Add(this.cmdAddBus);
            this.Controls.Add(this.cmdAddChofere);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAddChofere;
        private System.Windows.Forms.Button cmdAddBus;
        private System.Windows.Forms.Button cmdAddRuta;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.Button cmdSalir;
    }
}

