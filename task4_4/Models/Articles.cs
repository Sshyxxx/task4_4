using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_4.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Time { get; set; }

        public Articles(string title, string text, string author, DateTime time)
        {
            Random random = new Random();
            Id = random.Next(1, 10000);
            Title = title;
            Text = text;
            Author = author;
            Time = time;
        }
    }
}
