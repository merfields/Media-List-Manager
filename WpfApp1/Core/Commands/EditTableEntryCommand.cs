using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.MVVM;

namespace WpfApp1.Core.Commands
{
    public class EditTableEntryCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            if (parameter is Game)
            {
                Media.EditEntityById<Game>(parameter as Game);
            }
            else if (parameter is Movie)
            {
                Media.EditEntityById<Movie>(parameter as Movie);
            }
            else if (parameter is Anime)
            {
                Media.EditEntityById<Anime>(parameter as Anime);
            }

        }
    }
}
