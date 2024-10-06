#nullable disable

// Backpack Class Assignment

// Backpack1
Backpack bluebackpack=new Backpack("Blue","small");
// Backpack2
Backpack redbackpack=new Backpack("Red","medium");
// Backpack3
Backpack greenbackpack=new Backpack("Green","large");

// Open blue backpack
bluebackpack.OpenBag();
bluebackpack.Putin("Lunch");
bluebackpack.Putin("Jacket");
// Close blue backpack
bluebackpack.CloseBag();
bluebackpack.OpenBag();
bluebackpack.Takeout("Jacket");
bluebackpack.CloseBag();

class Backpack{
    public string Colour{get;set;}
    public string Size{get;set;}
    public List<string> items{get;set;}
    public bool Open{get;set;}

    public Backpack(string colour,string size){
        this.Colour=colour;
        this.Size=size;
        this.items=new List<string>();
        this.Open=false;
    }

// Function to open backpack
    public void OpenBag(){
        // Check if the backpack is closed or not  
        if(Open == false ){    
            Open=true;
            Console.WriteLine(Colour+" backpack opened");

        }
        // If the backpack is already open
        else{  
            Console.WriteLine(Colour+" Backpack already opened");
        }
        
    }
    // Function to close bag
    public void CloseBag(){
        // Check if the backpack is closed or not
        if(Open == true){
            Open=false;
            Console.WriteLine(Colour+" backpack closed");
        }
        // If the backpack is already open
        else{   
            Console.WriteLine(Colour+" Backpack Arleady closed");
        }

    }

// Use a string to add items to backpack list
    public void Putin(string usrinput){ 
        // Check is bag is opened or not 
        if(Open == true){   
            items.Add(usrinput);
            Console.WriteLine(usrinput+" Added in "+Colour+" Backpack");
        }
        // Display message if bag is closed
        else{
            Console.WriteLine("Backpack is closed please open it to add the item");
        }
    }

// To check if the item is already in the list
    int index=0;

// Using a string to remove item from the backpack list
    public void Takeout(string userinput){
        if (Open == true){ 
            // Loop through each item in the list
            for(int i=0;i<items.Count;i++){
                if (items[i] == userinput){
                    // Remove the item if its in the list
                    items.Remove(items[i]);  
                    index=1;
                    Console.WriteLine(userinput+" taken out");
                }

            }

            if(index == 0){
                Console.WriteLine(userinput+" not present in backpack");
            }
            // Set the index to 0 for nect iteration
            index=0;
        }
        else{
            Console.WriteLine("Backpack is closed please open it to remove item");
        }
    }
}