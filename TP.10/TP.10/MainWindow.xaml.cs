using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
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
using TP10.Logic;

namespace TP10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Zoo zoo;

        public MainWindow()
        {
            InitializeComponent();
            zoo = new Zoo();
            var list = zoo.ListSpecies();
            foreach (string s in list)
                species.Items.Add(s);
            ListAnimals();
        }

        private void ListAnimals()
        {
            animals.Items.Clear();
            foreach(Animal a in zoo.ListAnimals())
            {
                animals.Items.Add(a);
            }
        }

        private void AddAnimal(object sender, RoutedEventArgs e)
        {
            zoo.AddAnimal(name.Text, species.SelectedItem.ToString());
            ListAnimals();
        }

        private void RemoveAnimal(object sender, RoutedEventArgs e)
        {
            if(animals.SelectedItem is Animal a)
            {
                zoo.RemoveAnimal(a);
                ListAnimals();
            }
        }

        /// <summary>
        /// Sauvegarde les animaux créés
        /// </summary>
        private void SaveAnimals(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                    using (FileStream stream = File.OpenWrite(saveFileDialog.FileName))
                {
                    DataContractJsonSerializer ser = new(typeof(Zoo));
                    ser.WriteObject(stream, this.zoo);
                }
            }
        }

        /// <summary>
        /// Charge les animaux sauvegardés
        /// </summary>
        /// <exception cref="FileNotFoundException">Lancé si le fichier n'existe pas</exception>
        private void LoadAnimals(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            if (openFileDlg.ShowDialog() == true)
            {
                using (FileStream file = File.OpenRead(openFileDlg.FileName))
                {
                    DataContractSerializer ser = new DataContractSerializer(typeof(Zoo));
                    zoo = ser.ReadObject(file) as Zoo;
                    ListAnimals();
                }
            }
        }
    }
}
