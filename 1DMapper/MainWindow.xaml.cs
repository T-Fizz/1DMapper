using Newtonsoft.Json;
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
using System.IO;


namespace _1DMapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Beatmap bm = new Beatmap(100, "songpath", "diffAuthor", 0);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveMap();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveMap();
        }

        private void AddNoteButton_Click(object sender, RoutedEventArgs e)
        {
            Note n = new Note(float.Parse(timeBox.Text), int.Parse(xBox.Text), int.Parse(yBox.Text),
                trailUpBox.IsChecked ?? false, trailDownBox.IsChecked ?? false,
                trailLeftBox.IsChecked ?? false, trailRightBox.IsChecked ?? false);
            bm.addNote(n);
        }

        private void SaveMap()
        {
            var path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\map");
            var bmPath = path + @"\beatmap.json";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(bmPath))
            {
                File.Create(bmPath);
            }
            string json = JsonConvert.SerializeObject(bm, Formatting.Indented);
            System.IO.File.WriteAllText(bmPath, json);
        }
    }
}
