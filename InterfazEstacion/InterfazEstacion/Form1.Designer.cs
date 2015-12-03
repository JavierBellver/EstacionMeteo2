namespace InterfazEstacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Estaciones = new System.Windows.Forms.TabPage();
            this.label_EstacionesAct = new System.Windows.Forms.Label();
            this.listView_estacionesReg = new System.Windows.Forms.ListView();
            this.Button_Conectar = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.Acciones = new System.Windows.Forms.TabPage();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.textBox_NuevoValor = new System.Windows.Forms.TextBox();
            this.label_resultados = new System.Windows.Forms.Label();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.comboBox_Atributo = new System.Windows.Forms.ComboBox();
            this.comboBox_Estacion = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Estaciones.SuspendLayout();
            this.Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Estaciones);
            this.tabControl1.Controls.Add(this.Acciones);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // Estaciones
            // 
            this.Estaciones.Controls.Add(this.label_EstacionesAct);
            this.Estaciones.Controls.Add(this.listView_estacionesReg);
            this.Estaciones.Controls.Add(this.Button_Conectar);
            this.Estaciones.Controls.Add(this.textBox_direccion);
            this.Estaciones.Location = new System.Drawing.Point(4, 22);
            this.Estaciones.Name = "Estaciones";
            this.Estaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Estaciones.Size = new System.Drawing.Size(370, 310);
            this.Estaciones.TabIndex = 0;
            this.Estaciones.Text = "Estaciones";
            this.Estaciones.UseVisualStyleBackColor = true;
            // 
            // label_EstacionesAct
            // 
            this.label_EstacionesAct.AutoSize = true;
            this.label_EstacionesAct.Location = new System.Drawing.Point(7, 72);
            this.label_EstacionesAct.Name = "label_EstacionesAct";
            this.label_EstacionesAct.Size = new System.Drawing.Size(103, 13);
            this.label_EstacionesAct.TabIndex = 3;
            this.label_EstacionesAct.Text = "Estaciones Actuales";
            // 
            // listView_estacionesReg
            // 
            this.listView_estacionesReg.Location = new System.Drawing.Point(6, 91);
            this.listView_estacionesReg.Name = "listView_estacionesReg";
            this.listView_estacionesReg.ShowGroups = false;
            this.listView_estacionesReg.Size = new System.Drawing.Size(263, 213);
            this.listView_estacionesReg.TabIndex = 2;
            this.listView_estacionesReg.UseCompatibleStateImageBehavior = false;
            // 
            // Button_Conectar
            // 
            this.Button_Conectar.Location = new System.Drawing.Point(289, 31);
            this.Button_Conectar.Name = "Button_Conectar";
            this.Button_Conectar.Size = new System.Drawing.Size(75, 23);
            this.Button_Conectar.TabIndex = 1;
            this.Button_Conectar.Text = "Conectar";
            this.Button_Conectar.UseVisualStyleBackColor = true;
            this.Button_Conectar.Click += new System.EventHandler(this.Button_Conectar_Click);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(6, 34);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(263, 20);
            this.textBox_direccion.TabIndex = 0;
            this.textBox_direccion.Text = "IP:Puerto";
            // 
            // Acciones
            // 
            this.Acciones.Controls.Add(this.button_Modificar);
            this.Acciones.Controls.Add(this.textBox_NuevoValor);
            this.Acciones.Controls.Add(this.label_resultados);
            this.Acciones.Controls.Add(this.button_Consultar);
            this.Acciones.Controls.Add(this.comboBox_Atributo);
            this.Acciones.Controls.Add(this.comboBox_Estacion);
            this.Acciones.Location = new System.Drawing.Point(4, 22);
            this.Acciones.Name = "Acciones";
            this.Acciones.Padding = new System.Windows.Forms.Padding(3);
            this.Acciones.Size = new System.Drawing.Size(370, 310);
            this.Acciones.TabIndex = 1;
            this.Acciones.Text = "Acciones";
            this.Acciones.UseVisualStyleBackColor = true;
            // 
            // button_Modificar
            // 
            this.button_Modificar.Location = new System.Drawing.Point(179, 212);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(101, 23);
            this.button_Modificar.TabIndex = 5;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            // 
            // textBox_NuevoValor
            // 
            this.textBox_NuevoValor.Location = new System.Drawing.Point(21, 214);
            this.textBox_NuevoValor.Name = "textBox_NuevoValor";
            this.textBox_NuevoValor.Size = new System.Drawing.Size(152, 20);
            this.textBox_NuevoValor.TabIndex = 4;
            // 
            // label_resultados
            // 
            this.label_resultados.AutoSize = true;
            this.label_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados.Location = new System.Drawing.Point(21, 146);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(77, 16);
            this.label_resultados.TabIndex = 3;
            this.label_resultados.Text = "Resultados";
            // 
            // button_Consultar
            // 
            this.button_Consultar.Location = new System.Drawing.Point(179, 91);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(101, 23);
            this.button_Consultar.TabIndex = 2;
            this.button_Consultar.Text = "Consultar";
            this.button_Consultar.UseVisualStyleBackColor = true;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // comboBox_Atributo
            // 
            this.comboBox_Atributo.FormattingEnabled = true;
            this.comboBox_Atributo.Items.AddRange(new object[] {
            "Temperatura",
            "Humedad",
            "Luminosidad"});
            this.comboBox_Atributo.Location = new System.Drawing.Point(21, 91);
            this.comboBox_Atributo.Name = "comboBox_Atributo";
            this.comboBox_Atributo.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Atributo.TabIndex = 1;
            // 
            // comboBox_Estacion
            // 
            this.comboBox_Estacion.FormattingEnabled = true;
            this.comboBox_Estacion.Location = new System.Drawing.Point(21, 36);
            this.comboBox_Estacion.Name = "comboBox_Estacion";
            this.comboBox_Estacion.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Estacion.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Estaciones.ResumeLayout(false);
            this.Estaciones.PerformLayout();
            this.Acciones.ResumeLayout(false);
            this.Acciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Estaciones;
        private System.Windows.Forms.TabPage Acciones;
        private System.Windows.Forms.Button Button_Conectar;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label_EstacionesAct;
        private System.Windows.Forms.ListView listView_estacionesReg;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.TextBox textBox_NuevoValor;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.ComboBox comboBox_Atributo;
        private System.Windows.Forms.ComboBox comboBox_Estacion;
    }
}

