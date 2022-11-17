using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryMamondezIEFI
{
    internal class clsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la base
        private OleDbCommand Comando = new OleDbCommand();
        //Objeto para adaptar los datos de la base
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Gimnasio1.accdb";
        //Nombre de tabla a llamar
        private string Tabla = "Actividad";
        public void ListarActividad(ComboBox combo)
        {
            try
            {
                //Conectar a la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrimos la BD
                conexion.Open();
                //Conectar el comando a la BD
                Comando.Connection = conexion;
                //Traemos la tabla
                Comando.CommandType = CommandType.TableDirect;
                //selecciona la tabla
                Comando.CommandText = Tabla;//Nombre tabla
                                            //conectamos adaptador a la bd, traemos los datos y los subimos a la tabla
                adaptador = new OleDbDataAdapter(Comando);
                //Tabla virtual
                DataSet ds = new DataSet();
                adaptador.Fill(ds, Tabla);
                //llenamos grilla
                combo.DataSource = ds.Tables[Tabla];
                combo.DisplayMember = "Detalle";
                combo.ValueMember = "Codigo_Actividad";
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        public string Buscar(Int32 CodigoActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                Comando.Connection = conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader Lector = Comando.ExecuteReader();
                string Actividad = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            Actividad = Lector.GetString(1);
                        }
                    }
                }
                conexion.Close();
                return Actividad;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}     