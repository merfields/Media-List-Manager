using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MVVM;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.Core.Commands
{
    class DeleteMediaCommand : CommandBase
    {
        MediaListViewModel viewModel;

        public override void Execute(object? parameter)
        {
            if (parameter is Game)
            {
                Media.DeleteMediaFromDb<Game>((Game)parameter);
                (viewModel.MediaList as ObservableCollection<Game>).Remove(parameter as Game);
            }
            else if (parameter is Movie)
            {
                Media.DeleteMediaFromDb<Movie>((Movie)parameter);
                (viewModel.MediaList as ObservableCollection<Movie>).Remove(parameter as Movie);
            }
            else if (parameter is Anime)
            {
                Media.DeleteMediaFromDb<Anime>((Anime)parameter);
                (viewModel.MediaList as ObservableCollection<Anime>).Remove(parameter as Anime);
            }
        }

        public DeleteMediaCommand(MediaListViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
