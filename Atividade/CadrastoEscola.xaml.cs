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
    public partial class CadrastoEscola : Window
    {
        private object dataGridEscolas;

        public CadrastoEscola()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            var escola = new Escola
            {
                NomeFantasia = txtNomeFantasia.Text,
                RazaoSocial = txtRazaoSocial.Text,
                CNPJ = txtCNPJ.Text,
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text
            };

            string linha = $"{escola.NomeFantasia};{escola.RazaoSocial};{escola.CNPJ};{escola.Rua};{escola.Numero};{escola.Bairro};{escola.Cidade};{escola.Estado}";
            File.AppendAllText("Escolas.txt", linha + Environment.NewLine);
            MessageBox.Show("Escola salva com sucesso!");
            ListagemEscolas listagemEscolas = new ListagemEscolas();
            listagemEscolas.Show();
            this.Close();
        }


        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Foreground = Brushes.Gray;
            }
        }
    }
}
