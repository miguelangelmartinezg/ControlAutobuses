
namespace Presentacion
{
    partial class frmAsignarRuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboChoferes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBuses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRutas = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.txtIdAsignacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasignada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idasignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idchofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChoferes
            // 
            this.cboChoferes.FormattingEnabled = true;
            this.cboChoferes.Location = new System.Drawing.Point(465, 64);
            this.cboChoferes.Name = "cboChoferes";
            this.cboChoferes.Size = new System.Drawing.Size(348, 24);
            this.cboChoferes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chofer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "AutoBus";
            // 
            // cboBuses
            // 
            this.cboBuses.FormattingEnabled = true;
            this.cboBuses.Location = new System.Drawing.Point(465, 94);
            this.cboBuses.Name = "cboBuses";
            this.cboBuses.Size = new System.Drawing.Size(348, 24);
            this.cboBuses.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ruta";
            // 
            // cboRutas
            // 
            this.cboRutas.FormattingEnabled = true;
            this.cboRutas.Location = new System.Drawing.Point(465, 124);
            this.cboRutas.Name = "cboRutas";
            this.cboRutas.Size = new System.Drawing.Size(348, 24);
            this.cboRutas.TabIndex = 4;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Image = global::Presentacion.Properties.Resources.cancel1;
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Location = new System.Drawing.Point(790, 542);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(130, 73);
            this.cmdCancelar.TabIndex = 41;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Image = global::Presentacion.Properties.Resources.SalirRojo;
            this.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Location = new System.Drawing.Point(926, 542);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(130, 73);
            this.cmdSalir.TabIndex = 40;
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
            this.cmdBorrar.Location = new System.Drawing.Point(654, 542);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(130, 73);
            this.cmdBorrar.TabIndex = 39;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // cmdEditar
            // 
            this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditar.Image = global::Presentacion.Properties.Resources.save;
            this.cmdEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEditar.Location = new System.Drawing.Point(518, 542);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(130, 73);
            this.cmdEditar.TabIndex = 38;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEditar.UseVisualStyleBackColor = true;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevo.Image = global::Presentacion.Properties.Resources.icons8_bus_64;
            this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Location = new System.Drawing.Point(245, 541);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(130, 73);
            this.cmdNuevo.TabIndex = 37;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAsignar.Image = global::Presentacion.Properties.Resources.icons8_bus_driver_64;
            this.cmdAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAsignar.Location = new System.Drawing.Point(382, 542);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(130, 73);
            this.cmdAsignar.TabIndex = 36;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // grdDatos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chofer,
            this.bus,
            this.ruta,
            this.lasignada,
            this.idasignacion,
            this.idchofer,
            this.idbus,
            this.idruta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.Location = new System.Drawing.Point(34, 168);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.RowHeadersWidth = 51;
            this.grdDatos.RowTemplate.Height = 24;
            this.grdDatos.Size = new System.Drawing.Size(1146, 368);
            this.grdDatos.TabIndex = 42;
            // 
            // txtIdAsignacion
            // 
            this.txtIdAsignacion.Enabled = false;
            this.txtIdAsignacion.Location = new System.Drawing.Point(465, 38);
            this.txtIdAsignacion.Name = "txtIdAsignacion";
            this.txtIdAsignacion.ReadOnly = true;
            this.txtIdAsignacion.Size = new System.Drawing.Size(100, 22);
            this.txtIdAsignacion.TabIndex = 43;
            this.txtIdAsignacion.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Id Asignacion";
            this.label9.Visible = false;
            // 
            // chofer
            // 
            this.chofer.HeaderText = "Chofer";
            this.chofer.MinimumWidth = 6;
            this.chofer.Name = "chofer";
            this.chofer.ReadOnly = true;
            this.chofer.Width = 250;
            // 
            // bus
            // 
            this.bus.HeaderText = "Auto Bus";
            this.bus.MinimumWidth = 6;
            this.bus.Name = "bus";
            this.bus.ReadOnly = true;
            this.bus.Width = 300;
            // 
            // ruta
            // 
            this.ruta.HeaderText = "Ruta";
            this.ruta.MinimumWidth = 6;
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            this.ruta.Width = 200;
            // 
            // lasignada
            // 
            this.lasignada.HeaderText = "Asignada";
            this.lasignada.MinimumWidth = 6;
            this.lasignada.Name = "lasignada";
            // 
            // idasignacion
            // 
            this.idasignacion.HeaderText = "IdAsignacion";
            this.idasignacion.MinimumWidth = 6;
            this.idasignacion.Name = "idasignacion";
            this.idasignacion.Visible = false;
            this.idasignacion.Width = 125;
            // 
            // idchofer
            // 
            this.idchofer.HeaderText = "IdChofer";
            this.idchofer.MinimumWidth = 6;
            this.idchofer.Name = "idchofer";
            this.idchofer.Visible = false;
            this.idchofer.Width = 125;
            // 
            // idbus
            // 
            this.idbus.HeaderText = "IdBus";
            this.idbus.MinimumWidth = 6;
            this.idbus.Name = "idbus";
            this.idbus.Visible = false;
            this.idbus.Width = 125;
            // 
            // idruta
            // 
            this.idruta.HeaderText = "IdRuta";
            this.idruta.MinimumWidth = 6;
            this.idruta.Name = "idruta";
            this.idruta.Visible = false;
            this.idruta.Width = 125;
            // 
            // frmAsignarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1215, 641);
            this.Controls.Add(this.txtIdAsignacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRutas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBuses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChoferes);
            this.Name = "frmAsignarRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsignarRuta";
            this.Load += new System.EventHandler(this.frmAsignarRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChoferes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBuses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRutas;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.TextBox txtIdAsignacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lasignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idasignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idchofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruta;
    }
}