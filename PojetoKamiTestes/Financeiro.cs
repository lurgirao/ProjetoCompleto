using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoKamiTestes
{
    public partial class Financeiro : Form
    {
        public static Financeiro Instancia;

        public Financeiro()
        {
            InitializeComponent();
            Instancia = this;
        }

        private void Financeiro_Load_1 (object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void AdicionarPedidoFinanceiro(PedidoFinanceiro pedido)
        {
            dataGridView1.Rows.Add(
                pedido.DataHora.ToString("dd/MM/yyyy HH:mm"),
                pedido.Numero,
                pedido.Total.ToString("F2"),
                pedido.FormaPagamento
            );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Financeiro_Load(object sender, EventArgs e)
        {

        }
    }
}

