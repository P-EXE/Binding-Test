using Binding_Test.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Binding_Test.ViewModels;

public partial class MainVM : ObservableObject
{
  private const int EntriesToGenerate = 5;
  public MainVM()
  {
    GenerateEntries(EntriesToGenerate);
  }

  [ObservableProperty]
  private ObservableCollection<MainModel> _entries = [];

  private void GenerateEntries(int amount)
  {
    for (int i = 0; i <= amount; i++)
    {
      MainModel model = new()
      {
        Name = $"Name {i}",
        Description = $"Description {i}"
      };

      Entries.Add(model);
    }
  }
}
