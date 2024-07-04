using Binding_Test.Models;
using System.Collections.ObjectModel;

namespace Binding_Test.Views;

public partial class MainView : ContentView
{
  public static readonly BindableProperty EntriesProperty = BindableProperty.Create(nameof(Entries), typeof(ObservableCollection<MainModel>), typeof(MainView));
  public ObservableCollection<MainModel> Entries
  {
    get => (ObservableCollection<MainModel>)GetValue(EntriesProperty);
    set => SetValue(EntriesProperty, value);
  }
  public MainView()
  {
    InitializeComponent();
  }
}