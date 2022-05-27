using CommunityToolkit.Mvvm.ComponentModel;
using ForGuyOnGroup.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGuyOnGroup.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {
        #region Constructors
        public MainViewModel()
        {
            Models.Add(new Model1("Item1", new ObservableCollection<string> {"Item 1 collection 1", "Item 1 collection 2", "Item 1 collection 3" }));
            Models.Add(new Model1("Item2", new ObservableCollection<string> {"Item 2 collection 1", "Item 2 collection 2", "Item 2 collection 3" }));
            Models.Add(new Model1("Item3", new ObservableCollection<string> {"Item 3 collection 1", "Item 3 collection 2", "Item 3 collection 3" }));
            Models.Add(new Model1("Item4", new ObservableCollection<string> {"Item 4 collection 1", "Item 4 collection 2", "Item 4 collection 3" }));
        }
        #endregion Constructors
        #region Public properties
        public ObservableCollection<Model1> Models { get;} = new ObservableCollection<Model1>();
        #endregion Public properties
    }
}
