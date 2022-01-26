using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using System.Data;
using System;
using Context;

namespace Model{

    public class Videos{
        private int ID;
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        
        private string TITULO;
        public string Titulo
        {
            get { return TITULO; }
            set { TITULO = value; }
        }
        
        private string DESCRICAO;
        public string Descricao
        {
            get { return DESCRICAO; }
            set { DESCRICAO = value; }
        }
        
        private string URL;
        public string Url
        {
            get { return URL; }
            set { URL = value; }
        }
        
        public Videos(string titulo, string descricao, string url){
            Titulo = titulo;
            Descricao = descricao;
            Url = url;
        }


        public List<Videos> GetVideos(string QuerySQL){
            List<Videos> listaVideos = new List<Videos>();
            Banco bancoDeDados = new Banco();
            SqlConnection connection = new SqlConnection(bancoDeDados.conexao_string);
            try
            {
                SqlCommand comandoSQl = new SqlCommand(QuerySQL, connection);
                connection.Open();
                comandoSQl.CommandTimeout = 0;
                var dados = comandoSQl.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dados);

                foreach (DataRow video in dt.Rows)
                {
                    string video_id = video["id"].ToString();
                    string video_titulo = video["titulo"].ToString();
                    string video_descricao = video["descricao"].ToString();
                    string video_url = video["url"].ToString();
                    var novoVideo = new Videos(video_titulo, video_descricao, video_url);
                    listaVideos.Add(novoVideo);
                }

            }
            catch (System.Exception)
            {
                
                throw;
            }

            return listaVideos;
        }


    }
}