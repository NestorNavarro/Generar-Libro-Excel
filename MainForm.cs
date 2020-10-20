/*
 * Creado por SharpDevelop.
 * Usuario: rebel
 * Fecha: 10/19/2019
 * Hora: 15:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml.Schema;


namespace CrearExcel
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public object SafeFileName { get; private set; }

        public MainForm()
        {

            InitializeComponent();

        }
        bool isNumber(string dia)
        {
            try
            {
                Int32.Parse(dia);
                return true;
            }
            catch
            {
                return false;
            }
        }
        void bttnGuardar_Click(object sender, EventArgs e)
        {
  

            if (txtDia.Text != "" && txtAnioC.Text != "" && txtAnio.Text != "")
            {
                if (txtDC.Text != "" && txtFechaB.Text != "" && txtPag.Text != "")
                {
                    if (txtHijo.Text != "" && txtMadre.Text != "" && txtMC.Text != "")
                    {
                        if (txtMes.Text != "" && txtNo.Text != "" && txtPadre.Text != "")
                        {
                            if (txtPadrino.Text != "")
                            {
                                if (txtFileName.Text != "")
                                {
                                    if (lbPath.Text != "Sin Ruta")
                                    {
                                        if (isNumber(txtDia.Text) && isNumber(txtDC.Text) && isNumber(txtAnio.Text) && isNumber(txtPag.Text) && isNumber(txtNo.Text))
                                        {

                                            string path = lbPath.Text + "\\" + txtFileName.Text + ".xlsx";
                                            crearExcel(path);
                                        }
                                        else
                                        {
                                            MessageBox.Show("El día, año, número de página y de libro deben ser numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Para guardar un archivo debe establecer una ruta. Para establecer ruta vaya al icono Arcivo y selecione la opcione seleccionar carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe nombrar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Para guardar o crear un archivo no debe dejar ni un campo vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Para guardar o crear un archivo no debe dejar ni un campo vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Para guardar o crear un archivo no debe dejar ni un campo vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para guardar o crear un archivo no debe dejar ni un campo vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Para guardar o crear un archivo no debe dejar ni un campo vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void crearExcel(string path)
        {
            //Indicamos que vamos a trabajar con un tipo de archivo excel.					
            //Inicializar la aplicación Excel Object.

            Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;

            object misValue = System.Reflection.Missing.Value;

            try
            {

                //Verificamos que Excel este intalado en el equipo.
                if (excel == null)
                {
                    MessageBox.Show("¡No Tienes instalado Excel!");
                    return;
                }

                
                xlWorkBook = excel.Workbooks.Add(misValue);//Creamos un librio nuevo.
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add();//Creamos una hoja nueva.
                xlWorkSheet.Name = "PrimeraComunion";//Nombramos la hoja.
                ((Excel.Worksheet)excel.ActiveWorkbook.Sheets["Hoja1"]).Delete();//Eliminamos la hoja por defecto de excel.

                //Insertamos los datos al libro.
                inserta(xlWorkSheet);
                //Damos formato al excel.
                formato(xlWorkSheet);

                xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                
                //Importenate cerrar todo.
                xlWorkBook.Close(true, misValue, misValue); 
                excel.UserControl = false;
                excel.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excel);
                xlWorkSheet = null;
                xlWorkBook = null;
                excel = null;


                MessageBox.Show("Su archivo "+txtFileName.Text+" se creo correctamente lo puede encontrar en la ruta "+lbPath.Text
                    +"", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                xlWorkBook.Close(true, misValue, misValue); 
                excel.UserControl = false;
                excel.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(excel);

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                GC.Collect();
            }
        }

        void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (tooltxtBuscar.Text != "")
                {
                    FolderBrowserDialog result = new FolderBrowserDialog();
                    result.Description = "Eliga la carpeta";

                    DialogResult dirSelected = result.ShowDialog(this);

                    if (dirSelected == DialogResult.OK)
                    {

                        string nombreDir = result.SelectedPath;

                        DirectoryInfo di = new DirectoryInfo(nombreDir);

                        string nombreFile = tooltxtBuscar.Text + ".xlsx";
                        bool flag = false;

                        foreach (var fi in di.GetFiles())
                        {
                            if (nombreFile == fi.Name)
                            {
                                flag = true;
                                nombreFile = fi.FullName;

                                Excel.Application excel = new Excel.Application();
                                Excel.Workbook xlWorkBook = null;
                                xlWorkBook = excel.Workbooks.Open(nombreFile);
                                getCeldas(xlWorkBook);

                                xlWorkBook.Close();
                                excel.UserControl = false;
                                excel.Quit();


                                Marshal.ReleaseComObject(xlWorkBook);
                                Marshal.ReleaseComObject(excel);
                                xlWorkBook = null;
                                excel = null;

                            }
                        }
                        if (flag == false)
                        {
                            MessageBox.Show("El archivo no se encontro, asegurese de seleccionar la carpeta correcta o ingresar el nombre correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nombre del archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }
        void abrirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FolderBrowserDialog folderDlgt = new FolderBrowserDialog();
            folderDlgt.Description = "Eliga la carpeta";
            DialogResult result = folderDlgt.ShowDialog();

            lbPath.Text = folderDlgt.SelectedPath;
        }
        bool isXLS(string extension)
        {
            bool flag = false;
            if (extension == ".xls" || extension == ".xlsx")
            {
                flag = true;
                return flag;
            }
            return flag;
        }

        void abrirArchivo()
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path;
                    path = openFileDialog1.FileName;

                    if (isXLS(Path.GetExtension(openFileDialog1.FileName).ToLower()))
                    {                        

                        txtFileName.Text = openFileDialog1.SafeFileName;
                        lbPath.Text = path;
                        Excel.Application excel = new Excel.Application();
                        Excel.Workbook xlWorkBook = null;
                        xlWorkBook = excel.Workbooks.Open(path);
                        getCeldas(xlWorkBook);

                        xlWorkBook.Close();
                        excel.UserControl = false;
                        excel.Quit();


                        Marshal.ReleaseComObject(xlWorkBook);
                        Marshal.ReleaseComObject(excel);
                        xlWorkBook = null;
                        excel = null;
                    }
                    else
                    {
                        MessageBox.Show("El archivo no es un archivo tipo xls/xlsx.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getCeldas(Excel.Workbook xlWorkBook)
        {
            string day, moth, year;
            string no, pag;
            string hijo, padre, madre, padrino;
            string fechaB;
            string dia, mes, anio;

            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];

            day = xlWorkSheet.Range["B14"].Value.ToString();
            txtDia.Text = day;

            moth = xlWorkSheet.Range["D14"].Value.ToString();
            txtMes.Text = moth;

            year = xlWorkSheet.Range["F14"].Value.ToString();
            txtAnio.Text = year;

            no = xlWorkSheet.Range["F10"].Value.ToString();
            txtNo.Text = no;

            pag = xlWorkSheet.Range["G10"].Value.ToString();
            txtPag.Text = pag;

            hijo = xlWorkSheet.Range["C16"].Value.ToString();
            txtHijo.Text = hijo;

            padre = xlWorkSheet.Range["C18"].Value.ToString();
            txtPadre.Text = padre;

            madre = xlWorkSheet.Range["C20"].Value.ToString();
            txtMadre.Text = madre;

            padrino = xlWorkSheet.Range["C22"].Value.ToString();
            txtPadrino.Text = padrino;

            fechaB = xlWorkSheet.Range["D24"].Value.ToString();
            txtFechaB.Text = fechaB;

            dia = xlWorkSheet.Range["E31"].Value.ToString();
            txtDC.Text = dia;

            mes = xlWorkSheet.Range["F31"].Value.ToString();
            txtMC.Text = mes;

            anio = xlWorkSheet.Range["G31"].Value.ToString();
            txtAnioC.Text = anio;

            Marshal.ReleaseComObject(xlWorkSheet);
          
        }
        void inserta(Excel.Worksheet xlWorkSheet)
        {
            //Escribimos en las celdas
            xlWorkSheet.Cells[3, 2] = "Nuestra Señora de Guadalupe";//B3
            xlWorkSheet.Cells[4, 2] = "Morelos # 35";//B4
            xlWorkSheet.Cells[5, 2] = "Col. Manuel López Cotilla, Tlaq.";//B5
            xlWorkSheet.Cells[7, 3] = "Pbro. Víctor Ramírez Flores";//C7
            xlWorkSheet.Cells[8, 3] = "Nuestra Señora de Guadalupe";//C8
            xlWorkSheet.Cells[10, 6] = txtNo.Text;//F10
            xlWorkSheet.Cells[10, 7] = txtPag.Text;//G10
            xlWorkSheet.Cells[12, 4] = "        Sr. Cura Víctor Ramírez Flores ";//D12
            xlWorkSheet.Cells[14, 2] = txtDia.Text;//B14
            xlWorkSheet.Cells[14, 4] = txtMes.Text;//D14
            xlWorkSheet.Cells[14, 6] = txtAnio.Text;//F14
            xlWorkSheet.Cells[16, 3] = "        " + txtHijo.Text;//C16
            xlWorkSheet.Cells[18, 3] = txtPadre.Text;//C18
            xlWorkSheet.Cells[20, 3] = txtMadre.Text;//C20
            xlWorkSheet.Cells[22, 3] = txtPadrino.Text;//C22
            xlWorkSheet.Cells[23, 3] = "Nuestra Señora de Guadalupe";//C23
            xlWorkSheet.Cells[24, 4] = txtFechaB.Text;//D24
            xlWorkSheet.Cells[31, 2] = "Manuel López Cotilla, Tlaq., Jal.";//B31
            xlWorkSheet.Cells[31, 5] = txtDC.Text;//E31
            xlWorkSheet.Cells[31, 6] = txtMC.Text;//F31
            xlWorkSheet.Cells[31, 7] = txtAnioC.Text;//G31
            xlWorkSheet.Cells[33, 2] = ".";//B33
            xlWorkSheet.Cells[40, 5] = "                   Pbro. Víctor Ramírez Flores ";//E40
        }

        void formato(Excel.Worksheet xlWorkSheet) {
            //Cambiamos el tipo de letra y tamaño de las celdas
            xlWorkSheet.Range["A2"].RowHeight = 90.75;

            xlWorkSheet.Range["A1"].ColumnWidth = 12.57;
            xlWorkSheet.Range["B1"].ColumnWidth = 16.86;

            xlWorkSheet.Range["B3"].Font.Size = 9;
            xlWorkSheet.Range["B3"].Font.Name = "Calibri";
            xlWorkSheet.Range["B3"].RowHeight = 16.50;

            xlWorkSheet.Range["B4"].Font.Size = 9;
            xlWorkSheet.Range["B4"].Font.Name = "Calibri";
            xlWorkSheet.Range["B4"].RowHeight = 18;

            xlWorkSheet.Range["B5"].Font.Size = 9;
            xlWorkSheet.Range["B5"].Font.Name = "Calibri";
            xlWorkSheet.Range["B5"].RowHeight = 15;

            xlWorkSheet.Range["B6"].RowHeight = 21;

            xlWorkSheet.Range["C7"].Font.Size = 16;
            xlWorkSheet.Range["C7"].Font.Name = "Calibri";
            xlWorkSheet.Range["C7"].RowHeight = 21;

            xlWorkSheet.Range["C8"].Font.Size = 14;
            xlWorkSheet.Range["C8"].Font.Name = "Calibri";
            xlWorkSheet.Range["C8"].RowHeight = 18.75;

            xlWorkSheet.Range["F10"].Font.Size = 11;
            xlWorkSheet.Range["F10"].Font.Name = "Calibri";
            xlWorkSheet.Range["F10"].RowHeight = 15;
            xlWorkSheet.Range["F10"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            xlWorkSheet.Range["F11"].RowHeight = 13.5;

            xlWorkSheet.Range["G10"].Font.Size = 11;
            xlWorkSheet.Range["G10"].Font.Name = "Calibri";
            xlWorkSheet.Range["G10"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Range["D12"].Font.Size = 14;
            xlWorkSheet.Range["D12"].Font.Name = "Calibri";
            xlWorkSheet.Range["D12"].RowHeight = 18.75;

            xlWorkSheet.Range["B13"].RowHeight = 30;

            xlWorkSheet.Range["B14"].Font.Size = 11;
            xlWorkSheet.Range["B14"].Font.Name = "Calibri";
            xlWorkSheet.Range["B14"].RowHeight = 15;
            xlWorkSheet.Range["B14"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Range["F14"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Range["A15"].RowHeight = 9;

            xlWorkSheet.Range["C16"].Font.Bold = true;
            xlWorkSheet.Range["C16"].Font.Size = 13;
            xlWorkSheet.Range["C16"].Font.Name = "Calibri";
            xlWorkSheet.Range["C16"].RowHeight = 17.25;

            xlWorkSheet.Range["A17"].RowHeight = 8.25;

            xlWorkSheet.Range["C18"].Font.Size = 14;
            xlWorkSheet.Range["C18"].Font.Name = "Calibri";
            xlWorkSheet.Range["C18"].RowHeight = 18.75;

            xlWorkSheet.Range["A19"].RowHeight = 12.75;

            xlWorkSheet.Range["C20"].Font.Size = 14;
            xlWorkSheet.Range["C20"].Font.Name = "Calibri";
            xlWorkSheet.Range["C20"].RowHeight = 18.75;

            xlWorkSheet.Range["A21"].RowHeight = 7.5;

            xlWorkSheet.Range["C22"].Font.Size = 14;
            xlWorkSheet.Range["C22"].Font.Name = "Calibri";
            xlWorkSheet.Range["C22"].RowHeight = 18.75;

            xlWorkSheet.Range["C23"].Font.Size = 14;
            xlWorkSheet.Range["C23"].Font.Name = "Calibri";
            xlWorkSheet.Range["C23"].RowHeight = 22.50;

            xlWorkSheet.Range["D24"].Font.Size = 11;
            xlWorkSheet.Range["D24"].Font.Name = "Calibri";
            xlWorkSheet.Range["D24"].RowHeight = 24;

            xlWorkSheet.Range["A25"].RowHeight = 21;
            xlWorkSheet.Range["A30"].RowHeight = 5.25;

            xlWorkSheet.Range["F31"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Range["E31"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            xlWorkSheet.Range["E40"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            xlWorkSheet.Range["A42"].RowHeight = 18.75;
        }

        void toolStripBtnLimpiar_Click(object sender, EventArgs e)
        {
            txtAnio.Clear();
            txtAnioC.Clear();
            tooltxtBuscar.Clear();
            txtDC.Clear();
            txtDia.Clear();
            txtFechaB.Clear();
            txtHijo.Clear();
            txtMadre.Clear();
            txtMC.Clear();
            txtMes.Clear();
            txtNo.Clear();
            txtPadre.Clear();
            txtPadrino.Clear();
            txtPag.Clear();
            txtFileName.Clear();
        }

    }
}