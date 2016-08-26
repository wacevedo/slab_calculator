using System;

namespace DiseñoCalcLosa
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.rectangleTitulo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleMain = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.buttSalir = new System.Windows.Forms.Button();
            this.buttMini = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxProRecient = new System.Windows.Forms.GroupBox();
            this.listViewProyectosRecientes = new System.Windows.Forms.ListView();
            this.columnHeaderProjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.buttonOnedrive = new System.Windows.Forms.Button();
            this.buttonDropbox = new System.Windows.Forms.Button();
            this.buttonArcXml = new System.Windows.Forms.Button();
            this.buttonProyectosRecientes = new System.Windows.Forms.Button();
            this.buttonLosa = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonAbrirPro = new System.Windows.Forms.Button();
            this.buttonCrearPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBoxProRecient.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectangleTitulo
            // 
            this.rectangleTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleTitulo.FillColor = System.Drawing.Color.CadetBlue;
            this.rectangleTitulo.FillGradientColor = System.Drawing.Color.LightGreen;
            this.rectangleTitulo.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleTitulo.Location = new System.Drawing.Point(6, 6);
            this.rectangleTitulo.Name = "rectangleTitulo";
            this.rectangleTitulo.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleTitulo.Size = new System.Drawing.Size(512, 25);
            this.rectangleTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleTitulo_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleMain,
            this.rectangleTitulo});
            this.shapeContainer1.Size = new System.Drawing.Size(612, 466);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
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
            this.rectangleMain.Location = new System.Drawing.Point(6, 38);
            this.rectangleMain.Name = "rectangleMain";
            this.rectangleMain.Size = new System.Drawing.Size(595, 420);
            // 
            // buttSalir
            // 
            this.buttSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttSalir.BackColor = System.Drawing.Color.Tomato;
            this.buttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttSalir.Location = new System.Drawing.Point(568, 6);
            this.buttSalir.Name = "buttSalir";
            this.buttSalir.Size = new System.Drawing.Size(34, 26);
            this.buttSalir.TabIndex = 10;
            this.buttSalir.Text = "X";
            this.buttSalir.UseVisualStyleBackColor = false;
            this.buttSalir.Click += new System.EventHandler(this.buttSalir_Click);
            // 
            // buttMini
            // 
            this.buttMini.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMini.BackColor = System.Drawing.Color.CadetBlue;
            this.buttMini.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMini.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttMini.Location = new System.Drawing.Point(528, 6);
            this.buttMini.Name = "buttMini";
            this.buttMini.Size = new System.Drawing.Size(34, 26);
            this.buttMini.TabIndex = 11;
            this.buttMini.Text = "_";
            this.buttMini.UseVisualStyleBackColor = false;
            this.buttMini.Click += new System.EventHandler(this.buttMini_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(28, 252);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(200, 169);
            this.axWindowsMediaPlayer1.TabIndex = 27;
            // 
            // groupBoxProRecient
            // 
            this.groupBoxProRecient.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBoxProRecient.Controls.Add(this.listViewProyectosRecientes);
            this.groupBoxProRecient.Location = new System.Drawing.Point(368, 168);
            this.groupBoxProRecient.Name = "groupBoxProRecient";
            this.groupBoxProRecient.Size = new System.Drawing.Size(214, 213);
            this.groupBoxProRecient.TabIndex = 32;
            this.groupBoxProRecient.TabStop = false;
            this.groupBoxProRecient.Enter += new System.EventHandler(this.groupBoxProRecient_Enter);
            // 
            // listViewProyectosRecientes
            // 
            this.listViewProyectosRecientes.BackColor = System.Drawing.Color.MintCream;
            this.listViewProyectosRecientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProjects});
            this.listViewProyectosRecientes.FullRowSelect = true;
            this.listViewProyectosRecientes.Location = new System.Drawing.Point(0, 5);
            this.listViewProyectosRecientes.MultiSelect = false;
            this.listViewProyectosRecientes.Name = "listViewProyectosRecientes";
            this.listViewProyectosRecientes.Size = new System.Drawing.Size(214, 213);
            this.listViewProyectosRecientes.TabIndex = 0;
            this.listViewProyectosRecientes.UseCompatibleStateImageBehavior = false;
            this.listViewProyectosRecientes.View = System.Windows.Forms.View.SmallIcon;
            this.listViewProyectosRecientes.SelectedIndexChanged += new System.EventHandler(this.listViewProyectosRecientes_SelectedIndexChanged);
            this.listViewProyectosRecientes.DoubleClick += new System.EventHandler(this.listViewProyectosRecientes_DoubleClick);
            // 
            // columnHeaderProjects
            // 
            this.columnHeaderProjects.Text = "Proyectos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Slab Calculator";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Image = global::DiseñoCalcLosa.Properties.Resources.settings_filled_25;
            this.buttonSettings.Location = new System.Drawing.Point(550, 65);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(32, 32);
            this.buttonSettings.TabIndex = 33;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::DiseñoCalcLosa.Properties.Resources.menu_26;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(10, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 24);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "     Menu Principal";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectangleTitulo_MouseDown);
            // 
            // buttonOnedrive
            // 
            this.buttonOnedrive.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonOnedrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnedrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnedrive.Image = global::DiseñoCalcLosa.Properties.Resources.skydrive_26;
            this.buttonOnedrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOnedrive.Location = new System.Drawing.Point(273, 313);
            this.buttonOnedrive.Name = "buttonOnedrive";
            this.buttonOnedrive.Size = new System.Drawing.Size(155, 33);
            this.buttonOnedrive.TabIndex = 25;
            this.buttonOnedrive.Text = "OneDrive";
            this.buttonOnedrive.UseVisualStyleBackColor = false;
            this.buttonOnedrive.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonDropbox
            // 
            this.buttonDropbox.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDropbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDropbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDropbox.Image = global::DiseñoCalcLosa.Properties.Resources.dropbox_26;
            this.buttonDropbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDropbox.Location = new System.Drawing.Point(273, 274);
            this.buttonDropbox.Name = "buttonDropbox";
            this.buttonDropbox.Size = new System.Drawing.Size(155, 33);
            this.buttonDropbox.TabIndex = 23;
            this.buttonDropbox.Text = "Dropbox";
            this.buttonDropbox.UseVisualStyleBackColor = false;
            // 
            // buttonArcXml
            // 
            this.buttonArcXml.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonArcXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArcXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArcXml.Image = global::DiseñoCalcLosa.Properties.Resources.xml_26;
            this.buttonArcXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArcXml.Location = new System.Drawing.Point(273, 235);
            this.buttonArcXml.Name = "buttonArcXml";
            this.buttonArcXml.Size = new System.Drawing.Size(155, 33);
            this.buttonArcXml.TabIndex = 24;
            this.buttonArcXml.Text = "Archivo .XML";
            this.buttonArcXml.UseVisualStyleBackColor = false;
            this.buttonArcXml.Click += new System.EventHandler(this.buttonArcXml_Click);
            // 
            // buttonProyectosRecientes
            // 
            this.buttonProyectosRecientes.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonProyectosRecientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProyectosRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProyectosRecientes.Image = global::DiseñoCalcLosa.Properties.Resources.documents_folder_48;
            this.buttonProyectosRecientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProyectosRecientes.Location = new System.Drawing.Point(368, 117);
            this.buttonProyectosRecientes.Name = "buttonProyectosRecientes";
            this.buttonProyectosRecientes.Size = new System.Drawing.Size(214, 57);
            this.buttonProyectosRecientes.TabIndex = 3;
            this.buttonProyectosRecientes.Text = "Proyectos Recientes";
            this.buttonProyectosRecientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProyectosRecientes.UseVisualStyleBackColor = false;
            this.buttonProyectosRecientes.Click += new System.EventHandler(this.button6_Click);
            this.buttonProyectosRecientes.MouseEnter += new System.EventHandler(this.buttonProyectosRecientes_MouseEnter);
            this.buttonProyectosRecientes.MouseLeave += new System.EventHandler(this.buttonProyectosRecientes_MouseLeave);
            // 
            // buttonLosa
            // 
            this.buttonLosa.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLosa.Image = global::DiseñoCalcLosa.Properties.Resources.unchecked_checkbox_26;
            this.buttonLosa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLosa.Location = new System.Drawing.Point(273, 352);
            this.buttonLosa.Name = "buttonLosa";
            this.buttonLosa.Size = new System.Drawing.Size(155, 33);
            this.buttonLosa.TabIndex = 21;
            this.buttonLosa.Text = "Losa";
            this.buttonLosa.UseVisualStyleBackColor = false;
            this.buttonLosa.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Image = global::DiseñoCalcLosa.Properties.Resources.export_26;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExport.Location = new System.Drawing.Point(288, 391);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(125, 35);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = " Exportar ";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.button4_Click);
            this.buttonExport.MouseEnter += new System.EventHandler(this.buttonExport_MouseEnter);
            this.buttonExport.MouseLeave += new System.EventHandler(this.buttonExport_MouseLeave);
            // 
            // buttonAbrirPro
            // 
            this.buttonAbrirPro.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAbrirPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirPro.Image = global::DiseñoCalcLosa.Properties.Resources.Opened_Folder_50;
            this.buttonAbrirPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirPro.Location = new System.Drawing.Point(28, 180);
            this.buttonAbrirPro.Name = "buttonAbrirPro";
            this.buttonAbrirPro.Size = new System.Drawing.Size(177, 57);
            this.buttonAbrirPro.TabIndex = 1;
            this.buttonAbrirPro.Text = "Abrir Proyecto";
            this.buttonAbrirPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirPro.UseVisualStyleBackColor = false;
            this.buttonAbrirPro.Click += new System.EventHandler(this.button2_Click);
            this.buttonAbrirPro.MouseEnter += new System.EventHandler(this.buttonAbrirPro_MouseEnter);
            this.buttonAbrirPro.MouseLeave += new System.EventHandler(this.buttonAbrirPro_MouseLeave);
            // 
            // buttonCrearPro
            // 
            this.buttonCrearPro.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonCrearPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearPro.Image = global::DiseñoCalcLosa.Properties.Resources.add_file_50;
            this.buttonCrearPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrearPro.Location = new System.Drawing.Point(28, 117);
            this.buttonCrearPro.Name = "buttonCrearPro";
            this.buttonCrearPro.Size = new System.Drawing.Size(177, 57);
            this.buttonCrearPro.TabIndex = 0;
            this.buttonCrearPro.Text = "Crear Proyecto";
            this.buttonCrearPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCrearPro.UseVisualStyleBackColor = false;
            this.buttonCrearPro.Click += new System.EventHandler(this.button1_Click);
            this.buttonCrearPro.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.buttonCrearPro.MouseLeave += new System.EventHandler(this.buttonCrearPro_MouseLeave);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 466);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOnedrive);
            this.Controls.Add(this.buttonDropbox);
            this.Controls.Add(this.buttonArcXml);
            this.Controls.Add(this.buttonProyectosRecientes);
            this.Controls.Add(this.buttonLosa);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonAbrirPro);
            this.Controls.Add(this.buttonCrearPro);
            this.Controls.Add(this.buttSalir);
            this.Controls.Add(this.buttMini);
            this.Controls.Add(this.groupBoxProRecient);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBoxProRecient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.Button buttSalir;
        public System.Windows.Forms.Button buttMini;
        private System.Windows.Forms.Button buttonCrearPro;
        private System.Windows.Forms.Button buttonAbrirPro;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonLosa;
        private System.Windows.Forms.Button buttonProyectosRecientes;
        private System.Windows.Forms.Button buttonOnedrive;
        private System.Windows.Forms.Button buttonArcXml;
        private System.Windows.Forms.Button buttonDropbox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxProRecient;
        private System.Windows.Forms.ListView listViewProyectosRecientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderProjects;
        private System.Windows.Forms.Button buttonSettings;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleTitulo;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleMain;
    }
}