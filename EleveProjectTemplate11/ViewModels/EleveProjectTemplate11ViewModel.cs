using System;
using System.Windows.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;
using EleveProjectTemplate11.Models;

namespace EleveProjectTemplate11.ViewModels
{
    public class EleveProjectTemplate11ViewModel : ViewModelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public EleveProjectTemplate11ViewModel()
        {
            BindingOperations.EnableCollectionSynchronization(_Items1, new object());
            BindingOperations.EnableCollectionSynchronization(_Items2, new object());
            BindingOperations.EnableCollectionSynchronization(_Items3, new object());
        }
        /// <summary></summary>
        public List<Item> Originals = new List<Item>();
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Item> _Items1 = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items1
        {
            get { return _Items1; }
            set { SetProperty(ref _Items1, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Item> _Items2 = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items2
        {
            get { return _Items2; }
            set { SetProperty(ref _Items2, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Item> _Items3 = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items3
        {
            get { return _Items3; }
            set { SetProperty(ref _Items3, value); }
        }
    }
}
