using System;
using LogitechPvt.Ltd;

namespace Logitech_Pvt.Ltd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //object creation for full body class

            FullBody FB = new FullBody();

            //get the values from users

            FB.GetValuesForFullBody();
            FB.GetValuesForMidLayer();
            FB.GetValuesForMainBoard();
            //print the values 
            FB.Display();
        }
    }
}