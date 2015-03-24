namespace DiseñoCalcLosa
{
    partial class CrearProyectForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProyectForm));
            this.rectangleMain = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleTitulo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.buttSalir = new System.Windows.Forms.Button();
            this.buttMini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.numericUpDownNivel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPandereta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxtipoedif = new System.Windows.Forms.ComboBox();
            this.textBoxTeminacion = new System.Windows.Forms.TextBox();
            this.textBoxPesoEsp = new System.Windows.Forms.TextBox();
            this.comboBoxTipoLosa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPandereta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelmedidaPand = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleMain
            // 
            this.rectangleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleMain.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleMain.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleMain.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.rectangleMain.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleMain.Location = new System.Drawing.Point(8, 37);
            this.rectangleMain.Name = "rectangleMain";
            this.rectangleMain.Size = new System.Drawing.Size(887, 433);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleTitulo,
            this.rectangleMain});
            this.shapeContainer1.Size = new System.Drawing.Size(906, 480);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleTitulo
            // 
            this.rectangleTitulo.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleTitulo.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleTitulo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleTitulo.Location = new System.Drawing.Point(8, 8);
            this.rectangleTitulo.Name = "rectangleTitulo";
            this.rectangleTitulo.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleTitulo.Size = new System.Drawing.Size(803, 25);
            this.rectangleTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleTitulo_MouseDown);
            // 
            // buttSalir
            // 
            this.buttSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttSalir.BackColor = System.Drawing.Color.Tomato;
            this.buttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttSalir.Location = new System.Drawing.Point(860, 8);
            this.buttSalir.Name = "buttSalir";
            this.buttSalir.Size = new System.Drawing.Size(34, 26);
            this.buttSalir.TabIndex = 55;
            this.buttSalir.Text = "X";
            this.toolTip1.SetToolTip(this.buttSalir, "Ir al menu princial");
            this.buttSalir.UseVisualStyleBackColor = false;
            this.buttSalir.Click += new System.EventHandler(this.buttSalir_Click_1);
            // 
            // buttMini
            // 
            this.buttMini.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMini.BackColor = System.Drawing.Color.CadetBlue;
            this.buttMini.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMini.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttMini.Location = new System.Drawing.Point(820, 8);
            this.buttMini.Name = "buttMini";
            this.buttMini.Size = new System.Drawing.Size(34, 26);
            this.buttMini.TabIndex = 65;
            this.buttMini.Text = "_";
            this.buttMini.UseVisualStyleBackColor = false;
            this.buttMini.Click += new System.EventHandler(this.buttMini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÁLCULOS DE ESPESORES DE LOSAS";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(18, 433);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(332, 25);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Ing. Pedro Ml. Rosario Espinal";
            // 
            // numericUpDownNivel
            // 
            this.numericUpDownNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNivel.Location = new System.Drawing.Point(527, 224);
            this.numericUpDownNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNivel.Name = "numericUpDownNivel";
            this.numericUpDownNivel.Size = new System.Drawing.Size(58, 31);
            this.numericUpDownNivel.TabIndex = 1;
            this.numericUpDownNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Niveles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de edificio";
            // 
            // textBoxPandereta
            // 
            this.textBoxPandereta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPandereta.Location = new System.Drawing.Point(527, 369);
            this.textBoxPandereta.Name = "textBoxPandereta";
            this.textBoxPandereta.Size = new System.Drawing.Size(119, 31);
            this.textBoxPandereta.TabIndex = 5;
            this.textBoxPandereta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPandereta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Terminacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Peso especifico del concreto";
            // 
            // comboBoxtipoedif
            // 
            this.comboBoxtipoedif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtipoedif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxtipoedif.FormattingEnabled = true;
            this.comboBoxtipoedif.Items.AddRange(new object[] {
            "Edificio Residencial ",
            "Edificio para Comercios",
            "Edificio Institucionales",
            "Edificio Oficina",
            "Edificio Indusctrial",
            "Edificio Publicos",
            "Edificio para Almacenaje",
            "Aceras",
            "Techos"});
            this.comboBoxtipoedif.Location = new System.Drawing.Point(527, 185);
            this.comboBoxtipoedif.Name = "comboBoxtipoedif";
            this.comboBoxtipoedif.Size = new System.Drawing.Size(192, 28);
            this.comboBoxtipoedif.TabIndex = 0;
            // 
            // textBoxTeminacion
            // 
            this.textBoxTeminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeminacion.Location = new System.Drawing.Point(527, 298);
            this.textBoxTeminacion.Name = "textBoxTeminacion";
            this.textBoxTeminacion.Size = new System.Drawing.Size(119, 31);
            this.textBoxTeminacion.TabIndex = 3;
            this.textBoxTeminacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTeminacion_KeyPress);
            // 
            // textBoxPesoEsp
            // 
            this.textBoxPesoEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesoEsp.Location = new System.Drawing.Point(527, 261);
            this.textBoxPesoEsp.Name = "textBoxPesoEsp";
            this.textBoxPesoEsp.Size = new System.Drawing.Size(119, 31);
            this.textBoxPesoEsp.TabIndex = 2;
            this.textBoxPesoEsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesoEsp_KeyPress);
            // 
            // comboBoxTipoLosa
            // 
            this.comboBoxTipoLosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoLosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoLosa.FormattingEnabled = true;
            this.comboBoxTipoLosa.Items.AddRange(new object[] {
            "Entrepiso ",
            "Techo"});
            this.comboBoxTipoLosa.Location = new System.Drawing.Point(527, 335);
            this.comboBoxTipoLosa.Name = "comboBoxTipoLosa";
            this.comboBoxTipoLosa.Size = new System.Drawing.Size(192, 28);
            this.comboBoxTipoLosa.TabIndex = 4;
            this.comboBoxTipoLosa.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tipo de Losa";
            // 
            // labelPandereta
            // 
            this.labelPandereta.AutoSize = true;
            this.labelPandereta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelPandereta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPandereta.Location = new System.Drawing.Point(388, 371);
            this.labelPandereta.Name = "labelPandereta";
            this.labelPandereta.Size = new System.Drawing.Size(133, 29);
            this.labelPandereta.TabIndex = 39;
            this.labelPandereta.Text = "Pandereta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(652, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 41;
            this.label9.Text = "kg/m²";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(652, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "kg/m³";
            // 
            // labelmedidaPand
            // 
            this.labelmedidaPand.AutoSize = true;
            this.labelmedidaPand.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelmedidaPand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmedidaPand.Location = new System.Drawing.Point(652, 371);
            this.labelmedidaPand.Name = "labelmedidaPand";
            this.labelmedidaPand.Size = new System.Drawing.Size(78, 29);
            this.labelmedidaPand.TabIndex = 67;
            this.labelmedidaPand.Text = "kg/m²";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(527, 144);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(327, 31);
            this.textBoxNombre.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nombre del Proyecto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DiseñoCalcLosa.Properties.Resources.left_round_26b;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(23, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atras";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Ir al menu princial");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Image = global::DiseñoCalcLosa.Properties.Resources.add_file_26;
            this.buttonCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrear.Location = new System.Drawing.Point(712, 424);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(155, 34);
            this.buttonCrear.TabIndex = 6;
            this.buttonCrear.Text = "    Crear Proyecto";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::DiseñoCalcLosa.Properties.Resources.add_file_26;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(19, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 24);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "    Crear Proyecto";
            // 
            // CrearProyectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 480);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelmedidaPand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.labelPandereta);
            this.Controls.Add(this.comboBoxTipoLosa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxtipoedif);
            this.Controls.Add(this.textBoxTeminacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPesoEsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.textBoxPandereta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownNivel);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttSalir);
            this.Controls.Add(this.buttMini);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearProyectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleMain;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleTitulo;
        public System.Windows.Forms.Button buttSalir;
        public System.Windows.Forms.Button buttMini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPandereta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxtipoedif;
        private System.Windows.Forms.TextBox textBoxTeminacion;
        private System.Windows.Forms.TextBox textBoxPesoEsp;
        private System.Windows.Forms.ComboBox comboBoxTipoLosa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPandereta;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelmedidaPand;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label labelUser;

    }
}