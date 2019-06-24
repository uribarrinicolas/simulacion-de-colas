namespace SimulacionesDeCola
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.dataViewFrecuencias = new System.Windows.Forms.DataGridView();
            this.LlegadasDataSet = new System.Data.DataSet();
            this.lvl_unidad_tiempo = new System.Windows.Forms.Label();
            this.ConfiguracionesDataSet = new System.Data.DataSet();
            this.data_unidad_tiempo = new System.Windows.Forms.Label();
            this.BotonGuardarFrecuencias = new System.Windows.Forms.Button();
            this.BotonRecargarFrecuencias = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_servidor_tasa2 = new System.Windows.Forms.TextBox();
            this.data_tasa_servicio = new System.Windows.Forms.Label();
            this.lvl_tasa_servicio = new System.Windows.Forms.Label();
            this.data_servidor_id = new System.Windows.Forms.TextBox();
            this.lvl_servidor_id = new System.Windows.Forms.Label();
            this.bindingNavigatorServidores = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCargar = new System.Windows.Forms.ToolStripButton();
            this.lvl_tipo_servicio = new System.Windows.Forms.Label();
            this.data_tipo_servicio = new System.Windows.Forms.Label();
            this.ServidoresDataSet = new System.Data.DataSet();
            this.BotonGuardarServidores = new System.Windows.Forms.Button();
            this.data_tipo_cliente = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BotonSimular = new System.Windows.Forms.Button();
            this.data_sim_preview = new System.Windows.Forms.ListView();
            this.data_velocidad_simulacion = new System.Windows.Forms.TextBox();
            this.lvl_velocidad_simulacion = new System.Windows.Forms.Label();
            this.data_tiempo_desde = new System.Windows.Forms.TextBox();
            this.lvl_tiempo_simulado = new System.Windows.Forms.Label();
            this.lvl_tiempo_actual = new System.Windows.Forms.Label();
            this.data_tiempo_actual = new System.Windows.Forms.Label();
            this.BotonResultados = new System.Windows.Forms.Button();
            this.data_tiempo_hasta = new System.Windows.Forms.TextBox();
            this.data_step = new System.Windows.Forms.TextBox();
            this.lvl_step = new System.Windows.Forms.Label();
            this.TimerDeSimulacion = new System.Windows.Forms.Timer(this.components);
            this.BotonFast = new System.Windows.Forms.Button();
            this.CheckPreview = new System.Windows.Forms.CheckBox();
            this.data_nombre_simulacion = new System.Windows.Forms.TextBox();
            this.lvl_nombre_simulacion = new System.Windows.Forms.Label();
            this.bsConfig = new System.Windows.Forms.BindingSource(this.components);
            this.bsServidores = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlegadasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfiguracionesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorServidores)).BeginInit();
            this.bindingNavigatorServidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServidoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServidores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewFrecuencias
            // 
            this.dataViewFrecuencias.AllowUserToResizeRows = false;
            this.dataViewFrecuencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewFrecuencias.Location = new System.Drawing.Point(12, 44);
            this.dataViewFrecuencias.Name = "dataViewFrecuencias";
            this.dataViewFrecuencias.Size = new System.Drawing.Size(418, 336);
            this.dataViewFrecuencias.TabIndex = 0;
            // 
            // LlegadasDataSet
            // 
            this.LlegadasDataSet.DataSetName = "LlegadasDataSet";
            // 
            // lvl_unidad_tiempo
            // 
            this.lvl_unidad_tiempo.AutoSize = true;
            this.lvl_unidad_tiempo.Location = new System.Drawing.Point(9, 28);
            this.lvl_unidad_tiempo.Name = "lvl_unidad_tiempo";
            this.lvl_unidad_tiempo.Size = new System.Drawing.Size(93, 13);
            this.lvl_unidad_tiempo.TabIndex = 4;
            this.lvl_unidad_tiempo.Text = "Unidad de tiempo:";
            // 
            // ConfiguracionesDataSet
            // 
            this.ConfiguracionesDataSet.DataSetName = "ConfiguracionesDataSet";
            // 
            // data_unidad_tiempo
            // 
            this.data_unidad_tiempo.AutoSize = true;
            this.data_unidad_tiempo.Location = new System.Drawing.Point(109, 28);
            this.data_unidad_tiempo.Name = "data_unidad_tiempo";
            this.data_unidad_tiempo.Size = new System.Drawing.Size(76, 13);
            this.data_unidad_tiempo.TabIndex = 5;
            this.data_unidad_tiempo.Text = "unidad_tiempo";
            // 
            // BotonGuardarFrecuencias
            // 
            this.BotonGuardarFrecuencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonGuardarFrecuencias.Location = new System.Drawing.Point(308, 2);
            this.BotonGuardarFrecuencias.Name = "BotonGuardarFrecuencias";
            this.BotonGuardarFrecuencias.Size = new System.Drawing.Size(57, 23);
            this.BotonGuardarFrecuencias.TabIndex = 6;
            this.BotonGuardarFrecuencias.Text = "Guardar";
            this.BotonGuardarFrecuencias.UseVisualStyleBackColor = true;
            this.BotonGuardarFrecuencias.Click += new System.EventHandler(this.BotonGuardarFrecuencias_Click);
            // 
            // BotonRecargarFrecuencias
            // 
            this.BotonRecargarFrecuencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonRecargarFrecuencias.Location = new System.Drawing.Point(371, 2);
            this.BotonRecargarFrecuencias.Name = "BotonRecargarFrecuencias";
            this.BotonRecargarFrecuencias.Size = new System.Drawing.Size(59, 23);
            this.BotonRecargarFrecuencias.TabIndex = 7;
            this.BotonRecargarFrecuencias.Text = "Recargar";
            this.BotonRecargarFrecuencias.UseVisualStyleBackColor = true;
            this.BotonRecargarFrecuencias.Click += new System.EventHandler(this.BotonRecargarFrecuencias_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.data_servidor_tasa2);
            this.panel1.Controls.Add(this.data_tasa_servicio);
            this.panel1.Controls.Add(this.lvl_tasa_servicio);
            this.panel1.Controls.Add(this.data_servidor_id);
            this.panel1.Controls.Add(this.lvl_servidor_id);
            this.panel1.Controls.Add(this.bindingNavigatorServidores);
            this.panel1.Location = new System.Drawing.Point(17, 44);
            this.panel1.MinimumSize = new System.Drawing.Size(229, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 115);
            this.panel1.TabIndex = 9;
            // 
            // data_servidor_tasa2
            // 
            this.data_servidor_tasa2.Location = new System.Drawing.Point(107, 59);
            this.data_servidor_tasa2.Name = "data_servidor_tasa2";
            this.data_servidor_tasa2.Size = new System.Drawing.Size(61, 20);
            this.data_servidor_tasa2.TabIndex = 6;
            // 
            // data_tasa_servicio
            // 
            this.data_tasa_servicio.AutoSize = true;
            this.data_tasa_servicio.Location = new System.Drawing.Point(174, 62);
            this.data_tasa_servicio.Name = "data_tasa_servicio";
            this.data_tasa_servicio.Size = new System.Drawing.Size(141, 13);
            this.data_tasa_servicio.TabIndex = 5;
            this.data_tasa_servicio.Text = "tipo_cliente / unidad_tiempo";
            // 
            // lvl_tasa_servicio
            // 
            this.lvl_tasa_servicio.AutoSize = true;
            this.lvl_tasa_servicio.Location = new System.Drawing.Point(13, 62);
            this.lvl_tasa_servicio.Name = "lvl_tasa_servicio";
            this.lvl_tasa_servicio.Size = new System.Drawing.Size(88, 13);
            this.lvl_tasa_servicio.TabIndex = 4;
            this.lvl_tasa_servicio.Text = "Tasa de servicio:";
            // 
            // data_servidor_id
            // 
            this.data_servidor_id.Location = new System.Drawing.Point(43, 34);
            this.data_servidor_id.Name = "data_servidor_id";
            this.data_servidor_id.Size = new System.Drawing.Size(159, 20);
            this.data_servidor_id.TabIndex = 3;
            // 
            // lvl_servidor_id
            // 
            this.lvl_servidor_id.AutoSize = true;
            this.lvl_servidor_id.Location = new System.Drawing.Point(13, 37);
            this.lvl_servidor_id.Name = "lvl_servidor_id";
            this.lvl_servidor_id.Size = new System.Drawing.Size(24, 13);
            this.lvl_servidor_id.TabIndex = 1;
            this.lvl_servidor_id.Text = "ID: ";
            // 
            // bindingNavigatorServidores
            // 
            this.bindingNavigatorServidores.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorServidores.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorServidores.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorServidores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonCargar});
            this.bindingNavigatorServidores.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorServidores.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorServidores.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorServidores.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorServidores.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorServidores.Name = "bindingNavigatorServidores";
            this.bindingNavigatorServidores.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorServidores.Size = new System.Drawing.Size(364, 25);
            this.bindingNavigatorServidores.TabIndex = 0;
            this.bindingNavigatorServidores.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCargar
            // 
            this.toolStripButtonCargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCargar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCargar.Image")));
            this.toolStripButtonCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCargar.Name = "toolStripButtonCargar";
            this.toolStripButtonCargar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCargar.Text = "Recargar";
            this.toolStripButtonCargar.Click += new System.EventHandler(this.BotonCargarServidores_Click);
            // 
            // lvl_tipo_servicio
            // 
            this.lvl_tipo_servicio.AutoSize = true;
            this.lvl_tipo_servicio.Location = new System.Drawing.Point(14, 28);
            this.lvl_tipo_servicio.Name = "lvl_tipo_servicio";
            this.lvl_tipo_servicio.Size = new System.Drawing.Size(85, 13);
            this.lvl_tipo_servicio.TabIndex = 10;
            this.lvl_tipo_servicio.Text = "Tipo de servicio:";
            // 
            // data_tipo_servicio
            // 
            this.data_tipo_servicio.AutoSize = true;
            this.data_tipo_servicio.Location = new System.Drawing.Point(105, 28);
            this.data_tipo_servicio.Name = "data_tipo_servicio";
            this.data_tipo_servicio.Size = new System.Drawing.Size(66, 13);
            this.data_tipo_servicio.TabIndex = 11;
            this.data_tipo_servicio.Text = "tipo_servicio";
            // 
            // ServidoresDataSet
            // 
            this.ServidoresDataSet.DataSetName = "ServidoresDataSet";
            // 
            // BotonGuardarServidores
            // 
            this.BotonGuardarServidores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonGuardarServidores.Location = new System.Drawing.Point(306, 12);
            this.BotonGuardarServidores.Name = "BotonGuardarServidores";
            this.BotonGuardarServidores.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardarServidores.TabIndex = 12;
            this.BotonGuardarServidores.Text = "Guardar";
            this.BotonGuardarServidores.UseVisualStyleBackColor = true;
            this.BotonGuardarServidores.Click += new System.EventHandler(this.BotonGuardarServidores_Click);
            // 
            // data_tipo_cliente
            // 
            this.data_tipo_cliente.AutoSize = true;
            this.data_tipo_cliente.Location = new System.Drawing.Point(109, 15);
            this.data_tipo_cliente.Name = "data_tipo_cliente";
            this.data_tipo_cliente.Size = new System.Drawing.Size(61, 13);
            this.data_tipo_cliente.TabIndex = 13;
            this.data_tipo_cliente.Text = "tipo_cliente";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvl_nombre_simulacion);
            this.splitContainer1.Panel1.Controls.Add(this.data_nombre_simulacion);
            this.splitContainer1.Panel1.Controls.Add(this.CheckPreview);
            this.splitContainer1.Panel1.Controls.Add(this.BotonResultados);
            this.splitContainer1.Panel1.Controls.Add(this.data_tiempo_actual);
            this.splitContainer1.Panel1.Controls.Add(this.lvl_tiempo_actual);
            this.splitContainer1.Panel1.Controls.Add(this.data_sim_preview);
            this.splitContainer1.Panel1.Controls.Add(this.BotonGuardarServidores);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.data_tipo_servicio);
            this.splitContainer1.Panel1.Controls.Add(this.lvl_tipo_servicio);
            this.splitContainer1.Panel1MinSize = 249;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataViewFrecuencias);
            this.splitContainer1.Panel2.Controls.Add(this.data_tipo_cliente);
            this.splitContainer1.Panel2.Controls.Add(this.lvl_unidad_tiempo);
            this.splitContainer1.Panel2.Controls.Add(this.data_unidad_tiempo);
            this.splitContainer1.Panel2.Controls.Add(this.BotonGuardarFrecuencias);
            this.splitContainer1.Panel2.Controls.Add(this.BotonRecargarFrecuencias);
            this.splitContainer1.Size = new System.Drawing.Size(838, 390);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BotonFast);
            this.splitContainer2.Panel2.Controls.Add(this.lvl_step);
            this.splitContainer2.Panel2.Controls.Add(this.data_step);
            this.splitContainer2.Panel2.Controls.Add(this.data_tiempo_hasta);
            this.splitContainer2.Panel2.Controls.Add(this.lvl_tiempo_simulado);
            this.splitContainer2.Panel2.Controls.Add(this.data_tiempo_desde);
            this.splitContainer2.Panel2.Controls.Add(this.lvl_velocidad_simulacion);
            this.splitContainer2.Panel2.Controls.Add(this.data_velocidad_simulacion);
            this.splitContainer2.Panel2.Controls.Add(this.BotonSimular);
            this.splitContainer2.Size = new System.Drawing.Size(838, 447);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.TabIndex = 15;
            // 
            // BotonSimular
            // 
            this.BotonSimular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSimular.Location = new System.Drawing.Point(506, 2);
            this.BotonSimular.MinimumSize = new System.Drawing.Size(0, 48);
            this.BotonSimular.Name = "BotonSimular";
            this.BotonSimular.Size = new System.Drawing.Size(329, 48);
            this.BotonSimular.TabIndex = 0;
            this.BotonSimular.Text = "Simular";
            this.BotonSimular.UseVisualStyleBackColor = true;
            this.BotonSimular.Click += new System.EventHandler(this.BotonSimular_Click);
            // 
            // data_sim_preview
            // 
            this.data_sim_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_sim_preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_sim_preview.Location = new System.Drawing.Point(17, 165);
            this.data_sim_preview.MultiSelect = false;
            this.data_sim_preview.Name = "data_sim_preview";
            this.data_sim_preview.Size = new System.Drawing.Size(364, 165);
            this.data_sim_preview.TabIndex = 13;
            this.data_sim_preview.UseCompatibleStateImageBehavior = false;
            this.data_sim_preview.SelectedIndexChanged += new System.EventHandler(this.data_sim_preview_SelectedIndexChanged);
            // 
            // data_velocidad_simulacion
            // 
            this.data_velocidad_simulacion.Location = new System.Drawing.Point(124, 21);
            this.data_velocidad_simulacion.Name = "data_velocidad_simulacion";
            this.data_velocidad_simulacion.Size = new System.Drawing.Size(100, 20);
            this.data_velocidad_simulacion.TabIndex = 1;
            this.data_velocidad_simulacion.Text = "0,1";
            this.data_velocidad_simulacion.TextChanged += new System.EventHandler(this.data_velocidad_simulacion_TextChanged);
            // 
            // lvl_velocidad_simulacion
            // 
            this.lvl_velocidad_simulacion.AutoSize = true;
            this.lvl_velocidad_simulacion.Location = new System.Drawing.Point(9, 5);
            this.lvl_velocidad_simulacion.Name = "lvl_velocidad_simulacion";
            this.lvl_velocidad_simulacion.Size = new System.Drawing.Size(109, 39);
            this.lvl_velocidad_simulacion.TabIndex = 2;
            this.lvl_velocidad_simulacion.Text = "Velocidad simulacion:\r\n(segundos por unidad\r\nde tiempo simulada)";
            // 
            // data_tiempo_desde
            // 
            this.data_tiempo_desde.Location = new System.Drawing.Point(326, 5);
            this.data_tiempo_desde.Name = "data_tiempo_desde";
            this.data_tiempo_desde.Size = new System.Drawing.Size(100, 20);
            this.data_tiempo_desde.TabIndex = 3;
            this.data_tiempo_desde.Text = "0";
            // 
            // lvl_tiempo_simulado
            // 
            this.lvl_tiempo_simulado.AutoSize = true;
            this.lvl_tiempo_simulado.Location = new System.Drawing.Point(230, 5);
            this.lvl_tiempo_simulado.Name = "lvl_tiempo_simulado";
            this.lvl_tiempo_simulado.Size = new System.Drawing.Size(89, 39);
            this.lvl_tiempo_simulado.TabIndex = 4;
            this.lvl_tiempo_simulado.Text = "Tiempo simulado:\r\nDesde\r\nHasta";
            // 
            // lvl_tiempo_actual
            // 
            this.lvl_tiempo_actual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvl_tiempo_actual.AutoSize = true;
            this.lvl_tiempo_actual.Location = new System.Drawing.Point(19, 370);
            this.lvl_tiempo_actual.Name = "lvl_tiempo_actual";
            this.lvl_tiempo_actual.Size = new System.Drawing.Size(77, 13);
            this.lvl_tiempo_actual.TabIndex = 14;
            this.lvl_tiempo_actual.Text = "Tiempo actual:";
            // 
            // data_tiempo_actual
            // 
            this.data_tiempo_actual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.data_tiempo_actual.AutoSize = true;
            this.data_tiempo_actual.Location = new System.Drawing.Point(102, 370);
            this.data_tiempo_actual.Name = "data_tiempo_actual";
            this.data_tiempo_actual.Size = new System.Drawing.Size(13, 13);
            this.data_tiempo_actual.TabIndex = 15;
            this.data_tiempo_actual.Text = "0";
            // 
            // BotonResultados
            // 
            this.BotonResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonResultados.Location = new System.Drawing.Point(306, 360);
            this.BotonResultados.Name = "BotonResultados";
            this.BotonResultados.Size = new System.Drawing.Size(75, 23);
            this.BotonResultados.TabIndex = 16;
            this.BotonResultados.Text = "Resultados";
            this.BotonResultados.UseVisualStyleBackColor = true;
            this.BotonResultados.Click += new System.EventHandler(this.BotonResultados_Click);
            // 
            // data_tiempo_hasta
            // 
            this.data_tiempo_hasta.Location = new System.Drawing.Point(326, 26);
            this.data_tiempo_hasta.Name = "data_tiempo_hasta";
            this.data_tiempo_hasta.Size = new System.Drawing.Size(100, 20);
            this.data_tiempo_hasta.TabIndex = 5;
            this.data_tiempo_hasta.Text = "2000";
            // 
            // data_step
            // 
            this.data_step.Location = new System.Drawing.Point(432, 19);
            this.data_step.Name = "data_step";
            this.data_step.Size = new System.Drawing.Size(24, 20);
            this.data_step.TabIndex = 6;
            this.data_step.Text = "1";
            // 
            // lvl_step
            // 
            this.lvl_step.AutoSize = true;
            this.lvl_step.Location = new System.Drawing.Point(429, 5);
            this.lvl_step.Name = "lvl_step";
            this.lvl_step.Size = new System.Drawing.Size(29, 13);
            this.lvl_step.TabIndex = 7;
            this.lvl_step.Text = "Step";
            // 
            // TimerDeSimulacion
            // 
            this.TimerDeSimulacion.Tick += new System.EventHandler(this.TimerDeSimulacion_Tick);
            // 
            // BotonFast
            // 
            this.BotonFast.Location = new System.Drawing.Point(462, 26);
            this.BotonFast.Name = "BotonFast";
            this.BotonFast.Size = new System.Drawing.Size(38, 23);
            this.BotonFast.TabIndex = 8;
            this.BotonFast.Text = "Fast";
            this.BotonFast.UseVisualStyleBackColor = true;
            this.BotonFast.Click += new System.EventHandler(this.BotonFast_Click);
            // 
            // CheckPreview
            // 
            this.CheckPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckPreview.AutoSize = true;
            this.CheckPreview.Checked = true;
            this.CheckPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPreview.Location = new System.Drawing.Point(229, 364);
            this.CheckPreview.Name = "CheckPreview";
            this.CheckPreview.Size = new System.Drawing.Size(71, 17);
            this.CheckPreview.TabIndex = 17;
            this.CheckPreview.Text = "Preliminar";
            this.CheckPreview.UseVisualStyleBackColor = true;
            // 
            // data_nombre_simulacion
            // 
            this.data_nombre_simulacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_nombre_simulacion.Location = new System.Drawing.Point(161, 334);
            this.data_nombre_simulacion.Name = "data_nombre_simulacion";
            this.data_nombre_simulacion.Size = new System.Drawing.Size(220, 20);
            this.data_nombre_simulacion.TabIndex = 18;
            // 
            // lvl_nombre_simulacion
            // 
            this.lvl_nombre_simulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvl_nombre_simulacion.AutoSize = true;
            this.lvl_nombre_simulacion.Location = new System.Drawing.Point(19, 337);
            this.lvl_nombre_simulacion.Name = "lvl_nombre_simulacion";
            this.lvl_nombre_simulacion.Size = new System.Drawing.Size(136, 26);
            this.lvl_nombre_simulacion.TabIndex = 19;
            this.lvl_nombre_simulacion.Text = "Nombre de la simulacion:\r\n(identificador de resultados)";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.splitContainer2);
            this.MinimumSize = new System.Drawing.Size(410, 265);
            this.Name = "FormPrincipal";
            this.Text = "Simulacion de colas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlegadasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfiguracionesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorServidores)).EndInit();
            this.bindingNavigatorServidores.ResumeLayout(false);
            this.bindingNavigatorServidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServidoresDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServidores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewFrecuencias;
        private System.Data.DataSet LlegadasDataSet;
        private System.Windows.Forms.Label lvl_unidad_tiempo;
        private System.Data.DataSet ConfiguracionesDataSet;
        private System.Windows.Forms.Label data_unidad_tiempo;
        private System.Windows.Forms.BindingSource bsConfig;
        private System.Windows.Forms.Button BotonGuardarFrecuencias;
        private System.Windows.Forms.Button BotonRecargarFrecuencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorServidores;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lvl_servidor_id;
        private System.Windows.Forms.Label lvl_tipo_servicio;
        private System.Windows.Forms.Label data_tipo_servicio;
        private System.Windows.Forms.BindingSource bsServidores;
        private System.Data.DataSet ServidoresDataSet;
        private System.Windows.Forms.TextBox data_servidor_id;
        private System.Windows.Forms.ToolStripButton toolStripButtonCargar;
        private System.Windows.Forms.Button BotonGuardarServidores;
        private System.Windows.Forms.Label data_tasa_servicio;
        private System.Windows.Forms.Label lvl_tasa_servicio;
        private System.Windows.Forms.Label data_tipo_cliente;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BotonSimular;
        private System.Windows.Forms.TextBox data_servidor_tasa2;
        private System.Windows.Forms.ListView data_sim_preview;
        private System.Windows.Forms.Label lvl_velocidad_simulacion;
        private System.Windows.Forms.TextBox data_velocidad_simulacion;
        private System.Windows.Forms.Label lvl_tiempo_simulado;
        private System.Windows.Forms.TextBox data_tiempo_desde;
        private System.Windows.Forms.Button BotonResultados;
        private System.Windows.Forms.Label data_tiempo_actual;
        private System.Windows.Forms.Label lvl_tiempo_actual;
        private System.Windows.Forms.TextBox data_tiempo_hasta;
        private System.Windows.Forms.Label lvl_step;
        private System.Windows.Forms.TextBox data_step;
        private System.Windows.Forms.Timer TimerDeSimulacion;
        private System.Windows.Forms.Button BotonFast;
        private System.Windows.Forms.CheckBox CheckPreview;
        private System.Windows.Forms.Label lvl_nombre_simulacion;
        private System.Windows.Forms.TextBox data_nombre_simulacion;
    }
}

