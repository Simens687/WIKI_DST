using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WIKI_DST.Model;
using WIKI_DST.ViewModel.Helpers;

namespace WIKI_DST.ViewModel
{
    internal class PersViewModel : BindingHelper
    {

        public string name { get { return name; } set { name = value; OnPropertyChanged(); } }
        public string opisanie { get { return opisanie; } set { opisanie = value; OnPropertyChanged(); } }
        public string skills { get { return skills; } set { skills = value; OnPropertyChanged(); } }       
        public string health { get{ return health; } set { health = value; OnPropertyChanged(); } }
        public string satiety { get{ return satiety; } set { satiety = value; OnPropertyChanged(); } }
        public string mind { get{ return mind; } set { mind = value; OnPropertyChanged(); } }

        private Persons person = new Persons();

        public BitmapImage putImage { get { return putImage; } set { putImage = value; OnPropertyChanged(); } }

        public PersViewModel()
        {
            PersonsViewModel personsViewModel = new PersonsViewModel();
            MainViewModel mainViewModel = new MainViewModel();


            Uri put;

            switch (personsViewModel.SelectedPerson.UserName.Text)
            {
                case "Вилсон":
                    person = mainViewModel.Wilson_inf;
                    put = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Wilson_img.png");
                    putImage = new BitmapImage(put);
                    break;
                case "Виллоу":
                    person = mainViewModel.Willow_inf;
                    put = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Willow_img.png");
                    putImage = new BitmapImage(put);
                    break;
                case "Вольфганг":
                    person = mainViewModel.Wolfgang_inf;
                    put = new Uri("C:/Users/lolke/source/repos/WIKI_DST/WIKI_DST/Model/Images/Wolfgang_img.png");
                    putImage = new BitmapImage(put);
                    break;
            }

            name = person.name;
            opisanie = person.opisanie;
            health = "Здоровье: " + person.health.ToString();
            satiety = "Сытость: " + person.satiety.ToString();
            mind = "Рассудок: " + person.mind.ToString();
            skills = person.skills;
            
        }
    }
}
