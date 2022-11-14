using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    interface ILiveBirth
    {
        string BabyCalled();
    }
    class Animal
    {
    }
    class Cat : Animal, ILiveBirth
    {
        public string BabyCalled()
        {
            return "Ketten";
        }
    }
    class Dog : Animal, ILiveBirth
    {
        public string BabyCalled()
        {
            return "puppy";
        }
    }
    class Bird : Animal
    {

    }
}
