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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Atividade
{
    /// <summary>
    /// Lógica interna para CadrastoCurso.xaml
    /// </summary>
    public partial class CadrastoCurso : Window
    {
        public CadrastoCurso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var curso = new Curso();
            {
                Nome = txtNomeCurs.Text;
                Descricao = txtDescricao.Text;
                Cordenador = txtCordenador.Text;
                Status = txtStatus.Text;
            };

            string linha = $"{curso.Nome};{curso.Descricao};{curso.Coordenador};{curso.Status}";
            File.AppendAllText("Escolas.txt", linha + Environment.NewLine);
            MessageBox.Show("Curso salvo com sucesso!");
            ListagemCurso listagemCurso = new ListagemCurso();
            listagemCurso.Show();
            this.Close();
        }
    }
}
