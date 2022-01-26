using System;
using System.Data.SqlClient;
using Model;

namespace Data{


    public class VideosBanco
    {

        public void InsereNovoVideo(Videos video)
        {
            Banco banco = new Banco();
            string SQLString = $"INSERT INTO Videos (titulo, descricao, url) values ('{video.Titulo}', '{video.Descricao}', '{video.Url}');"; 

            try
            {   
                SqlConnection connection = new SqlConnection(banco.conexao_string);
                SqlCommand comandoSQl = new SqlCommand(SQLString, connection);
                connection.Open();
                comandoSQl.CommandTimeout = 0;
                comandoSQl.ExecuteScalar();
                System.Console.WriteLine("Video inserido!");
            } 
            catch (Exception e)
            {
                throw e;
            }     
        }
    }
}