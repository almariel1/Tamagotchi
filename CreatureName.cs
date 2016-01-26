using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public class CreatureName
    {
        private string name;   // объявление закрытого поля
        public string Name      // объявление свойства
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
    }
}
