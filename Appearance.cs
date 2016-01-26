using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    abstract public class Appearance
    {
        public string haircolor;
        public string hairlength;

        public abstract string HairColor { get; set; }
        public abstract string HairLength { get; set; }

        public abstract string Breed();     // объявление абстрактного метода


        //protected string HairColor;
        //protected string HairLength;

        //public Appearance (string HairColor, string HairLength)   // конструктор с двумя параметрами
        //{
        //    this.HairColor = HairColor;
        //    this.HairLength = HairLength;
        //}

        //public abstract string PetAppearance();     // абстрактный метод

    }
}
