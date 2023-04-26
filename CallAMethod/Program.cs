using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//KSI Msimango
namespace CallAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Get the first letter of the msg string using Substring()
                string msg = "Yabba dabba doo!";
                Math.Min(50, 24);
                Console.WriteLine(msg.Substring(0, 1));

                string designer = "Anders Hejlsberg";//find the index of the space (" ") in the string designer and store it in a variable indexOfSpace.
                int indexOfSpace = designer.IndexOf(" ");
                //Use Substring() and the variable indexOfSpace to get the second name. Store the returned value in a variable secondName.
                string secondName = designer.Substring(indexOfSpace);
                Console.WriteLine(secondName);//Print secondName to the console.

            }

        }
    }
}