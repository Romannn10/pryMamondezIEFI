using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos 4 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Drawing;
using System.Drawing.Printing;

namespace pryMamondezIEFI.Resources
{
    internal class ClsClientes
    {

        public string varNombreMontoMayor = "";

        //Conectamos la Base de datos
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la base
        private OleDbCommand Comando = new OleDbCommand();
        //Objeto para adaptar los datos de la base
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Ruta de base de datos
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Gimnasio1.accdb";
        //Nombre de tabla a llamar
        private string Tabla = "Principal";
        private Int32 varCantidadClientes;
        private Decimal varPromedioSaldos;
        private Decimal varTotalSaldos;
        private Decimal varMontoMayor;
        //Con la variable privada vamos a interactuar en la base
        //con la variable publica interactuamos con el formulario
        public Int32 CantClientes
        {
            get { return varCantidadClientes; }
        }
        public Decimal PromSaldos
        {
            get { return varPromedioSaldos; }
        }
        public Decimal TotSaldos
        {
            get { return varTotalSaldos; }
        }
        public decimal MontoMayor
        {
            get { return varMontoMayor; }
        }
        public void Listar(DataGridView dgvDeudores)
        {
            //el try hace las operaciones y el catch devuelve los errores
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexion.ConnectionString = CadenaConexion;
                //Abre la conexion de la BD, es un canal
                conexion.Open();
                //Necesitamos mndar una orden para que nos traiga datos de la BD 
                //usamos el objeto comando
                //Indicamos la conexion que tiene que utilizar
                Comando.Connection = conexion;
                //Indicamos el tipo de comando
                //Trae una tabla el comando
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                //Es una tabla virtual que esta en la ram
                OleDbDataReader DR = Comando.ExecuteReader();
                dgvDeudores.Rows.Clear();
                varCantidadClientes = 0;
                varTotalSaldos = 0;
                varPromedioSaldos = 0;
                varMontoMayor = 0;
                clsActividad Actividad = new clsActividad();
                clsBarrio Barrio = new clsBarrio();
                string DActividad = "";
                string DBarrio = "";

                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {

                    //Mientras hayan datos para leer en el Datareader
                    while (DR.Read())
                    {
                        DActividad = Actividad.Buscar(DR.GetInt32(4));
                        DBarrio = Barrio.Buscar(DR.GetInt32(3));
                        //Añade filas a la grilla tomando las posiciones de los campos de la tabla clientes

                        dgvDeudores.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DBarrio, DActividad, DR.GetDecimal(5), DR.GetInt32(6));
                        varCantidadClientes++;
                        varTotalSaldos = varTotalSaldos + DR.GetDecimal(5);


                        if (DR.GetDecimal(5) > varMontoMayor)
                        {
                            varNombreMontoMayor = DR.GetString(1);
                            varMontoMayor = DR.GetDecimal(5);
                        }
                    }
                    varPromedioSaldos = varTotalSaldos / varCantidadClientes;
          
                }
                conexion.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

            }
        }
        public void ListarPorBarrio(DataGridView dgvListadoBarrios, Int32 CodigoBarrio)
        {
            //Conecto la base de datos
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            //El comando toma la conexion
            Comando.Connection = conexion;
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla
            Comando.CommandText = Tabla;
            OleDbDataReader Lector = Comando.ExecuteReader(); //el datareader toma el comando que lee la base de datos
            dgvListadoBarrios.Rows.Clear();
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            clsActividad activi = new clsActividad();
            string act = "";

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {

                    if (Lector.GetInt32(3) == CodigoBarrio)
                    {
                        act = activi.Buscar(Lector.GetInt32(4));
                        NombreBarrio = Barrios.Buscar(Lector.GetInt32(3));
                        dgvListadoBarrios.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), NombreBarrio, act, Lector.GetDecimal(5), Lector.GetInt32(6));
                    }
                }
            }
            conexion.Close();
        }

        public void GenerarReporte(PrintPageEventArgs Reporte)
        {
            try
            {
                Int32 Linea = 100;
                Font FuenteTexto = new Font("Calibri", 8, FontStyle.Italic);
                Font FuenteTitulo = new Font("Calibri", 20, FontStyle.Underline);
                Font FuenteSubTitulo = new Font("Calibri", 12, FontStyle.Bold);

                Reporte.Graphics.DrawString("Reporte de saldos", FuenteTitulo, Brushes.CadetBlue, 50, Linea - 70);
                Reporte.Graphics.DrawString("DNI", FuenteSubTitulo, Brushes.Blue, 50, Linea - 15);
                Reporte.Graphics.DrawString("Nombre", FuenteSubTitulo, Brushes.Blue, 150, Linea - 15);
                Reporte.Graphics.DrawString("Direccion", FuenteSubTitulo, Brushes.Blue, 250, Linea - 15);
                Reporte.Graphics.DrawString("Barrio", FuenteSubTitulo, Brushes.Blue, 350, Linea - 15);
                Reporte.Graphics.DrawString("Actividad", FuenteSubTitulo, Brushes.Blue, 450, Linea - 15);
                Reporte.Graphics.DrawString("Saldo", FuenteSubTitulo, Brushes.Blue, 550, Linea - 15);
                Reporte.Graphics.DrawString("Edad", FuenteSubTitulo, Brushes.Blue, 650, Linea - 15);

                conexion.ConnectionString = CadenaConexion; //Toma la ruta de acceso a la base
                conexion.Open(); //Abrimos la conexion
                Comando.Connection = conexion; //Establece la conexion con la BD
                //El tipo de comando es un acceso directo a una tabla
                Comando.CommandType = CommandType.TableDirect; //Establece la conexion con la BD
                Comando.CommandText = Tabla; //Selecciona la tabla
                adaptador = new OleDbDataAdapter(Comando); //Ejecutamos el comando
                clsBarrio ReporteBarrio = new clsBarrio();

                DataSet Data = new DataSet(); //Declaramos un DataSet
                adaptador.Fill(Data, Tabla); //Llenamos el data set

                if (Data.Tables[Tabla].Rows.Count > 0) //Si tiene filas
                {
                    //Sirve para hacer una repetitiva similar al for
                    //se mantiene dentro de un objeto, avanza y recorre el objeto
                    foreach (DataRow fila in Data.Tables[Tabla].Rows)
                    {
                        Reporte.Graphics.DrawString(fila["Dni_Socio"].ToString(), FuenteTexto, Brushes.Black, 50, Linea);
                        Reporte.Graphics.DrawString(fila["Nombre_Apellido"].ToString(), FuenteTexto, Brushes.Black, 150, Linea);
                        Reporte.Graphics.DrawString(fila["Direccion"].ToString(), FuenteTexto, Brushes.Black, 250, Linea);
                        Reporte.Graphics.DrawString(fila["Codigo_Barrio"].ToString(), FuenteTexto, Brushes.Black, 350, Linea);
                        Reporte.Graphics.DrawString(fila["Actividad"].ToString(), FuenteTexto, Brushes.Black, 450, Linea);
                        Reporte.Graphics.DrawString(fila["Saldo"].ToString(), FuenteTexto, Brushes.Black, 550, Linea);
                        Reporte.Graphics.DrawString(fila["Edad"].ToString(), FuenteTexto, Brushes.Black, 650, Linea);
                        Linea = Linea + 15;
                    }
                }
                conexion.Close(); //Cierra la conexion
                //Falta poner el total del balance
                //cantidad de clientes deudores
                //y deuda general
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    
    }
}
