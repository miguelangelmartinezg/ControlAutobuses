namespace Presentacion
{
    partial class frmAutobuses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lPlaca = new System.Windows.Forms.Label();
            this.lyear = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grdBuses = new System.Windows.Forms.DataGridView();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cboModelos = new System.Windows.Forms.ComboBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdBus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autobuses\r\n";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(349, 94);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 17);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Marca";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(398, 176);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(111, 22);
            this.txtPlaca.TabIndex = 4;
            // 
            // lPlaca
            // 
            this.lPlaca.AutoSize = true;
            this.lPlaca.Location = new System.Drawing.Point(353, 179);
            this.lPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlaca.Name = "lPlaca";
            this.lPlaca.Size = new System.Drawing.Size(43, 17);
            this.lPlaca.TabIndex = 3;
            this.lPlaca.Text = "Placa";
            // 
            // lyear
            // 
            this.lyear.AutoSize = true;
            this.lyear.Location = new System.Drawing.Point(622, 147);
            this.lyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lyear.Name = "lyear";
            this.lyear.Size = new System.Drawing.Size(33, 17);
            this.lyear.TabIndex = 8;
            this.lyear.Text = "Año";
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.Location = new System.Drawing.Point(358, 147);
            this.lColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(41, 17);
            this.lColor.TabIndex = 11;
            this.lColor.Text = "Color";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(343, 121);
            this.lModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(54, 17);
            this.lModelo.TabIndex = 9;
            this.lModelo.Text = "Modelo";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(657, 43);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 50);
            this.button6.TabIndex = 17;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(4, 41);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 50);
            this.button5.TabIndex = 18;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // grdBuses
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marca,
            this.modelo,
            this.placa,
            this.color,
            this.ano,
            this.idbus,
            this.idmarca,
            this.idmodelo,
            this.idcolor,
            this.idano});
            this.grdBuses.Location = new System.Drawing.Point(24, 205);
            this.grdBuses.Name = "grdBuses";
            this.grdBuses.RowHeadersVisible = false;
            this.grdBuses.RowHeadersWidth = 51;
            this.grdBuses.RowTemplate.Height = 24;
            this.grdBuses.Size = new System.Drawing.Size(1017, 387);
            this.grdBuses.TabIndex = 36;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Image = global::Presentacion.Properties.Resources.cancel1;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(653, 613);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(106, 47);
            this.cmdCancelar.TabIndex = 35;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Image = global::Presentacion.Properties.Resources.SalirRojo;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(765, 613);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(106, 47);
            this.cmdSalir.TabIndex = 34;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBorrar.Image = global::Presentacion.Properties.Resources.delete;
            this.cmdBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBorrar.Location = new System.Drawing.Point(541, 613);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(106, 47);
            this.cmdBorrar.TabIndex = 33;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditar.Image = global::Presentacion.Properties.Resources.save;
            this.cmdEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEditar.Location = new System.Drawing.Point(429, 613);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(106, 47);
            this.cmdEditar.TabIndex = 32;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEditar.UseVisualStyleBackColor = true;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGrabar.Image = global::Presentacion.Properties.Resources.save2;
            this.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGrabar.Location = new System.Drawing.Point(317, 613);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(106, 47);
            this.cmdGrabar.TabIndex = 31;
            this.cmdGrabar.Text = "Guardar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Image = global::Presentacion.Properties.Resources._new;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(205, 613);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(106, 47);
            this.cmdNuevo.TabIndex = 30;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cboModelos
            // 
            this.cboModelos.FormattingEnabled = true;
            this.cboModelos.Location = new System.Drawing.Point(398, 118);
            this.cboModelos.Name = "cboModelos";
            this.cboModelos.Size = new System.Drawing.Size(348, 24);
            this.cboModelos.TabIndex = 38;
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(398, 91);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(348, 24);
            this.cboMarcas.TabIndex = 37;
            this.cboMarcas.SelectedIndexChanged += new System.EventHandler(this.cboMarcas_SelectedIndexChanged);
            this.cboMarcas.DropDownClosed += new System.EventHandler(this.cboMarcas_DropDownClosed);
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(653, 144);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(93, 24);
            this.cboAno.TabIndex = 41;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(398, 145);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(214, 24);
            this.cboColor.TabIndex = 39;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 225;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.MinimumWidth = 6;
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 200;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.MinimumWidth = 6;
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Width = 125;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 125;
            // 
            // ano
            // 
            this.ano.HeaderText = "Año";
            this.ano.MinimumWidth = 6;
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            this.ano.Width = 75;
            // 
            // idbus
            // 
            this.idbus.HeaderText = "IdBus";
            this.idbus.MinimumWidth = 6;
            this.idbus.Name = "idbus";
            this.idbus.Visible = false;
            this.idbus.Width = 125;
            // 
            // idmarca
            // 
            this.idmarca.HeaderText = "IdMarca";
            this.idmarca.MinimumWidth = 6;
            this.idmarca.Name = "idmarca";
            this.idmarca.Visible = false;
            this.idmarca.Width = 125;
            // 
            // idmodelo
            // 
            this.idmodelo.HeaderText = "IdModelo";
            this.idmodelo.MinimumWidth = 6;
            this.idmodelo.Name = "idmodelo";
            this.idmodelo.Visible = false;
            this.idmodelo.Width = 125;
            // 
            // idcolor
            // 
            this.idcolor.HeaderText = "IdColor";
            this.idcolor.MinimumWidth = 6;
            this.idcolor.Name = "idcolor";
            this.idcolor.Visible = false;
            this.idcolor.Width = 125;
            // 
            // idano
            // 
            this.idano.HeaderText = "IdAno";
            this.idano.MinimumWidth = 6;
            this.idano.Name = "idano";
            this.idano.Visible = false;
            this.idano.Width = 125;
            // 
            // txtIdBus
            // 
            this.txtIdBus.Enabled = false;
            this.txtIdBus.Location = new System.Drawing.Point(398, 67);
            this.txtIdBus.Name = "txtIdBus";
            this.txtIdBus.ReadOnly = true;
            this.txtIdBus.Size = new System.Drawing.Size(100, 22);
            this.txtIdBus.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Id Bus";
            // 
            // frmAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1053, 672);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdBus);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.cboModelos);
            this.Controls.Add(this.cboMarcas);
            this.Controls.Add(this.grdBuses);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lyear);
            this.Controls.Add(this.lPlaca);
            this.Controls.Add(this.lNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAutobuses";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmAutobuses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lPlaca;
        private System.Windows.Forms.Label lyear;
        private System.Windows.Forms.Label lColor;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView grdBuses;
        private System.Windows.Forms.ComboBox cboModelos;
        private System.Windows.Forms.ComboBox cboMarcas;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idano;
        private System.Windows.Forms.TextBox txtIdBus;
        private System.Windows.Forms.Label label9;
    }
}

