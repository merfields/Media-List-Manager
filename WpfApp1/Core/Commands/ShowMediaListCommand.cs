using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MVVM;
using WpfApp1.MVVM.ViewModel;

namespace WpfApp1.Core.Commands
{
    public class ShowMediaListCommand<TEntity> : CommandBase where TEntity : Media
    {
        private MediaListViewModel mediaListViewModel;

        public ShowMediaListCommand(MediaListViewModel mediaListVM)
        {
            this.mediaListViewModel = mediaListVM;
        }

        public override void Execute(object? parameter)
        {
            var tags = parameter as string;
            ObservableCollection<TEntity> mediaCollectionWithTags = Media.GetMediaWithTags<TEntity>(tags);
            mediaListViewModel.MediaList = mediaCollectionWithTags;
        }
    }
}
