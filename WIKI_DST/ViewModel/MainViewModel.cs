using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WIKI_DST.Model;
using WIKI_DST.View;
using WIKI_DST.ViewModel.Helpers;

namespace WIKI_DST.ViewModel
{
    internal class MainViewModel
    {
        #region Команды
        public BindableCommand AddCommand { get; set; }
        #endregion

        public Persons Wilson_inf = new Persons();
        public Persons Willow_inf = new Persons();
        public Persons Wolfgang_inf = new Persons();

        public MainViewModel() 
        {
            AddCommand = new BindableCommand(_ => OpenWinPersMet());

            Zapoln();
            
        }
        public void OpenWinPersMet()
        {
            PersonsWindow personsWindow = new PersonsWindow();
            personsWindow.Show();
        }

        private void Zapoln()
        {
            #region Вилсон
            Wilson_inf.name = "Вилсон";
            Wilson_inf.opisanie = "Учёный-аристократ, пойманный Максвеллом и перенесённый в таинственный дикий мир.";
            Wilson_inf.health = 150;
            Wilson_inf.satiety = 150;
            Wilson_inf.mind = 200;
            Wilson_inf.skills = "+ Отращивает бороду, которая по кд согревает";
            #endregion

            #region Виллоу
            Willow_inf.name = "Виллоу";
            Willow_inf.opisanie = "Очень любит огонь. Чтобы открыть Уиллоу, игроку нужно 160 очков опыта (8 игровых дней, или же 1 час 4 минуты).";
            Willow_inf.health = 150;
            Willow_inf.satiety = 150;
            Willow_inf.mind = 120;
            Willow_inf.skills = "+ Появляется в мире с зажигалкой, на которой можно готовить пищу\n+ Появляется в мире с мишкой Берни, который помогает справляться с ужасами\n+ Имеет иммунитет к урону от огня\n+ Огонь добавляет 6.25 ед/мин";
            #endregion

            #region Вольфганг
            Wolfgang_inf.name = "Вольфганг";
            Wolfgang_inf.opisanie = "Циркач, который может прокачивать свою силу и дольше ее сохранять, когда не голодаед";
            Wolfgang_inf.health = 200;
            Wolfgang_inf.satiety = 200;
            Wolfgang_inf.mind = 200;
            Wolfgang_inf.skills = "+ Появляется в мире с гантелей\n+ У него есть шкала могучести\n+ Уникальные крафта для могучести\n- Сильнее хочет есть и сильнее боиться монстров с темнотой";
            #endregion
        }
    }
}
