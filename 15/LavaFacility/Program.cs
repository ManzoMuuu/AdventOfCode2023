// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

class LavaFacility{
    static void Main(string[] args){
        // Display the number of command line arguments.
        string input = "rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7";
        int currentValue = 0;
        string[] splitted = input.Split(',');

        foreach(string stringSplitted in splitted){
            byte[] asciiBytes = Encoding.ASCII.GetBytes(stringSplitted);
            Console.WriteLine(asciiBytes[1]);

            foreach(byte asciiValue in asciiBytes){
                currentValue += 
            }
        }


        
    }
}


