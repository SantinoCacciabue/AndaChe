namespace AndaChe
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
            this.cBclientes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBver = new System.Windows.Forms.TextBox();
            this.cBvehiculos = new System.Windows.Forms.ComboBox();
            this.cBtecnicos = new System.Windows.Forms.ComboBox();
            this.cBempleados = new System.Windows.Forms.ComboBox();
            this.rBtecnicos = new System.Windows.Forms.RadioButton();
            this.rBvehiculos = new System.Windows.Forms.RadioButton();
            this.rBclientes = new System.Windows.Forms.RadioButton();
            this.rBempleados = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBdniVenta = new System.Windows.Forms.TextBox();
            this.tBdniClienteVenta = new System.Windows.Forms.TextBox();
            this.tBpatenteVenta = new System.Windows.Forms.TextBox();
            this.lBdatosventa = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBclientes
            // 
            this.cBclientes.FormattingEnabled = true;
            this.cBclientes.Location = new System.Drawing.Point(90, 38);
            this.cBclientes.Name = "cBclientes";
            this.cBclientes.Size = new System.Drawing.Size(161, 21);
            this.cBclientes.TabIndex = 3;
            this.cBclientes.SelectedIndexChanged += new System.EventHandler(this.cBclientes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBver);
            this.groupBox2.Controls.Add(this.cBvehiculos);
            this.groupBox2.Controls.Add(this.cBtecnicos);
            this.groupBox2.Controls.Add(this.rBtecnicos);
            this.groupBox2.Controls.Add(this.cBclientes);
            this.groupBox2.Controls.Add(this.cBempleados);
            this.groupBox2.Controls.Add(this.rBvehiculos);
            this.groupBox2.Controls.Add(this.rBclientes);
            this.groupBox2.Controls.Add(this.rBempleados);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(18, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 404);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar";
            // 
            // tBver
            // 
            this.tBver.Location = new System.Drawing.Point(17, 166);
            this.tBver.Multiline = true;
            this.tBver.Name = "tBver";
            this.tBver.Size = new System.Drawing.Size(266, 108);
            this.tBver.TabIndex = 13;
            // 
            // cBvehiculos
            // 
            this.cBvehiculos.FormattingEnabled = true;
            this.cBvehiculos.Location = new System.Drawing.Point(90, 92);
            this.cBvehiculos.Name = "cBvehiculos";
            this.cBvehiculos.Size = new System.Drawing.Size(161, 21);
            this.cBvehiculos.TabIndex = 12;
            // 
            // cBtecnicos
            // 
            this.cBtecnicos.FormattingEnabled = true;
            this.cBtecnicos.Location = new System.Drawing.Point(90, 65);
            this.cBtecnicos.Name = "cBtecnicos";
            this.cBtecnicos.Size = new System.Drawing.Size(161, 21);
            this.cBtecnicos.TabIndex = 11;
            // 
            // cBempleados
            // 
            this.cBempleados.FormattingEnabled = true;
            this.cBempleados.Location = new System.Drawing.Point(89, 15);
            this.cBempleados.Name = "cBempleados";
            this.cBempleados.Size = new System.Drawing.Size(161, 21);
            this.cBempleados.TabIndex = 10;
            // 
            // rBtecnicos
            // 
            this.rBtecnicos.AutoSize = true;
            this.rBtecnicos.Location = new System.Drawing.Point(6, 65);
            this.rBtecnicos.Name = "rBtecnicos";
            this.rBtecnicos.Size = new System.Drawing.Size(69, 17);
            this.rBtecnicos.TabIndex = 9;
            this.rBtecnicos.TabStop = true;
            this.rBtecnicos.Text = "Tecnicos";
            this.rBtecnicos.UseVisualStyleBackColor = true;
            // 
            // rBvehiculos
            // 
            this.rBvehiculos.AutoSize = true;
            this.rBvehiculos.Location = new System.Drawing.Point(6, 92);
            this.rBvehiculos.Name = "rBvehiculos";
            this.rBvehiculos.Size = new System.Drawing.Size(71, 17);
            this.rBvehiculos.TabIndex = 8;
            this.rBvehiculos.TabStop = true;
            this.rBvehiculos.Text = "Vehiculos";
            this.rBvehiculos.UseVisualStyleBackColor = true;
            // 
            // rBclientes
            // 
            this.rBclientes.AutoSize = true;
            this.rBclientes.Location = new System.Drawing.Point(6, 42);
            this.rBclientes.Name = "rBclientes";
            this.rBclientes.Size = new System.Drawing.Size(62, 17);
            this.rBclientes.TabIndex = 7;
            this.rBclientes.TabStop = true;
            this.rBclientes.Text = "Clientes";
            this.rBclientes.UseVisualStyleBackColor = true;
            // 
            // rBempleados
            // 
            this.rBempleados.AutoSize = true;
            this.rBempleados.Location = new System.Drawing.Point(6, 19);
            this.rBempleados.Name = "rBempleados";
            this.rBempleados.Size = new System.Drawing.Size(77, 17);
            this.rBempleados.TabIndex = 6;
            this.rBempleados.TabStop = true;
            this.rBempleados.Text = "Empleados";
            this.rBempleados.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(64, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 46);
            this.button10.TabIndex = 4;
            this.button10.Text = "Iniciar venta";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(362, 228);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 46);
            this.button11.TabIndex = 6;
            this.button11.Text = "Iniciar compra";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Location = new System.Drawing.Point(340, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 284);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operaciones";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(351, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Todo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Compras";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ventas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(131, 35);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 33);
            this.button12.TabIndex = 4;
            this.button12.Text = "Ver";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(762, 457);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 29);
            this.button14.TabIndex = 9;
            this.button14.Text = "Salir";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vehiculo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lBdatosventa);
            this.groupBox1.Controls.Add(this.tBpatenteVenta);
            this.groupBox1.Controls.Add(this.tBdniClienteVenta);
            this.groupBox1.Controls.Add(this.tBdniVenta);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 255);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // tBdniVenta
            // 
            this.tBdniVenta.Location = new System.Drawing.Point(64, 18);
            this.tBdniVenta.Name = "tBdniVenta";
            this.tBdniVenta.Size = new System.Drawing.Size(100, 20);
            this.tBdniVenta.TabIndex = 14;
            this.tBdniVenta.Text = "Nro empleado...";
            this.tBdniVenta.TextChanged += new System.EventHandler(this.tBdniVenta_TextChanged);
            this.tBdniVenta.Leave += new System.EventHandler(this.tBdniVenta_Leave);
            // 
            // tBdniClienteVenta
            // 
            this.tBdniClienteVenta.Location = new System.Drawing.Point(64, 43);
            this.tBdniClienteVenta.Name = "tBdniClienteVenta";
            this.tBdniClienteVenta.Size = new System.Drawing.Size(100, 20);
            this.tBdniClienteVenta.TabIndex = 15;
            this.tBdniClienteVenta.Text = "Dni cliente...";
            this.tBdniClienteVenta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tBdniClienteVenta.Leave += new System.EventHandler(this.tBnroClienteVenta_Leave);
            // 
            // tBpatenteVenta
            // 
            this.tBpatenteVenta.Location = new System.Drawing.Point(64, 69);
            this.tBpatenteVenta.Name = "tBpatenteVenta";
            this.tBpatenteVenta.Size = new System.Drawing.Size(100, 20);
            this.tBpatenteVenta.TabIndex = 16;
            this.tBpatenteVenta.Text = "Patente...";
            // 
            // lBdatosventa
            // 
            this.lBdatosventa.FormattingEnabled = true;
            this.lBdatosventa.Location = new System.Drawing.Point(6, 95);
            this.lBdatosventa.Name = "lBdatosventa";
            this.lBdatosventa.Size = new System.Drawing.Size(277, 95);
            this.lBdatosventa.TabIndex = 17;
            this.lBdatosventa.SelectedIndexChanged += new System.EventHandler(this.lBdatosventa_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 498);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cBclientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rBvehiculos;
        private System.Windows.Forms.RadioButton rBclientes;
        private System.Windows.Forms.RadioButton rBempleados;
        private System.Windows.Forms.RadioButton rBtecnicos;
        private System.Windows.Forms.TextBox tBver;
        private System.Windows.Forms.ComboBox cBvehiculos;
        private System.Windows.Forms.ComboBox cBtecnicos;
        private System.Windows.Forms.ComboBox cBempleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBpatenteVenta;
        private System.Windows.Forms.TextBox tBdniClienteVenta;
        private System.Windows.Forms.TextBox tBdniVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBdatosventa;
    }
}

