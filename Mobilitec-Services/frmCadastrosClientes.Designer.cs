﻿
namespace Mobilitec_Services
{
    partial class frmCadastrosClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientesCadastros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesCadastros
            // 
            this.dgvClientesCadastros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClientesCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCadastros.Location = new System.Drawing.Point(3, 60);
            this.dgvClientesCadastros.Name = "dgvClientesCadastros";
            this.dgvClientesCadastros.Size = new System.Drawing.Size(795, 296);
            this.dgvClientesCadastros.TabIndex = 0;
            this.dgvClientesCadastros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientesCadastros_MouseDoubleClick);
            // 
            // frmCadastrosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.dgvClientesCadastros);
            this.Name = "frmCadastrosClientes";
            this.Text = "CadClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCadastros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesCadastros;
    }
}