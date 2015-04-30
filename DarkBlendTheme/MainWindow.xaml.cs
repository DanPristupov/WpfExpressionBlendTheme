using System;
using System.Collections.Generic;
using System.Windows;

namespace DarkBlendTheme
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Users = new List<User>
            {
                new User {Id = 1, Name = "John", Birthday = new DateTime(1971, 7, 23)},
                new User {Id = 2, Name = "Jane", Birthday = new DateTime(1971, 1, 17)},
                new User {Id = 3, Name = "Mary", Birthday = new DateTime(1991, 10, 12)},
                new User {Id = 4, Name = "Simon", Birthday = new DateTime(1981, 9, 5)},
                new User {Id = 5, Name = "Ann", Birthday = new DateTime(1984, 7, 3)}
            };

            DataGrid.ItemsSource = Users;
        }

        public List<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
    }
}