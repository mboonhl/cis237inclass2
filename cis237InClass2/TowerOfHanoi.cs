using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("enter a number of  disks to use. Less than 5 is a good number.");
            string input = Console.ReadLine();
            int diskNumber = Int32.Parse(input);

            moveDisk(diskNumber, 'A', 'B', 'C');
        }

        private void moveDisk(int n, char source, char aux, char dest)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk from tower {0} to tower {1}", source , dest);
            }
            else
            {
                moveDisk(n-1, source, dest, aux);
                moveDisk(1, source, aux, dest);
                moveDisk(n-1, aux, source, dest);
            }
        }
    }
}
