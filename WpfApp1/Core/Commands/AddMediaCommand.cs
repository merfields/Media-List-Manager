using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.MVVM;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.Core.Commands
{
    public class AddMediaCommand : CommandBase
    {
        private AddMediaViewModel viewModel;
        private MediaListViewModel mediaListViewModel;

        public override void Execute(object? parameter)
        {
            bool hasMediaBeenAdded = AddNewMedia();

            if (parameter != null && hasMediaBeenAdded)
            {
                Window windowToClose = (Window)parameter;
                SystemCommands.CloseWindow(windowToClose);
            }
        }

        public AddMediaCommand(AddMediaViewModel viewModel, MediaListViewModel mediaListViewModel)
        {
            this.viewModel = viewModel;
            this.mediaListViewModel = mediaListViewModel;
        }

        public bool AddNewMedia()
        {
            if (viewModel.MediaTitle == null || viewModel.Genre == null)
            {
                MessageBox.Show("Please, enter title and genre.", "Adding new media error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            List<string> newMediaTags = new List<string>();
            newMediaTags.Add(viewModel.Tag);

            switch (viewModel.MediaTypeName)
            {
                case "Anime":
                    Anime newAnime = new Anime(viewModel.MediaTitle, viewModel.Genre, viewModel.Score, newMediaTags);
                    Media.AddMediaToDb<Anime>(newAnime);
                    mediaListViewModel.MediaList = Media.GetMediaWithTags<Anime>(null);
                    break;
                case "Movie":
                    Movie newMovie = new Movie(viewModel.MediaTitle, viewModel.Genre, viewModel.Score, newMediaTags);
                    Media.AddMediaToDb<Movie>(newMovie);
                    mediaListViewModel.MediaList = Media.GetMediaWithTags<Movie>(null);
                    break;
                case "Game":
                    Game newGame = new Game(viewModel.MediaTitle, viewModel.Genre, viewModel.Score, newMediaTags, viewModel.Developer);
                    Media.AddMediaToDb<Game>(newGame);
                    mediaListViewModel.MediaList = Media.GetMediaWithTags<Game>(null);
                    break;
                default:
                    MessageBox.Show("Choose media type.", "Adding new media error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
            }
            return true;
        }
    }
}
