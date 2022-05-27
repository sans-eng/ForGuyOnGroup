using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGuyOnGroup.Models
{
    [ObservableObject]
    public partial class Model1
    {
        #region Private fields
        [ObservableProperty]
        private string _stringObject;
        [ObservableProperty]
        private ObservableCollection<string> _strings;
        #endregion Private fields

        #region Constructors
        public Model1(string stringObject, ObservableCollection<string> strings)
        {
            _stringObject = stringObject;
            _strings = strings;
        }
        #endregion Constructors
    }
}
