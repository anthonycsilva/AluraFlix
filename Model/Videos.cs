using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using System.Data;
using System;

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

    }
}