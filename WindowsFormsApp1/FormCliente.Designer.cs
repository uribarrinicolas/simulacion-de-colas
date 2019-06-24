namespace SimulacionesDeCola
{
    partial class FormCliente
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
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.lvl_id = new System.Windows.Forms.Label();
            this.data_id = new System.Windows.Forms.Label();
            this.lvl_t_llegada = new System.Windows.Forms.Label();
            this.lvl_t_atendido = new System.Windows.Forms.Label();
            this.lvl_t_salida = new System.Windows.Forms.Label();
            this.lvl_servidor = new System.Windows.Forms.Label();
            this.data_t_llegada = new System.Windows.Forms.Label();
            this.data_t_atendido = new System.Windows.Forms.Label();
            this.data_t_salir = new System.Windows.Forms.Label();
            this.data_servidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAceptar.Location = new System.Drawing.Point(230, 148);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(88, 32);
            this.BotonAceptar.TabIndex = 0;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // lvl_id
            // 
            this.lvl_id.AutoSize = true;
            this.lvl_id.Location = new System.Drawing.Point(17, 21);
            this.lvl_id.Name = "lvl_id";
            this.lvl_id.Size = new System.Drawing.Size(21, 13);
            this.lvl_id.TabIndex = 1;
            this.lvl_id.Text = "ID:";
            // 
            // data_id
            // 
            this.data_id.AutoSize = true;
            this.data_id.Location = new System.Drawing.Point(44, 21);
            this.data_id.Name = "data_id";
            this.data_id.Size = new System.Drawing.Size(45, 13);
            this.data_id.TabIndex = 2;
            this.data_id.Text = "data_ID";
            // 
            // lvl_t_llegada
            // 
            this.lvl_t_llegada.AutoSize = true;
            this.lvl_t_llegada.Location = new System.Drawing.Point(17, 47);
            this.lvl_t_llegada.Name = "lvl_t_llegada";
            this.lvl_t_llegada.Size = new System.Drawing.Size(97, 13);
            this.lvl_t_llegada.TabIndex = 3;
            this.lvl_t_llegada.Text = "Tiempo de llegada:";
            // 
            // lvl_t_atendido
            // 
            this.lvl_t_atendido.AutoSize = true;
            this.lvl_t_atendido.Location = new System.Drawing.Point(17, 73);
            this.lvl_t_atendido.Name = "lvl_t_atendido";
            this.lvl_t_atendido.Size = new System.Drawing.Size(117, 13);
            this.lvl_t_atendido.TabIndex = 4;
            this.lvl_t_atendido.Text = "Tiempo al ser atendido:";
            // 
            // lvl_t_salida
            // 
            this.lvl_t_salida.AutoSize = true;
            this.lvl_t_salida.Location = new System.Drawing.Point(17, 99);
            this.lvl_t_salida.Name = "lvl_t_salida";
            this.lvl_t_salida.Size = new System.Drawing.Size(77, 13);
            this.lvl_t_salida.TabIndex = 5;
            this.lvl_t_salida.Text = "Tiempo al salir:";
            // 
            // lvl_servidor
            // 
            this.lvl_servidor.AutoSize = true;
            this.lvl_servidor.Location = new System.Drawing.Point(17, 125);
            this.lvl_servidor.Name = "lvl_servidor";
            this.lvl_servidor.Size = new System.Drawing.Size(70, 13);
            this.lvl_servidor.TabIndex = 6;
            this.lvl_servidor.Text = "Atendido por:";
            // 
            // data_t_llegada
            // 
            this.data_t_llegada.AutoSize = true;
            this.data_t_llegada.Location = new System.Drawing.Point(140, 47);
            this.data_t_llegada.Name = "data_t_llegada";
            this.data_t_llegada.Size = new System.Drawing.Size(41, 13);
            this.data_t_llegada.TabIndex = 7;
            this.data_t_llegada.Text = "llegada";
            // 
            // data_t_atendido
            // 
            this.data_t_atendido.AutoSize = true;
            this.data_t_atendido.Location = new System.Drawing.Point(140, 73);
            this.data_t_atendido.Name = "data_t_atendido";
            this.data_t_atendido.Size = new System.Drawing.Size(48, 13);
            this.data_t_atendido.TabIndex = 8;
            this.data_t_atendido.Text = "atendido";
            // 
            // data_t_salir
            // 
            this.data_t_salir.AutoSize = true;
            this.data_t_salir.Location = new System.Drawing.Point(140, 99);
            this.data_t_salir.Name = "data_t_salir";
            this.data_t_salir.Size = new System.Drawing.Size(25, 13);
            this.data_t_salir.TabIndex = 9;
            this.data_t_salir.Text = "salir";
            // 
            // data_servidor
            // 
            this.data_servidor.AutoSize = true;
            this.data_servidor.Location = new System.Drawing.Point(140, 125);
            this.data_servidor.Name = "data_servidor";
            this.data_servidor.Size = new System.Drawing.Size(44, 13);
            this.data_servidor.TabIndex = 10;
            this.data_servidor.Text = "servidor";
            // 
            // FormCliente
            // 
            this.AcceptButton = this.BotonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 192);
            this.Controls.Add(this.data_servidor);
            this.Controls.Add(this.data_t_salir);
            this.Controls.Add(this.data_t_atendido);
            this.Controls.Add(this.data_t_llegada);
            this.Controls.Add(this.lvl_servidor);
            this.Controls.Add(this.lvl_t_salida);
            this.Controls.Add(this.lvl_t_atendido);
            this.Controls.Add(this.lvl_t_llegada);
            this.Controls.Add(this.data_id);
            this.Controls.Add(this.lvl_id);
            this.Controls.Add(this.BotonAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cliente - ";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label lvl_id;
        private System.Windows.Forms.Label data_id;
        private System.Windows.Forms.Label lvl_t_llegada;
        private System.Windows.Forms.Label lvl_t_atendido;
        private System.Windows.Forms.Label lvl_t_salida;
        private System.Windows.Forms.Label lvl_servidor;
        private System.Windows.Forms.Label data_t_llegada;
        private System.Windows.Forms.Label data_t_atendido;
        private System.Windows.Forms.Label data_t_salir;
        private System.Windows.Forms.Label data_servidor;
    }
}