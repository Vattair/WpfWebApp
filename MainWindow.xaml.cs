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
using WpfWebApp.Data;
using WpfWebApp.Models;

namespace WpfWebApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WebAppContext context = new WebAppContext();
        public static DataGrid _postDataGrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            PostDataGrid.ItemsSource = context.Posts.ToList();
            _postDataGrid = PostDataGrid;
        }

        private void removePostBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PostDataGrid.SelectedItem as Post == null) return;
            int postID = (PostDataGrid.SelectedItem as Post).PostID;
            var deletePost = context.Posts.Where(p => p.PostID == postID).Single();
            context.Posts.Remove(deletePost);
            context.SaveChanges();
            PostDataGrid.ItemsSource = context.Posts.ToList();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTextBox.Text != null && firstnameTextBox.Text != null && lastnameTextBox.Text != null) DB.AddUser(usernameTextBox.Text, firstnameTextBox.Text, lastnameTextBox.Text);
        }

        private void AddCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (categorynameTextBox.Text != null) DB.AddCategory(categorynameTextBox.Text);
        }

        private void AddPostButton_Click(object sender, RoutedEventArgs e)
        {
            if (useridTextBox.Text != null && categoryidTextBox.Text != null && contentTextBox.Text != null) DB.AddPost(int.Parse(useridTextBox.Text), int.Parse(categoryidTextBox.Text), contentTextBox.Text);

            Load();
        }
    }
}
