using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNotificationSample
{
    class User
    {
        private string name;
        public string Name 
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                }
            }
        }

    }
}
