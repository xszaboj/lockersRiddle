using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRiddle
{
    public class Locker
    {
        private readonly int _number;

        public Locker(int lockerNumber)
        {
            _number = lockerNumber;
            IsOpen = false;
        }

        public int Number {
            get { return _number;}
        }

        public bool IsOpen { get; private set; }

        public bool IsDivisible(int number)
        {
            if (_number%number == 0)
            {
                return true;
            }
            return false;
        }

        public void FlipStatus()
        {
            IsOpen = !IsOpen;
        }
    }
}
