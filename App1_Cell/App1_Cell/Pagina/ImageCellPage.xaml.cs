using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ImageCellPage : ContentPage
  {
    public ImageCellPage()
    {
      InitializeComponent();

      List<Funcionario> Lista = new List<Funcionario>();
      Lista.Add(new Funcionario() { Foto = "f1.jpg", Nome = "José", Cargo = "Presidente da EMpresa" });
      Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
      Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marqueting" });
      Lista.Add(new Funcionario() { Foto = "f2.jpg", Nome = "Felipe", Cargo = "Entregador" });
      Lista.Add(new Funcionario() { Foto = "f3.jpg", Nome = "João", Cargo = "Vendedor" });

      ListaFuncionario.ItemsSource = Lista;
    }
  }
}
