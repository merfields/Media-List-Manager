using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WpfApp1.Core;
using System.Collections.Specialized;

namespace WpfApp1.MVVM
{
    public abstract class Media : ObservableObject
    {
        protected int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        protected string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        protected string genre;
        public string Genre
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

        protected int? score;
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

        protected List<string>? tags;
        public List<string>? Tags
        {
            get
            {
                return tags;
            }
            set
            {
                tags = value;
                OnPropertyChanged(nameof(Tags));
            }
        }

        public Media(string title = "Title not specifyed", string genre = "Genre not specifyed", int? score = 0, List<string>? tags = null)
        {
            this.title = title;
            this.genre = genre;
            this.score = score;
            this.tags = tags;
        }

        public static ObservableCollection<TEntity> GetMediaWithTags<TEntity>(string tags) where TEntity : Media
        {
            IOrderedQueryable<TEntity> selectedRows;
            using (ManagerContext managerContext = new ManagerContext())
            {
                DbSet<TEntity> dbset = managerContext.Set<TEntity>();

                if (tags != null)
                {
                    selectedRows = from s in dbset
                                   where s.Tags.Contains(tags)
                                   orderby s.Title
                                   select s;
                }
                else
                {
                    selectedRows = from s in dbset
                                   orderby s.Title
                                   select s;
                }
                var listOfMediaWithTags = new ObservableCollection<TEntity>(selectedRows);
                return listOfMediaWithTags;
            }
        }

        public static void AddMediaToDb<TEntity>(TEntity mediaToAdd) where TEntity : Media
        {
            using (ManagerContext managerContext = new ManagerContext())
            {
                DbSet<TEntity> dbset = managerContext.Set<TEntity>();
                dbset.Add(mediaToAdd);
                managerContext.SaveChanges();
            }
        }

        public static void DeleteMediaFromDb<TEntity>(TEntity mediaToDelete) where TEntity : Media
        {
            using (ManagerContext managerContext = new ManagerContext())
            {
                DbSet<TEntity> dbset = managerContext.Set<TEntity>();
                dbset.Remove(mediaToDelete);
                managerContext.SaveChanges();
            }
        }

        public static void EditEntityById<TEntity>(TEntity changedMedia) where TEntity : Media
        {
            using (ManagerContext managerContext = new ManagerContext())
            {
                DbSet<TEntity> dbset = managerContext.Set<TEntity>();

                TEntity entityToChange = (from s in dbset
                                          where s.Id == changedMedia.Id
                                          select s).First();
                entityToChange.Genre = changedMedia.Genre;
                entityToChange.Score = changedMedia.Score;
                entityToChange.Tags = changedMedia.Tags;
                if (changedMedia is Game)
                {
                    (entityToChange as Game).Developer = (changedMedia as Game).Developer;
                }
                managerContext.SaveChanges();
            }
        }
    }
}
