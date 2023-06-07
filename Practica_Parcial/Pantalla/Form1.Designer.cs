namespace Pantalla
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.comboBoxLibroPrestamo = new System.Windows.Forms.ComboBox();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lbl5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoLibro = new System.Windows.Forms.Label();
            this.comboBoxLibro = new System.Windows.Forms.ComboBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDato4 = new System.Windows.Forms.Label();
            this.lblDato5 = new System.Windows.Forms.Label();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Clientes",
            "Libros Disponibles",
            "Prestamos"});
            this.comboBoxTipo.Location = new System.Drawing.Point(70, 20);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 1;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLibro);
            this.groupBox1.Controls.Add(this.comboBoxLibroPrestamo);
            this.groupBox1.Controls.Add(this.lblFechaDevolucion);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.groupBox1.Controls.Add(this.lblFechaPrestamo);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaPrestamo);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTipoLibro);
            this.groupBox1.Controls.Add(this.comboBoxLibro);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Location = new System.Drawing.Point(260, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(20, 190);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(33, 13);
            this.lblLibro.TabIndex = 20;
            this.lblLibro.Text = "Libro:";
            // 
            // comboBoxLibroPrestamo
            // 
            this.comboBoxLibroPrestamo.FormattingEnabled = true;
            this.comboBoxLibroPrestamo.Items.AddRange(new object[] {
            "epub",
            "pdf",
            "azw3",
            "txt",
            "docx",
            "mobi"});
            this.comboBoxLibroPrestamo.Location = new System.Drawing.Point(59, 187);
            this.comboBoxLibroPrestamo.Name = "comboBoxLibroPrestamo";
            this.comboBoxLibroPrestamo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLibroPrestamo.TabIndex = 19;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(6, 260);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(95, 13);
            this.lblFechaDevolucion.TabIndex = 18;
            this.lblFechaDevolucion.Text = "Fecha devolución:";
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(9, 276);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerFechaDevolucion.TabIndex = 17;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(6, 213);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(103, 13);
            this.lblFechaPrestamo.TabIndex = 16;
            this.lblFechaPrestamo.Text = "Fecha del prestamo:";
            // 
            // dateTimePickerFechaPrestamo
            // 
            this.dateTimePickerFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaPrestamo.Location = new System.Drawing.Point(9, 229);
            this.dateTimePickerFechaPrestamo.Name = "dateTimePickerFechaPrestamo";
            this.dateTimePickerFechaPrestamo.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerFechaPrestamo.TabIndex = 15;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(5, 163);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(48, 13);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "Formato:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "epub",
            "pdf",
            "azw3",
            "txt",
            "docx",
            "mobi"});
            this.comboBox1.Location = new System.Drawing.Point(59, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(4, 137);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(49, 13);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Tamaño:";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(59, 134);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(121, 20);
            this.txt4.TabIndex = 11;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(24, 111);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 13);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "DNI:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Apellido:";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(59, 108);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(121, 20);
            this.txt3.TabIndex = 8;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(59, 82);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(121, 20);
            this.txt2.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTipoLibro
            // 
            this.lblTipoLibro.AutoSize = true;
            this.lblTipoLibro.Location = new System.Drawing.Point(22, 22);
            this.lblTipoLibro.Name = "lblTipoLibro";
            this.lblTipoLibro.Size = new System.Drawing.Size(31, 13);
            this.lblTipoLibro.TabIndex = 4;
            this.lblTipoLibro.Text = "Tipo:";
            // 
            // comboBoxLibro
            // 
            this.comboBoxLibro.FormattingEnabled = true;
            this.comboBoxLibro.Items.AddRange(new object[] {
            "Libro Físico",
            "Libro Dígital"});
            this.comboBoxLibro.Location = new System.Drawing.Point(59, 19);
            this.comboBoxLibro.Name = "comboBoxLibro";
            this.comboBoxLibro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLibro.TabIndex = 1;
            this.comboBoxLibro.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibro_SelectedIndexChanged);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(119, 322);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDato4);
            this.groupBox2.Controls.Add(this.lblDato5);
            this.groupBox2.Controls.Add(this.lblDato3);
            this.groupBox2.Controls.Add(this.lblDato2);
            this.groupBox2.Controls.Add(this.lblDato1);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(466, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 351);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // lblDato4
            // 
            this.lblDato4.AutoSize = true;
            this.lblDato4.Location = new System.Drawing.Point(153, 89);
            this.lblDato4.Name = "lblDato4";
            this.lblDato4.Size = new System.Drawing.Size(35, 13);
            this.lblDato4.TabIndex = 6;
            this.lblDato4.Text = "label6";
            // 
            // lblDato5
            // 
            this.lblDato5.AutoSize = true;
            this.lblDato5.Location = new System.Drawing.Point(7, 168);
            this.lblDato5.Name = "lblDato5";
            this.lblDato5.Size = new System.Drawing.Size(35, 13);
            this.lblDato5.TabIndex = 5;
            this.lblDato5.Text = "label5";
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Location = new System.Drawing.Point(7, 89);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(35, 13);
            this.lblDato3.TabIndex = 4;
            this.lblDato3.Text = "label4";
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(153, 20);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(35, 13);
            this.lblDato2.TabIndex = 3;
            this.lblDato2.Text = "label3";
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Location = new System.Drawing.Point(7, 20);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(35, 13);
            this.lblDato1.TabIndex = 2;
            this.lblDato1.Text = "label2";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(241, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Items.AddRange(new object[] {
            "Ejemplo"});
            this.listBoxItems.Location = new System.Drawing.Point(27, 76);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(164, 290);
            this.listBoxItems.TabIndex = 1;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ComboBox comboBoxLibro;
        private System.Windows.Forms.Label lblTipoLibro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrestamo;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox comboBoxLibroPrestamo;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDato4;
        private System.Windows.Forms.Label lblDato5;
        private System.Windows.Forms.Label lblDato3;
    }
}

