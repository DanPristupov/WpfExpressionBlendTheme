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

namespace DarkBlendTheme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var users = new List<User>
            {
                new User()
                {
                    Id = 1,
                    Name = "John Doe",
                    Birthday = new DateTime(1971, 7, 23),
                    ImageUrl = "http://www.wpf-tutorial.com/images/misc/john_doe.jpg"
                },
                new User() {Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17)},
                new User() {Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2)}
            };

            DataGrid.ItemsSource = users;
        }
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string ImageUrl { get; set; }
    }
}
