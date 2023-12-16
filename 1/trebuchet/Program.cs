// See https://aka.ms/new-console-template for more information

using System.Text;

class Trebuchet{
    static void Main(string[] args){
        int sum= Constants.Reset, currentNum,  i, count=0, focalLength = 0;
        string numberString;
        var watch = new System.Diagnostics.Stopwatch();

        foreach (string line in File.ReadLines(@"E:\Progetti\AdventOfCode\2023\AdventOfCode2023\1\trebuchet\input.dat", Encoding.UTF8)){
            char []charSplitted = line.ToCharArray();
            numberString="";
            for( i= 0; i<charSplitted.Length; i++){
                if(charSplitted[i]-'0' >= 0 && charSplitted[i]-'0' <= 9 ){
                    numberString += charSplitted[i];
                    i = charSplitted.Length;
                }
            }
            for( i= charSplitted.Length -1; i >= 0; i--){
                if(charSplitted[i]-'0' >= 0 && charSplitted[i]-'0' <= 9 ){
                    numberString += charSplitted[i];
                    i = -1;
                }
            }
            currentNum = Int32.Parse(numberString);
           
            count++;
            sum += currentNum;
            // process the line
        }
       
            
        
        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine(sum);

    }
}