using System;
using System.Collections.Generic;
using System.Text;

namespace LogitechPvt.Ltd
{
    //inherted mainboard
    class MidLayer: MainBoard
    {
        //private variables
        private int scrollWheel34N,scrollWheel14N,ledLight, wire,screw;
        // MainBoard private Method Variables
        private int baseCover, wheelAssembly;
        public MidLayer()
        {
        }
        ~MidLayer()
        {


        }
        //property of scroll134n and scrollwheel14N
        public int Scrollwheel34N_a
        {
            get
            {
                return scrollWheel34N;
            }
            set
            {
                this.scrollWheel34N = value;
            }
        }
        public int Scrollwheel14N_a
        {
            get
            {
                return scrollWheel14N;
            }
            set
            {
                this.scrollWheel14N = value;
            }
        }
        public int GetLedLight()
        {
            
            return ledLight;
        }
        public int GetWire()
        {

            return wire;
        }
        //using (this) key word to access the private varibles
        public void SetLedLightAndWire(int ledLight,int wire)
        {
            this.ledLight = ledLight;

            this.wire=wire;



        }

        //Main Board Abstract  Method
        //setMain boarditems method overloaded and overriden

        public override void SetMainBoardItems(int baseCover, int wheelAssembly, int screw)
        {
            this.baseCover = baseCover;
            this.wheelAssembly = wheelAssembly;
            this.screw = screw;
        }

        public override void SetMainBoardItems(int baseCover,int wheelAssembly)
        {
            this.baseCover= baseCover;
            this.wheelAssembly= wheelAssembly;
        }
        public override int GetMainBoardItemBaseCover()
        {

            return this.baseCover ;
        }
        public override int GetMainBoardItemWheelAssembly()
        {

            return this.wheelAssembly;
        }
        public override int GetMainBoardItemScrew()
        {

            return this.screw;
        }
        //get the values for mid layer
        public void GetValuesForMidLayer()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter the Quantity of SCROLLWHEEL34N-->");
            Scrollwheel34N_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of SCROLLWHEEL14N-->");
            Scrollwheel14N_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of LED LIGHT-->");
            ledLight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of WIRE-->");
            wire = Convert.ToInt32(Console.ReadLine());

            SetLedLightAndWire(ledLight, wire);
        }
        //get the values for  Main board
        public void GetValuesForMainBoard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the Quantity of BASE COVER-->");
           int baseCover1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of WHEEL ASSEMBLY-->");
           int wheelAssembly1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of WHEEL SCREW-->");
           int screw1 = Convert.ToInt32(Console.ReadLine());
            SetMainBoardItems(baseCover1, wheelAssembly1, screw1);
        }
    }
}
