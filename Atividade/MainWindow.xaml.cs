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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Atividade
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListagemAlunos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListagemAluno listagemAluno = new ListagemAluno();
            listagemAluno.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadrastoAluno cadrastoAluno = new CadrastoAluno();
            cadrastoAluno.Show();
            this.Close();
        }

        private void irparacadastroescola(object sender, RoutedEventArgs e)
        {
            CadrastoEscola cadrastoEscola = new CadrastoEscola();
            cadrastoEscola.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListagemCurso listagemCurso = new ListagemCurso();
            listagemCurso.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CadrastoCurso cadrastoCurso = new CadrastoCurso();
            cadrastoCurso.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ListagemEscolas listagemEscolas = new ListagemEscolas();
            listagemEscolas.Show();
            this.Close(); 
        }
    }
}
