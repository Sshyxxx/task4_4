using task4_4.Models;
using System.Collections.Generic;

namespace task4_4.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() {

            News = [
              new("Новость 1", "Текст новости 1. Лол кек огурец.", "Гаврина Саша", System.DateTime.Today),
              new("Новость 2", "Текст новости 2. Лол кек огурец.", "Гаврина Саша", System.DateTime.Today),
              new("Новость 3", "Текст новости 3. Лол кек огурец.", "Гаврина Саша", System.DateTime.Today),
            ];

            Articles = [
              new("Статья 1", "Текст статьи 1.Как солить огурец.", "Марк Трент", System.DateTime.Today),
              new("Статья 2", "Текст статьи 2.Как жувать огурец.", "Марк Трент", System.DateTime.Today),
              new("Статья 3", "Текст статьи 3.Как пить расол.", "Ирина Ванс", System.DateTime.Today),
            ];
        }
        public List<News> News { get; set; }
        public List<Articles> Articles { get; set; }

    }

}
