using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.MVVM.View;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.Core.Commands
{
    public class OpenAddMediaWindowCommand : CommandBase
    {
        private MediaListViewModel mediaListViewModel;

        public override void Execute(object? parameter)
        {
            Window newDialog = new AddMediaView()
            {
                Title = "Add Media Dialog",
                Width = 400,
                Height = 550,
                DataContext = new AddMediaViewModel(mediaListViewModel)
            };
            newDialog.ShowDialog();
        }

        public OpenAddMediaWindowCommand(MediaListViewModel mediaListViewModel)
        {
            this.mediaListViewModel = mediaListViewModel;
        }
    }
}
