using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyBlanket
{
    public class Dog
    {
        #region Instance
        private int _drool;
        private int _bark;
        private int _scream;


        #endregion

        #region Constructor
        public Dog(int drool, int bark, int scream)
        {
            _drool = drool;
            _bark = bark;
            _scream = scream;

            Console.WriteLine("FUckedup little creacher has arrived.");
        }
        #endregion

        #region Properties
        public int Drool
        { get { return _drool; }
          set { _drool = value; }

        }

        public int Bark
        { get { return _bark; } }

        public int Scream { get { return _scream; } }

        #endregion

        #region Method
        public string CommitDrool()
        {
            _drool = _drool - 1;
            return "Drool";
        }

        public string CommitScream()
        {
            _scream = _scream - 1;
            return "Scream";
        }
        public string CommitBark()
        {
            _bark = _bark - 1;
            return "Bark";
        }

        #endregion
    }
}
