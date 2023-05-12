using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WIKI_DST.Model;
using WIKI_DST.View;
using WIKI_DST.ViewModel.Helpers;

namespace WIKI_DST.ViewModel
{
    internal class PersonsViewModel : BindingHelper
    {
        #region Команды
        internal BindableCommand AddCommand { get; set; }
        #endregion

        private ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons 
        {
            get
            {
                return persons;
            }
            set
            {
                persons = value;
                OnPropertyChanged();
            }
        }

        private Person selected_person;
        public Person SelectedPerson
        {
            get { return selected_person; }
            set
            {
                selected_person = value;
                OnPropertyChanged();

                Pers pers = new Pers();
                pers.Show();
            }
        }


        public PersonsViewModel()
        {
            

            #region Добавка в лист
            MainViewModel mainViewModel = new MainViewModel();

            Person wilson = new Person();
            wilson.UserName.Text = mainViewModel.Wilson_inf.name;
            Uri WilsonImg = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Wilson_img.png");
            wilson.UserImage.Source = new BitmapImage(WilsonImg);

            Person willow = new Person();
            willow.UserName.Text = mainViewModel.Willow_inf.name;
            Uri WillowImg = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Willow_img.png");
            willow.UserImage.Source = new BitmapImage(WillowImg);

            Person wolfgang = new Person();
            wolfgang.UserName.Text =mainViewModel.Wolfgang_inf.name;
            Uri WolfgangImg = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Wolfgang_img.png");
            wolfgang.UserImage.Source = new BitmapImage(WolfgangImg);

            persons.Add(wilson);
            persons.Add(willow);
            persons.Add(wolfgang);
            #endregion
        }


    }
}
