using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.Configuration;

namespace WpfApp1.MVVM
{
    public class Game : Media
    {
        public Game(string? title = null, string? genre = null, int? score = 0, List<string>? tags = null, String? developer = null) : base(title, genre, score, tags)
        {
            Developer = developer;
        }

        public string? Developer { get; set; }
    }
}
