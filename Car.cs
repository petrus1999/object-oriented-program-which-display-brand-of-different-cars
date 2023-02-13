using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_program_which_display_brand_of__different_cars
{
    class Car
    {
        string brand;

        // constructor
        Car(string theBrand)
        {
            brand = theBrand;
        }

        // copy constructor
        Car(Car c1)
        {
            brand = c1.brand;
        }
}
