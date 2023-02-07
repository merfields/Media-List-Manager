using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace WpfApp1.MVVM
{
    public class Anime : Media
    {
        public Anime(string? title = null, string? genre = null, int? score = 0, List<string>? tags = null) : base( title, genre, score, tags)
        {
        }
    }
}
