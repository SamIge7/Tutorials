﻿using PersonRepository.Factory;
using PersonRepository.Interface;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateData("Service");
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateData("CSV");
        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateData("SQL");
        }

        private void PopulateData(string repositoryType)
        {
            ClearListBox();
            IPersonRepository repository = RepositoryFactory.GetRepository(repositoryType);

            var people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
