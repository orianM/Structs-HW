using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*A struct is a type of object(like enum, interface, class etc..), struct inherits from ValueType,
              struct is saved in the stack unlike class which is saved in the heap.*/

            #endregion

            #region question 2

            /*Struct is used when we want to build a simple data structure that is lightweight.*/

            #endregion

            #region question 3

            /*Empty constructors are not allowed in structs, a struct ctor must have atleast 1 parameter.*/

            #endregion

            #region question 4

            /*using the "new" keyword when creating a struct isn't a must,
              because the struct -  is saved in the stack.*/

            #endregion

            #region question 5

            /*When not using the new keyword on a struct instance - all values will be unassigned.
              When using the new keyword on a struct instance - all values will be assigned default values*/

            #endregion

            #region question 6

            /*(1). A class can not inherit from a struct.
              (2). A struct can not inherit from a class.
              (3). A struct can not inherit from a struct.
              (4). A struct can not inherit from a struct.
              (5). A struct can implement from an interface.*/

            #endregion
        }
    }
}
