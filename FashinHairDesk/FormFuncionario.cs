using FashionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashinHairDesk
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {
            var Cargos = Cargo.ObterPorLista();
            cmbCargo.DataSource = Cargos;
            cmbCargo.DisplayMember = "Cargos";
            cmbCargo.ValueMember = "Id";
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(

                txtNome.Text,
                txtRG.Text,
                txtCpf.Text,
                dtpDataNasc.Value,
                ckbAtivo.Checked,
                Cargo.ObterPorId(Convert.ToInt32(cmbCargo.SelectedValue))

            );
            funcionario.Inserir();
            if (funcionario.Id > 0)
            {
                txtId.Text = funcionario.Id.ToString();
                MessageBox.Show($"O Funcionario {funcionario.Nome}, foi gravado " +
                    $"com sucesso, com o ID {funcionario.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtRG.Clear();
                txtCpf.Clear();
                txtNome.Focus();
                FormTeste_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao Grava Funcionário!");
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Funcionario.ObterPorLista(nome);
            dgvFuncionarios.Rows.Clear();
            int cont = 0;
            foreach (var funcionario in lista)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[cont].Cells[0].Value = funcionario.Id;
                dgvFuncionarios.Rows[cont].Cells[1].Value = funcionario.Nome;
                dgvFuncionarios.Rows[cont].Cells[2].Value = funcionario.Rg;
                dgvFuncionarios.Rows[cont].Cells[3].Value = funcionario.Cpf;
                dgvFuncionarios.Rows[cont].Cells[4].Value = funcionario.Data_Nasc;
                dgvFuncionarios.Rows[cont].Cells[5].Value = funcionario.Ativo;
                dgvFuncionarios.Rows[cont].Cells[6].Value = funcionario.Id_Cargo.Cargos;

                cont++;
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
