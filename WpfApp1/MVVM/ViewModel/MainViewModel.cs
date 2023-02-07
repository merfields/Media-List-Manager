using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Core;
using WpfApp1.Core.Commands;
using WpfApp1.Core.Commands.TitleBarCommands;

namespace WpfApp1.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private Window mainWindow;
        #region "Main window parameters"

        public int ResizeBorderNumber { get; set; } = 7;

        public Thickness ResizeBorderThickness
        {
            get
            {
                return new Thickness(ResizeBorderNumber);
            }
        }

        public int CaptionHeight { get; set; } = 10;

        public int GlassFrameThickness { get; set; } = 0;


        #endregion

        #region "VM's and Commands"

        public MediaListViewModel MediaListVM { get; set; }
        public AddMediaViewModel AddMediaVM { get; set; }
        public CommandBase OpenAddMediaWindowCommand { get; set; }
        public CommandBase ShowGamesListCommand { get; set; }
        public CommandBase ShowAnimeListCommand { get; set; }
        public CommandBase ShowMoviesListCommand { get; set; }

        public CommandBase CloseWindowCommand { get; set; }
        public CommandBase MinimizeWindowCommand { get; set; }


        private ObservableObject _currentViewModel;
        public ObservableObject CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainViewModel(Window mainWindow)
        {
            this.mainWindow = mainWindow;
            MediaListVM = new MediaListViewModel();
            AddMediaVM = new AddMediaViewModel(MediaListVM);
            OpenAddMediaWindowCommand = new OpenAddMediaWindowCommand(MediaListVM);

            CloseWindowCommand = new CloseWindowCommand(mainWindow);
            MinimizeWindowCommand = new MinimizeWindowCommand(mainWindow);

            using (ManagerContext managerContext = new ManagerContext())
            {
                ShowGamesListCommand = new ShowMediaListCommand<Game>(MediaListVM);
                ShowAnimeListCommand = new ShowMediaListCommand<Anime>(MediaListVM);
                ShowMoviesListCommand = new ShowMediaListCommand<Movie>(MediaListVM);
            }

            CurrentViewModel = MediaListVM;

        }


    }
}
