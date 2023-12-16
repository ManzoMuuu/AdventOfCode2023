
namespace Object{
     class Box{

        List<Lens> lenses = new List<Lens>() ;
        public List<Lens> getList(){
            return lenses;
        }
        


        //Aggiunge una lente alla scatola, controlla se esiste in caso cambia solo il valore della focale
        //altrimenti aggiunge una nuova lente in fondo alla lista 
        public void AddLens (string newLabel, int newFocalLength){
            if (lenses.Contains(new Lens{Label = newLabel})){
                lenses[lenses.IndexOf(new Lens{Label = newLabel})].FocalLength = newFocalLength;
            }else{
            lenses.Add(new Lens() {Label = newLabel, FocalLength = newFocalLength});
            }
        }

        public void RemoveLens (string newLabel){
            lenses.Remove(new Lens() {Label = newLabel});
        }

        public int LensLength (){
            return lenses.Count;
        }
    }

    internal class Lens
    {
        public string Label { get; set; }
        public int FocalLength { get; set; } 
        public int lensPosition { get; set; }


        // Override dei metodi equals e gethashcode per fare i confronti con con gli elementi dell'oggetto
        // il confronto in questo modo viene effettuato solo su lenslabel 
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Lens objAsLens = obj as Lens;
            if (objAsLens == null) return false;
            else return Equals(objAsLens);
        }
        public override int GetHashCode()
        {
            return Function.HASHA(Label);
        }
        public bool Equals(Lens other)
        {
            if (other == null) return false;
            return this.Label.Equals(other.Label);
        }
    }
}