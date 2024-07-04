using Binding_Test.ViewModels;

namespace Binding_Test.Pages;

public partial class MainPage : ContentPage
{
  private readonly MainVM _vm;
  public MainPage(MainVM vm)
  {
    InitializeComponent();

    _vm = vm;
    BindingContext = _vm;
  }
}
