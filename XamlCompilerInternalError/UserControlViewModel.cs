using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlCompilerInternalError
{
    public class UserControlViewModel
    {
        public UserControlViewModel(int x)
        {
        }

        public bool CanAdvance => true;

        public static UserControlViewModel DesignVM => new UserControlViewModel(3);
    }
}
