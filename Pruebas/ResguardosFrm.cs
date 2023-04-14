using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Pruebas
{
    public partial class ResguardosFrm : Form
    {
        string rfc, nombrepdf;
        decimal importe;

        public ResguardosFrm()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            try
            {
                var Lst = ComboActivo(rfc);
                cbActivo.DataSource = Lst;
                cbActivo.DisplayMember = "Descripcion";
                cbActivo.ValueMember = "NoControlInv";
                cbActivo.Tag = "NoControlInv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private List<Activos> ComboActivo(string prfc)
        {
            using (PruebaEntities db = new PruebaEntities())
            {
                return db.Activos.Where(ac=>ac.RFC==prfc).ToList();
            }
        }

        private void txtrfc_TextChanged(object sender, EventArgs e)
        {
            rfc = txtrfc.Text;
            CargarCombo();
        }


        private List<Activos> BuscarImporte(string pCod)
        {
            try
            {
                using (PruebaEntities db = new PruebaEntities())
                {
                    return db.Activos.Where(us => us.NoControlInv == pCod).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                throw;
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            var activo = BuscarImporte(cbActivo.SelectedValue.ToString());
            foreach (var act in activo)
            {
                importe = act.ImporteIVA;

            }
            int indice_fila = dgvActivos.Rows.Add();
            DataGridViewRow fila = dgvActivos.Rows[indice_fila];
            fila.Cells["Codigo"].Value = cbActivo.SelectedValue;
            fila.Cells["Descripcion"].Value = cbActivo.Text;
            fila.Cells["Cantidad"].Value = txtcant.Text;
            fila.Cells["Unidad"].Value = txtunit.Text;
            fila.Cells["PrecioUnitario"].Value = importe;
            fila.Cells["Importe"].Value = importe * decimal.Parse(txtcant.Text);

            txtcant.Clear();
            txtunit.Clear();
        }

        private void ResguardosFrm_Load(object sender, EventArgs e)
        {
            dgvActivos.Columns.Add("Codigo", "Codigo");
            dgvActivos.Columns.Add("Descripcion", "Descripcion");
            dgvActivos.Columns.Add("Cantidad", "Cantidad");
            dgvActivos.Columns.Add("Unidad", "Unidad");
            dgvActivos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvActivos.Columns.Add("Importe", "Importe");
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            nombrepdf = DateTime.Now.ToString("ddMMyyyyHH")+ ".pdf";
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = nombrepdf;

            string paginahtml_texto = Properties.Resources.plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@Fecha",dtpFecha.Text);
            paginahtml_texto = paginahtml_texto.Replace("@NoRes", txtNoRes.Text);
            paginahtml_texto = paginahtml_texto.Replace("@Oficina", txtoffi.Text);
            paginahtml_texto = paginahtml_texto.Replace("@Dependencia", txtDepFor.Text);
            paginahtml_texto = paginahtml_texto.Replace("@1apellido", txtape1.Text);
            paginahtml_texto = paginahtml_texto.Replace("@2apellido", txtape2.Text);
            paginahtml_texto = paginahtml_texto.Replace("@nombre", txtnombres.Text);

            string filas = string.Empty;
            decimal total = 0;

            foreach (DataGridViewRow row in dgvActivos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Codigo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Unidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            paginahtml_texto = paginahtml_texto.Replace("@Filas", filas);
            paginahtml_texto = paginahtml_texto.Replace("@Total", total.ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using(StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
                
            }
            

        }
    }
}
