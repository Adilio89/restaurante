using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace restaurante
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string MySqlClientString =
            "server= localhost;Port=3306;" +
            "User Id = root; Database = bd_restaurante; " +
            "SSL Mode=0";
                
        private void btn_carregar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter
                        ("SELECT * FROM tb_produtos", conn);
            da.Fill(dt);
            dgvprodutos.DataSource = dt;
            dgvprodutos.Columns[0].Width = 150;
            dgvprodutos.Columns[1].Width = 400;
            dgvprodutos.Columns[2].Width = 100;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tb_produtos(codigo_produto, nome_produto, preco_produto)" +
                "VALUES ('" + txtcod_prod.Text + "','" + txtnome_prod.Text + "','" + txtpreco_prod.Text + "')";
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Produto Gravado Com Sucesso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnnovo_prod_Click(sender, e);
        }

        private void btnnovo_prod_Click(object sender, EventArgs e)
        {
            txtcod_prod.Clear();
            txtnome_prod.Clear();
            txtpreco_prod.Clear();
        }

        private void btnapagar_prod_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tb_produtos WHERE nome_produto '" + txtnome_prod.Text + "'";
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Produto excluido com sucesso", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double almoco = Convert.ToDouble(txtTotalAlmoco.Text);
            double bebida = Convert.ToDouble(txtTotalBebida.Text);
            double sobremesa = Convert.ToDouble(txtTotalSobremesa.Text);

            int qtdAlmoco = Convert.ToInt32(txtQtdAlmoco.Text);
            int qtdBebida = Convert.ToInt32(txtQtdBebida.Text);
            int qtdSobremesa = Convert.ToInt32(txtQtdSobremesa.Text);

            double totalAlmoco = almoco * qtdAlmoco;
            double totalBebida = bebida * qtdBebida;
            double totalSobremesa = sobremesa * qtdSobremesa;
            

            lblTotal.Text = (totalAlmoco + totalBebida + totalSobremesa).ToString("#,##0.00");
        }    

        private void cboalmoco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboalmoco.SelectedIndex == 0)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
                _ = Convert.ToDouble(txtTotalAlmoco.Text);
            }
            else if (cboalmoco.SelectedIndex == 1)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
            else if (cboalmoco.SelectedIndex == 2)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "22,00";
            }
            else if (cboalmoco.SelectedIndex == 3)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "22,00";
            }
            else if (cboalmoco.SelectedIndex == 4)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "22,00";
            }
            else if (cboalmoco.SelectedIndex == 5)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "26,00";
            }
            else if (cboalmoco.SelectedIndex == 6)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "18,00";
            }
            else if (cboalmoco.SelectedIndex == 7)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "18,00";
            }
            else if (cboalmoco.SelectedIndex == 8)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
            else if (cboalmoco.SelectedIndex == 9)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
            else if (cboalmoco.SelectedIndex == 10)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
            else if (cboalmoco.SelectedIndex == 11)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
            else if (cboalmoco.SelectedIndex == 13)
            {
                string almoco = cboalmoco.SelectedIndex.ToString();
                txtTotalAlmoco.Text = "20,00";
            }
        }

        private void cbobebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbobebida.SelectedIndex == 0)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "5,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 1)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "8,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 2)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "12,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 3)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "5,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 4)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "8,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 5)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "10,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 6)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "5,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 7)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "8,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 8)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "10,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }
            else if (cbobebida.SelectedIndex == 9)
            {
                string bebida = cbobebida.SelectedIndex.ToString();
                txtTotalBebida.Text = "7,00";
                _ = Convert.ToDouble(txtTotalBebida.Text);
            }

        }

        private void cbosobremesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbosobremesa.SelectedIndex == 0)
            {
                string sobremesa = cbosobremesa.SelectedIndex.ToString();
                txtTotalSobremesa.Text = "6,00";
                _ = Convert.ToDouble(txtTotalSobremesa.Text);
            }
            else if (cbosobremesa.SelectedIndex == 1)
            {
                string sobremesa = cbosobremesa.SelectedIndex.ToString();
                txtTotalSobremesa.Text = "6,00";
                _ = Convert.ToDouble(txtTotalSobremesa.Text);
            }
            else if (cbosobremesa.SelectedIndex == 2)
            {
                string sobremesa = cbosobremesa.SelectedIndex.ToString();
                txtTotalSobremesa.Text = "6,00";
                _ = Convert.ToDouble(txtTotalSobremesa.Text);
            }
            else if (cbosobremesa.SelectedIndex == 3)
            {
                string sobremesa = cbosobremesa.SelectedIndex.ToString();
                txtTotalSobremesa.Text = "6,00";
                _ = Convert.ToDouble(txtTotalSobremesa.Text);
            }
        }
    }
}
