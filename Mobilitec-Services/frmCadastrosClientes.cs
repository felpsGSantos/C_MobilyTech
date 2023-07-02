﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public partial class frmCadastrosClientes : Form
    {
        ClCadClientes ClCadClientes = new ClCadClientes();
        public frmCadastrosClientes()
        {
            InitializeComponent();
            dgvClientesCadastros.DataSource = ClCadClientes.BuscarTodos();
            ConfigurarGrade();
           

        }

        private void ConfigurarGrade()
        {
            dgvClientesCadastros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dgvClientesCadastros.DefaultCellStyle.Font = new Font("Arial", 9);

            dgvClientesCadastros.Columns["codCli"].HeaderText = "Código do cliente";
            dgvClientesCadastros.Columns["codCli"].ReadOnly = true;
            dgvClientesCadastros.Columns["codCli"].Width = 60;
            dgvClientesCadastros.Columns["codCli"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvClientesCadastros.Columns["codCli"].DefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;

            dgvClientesCadastros.Columns["nome"].HeaderText = "Nome";
            dgvClientesCadastros.Columns["nome"].Width = 300;
            dgvClientesCadastros.Columns["nome"].ReadOnly = true;

            dgvClientesCadastros.Columns["email"].HeaderText = "E-mail";
            dgvClientesCadastros.Columns["email"].Width = 380;
            dgvClientesCadastros.Columns["email"].ReadOnly = true;


        }
    }
}
