using DataAccessLayer.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class DAL_Personas_SQL : IDAL_Personas
    {
       
        private string sqlConnection = "Data Source=DESKTOP-O6DTQ45\\ROOT; Initial Catalog=Practico3; User ID=sa; Password=1234;";
        public Persona AddPersona(Persona x)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PERSONAS VALUES(@nombre, @documento)", connection);
                {
                    cmd.Parameters.Add(new SqlParameter("nombre", x.Nombre));
                    cmd.Parameters.Add(new SqlParameter("documento", x.Documento));
                    connection.Open();

                    int result = cmd.ExecuteNonQuery();
                }   
            }

            return x;
        }

        public Persona Get(string documento)
        {
            Persona result = null;

            using (SqlConnection connection = new SqlConnection(sqlConnection))
            {
                string query = "SELECT Nombre, Documento FROM Personas WHERE Documento = @documento";
                SqlCommand com = new SqlCommand(query, connection);
                com.Parameters.AddWithValue("@documento", documento);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                if (Reader.Read())
                {
                    result = new Persona();

                    result.Documento = Reader["Documento"].ToString();
                    result.Nombre = Reader["Nombre"].ToString();

                    Console.WriteLine(result.Nombre);

                }
                else
                {
                    Console.WriteLine("no llegamos");
                }
            }

            return result;
        }

        public List<Persona> GetPersonas()
        {

            List<Persona> result = null;

            using (var connection = new SqlConnection(sqlConnection))
            {
                result = new List<Persona>();
                string query = "SELECT * FROM Persona";
                SqlCommand com = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader Reader = com.ExecuteReader();

                while (Reader.Read())
                {
                    if (result == null)
                    {
                        result = new List<Persona>();
                    }

                    Persona P = new Persona();

                    P.Documento = Reader["documento"].ToString();
                    P.Nombre = Reader["Nombre"].ToString();

                    result.Add(P);
                }

            }
            return result;
        }
    }
}
