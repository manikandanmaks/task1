using System;
using System.Collections.Generic;
using System.Text;

namespace LogitechPvt.Ltd
{
    //abstract class
    public abstract class MainBoard
    {
        //constructor
        public MainBoard()
        {
        }
        public MainBoard(int a)
        {
        }
        //destructor
        ~MainBoard()
        {


        }
        //absract methods
        public abstract void SetMainBoardItems(int baseCover, int wheelAssembly, int screw);
        public abstract void SetMainBoardItems(int baseCover, int wheelAssembly);
        public abstract int GetMainBoardItemBaseCover();
        public abstract int GetMainBoardItemWheelAssembly();
        public abstract int GetMainBoardItemScrew();

    }
}
