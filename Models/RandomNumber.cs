using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Models
{
    public class RandomNumber
    {
        public int random;
        public RandomNumber()
        {
            Random randomNumber = new Random();
            int random = randomNumber.Next(1, 100);

            Console.WriteLine(random);



        }


    }
}
