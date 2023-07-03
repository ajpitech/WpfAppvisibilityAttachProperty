using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppvisibilityAttachProperty
{
    public class MainWindowViewModel:BaseViewModel
    {
        public bool MyVisibility { get; set; } = true;
        public ICommand ChangeVisibility { get; set; }
        public MainWindowViewModel()
        {
            ChangeVisibility = new RelayCommand(ChangeVisibilityClick);
        }

        private void ChangeVisibilityClick(object obj)
        {
            MyVisibility = !MyVisibility;
            OnPropertyChanged(nameof(MyVisibility));
                
        }
    }
}
