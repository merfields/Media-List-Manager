using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Core;
using WpfApp1.Core.Commands;

namespace WpfApp1.MVVM.ViewModel
{
    public class AddMediaViewModel : ObservableObject
    {
        private MediaListViewModel mediaListViewModel;

        public ICommand AddMediaCommand { get; }
        public ICommand CancelDialogCommand { get; }
        public AddMediaViewModel(MediaListViewModel mediaListViewModel)
        {
            CancelDialogCommand = new CancelDialogCommand();
            this.mediaListViewModel = mediaListViewModel;
            AddMediaCommand = new AddMediaCommand(this, this.mediaListViewModel);
        }

        private string mediaTitle;
        public string MediaTitle
        {
            get
            {
                return mediaTitle;
            }
            set
            {
                mediaTitle = value;
                OnPropertyChanged(nameof(MediaTitle));
            }
        }

        private string mediaTypeName;
        public string MediaTypeName
        {
            get
            {
                return mediaTypeName;
            }
            set
            {
                mediaTypeName = value;
                OnPropertyChanged(nameof(MediaTypeName));
            }
        }

        private string? genre;
        public string? Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
                OnPropertyChanged(nameof(Genre));
            }
        }

        private int? score;
        public int? Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                OnPropertyChanged(nameof(Score));
            }
        }

        private string? developer;
        public string? Developer
        {
            get
            {
                return developer;
            }
            set
            {
                developer = value;
                OnPropertyChanged(nameof(Developer));
            }
        }

        private string? tag;
        public string? Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
                OnPropertyChanged(nameof(Tag));
            }
        }
    }
}
