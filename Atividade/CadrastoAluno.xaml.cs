using Atividade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Atividade
{
    /// <summary>
    /// Lógica interna para CadrastoAluno.xaml
    /// </summary>
    public partial class CadrastoAluno : Window
    {
        public CadrastoAluno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                CPF = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Email = txtemail.Text,
                
            };

            string linha = $"{aluno.Nome};{aluno.CPF};{aluno.Telefone};{aluno.Email}";
            File.AppendAllText("Escolas.txt", linha + Environment.NewLine);
            MessageBox.Show("Aluno salvo com sucesso!");
            ListagemAluno listagemAluno = new ListagemAluno();
            listagemAluno.Show();
            this.Close();
        }
    }
}
