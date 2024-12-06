//Steg 1/5
Book book1 = new("bajsbok", 30);
Book book2 = new("ijnsdga", 2);
Book book3 = new("skibidi toilet orgins", 765923473);

//steg 1
//book1.name = "bajsbok";
//book2.name = "bokis";
//book3.name = "ieurds";

//book1.pages = 15;
//book2.pages = 11;
//book1.pages = 5;


//steg 6
List<Rock> rockList = new();


string antal = "";
while (!int.TryParse(antal, out int h)){
    Console.WriteLine("Bestäm antal stenar: ");
    antal = Console.ReadLine();

    if (int.TryParse(antal, out int result) && result >= 0){
        for (int i = 0; i <= result; i++){
            Console.WriteLine($"Välj en vikt för sten {i + 1}: ");
            
            int w = Console.ReadLine();
            Rock rock = new();
        }
    }
}