/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 10/19/2019
 * Hora: 15:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CrearExcel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox txtDia;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.Label lbDia;
		private System.Windows.Forms.Label lbmes;
		private System.Windows.Forms.Label lbyear;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lbDia = new System.Windows.Forms.Label();
            this.lbmes = new System.Windows.Forms.Label();
            this.lbyear = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.lbPag = new System.Windows.Forms.Label();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.lbDatosFam = new System.Windows.Forms.Label();
            this.lbNomB = new System.Windows.Forms.Label();
            this.lbNomP = new System.Windows.Forms.Label();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.lbMadre = new System.Windows.Forms.Label();
            this.txtMadre = new System.Windows.Forms.TextBox();
            this.lbPadrino = new System.Windows.Forms.Label();
            this.txtPadrino = new System.Windows.Forms.TextBox();
            this.lbFB = new System.Windows.Forms.Label();
            this.lbFechaB = new System.Windows.Forms.Label();
            this.txtFechaB = new System.Windows.Forms.TextBox();
            this.lbFC = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnioC = new System.Windows.Forms.TextBox();
            this.txtMC = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tooltxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDia
            // 
            this.helpProvider1.SetHelpString(this.txtDia, "Campo en donde se debe ingresar el parámetro especificado de la fecha de creación" +
        " de la boleta de primera comunión.");
            this.txtDia.Location = new System.Drawing.Point(144, 145);
            this.txtDia.Name = "txtDia";
            this.helpProvider1.SetShowHelp(this.txtDia, true);
            this.txtDia.Size = new System.Drawing.Size(115, 20);
            this.txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            this.helpProvider1.SetHelpString(this.txtMes, "Campo en donde se debe ingresar el parámetro especificado de la fecha de creación" +
        " de la boleta de primera comunión.");
            this.txtMes.Location = new System.Drawing.Point(144, 171);
            this.txtMes.Name = "txtMes";
            this.helpProvider1.SetShowHelp(this.txtMes, true);
            this.txtMes.Size = new System.Drawing.Size(115, 20);
            this.txtMes.TabIndex = 6;
            // 
            // txtAnio
            // 
            this.helpProvider1.SetHelpString(this.txtAnio, "Campo en donde se debe ingresar el parámetro especificado de la fecha de creación" +
        " de la boleta de primera comunión.");
            this.txtAnio.Location = new System.Drawing.Point(144, 197);
            this.txtAnio.Name = "txtAnio";
            this.helpProvider1.SetShowHelp(this.txtAnio, true);
            this.txtAnio.Size = new System.Drawing.Size(115, 20);
            this.txtAnio.TabIndex = 7;
            // 
            // lbDia
            // 
            this.lbDia.BackColor = System.Drawing.Color.Transparent;
            this.lbDia.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDia.Location = new System.Drawing.Point(86, 145);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(52, 20);
            this.lbDia.TabIndex = 8;
            this.lbDia.Text = "Día:";
            // 
            // lbmes
            // 
            this.lbmes.BackColor = System.Drawing.Color.Transparent;
            this.lbmes.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmes.Location = new System.Drawing.Point(86, 168);
            this.lbmes.Name = "lbmes";
            this.lbmes.Size = new System.Drawing.Size(52, 23);
            this.lbmes.TabIndex = 9;
            this.lbmes.Text = "Mes:";
            // 
            // lbyear
            // 
            this.lbyear.BackColor = System.Drawing.Color.Transparent;
            this.lbyear.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbyear.Location = new System.Drawing.Point(86, 194);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(52, 23);
            this.lbyear.TabIndex = 10;
            this.lbyear.Text = "Año:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(162, 112);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(75, 30);
            this.lbFecha.TabIndex = 11;
            this.lbFecha.Text = "Fecha ";
            // 
            // lbLibro
            // 
            this.lbLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLibro.AutoSize = true;
            this.lbLibro.BackColor = System.Drawing.Color.Transparent;
            this.lbLibro.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.Location = new System.Drawing.Point(624, 290);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(68, 30);
            this.lbLibro.TabIndex = 12;
            this.lbLibro.Text = "Libro ";
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.helpProvider1.SetHelpString(this.txtNo, "Numero de libro en donde se encuentre el registro de la boleta.");
            this.txtNo.Location = new System.Drawing.Point(571, 326);
            this.txtNo.Name = "txtNo";
            this.helpProvider1.SetShowHelp(this.txtNo, true);
            this.txtNo.Size = new System.Drawing.Size(169, 20);
            this.txtNo.TabIndex = 13;
            // 
            // lbNo
            // 
            this.lbNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNo.BackColor = System.Drawing.Color.Transparent;
            this.lbNo.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNo.Location = new System.Drawing.Point(513, 323);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(52, 23);
            this.lbNo.TabIndex = 14;
            this.lbNo.Text = "No:";
            // 
            // lbPag
            // 
            this.lbPag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPag.BackColor = System.Drawing.Color.Transparent;
            this.lbPag.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPag.Location = new System.Drawing.Point(513, 352);
            this.lbPag.Name = "lbPag";
            this.lbPag.Size = new System.Drawing.Size(52, 23);
            this.lbPag.TabIndex = 15;
            this.lbPag.Text = "Pág:";
            // 
            // txtPag
            // 
            this.txtPag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.helpProvider1.SetHelpString(this.txtPag, "Pagina en donde se encuentra el registro de la boleta.");
            this.txtPag.Location = new System.Drawing.Point(571, 352);
            this.txtPag.Name = "txtPag";
            this.helpProvider1.SetShowHelp(this.txtPag, true);
            this.txtPag.Size = new System.Drawing.Size(169, 20);
            this.txtPag.TabIndex = 16;
            // 
            // lbDatosFam
            // 
            this.lbDatosFam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDatosFam.AutoSize = true;
            this.lbDatosFam.BackColor = System.Drawing.Color.Transparent;
            this.lbDatosFam.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosFam.Location = new System.Drawing.Point(523, 106);
            this.lbDatosFam.Name = "lbDatosFam";
            this.lbDatosFam.Size = new System.Drawing.Size(184, 30);
            this.lbDatosFam.TabIndex = 17;
            this.lbDatosFam.Text = "Datos de la Familia";
            // 
            // lbNomB
            // 
            this.lbNomB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomB.BackColor = System.Drawing.Color.Transparent;
            this.lbNomB.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomB.Location = new System.Drawing.Point(414, 146);
            this.lbNomB.Name = "lbNomB";
            this.lbNomB.Size = new System.Drawing.Size(177, 37);
            this.lbNomB.TabIndex = 18;
            this.lbNomB.Text = "Nombre del Hijo:";
            // 
            // lbNomP
            // 
            this.lbNomP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomP.BackColor = System.Drawing.Color.Transparent;
            this.lbNomP.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomP.Location = new System.Drawing.Point(414, 180);
            this.lbNomP.Name = "lbNomP";
            this.lbNomP.Size = new System.Drawing.Size(151, 37);
            this.lbNomP.TabIndex = 19;
            this.lbNomP.Text = "Nombre del Padre:";
            // 
            // txtHijo
            // 
            this.txtHijo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpProvider1.SetHelpString(this.txtHijo, "Nombre de la persona que recibirá la primera comunión.");
            this.txtHijo.Location = new System.Drawing.Point(571, 145);
            this.txtHijo.Name = "txtHijo";
            this.helpProvider1.SetShowHelp(this.txtHijo, true);
            this.txtHijo.Size = new System.Drawing.Size(169, 20);
            this.txtHijo.TabIndex = 20;
            // 
            // txtPadre
            // 
            this.txtPadre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpProvider1.SetHelpString(this.txtPadre, "Nombre del padre de la persona que recibirá la primera comunión.");
            this.txtPadre.Location = new System.Drawing.Point(571, 181);
            this.txtPadre.Name = "txtPadre";
            this.helpProvider1.SetShowHelp(this.txtPadre, true);
            this.txtPadre.Size = new System.Drawing.Size(169, 20);
            this.txtPadre.TabIndex = 21;
            // 
            // lbMadre
            // 
            this.lbMadre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMadre.BackColor = System.Drawing.Color.Transparent;
            this.lbMadre.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadre.Location = new System.Drawing.Point(414, 216);
            this.lbMadre.Name = "lbMadre";
            this.lbMadre.Size = new System.Drawing.Size(151, 37);
            this.lbMadre.TabIndex = 22;
            this.lbMadre.Text = "Nombre de la Madre:";
            // 
            // txtMadre
            // 
            this.txtMadre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpProvider1.SetHelpString(this.txtMadre, "Nombre de la madre de la persona que recibirá la primera comunión.");
            this.txtMadre.Location = new System.Drawing.Point(571, 219);
            this.txtMadre.Name = "txtMadre";
            this.helpProvider1.SetShowHelp(this.txtMadre, true);
            this.txtMadre.Size = new System.Drawing.Size(169, 20);
            this.txtMadre.TabIndex = 23;
            // 
            // lbPadrino
            // 
            this.lbPadrino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPadrino.BackColor = System.Drawing.Color.Transparent;
            this.lbPadrino.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPadrino.Location = new System.Drawing.Point(414, 251);
            this.lbPadrino.Name = "lbPadrino";
            this.lbPadrino.Size = new System.Drawing.Size(151, 23);
            this.lbPadrino.TabIndex = 24;
            this.lbPadrino.Text = "Padrino o Madrina:";
            // 
            // txtPadrino
            // 
            this.txtPadrino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpProvider1.SetHelpString(this.txtPadrino, "Nombre del Padrino o Madrina.");
            this.txtPadrino.Location = new System.Drawing.Point(571, 252);
            this.txtPadrino.Name = "txtPadrino";
            this.helpProvider1.SetShowHelp(this.txtPadrino, true);
            this.txtPadrino.Size = new System.Drawing.Size(169, 20);
            this.txtPadrino.TabIndex = 25;
            // 
            // lbFB
            // 
            this.lbFB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFB.AutoSize = true;
            this.lbFB.BackColor = System.Drawing.Color.Transparent;
            this.lbFB.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFB.Location = new System.Drawing.Point(141, 358);
            this.lbFB.Name = "lbFB";
            this.lbFB.Size = new System.Drawing.Size(100, 30);
            this.lbFB.TabIndex = 26;
            this.lbFB.Text = "Bautismo";
            // 
            // lbFechaB
            // 
            this.lbFechaB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFechaB.BackColor = System.Drawing.Color.Transparent;
            this.lbFechaB.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaB.Location = new System.Drawing.Point(82, 391);
            this.lbFechaB.Name = "lbFechaB";
            this.lbFechaB.Size = new System.Drawing.Size(56, 20);
            this.lbFechaB.TabIndex = 30;
            this.lbFechaB.Text = "Fecha:";
            // 
            // txtFechaB
            // 
            this.txtFechaB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.helpProvider1.SetHelpString(this.txtFechaB, "Fecha del Bautizo de la persona que se le dará entrega la boleta de primeria comu" +
        "nión.");
            this.txtFechaB.Location = new System.Drawing.Point(144, 391);
            this.txtFechaB.Name = "txtFechaB";
            this.helpProvider1.SetShowHelp(this.txtFechaB, true);
            this.txtFechaB.Size = new System.Drawing.Size(115, 20);
            this.txtFechaB.TabIndex = 27;
            // 
            // lbFC
            // 
            this.lbFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbFC.AutoSize = true;
            this.lbFC.BackColor = System.Drawing.Color.Transparent;
            this.lbFC.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFC.Location = new System.Drawing.Point(141, 226);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(118, 30);
            this.lbFC.TabIndex = 31;
            this.lbFC.Text = "Constancia";
            // 
            // txtAC
            // 
            this.txtAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAC.BackColor = System.Drawing.Color.Transparent;
            this.txtAC.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAC.Location = new System.Drawing.Point(86, 321);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(52, 23);
            this.txtAC.TabIndex = 37;
            this.txtAC.Text = "Año:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Día:";
            // 
            // txtAnioC
            // 
            this.txtAnioC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.helpProvider1.SetHelpString(this.txtAnioC, "Campo en donde se debe ingresar el parámetro especificado de la fecha de constanc" +
        "ia.");
            this.txtAnioC.Location = new System.Drawing.Point(144, 324);
            this.txtAnioC.Name = "txtAnioC";
            this.helpProvider1.SetShowHelp(this.txtAnioC, true);
            this.txtAnioC.Size = new System.Drawing.Size(115, 20);
            this.txtAnioC.TabIndex = 34;
            // 
            // txtMC
            // 
            this.txtMC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.helpProvider1.SetHelpString(this.txtMC, "Campo en donde se debe ingresar el parámetro especificado de la fecha de constanc" +
        "ia.");
            this.txtMC.Location = new System.Drawing.Point(144, 298);
            this.txtMC.Name = "txtMC";
            this.helpProvider1.SetShowHelp(this.txtMC, true);
            this.txtMC.Size = new System.Drawing.Size(115, 20);
            this.txtMC.TabIndex = 33;
            // 
            // txtDC
            // 
            this.txtDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.helpProvider1.SetHelpString(this.txtDC, "Campo en donde se debe ingresar el parámetro especificado de la fecha de constanc" +
        "ia.");
            this.txtDC.Location = new System.Drawing.Point(144, 272);
            this.txtDC.Name = "txtDC";
            this.helpProvider1.SetShowHelp(this.txtDC, true);
            this.txtDC.Size = new System.Drawing.Size(115, 20);
            this.txtDC.TabIndex = 32;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.abrirCarpetaToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripSplitButton1.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.AutoSize = false;
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo.";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            this.abrirCarpetaToolStripMenuItem.AutoSize = false;
            this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.abrirCarpetaToolStripMenuItem.Text = "Seleccionar Carpeta ";
            this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.abrirCarpetaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Maroon;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripBtnLimpiar,
            this.tooltxtBuscar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 35);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnLimpiar
            // 
            this.toolStripBtnLimpiar.AutoSize = false;
            this.toolStripBtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLimpiar.Image")));
            this.toolStripBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLimpiar.Name = "toolStripBtnLimpiar";
            this.toolStripBtnLimpiar.Size = new System.Drawing.Size(40, 40);
            this.toolStripBtnLimpiar.Text = "Limpiar";
            this.toolStripBtnLimpiar.Click += new System.EventHandler(this.toolStripBtnLimpiar_Click);
            // 
            // tooltxtBuscar
            // 
            this.tooltxtBuscar.BackColor = System.Drawing.Color.White;
            this.tooltxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tooltxtBuscar.Name = "tooltxtBuscar";
            this.tooltxtBuscar.Size = new System.Drawing.Size(120, 35);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Maroon;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton1.Text = "Buscar. Nota: Para poder realizar una búsqueda deberá escribir el nombre del usua" +
    "rio en el campo de a lado.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ruta: ";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.BackColor = System.Drawing.Color.Transparent;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.lbPath, "Ruta en donde se encuentra guardado el registro.");
            this.lbPath.Location = new System.Drawing.Point(60, 446);
            this.lbPath.Name = "lbPath";
            this.helpProvider1.SetShowHelp(this.lbPath, true);
            this.lbPath.Size = new System.Drawing.Size(58, 16);
            this.lbPath.TabIndex = 41;
            this.lbPath.Text = "Sin Ruta";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nombre del Archivo:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpString(this.txtFileName, "En este campo se coloca el nombre del archivo. Nota: Recuerde que si es important" +
        "e nombrar su archivo para guardarlo.");
            this.txtFileName.Location = new System.Drawing.Point(225, 82);
            this.txtFileName.Name = "txtFileName";
            this.helpProvider1.SetShowHelp(this.txtFileName, true);
            this.txtFileName.Size = new System.Drawing.Size(199, 20);
            this.txtFileName.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 33);
            this.label6.TabIndex = 45;
            this.label6.Text = "Primera Comunión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.bttnGuardar, "Con este botón se guardan los cambios de un archivo o la creación de uno. Recuerd" +
        "e llenar todos los campos solicitados.");
            this.bttnGuardar.Location = new System.Drawing.Point(328, 401);
            this.bttnGuardar.Name = "bttnGuardar";
            this.helpProvider1.SetShowHelp(this.bttnGuardar, true);
            this.bttnGuardar.Size = new System.Drawing.Size(173, 53);
            this.bttnGuardar.TabIndex = 47;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnioC);
            this.Controls.Add(this.txtMC);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.lbFC);
            this.Controls.Add(this.lbFechaB);
            this.Controls.Add(this.txtFechaB);
            this.Controls.Add(this.lbFB);
            this.Controls.Add(this.txtPadrino);
            this.Controls.Add(this.lbPadrino);
            this.Controls.Add(this.txtMadre);
            this.Controls.Add(this.lbMadre);
            this.Controls.Add(this.txtPadre);
            this.Controls.Add(this.txtHijo);
            this.Controls.Add(this.lbNomP);
            this.Controls.Add(this.lbNomB);
            this.Controls.Add(this.lbDatosFam);
            this.Controls.Add(this.txtPag);
            this.Controls.Add(this.lbPag);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbyear);
            this.Controls.Add(this.lbmes);
            this.Controls.Add(this.lbDia);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(883, 505);
            this.Name = "MainForm";
            this.Text = "Primera Comunión";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbLibro;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbPag;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label lbDatosFam;
        private System.Windows.Forms.Label lbNomB;
        private System.Windows.Forms.Label lbNomP;
        private System.Windows.Forms.TextBox txtHijo;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.Label lbMadre;
        private System.Windows.Forms.TextBox txtMadre;
        private System.Windows.Forms.Label lbPadrino;
        private System.Windows.Forms.TextBox txtPadrino;
        private System.Windows.Forms.Label lbFB;
        private System.Windows.Forms.Label lbFechaB;
        private System.Windows.Forms.TextBox txtFechaB;
        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.Label txtAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnioC;
        private System.Windows.Forms.TextBox txtMC;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnLimpiar;
        private System.Windows.Forms.ToolStripTextBox tooltxtBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
