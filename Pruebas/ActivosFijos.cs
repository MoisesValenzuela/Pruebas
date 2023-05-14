using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace Pruebas
{
    public class ActivosFijos
    {
        Conexion cn = new Conexion();

        public DataTable MostrarActivos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARTABLAACTIVOS", cn.LeerCadena());

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Actualizar(string noControl, string noControlMod, string descripcion, string importe, string cambios, string monitoreo, string rfc)
        {
            string consulta = "UPDATE Activos SET NoControlInv='" + noControlMod + "',Descripcion='" + descripcion + "',ImporteIVA=" + Decimal.Parse(importe) + ",Cambios='" + cambios + "',Monitoreo='" + monitoreo + "',RFC='" + rfc + "' WHERE NoControlInv='" + noControl + "'";

            SqlCommand comando = new SqlCommand(consulta, cn.LeerCadena());
            int cant = comando.ExecuteNonQuery();

            if (cant > 0)
            {
                MessageBox.Show("Registro Modificado");
            }
        }

        public DataTable Busqueda(string busqueda, string campo, string tipo)
        {
            string consulta = "";
            if (tipo == "decimal")
            {
                decimal busquedaDecimal = Decimal.Parse(busqueda);
                consulta = "SELECT * FROM Activos WHERE " + campo + "=" + busquedaDecimal;
            }
            else
            {
                consulta = "SELECT * FROM Activos WHERE " + campo + "='" + busqueda + "'";
            }

            SqlCommand comando = new SqlCommand(consulta, cn.LeerCadena());

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }

        public List<string> ConsultarCampos()
        {
            string consulta = ("SELECT * FROM Activos");

            SqlCommand comando = new SqlCommand(consulta, cn.LeerCadena());

            SqlDataReader lector = comando.ExecuteReader();
            DataTable esquema = lector.GetSchemaTable();

            List<string> campos = new List<string>();

            foreach (DataRow fila in esquema.Rows)
            {
                string nombreColumna = fila["ColumnName"].ToString();
                campos.Add(nombreColumna);
            }

            lector.Close();

            return campos;
        }

        public List<string> ConsultarTipos()
        {
            string consulta = ("SELECT * FROM Activos");

            SqlCommand comando = new SqlCommand(consulta, cn.LeerCadena());

            SqlDataReader lector = comando.ExecuteReader();
            DataTable esquema = lector.GetSchemaTable();

            List<string> tipos = new List<string>();

            foreach (DataRow fila in esquema.Rows)
            {
                string tipo = fila["DataTypeName"].ToString();
                tipos.Add(tipo);
            }

            lector.Close();

            return tipos;
        }
    }
}
