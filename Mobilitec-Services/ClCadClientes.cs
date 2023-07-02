﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public class ClCadClientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

        public ClCadClientes() { }

        public ClCadClientes(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
        }

        public static DataTable BuscarTodos()


        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codCli, nome, email FROM tbClientes";
            comm.CommandType = CommandType.Text;

            

            var dt = new DataTable();

            try
            {
                MySqlConnection mySqlConnection = Connect.obterConexao();
                using (comm.Connection = mySqlConnection)
                {
                    if (comm.Connection.State == ConnectionState.Closed)
                    {
                        comm.Connection.Open();
                    }

                    using (var da = new MySqlDataAdapter(comm ))
                    { 
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }


    }

   
}
