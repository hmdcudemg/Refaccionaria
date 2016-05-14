using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data; // 1. agregar referencia

namespace Refaccionaria
{
    public class manejadorBD
    {
        // atributos
        private string servidor;
        private string bd;
        private string usr;
        private string pwd;
        private MySqlConnection conexion;
        //constructor
        /// <summary>
        /// Inicializa los valores de la conexión a la BD
        /// </summary>
        /// <param name="servidor">Servidor al que se va a conectar</param>
        /// <param name="bd">Base de datos a la que se va a conectar</param>
        /// <param name="usr">Usuario</param>
        /// <param name="pwd">Contraseña</param>
        public manejadorBD(string servidor, string bd, string usr, string pwd)
        {
            // inicializar atributos
            this.servidor = servidor;
            this.bd = bd;
            this.usr=usr;
            this.pwd = pwd;
        }
        //metodos
        public string conectarse()
        {
            //retorna el resultado de la conexion
            string res="";
            // Configurar la cadena de conexion
            string cadcon="Server={0};Database={1};Uid={2};Pwd={3};";
            //asignar los valores a los marcadores de posicion
            cadcon=string.Format(cadcon,servidor,bd,usr,pwd);
            //instanciar un objeto de conexion
            conexion = new MySqlConnection(cadcon);
            try
            {
                //abrir conexion
                conexion.Open();
                res = "hecho";
            }
            catch(MySqlException ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public void desconectarse()
        {
            conexion.Close();
        }

        public DataTable consultar(string consulta)
        {
            DataTable t = new DataTable();
            try
            {
                conectarse();
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                da.Fill(t);
            }
            catch(MySqlException ex)
            {

            }
            finally
            {
                desconectarse();
            }
            return t;
        }

        public int ejecutar(string instruccion)
        {
            int res = 0;
            try
            {
                conectarse();
                MySqlCommand cmd = new MySqlCommand(instruccion, conexion);
                res=cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                desconectarse();
            }
            return res;
        }

    }
}