using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using WpfApp1.Core;
using System.Collections.Specialized;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Core.Commands;

namespace WpfApp1.MVVM.ViewModel
{
    public class MediaListViewModel : ObservableObject
    {
        private List<string> statusList = new List<string> { "Completed", "Wishlist", "In progress" };
        public List<string> StatusList
        {
            get
            {
                return statusList;
            }
            set
            {
                statusList = value;
                OnPropertyChanged(nameof(StatusList));
            }
        }

        private List<int> ratingList = new List<int> { 1, 2, 3, 4, 5 };
        public List<int> RatingList
        {
            get
            {
                return ratingList;
            }
            set
            {
                ratingList = value;
                OnPropertyChanged(nameof(RatingList));
            }
        }

        private INotifyCollectionChanged mediaList;
        public INotifyCollectionChanged MediaList
        {
            get
            {
                return mediaList;
            }
            set
            {
                mediaList = value;
                OnPropertyChanged(nameof(MediaList));
            }
        }

        public CommandBase DeleteMediaCommand { get; set; }
        public CommandBase EditTableEntryCommand { get; set; }

        public MediaListViewModel()
        {
            DeleteMediaCommand = new DeleteMediaCommand(this);
            EditTableEntryCommand = new EditTableEntryCommand();

            using (ManagerContext managerContext = new ManagerContext())
            {
                MediaList = Media.GetMediaWithTags<Game>(null);
            }
        }
    }
}
