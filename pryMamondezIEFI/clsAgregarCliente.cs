using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryMamondezIEFI
{
    internal class clsAgregarCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la base
        private OleDbCommand Comando = new OleDbCommand();
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Gimnasio1.accdb";
        private string Tabla = "Principal";

        //estas variables privadas son las que interactuan en la clase
        private Int32 DniSocio;
        private string NombreyApellido;
        private string Direccion;
        private Int32 CodigoBarrio;
        private Int32 Actividad;
        private Decimal Saldo;
        private Int32 Edad;

        //estas variables publicas interactuarian con el formulario
        public Int32 Dni
        {
            //el get retorna la variable
      
            get { return DniSocio; }
            set { DniSocio = value; }
            //trae la variable desde el formulario
        }

        public string NyA
        {
            get { return NombreyApellido; }
            set { NombreyApellido = value; }
        }

        public string Direc
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public Int32 Barrio
        {
            get { return CodigoBarrio; }
            set { CodigoBarrio = value; }
        }


        public Int32 Act
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        public Int32 EdadCliente
        {
            get { return Edad; }
            set { Edad = value; }             
        }

        public Decimal Monto
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public void Agregar()
        {
            try
            {
                string AgregarCliente = "INSERT INTO Principal ([Dni_Socio], [Nombre_Apellido], [Direccion], [Codigo_Barrio], [Actividad], [Saldo], [Edad])" +
                    "VALUES ('" + DniSocio + "','" + NombreyApellido + "','" + Direccion + "','" + CodigoBarrio + "','" + Actividad + "','" + Saldo + "','" + Edad +"')";
                //Conecto la base de datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                //El comando toma la conexion
                Comando.Connection = conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = AgregarCliente;
                Comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron registrarse");
            }
        }
        public void Buscar(Int32 DNI)
        {
            try
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
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay registros ingresa
                if (Lector.HasRows)
                {
                    //Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == DNI)
                        {
                            DniSocio = Lector.GetInt32(0);
                            NombreyApellido = Lector.GetString(1);
                            Direccion = Lector.GetString(2);
                            CodigoBarrio = Lector.GetInt32(3);
                            Actividad = Lector.GetInt32(4);
                            Saldo = Lector.GetDecimal(5);
                            Edad = Lector.GetInt32(6);
                        }
                    }
                }
                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no se encontraron");
            }
        }
        public void Modificar(Int32 Cliente)
        {
            try
            {
                string Modificar = "UPDATE Principal SET Nombre_Apellido='" + NyA + "', Actividad= " + Act + ", Codigo_Barrio=" + Barrio + ", Edad=" + Edad +", Saldo=" + Monto + " WHERE [Dni_Socio] =" + Cliente + "";
                //Conecto la base de datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                //El comando toma la conexion
                Comando.Connection = conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Modificar;
                Comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Los datos no se pueden modificar");
            }
        }
        //Elimina al socio de la BD

        public void Eliminar(Int32 Cliente)
        {
            try
            {
                //Creo la variable para eliminar los datos en la Base de datps
                string eliminar = "DELETE FROM Principal WHERE (" + Cliente + "= [Dni_Socio])";
                conexion.ConnectionString = CadenaConexion; //ruta de acceso
                conexion.Open(); //Abrimos la conexion
                Comando.Connection = conexion; //Establemos conexion
                Comando.CommandType = CommandType.Text; //Trae el texto
                Comando.CommandText = eliminar; //Toma la variable eliminar
                Comando.ExecuteNonQuery(); //Modifica los campos de la tabla
                conexion.Close(); //Cierra la conexion
                MessageBox.Show("Datos borrados con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
