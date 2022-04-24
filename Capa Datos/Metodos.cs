using System;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class Metodos
    {
        private Conectar datos = new Conectar();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();


        //------------------------------------------Metodos de Entidades
        public DataTable consultar()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "consultar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;

        }

        public void agregar(string Matricula, string Nombre, string Apellidos, string Lengua_Espanola, string Historia, string Ingles, string Frances, string Naturales, string Matematicas, string Etica, string Contabilidad )
                {
                    String conec;
                    SqlConnection cnn;
                    conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
                    cnn = new SqlConnection(conec);
                    cnn.Open();

                    comando.Connection = cnn;
                    comando.CommandText = "INSERT into Estudiantes (Matricula, Nombre, " +
                    "Lengua_Espanola, Historia, Ingles, Frances, Naturales, Matematicas, Etica, Contabilidaad)";
                    comando.Parameters.AddWithValue("@Matricula", Matricula);
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Apellido", Apellidos);
                    comando.Parameters.AddWithValue("@Lengua_Espanola", Lengua_Espanola);
                    comando.Parameters.AddWithValue("@Historia", Historia);
                    comando.Parameters.AddWithValue("@Ingles", Ingles);
                    comando.Parameters.AddWithValue("@Frances", Frances);
                    comando.Parameters.AddWithValue("@Naturales", Naturales);
                    comando.Parameters.AddWithValue("@Matematicas", Matematicas);
                    comando.Parameters.AddWithValue("@Etica", Etica);
                    comando.Parameters.AddWithValue("@Contabilidad", Contabilidad);
                    comando.ExecuteNonQuery();

                    cnn.Close();
                }
        
        public void cambiar(int ID_Estudiante, string Matricula, string Nombre, string Lengua_Espanola, string Historia, string Ingles, string Frances, string Naturales, string Matematicas, string Etica, string Contabilidad)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();
            //Tipoentidad
            comando.Connection = cnn;
            comando.CommandText = "UPDATE Estudiantes SET Matricula = @Matricula,Nombre = @Nombre,Lengua_Espanola = @Lengua_Espanola,Historia = @Historia,Ingles = @Ingles,Frances = @Frances,Naturales = @Naturales,Matematicas = @Matematicas,Etica = @Etica,Contabilidad = @Contabilidad  WHERE ID_Estudiante = @ID_Estudiante";
            comando.Parameters.AddWithValue("@ID_Estudiante", ID_Estudiante);
            comando.Parameters.AddWithValue("@Matricula", Matricula);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Lengua_Espanola", Lengua_Espanola);
            comando.Parameters.AddWithValue("@Historia", Historia);
            comando.Parameters.AddWithValue("@Ingles", Ingles);
            comando.Parameters.AddWithValue("@Frances", Frances);
            comando.Parameters.AddWithValue("@Naturales", Naturales);
            comando.Parameters.AddWithValue("@Matematicas", Matematicas);
            comando.Parameters.AddWithValue("@Etica", Etica);
            comando.Parameters.AddWithValue("@Contabilidad", Contabilidad);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void Eliminar(int ID_Estudiante)
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "Eliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_Estudiante", ID_Estudiante);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            datos.cerrarConexion();
        }

        //------------------------------------------Metodos de GruposEntidades
        public DataTable gpConsultar()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "pConsultar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;
        }

        public void gpAgregar(string Nombre, string Clave, string Materia, string Telefono, string Correo, string Sueldo)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "INSERT into Profesores (Nombre,Clave,Materia,Telefono,Correo,Sueldo) values (@Nombre,@Clave,@Materia,@Telefono,@Correo,@Sueldo)";
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Clave", Clave);
            comando.Parameters.AddWithValue("@Materia", Materia);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Sueldo", Sueldo);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void gpCambiar(int ID_Profesor, string Nombre, string Clave, string Materia, string Telefono, string Correo, string Sueldo)
        {
            String conec;
            SqlConnection cnn;
            conec = "Server=DESKTOP-LVU63JL;DataBase=Escuela;Integrated Security=true";
            cnn = new SqlConnection(conec);
            cnn.Open();

            comando.Connection = cnn;
            comando.CommandText = "UPDATE Profesores SET Nombre = @Nombre,Clave = @Clave,Materia = @Materia,Telefono = @Telefono,Correo = @Correo,Sueldo = @Sueldo WHERE ID_Profesor = @ID_Profesor";
            comando.Parameters.AddWithValue("@ID_Profesor", ID_Profesor);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Clave", Clave);
            comando.Parameters.AddWithValue("@Materia", Materia);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@Sueldo", Sueldo);
            comando.ExecuteNonQuery();

            cnn.Close();
        }

        public void gpEliminar(int ID_Profesor)
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "pEliminar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_Profesor", ID_Profesor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            datos.cerrarConexion();
        }

        /*Consultar Director*/
        public DataTable consultard()
        {
            comando.Connection = datos.abrirConexion();
            comando.CommandText = "ConsultarD";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            datos.cerrarConexion();
            return tabla;

        }
    }
}
