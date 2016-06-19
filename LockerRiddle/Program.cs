using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockerRiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Locker[] lockers = GetLockers().ToArray();
            for (int i = 1; i <= 100; i++)
            {
                foreach (var currentLocker in lockers)
                {
                    if (currentLocker.IsDivisible(i))
                    {
                        currentLocker.FlipStatus();
                    }
                }
            }

            var opened = lockers.Where(l => l.IsOpen).ToList();
            foreach (var locker in opened)
            {
                Console.WriteLine(locker.Number);
            }
            Console.ReadLine();
        }

        private static List<Locker> GetLockers()
        {
            var lockers = new List<Locker>();
            for (int i = 1; i <= 100; i++)
            {
                var locker = new Locker(i);
                lockers.Add((locker));
            }
            return lockers;
        }
    }
}
