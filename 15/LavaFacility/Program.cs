
using System.Text;
class LavaFacility{
    
    static void Main(string[] args){
        int sum= Constants.Reset;
        var watch = new System.Diagnostics.Stopwatch();
                    
        watch.Start();

        string[] splitted = Constants.Input.Split(',');

        foreach(string stringSplitted in splitted){



            sum += Function.HASHA(stringSplitted);


            
        }
        
        
        
        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine(sum);

        
    }
}


