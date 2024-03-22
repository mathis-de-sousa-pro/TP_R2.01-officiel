using System.Windows;
using TP;
using TP10.Logic;

namespace TP10;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private Zoo _zoo;

    public MainWindow()
    {
        InitializeComponent();
        _zoo = new Zoo();
        var list = _zoo.ListSpecies();
        foreach (var s in list)
            species.Items.Add(s);
        ListAnimals();
    }

    private void ListAnimals()
    {
        animals.Items.Clear();
        foreach (Animal a in _zoo.ListAnimals())
        {
            animals.Items.Add(a);
        }
    }

    private void AddAnimal(object sender, RoutedEventArgs e)
    {
        _zoo.AddAnimal(name.Text, species.SelectedItem.ToString());
        ListAnimals();
    }

    private void RemoveAnimal(object sender, RoutedEventArgs e)
    {
        if (animals.SelectedItem is Animal a)
        {
            _zoo.RemoveAnimal(a);
            ListAnimals();
        }
    }
}