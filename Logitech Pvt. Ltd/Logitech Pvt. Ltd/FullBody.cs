using System;
using System.Collections.Generic;
using System.Text;

namespace LogitechPvt.Ltd
{   // inherited  midlayer
   sealed class FullBody:MidLayer
    {
        private int  splitCover,spring;
        public FullBody()
        {
        }
        ~FullBody()
        {

        }
        //get the values for full body
        public void GetValuesForFullBody()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the Quantity of SPLIT COVER-->");
            splitCover_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of SPRING-->");
            spring_a = Convert.ToInt32(Console.ReadLine());

        }
        public int splitCover_a
        {
            get
            {
                return splitCover;
            }
            set
            {
                this.splitCover = value;
            }
        }
        public int spring_a
        {
            get
            {
                return spring;
            }
            set
            {
                this.spring = value;
            }
        }
        //PRint the Values
        public void Display() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                               --------ITEM----------------Quantity---------");
            Console.WriteLine("                               |      splitCover     |        {0}           |", splitCover_a);
            Console.WriteLine("                               |      screw          |        {0}           |", GetMainBoardItemScrew());
            Console.WriteLine("                               |      spring         |        {0}           |", spring_a);
            Console.WriteLine("                               |      Scrollwheel34N |        {0}           |", Scrollwheel34N_a);
            Console.WriteLine("                               |      Scrollwheel14N |        {0}           |", Scrollwheel14N_a);
            Console.WriteLine("                               |      ledLight1      |        {0}           |", GetLedLight());
            Console.WriteLine("                               |      wire1          |        {0}           |", GetWire());
            Console.WriteLine("                               |      baseCover1     |        {0}           |", GetMainBoardItemBaseCover());
            Console.WriteLine("                               |      wheelAssembly1 |        {0}           |", GetMainBoardItemWheelAssembly());
            Console.WriteLine("                               ---------------------------------------------");
            Console.ReadKey();
        }
       
    }
}
