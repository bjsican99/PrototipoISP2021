using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaVistaSeguridad;

namespace CapaModeloNavegador
{
    public class clsSentencias
    {
        clsConexion con = new clsConexion();
        clsVistaBitacora bit = new clsVistaBitacora();
        public int procInsertar(string tabla, string campo)
        {
            int codigo = 0;
            string sql = "SELECT MAX(" + campo + ") FROM " + tabla + " ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codigo = reader.GetInt16(0);
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo); }

            codigo++;
            return codigo;
        }


        public void procInsertarDatos(string tabla, List<string> lista, int aplicacion)
        {
            string sql = " INSERT INTO " + tabla + " VALUES (";
            string consulta = sql;
            int contador = lista.Count();
            int i = 1;
            foreach (var items in lista)
            {
                if (i != contador)
                {
                    try
                    {
                        //int 
                        int.Parse(items);
                        sql += " " + items + ", ";
                        consulta += " " + items + ", ";
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            //double
                            double.Parse(items);
                            sql += " " + items + ", ";
                            consulta += " " + items + ", ";
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                //DateTimePicker
                                DateTime.Parse(items);
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                            catch (Exception exx)
                            {
                                //string
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                i++;
            }

            string sqlMax = lista.Last();
            sql += " " + sqlMax + ") ";
            consulta += " " + sqlMax + ") ";
            bit.insert(consulta, aplicacion);

            try
            {

                OdbcCommand comm = new OdbcCommand(sql, con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -");

            }

        }

        public void procModificar(string tabla, List<string> campos, List<string> datos, int aplicacion)
        {
            int contador = datos.Count();
            string sqlInicio = "UPDATE " + tabla + " SET  ";
            string consulta = sqlInicio;
            int i = 1;
            while (i < contador)
            {
                if (i != (contador - 1))
                {
                    string campo = campos.ElementAt(i);
                    sqlInicio += " " + campo + " = ";
                    consulta += " " + campo + " = ";
                    string dato = datos.ElementAt(i);
                    sqlInicio += " '" + dato + "', ";
                    consulta += " " + dato + ", ";
                }
                else
                {
                    string campo = campos.ElementAt(i);
                    sqlInicio += " " + campo + " = ";
                    consulta += " " + campo + " = ";
                    string dato = datos.ElementAt(i);
                    sqlInicio += " '" + dato + "' ";
                    consulta += " " + dato + " ";
                }
                i++;
            }
            sqlInicio += " WHERE " + campos.ElementAt(0) + " = " + datos.ElementAt(0) + "; ";
            consulta += " WHERE " + campos.ElementAt(0) + " = " + datos.ElementAt(0) + "; ";
            bit.insert(consulta, aplicacion);
            try
            {
                OdbcCommand comm = new OdbcCommand(sqlInicio, con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -");

            }
        }

        public OdbcDataAdapter funcObtener(string tabla, string estado)
        {
            try
            {
                string sql = "SELECT * FROM " + tabla + " where " + estado + " = 1  ;";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }
        }

        public bool procEliminar(string tabla, string campo, string idTabla, string id, int aplicacion)
        {
            string sql = "UPDATE " + tabla + " SET " + campo + "=0 WHERE " + idTabla + "= " + id + " ";
            bit.insert(sql, aplicacion);
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader odbcDataReader = command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en Eliminar registro, revise los parametros \n -" + tabla + "\n -" + campo);
                return false;
            }

        }
        public string procTablas(string tabla)
        {
            string Mensaje = "";
            string sql = "SHOW TABLES";
            bool Señal = false;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0).Equals(tabla))
                    {
                        Console.WriteLine(reader.GetString(0));
                        Señal = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en Eliminar registro, revise los parametros \n -" + tabla + "\n -");
            }

            if (Señal)
            {
                Mensaje += "bien";
            }
            else {

                Mensaje += "La tabla: " + tabla + " no existe en la base de datos";
            }

            return Mensaje;
        }

        public List<string> procCampos(string tabla)
        {
            List<string> Campos = new List<string>();
            string sql = "SHOW columns from "+tabla;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos.Add(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en Eliminar registro, revise los parametros \n -" + tabla + "\n -");
            }
            return Campos;
        }


    }
}
