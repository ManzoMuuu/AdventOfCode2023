
using System.Text;
using Microsoft.VisualBasic;
using Object;
class LavaFacility{
    
    static void Main(string[] args){

        int sum= Constants.Reset, hashLabel,  i, operation=0, focalLength = 0;
        var watch = new System.Diagnostics.Stopwatch();
        string label; 
        IDictionary<int, Box> Boxes = new Dictionary<int, Box>();
       
       
        watch.Start();

        string[] splitted = Constants.Input.Split(',');

        foreach(string stringSplitted in splitted){
            label = "";
            char []charSplitted = stringSplitted.ToCharArray();
       
            foreach (var item in charSplitted){
                if (item == '=' || item == '-') {
                    operation = Function.AddOrRemove(item);
                }else if (item-'0' >= 0 && item-'0' <= 9  ){
                    focalLength = item -'0';
                } else {
                    label+= item;
                }
            }

            hashLabel = Function.HASHA(label);
    
            if(operation.Equals(Constants.Add)){
                if(!(Boxes.ContainsKey(hashLabel))) Boxes.Add(hashLabel, new Box());
                Boxes[hashLabel].AddLens(label, focalLength);
            }else if (operation.Equals(Constants.Remove)&& Boxes.ContainsKey(hashLabel)){
                
                Boxes[hashLabel].RemoveLens(label);
                if (Boxes[hashLabel].LensLength() == 0) Boxes.Remove(hashLabel);
            }


        }

        foreach(var kvp in Boxes){
             i = Constants.Reset;
            foreach(var list in kvp.Value.getList()){
                
                sum += Function.FocusingPower(kvp.Key, i, list.FocalLength);
                i++;
            }
        }
        
        
        
        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        Console.WriteLine(sum);

        
    }
}


