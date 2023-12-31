﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //limpar campos

        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbResultadoPesquisa.Items.Clear();
            txtDescricao.Focus();
            txtDescricao.Enabled = false;
        }

        public void pqspCod(int codigoCliente)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select*from tbclientes where codCli = " + codigoCliente + ";";
            comm.CommandType = CommandType.Text;
            comm.Connection = Connect.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbResultadoPesquisa.Items.Clear();


            ltbResultadoPesquisa.Items.Add(DR.GetString(1));

            Connect.fecharConexao();
        }

        public void pqspNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbClientes where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Connect.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbResultadoPesquisa.Items.Clear();

            while (DR.Read())
            {
                ltbResultadoPesquisa.Items.Add(DR.GetString(1));
            }

            Connect.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                txtDescricao.Focus();

            }
            else if (rdbNome.Checked && txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores para pesquisa",
                     "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                txtDescricao.Focus();

            }
            else 
            {
                if (rdbCodigo.Checked)
                {
                    pqspCod(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked)
                {
                    pqspNome(txtDescricao.Text);
                }
            }
            
               
            

        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void ltbResultadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resp = ltbResultadoPesquisa.SelectedItem.ToString();

            frmClientes abrir = new frmClientes(resp);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmClientes abrir = new frmClientes();
            abrir.Show();
            this.Hide();
        }

        private void lblResultadoPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void gpbPesquisar_Enter(object sender, EventArgs e)
        {

        }
    }
}
