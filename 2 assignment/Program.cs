using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_assignment
{
    class Branch
    {
        //After creating this object, we can add new Branch type objects into branches
        //variable.Doing so we increase object depth by one.Into created objects we can
        //add again new branches etc.In the figure below we have similar structure.This
        //structure depth is 5.

        void Main(string[] args)
        {
            List<Branch> branches;
            branches = new List<Branch>();

            branches.Add(new Branch());
            branches.Add(new Branch());
            branches.Add(new Branch());
            branches.Add(new Branch());
            branches.Add(new Branch());
            branches.Add(new Branch());


            Console.ReadKey();
        }
    }
}
