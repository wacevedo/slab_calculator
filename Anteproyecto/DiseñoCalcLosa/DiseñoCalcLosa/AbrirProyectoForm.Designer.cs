namespace DiseñoCalcLosa
{
    partial class AbrirProyectoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirProyectoForm));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleTitulo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleMain = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.groupBoxAbrir = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.listViewProyectosRecientes = new System.Windows.Forms.ListView();
            this.columnHeaderProjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxAbrir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleTitulo,
            this.rectangleMain});
            this.shapeContainer1.Size = new System.Drawing.Size(631, 422);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleTitulo
            // 
            this.rectangleTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleTitulo.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleTitulo.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleTitulo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleTitulo.Location = new System.Drawing.Point(5, 6);
            this.rectangleTitulo.Name = "rectangleTitulo";
            this.rectangleTitulo.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleTitulo.Size = new System.Drawing.Size(577, 25);
            this.rectangleTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleTitulo_MouseDown);
            // 
            // rectangleMain
            // 
            this.rectangleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleMain.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleMain.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleMain.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical;
            this.rectangleMain.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleMain.Location = new System.Drawing.Point(5, 37);
            this.rectangleMain.Name = "rectangleMain";
            this.rectangleMain.Size = new System.Drawing.Size(617, 379);
            // 
            // groupBoxAbrir
            // 
            this.groupBoxAbrir.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBoxAbrir.Controls.Add(this.label3);
            this.groupBoxAbrir.Controls.Add(this.shapeContainer2);
            this.groupBoxAbrir.Location = new System.Drawing.Point(16, 87);
            this.groupBoxAbrir.Name = "groupBoxAbrir";
            this.groupBoxAbrir.Size = new System.Drawing.Size(132, 320);
            this.groupBoxAbrir.TabIndex = 34;
            this.groupBoxAbrir.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxAbrir, "Arrastre aqui un archivo .slc para abrirlo");
            this.groupBoxAbrir.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBoxProRecient_DragDrop);
            this.groupBoxAbrir.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBoxProRecient_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Arrastre y Suelte";
            this.toolTip1.SetToolTip(this.label3, "Arrastre aqui un archivo .slc para abrirlo");
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(126, 301);
            this.shapeContainer2.TabIndex = 71;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 5;
            this.lineShape4.X2 = 6;
            this.lineShape4.Y1 = 286;
            this.lineShape4.Y2 = 21;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 119;
            this.lineShape3.X2 = 120;
            this.lineShape3.Y1 = 284;
            this.lineShape3.Y2 = 23;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 117;
            this.lineShape2.Y1 = 292;
            this.lineShape2.Y2 = 291;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 119;
            this.lineShape1.Y1 = 14;
            this.lineShape1.Y2 = 14;
            // 
            // listViewProyectosRecientes
            // 
            this.listViewProyectosRecientes.BackColor = System.Drawing.Color.MintCream;
            this.listViewProyectosRecientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProjects,
            this.columnHeaderFecha});
            this.listViewProyectosRecientes.FullRowSelect = true;
            this.listViewProyectosRecientes.Location = new System.Drawing.Point(154, 87);
            this.listViewProyectosRecientes.MultiSelect = false;
            this.listViewProyectosRecientes.Name = "listViewProyectosRecientes";
            this.listViewProyectosRecientes.Size = new System.Drawing.Size(459, 320);
            this.listViewProyectosRecientes.TabIndex = 0;
            this.listViewProyectosRecientes.UseCompatibleStateImageBehavior = false;
            this.listViewProyectosRecientes.View = System.Windows.Forms.View.Details;
            this.listViewProyectosRecientes.DoubleClick += new System.EventHandler(this.listViewProyectosRecientes_DoubleClick);
            // 
            // columnHeaderProjects
            // 
            this.columnHeaderProjects.Text = "Proyectos";
            this.columnHeaderProjects.Width = 245;
            // 
            // columnHeaderFecha
            // 
            this.columnHeaderFecha.Text = "Fecha";
            this.columnHeaderFecha.Width = 205;
            // 
            // buttSalir
            // 
            this.buttSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttSalir.BackColor = System.Drawing.Color.Tomato;
            this.buttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttSalir.Location = new System.Drawing.Point(589, 6);
            this.buttSalir.Name = "buttSalir";
            this.buttSalir.Size = new System.Drawing.Size(34, 26);
            this.buttSalir.TabIndex = 35;
            this.buttSalir.Text = "X";
            this.toolTip1.SetToolTip(this.buttSalir, "Ir al menu principal");
            this.buttSalir.UseVisualStyleBackColor = false;
            this.buttSalir.Click += new System.EventHandler(this.buttSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(421, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 19);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox1, "Filtrar proyectos");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DiseñoCalcLosa.Properties.Resources.Open_In_Browser_26;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(156, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 52;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button2, "Abrir proyecto selecionado");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.listViewProyectosRecientes_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::DiseñoCalcLosa.Properties.Resources.Search_26;
            this.pictureBox1.InitialImage = global::DiseñoCalcLosa.Properties.Resources.Search_26;
            this.pictureBox1.Location = new System.Drawing.Point(593, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::DiseñoCalcLosa.Properties.Resources.opened_folder_26;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 24);
            this.lblTitulo.TabIndex = 48;
            this.lblTitulo.Text = "     Abrir Proyecto";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Image = global::DiseñoCalcLosa.Properties.Resources.overview_pages_4_26;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(203, 44);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(39, 37);
            this.buttonExport.TabIndex = 47;
            this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonExport, "Cambiar tipo de vista");
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::DiseñoCalcLosa.Properties.Resources.left_round_26b;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(16, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 37);
            this.button3.TabIndex = 53;
            this.button3.Text = "Atras";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button3, "Ir al menu principal");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttSalir_Click);
            // 
            // AbrirProyectoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttSalir);
            this.Controls.Add(this.listViewProyectosRecientes);
            this.Controls.Add(this.groupBoxAbrir);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbrirProyectoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbrirProyectoForm";
            this.Load += new System.EventHandler(this.AbrirProyectoForm_Load);
            this.groupBoxAbrir.ResumeLayout(false);
            this.groupBoxAbrir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleTitulo;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleMain;
        private System.Windows.Forms.GroupBox groupBoxAbrir;
        private System.Windows.Forms.ListView listViewProyectosRecientes;
        private System.Windows.Forms.ColumnHeader columnHeaderProjects;
        private System.Windows.Forms.ColumnHeader columnHeaderFecha;
        public System.Windows.Forms.Button buttSalir;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}