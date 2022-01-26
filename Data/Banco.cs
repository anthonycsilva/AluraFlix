using System;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Banco{
        public string conexao_string { get; set; } = $"Server=ANTHONYWINDOWS;Database=AluraFlix;Trusted_Connection=True;";
    }
}