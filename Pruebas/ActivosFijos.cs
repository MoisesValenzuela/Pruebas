using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
