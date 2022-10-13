Random gen = new Random();

int hitRoll = gen.Next(25); //skadan du gör
int ehitRoll = gen.Next(26);//skadan din motståndare gör
int hp = 100; //ditt hp
int ehp = 100;// din motståndares hp
string name;//ditt namn
string op;//din opponents namn
string answer = "YES"; //while loop definition
while (answer == "YES"){ //while loop för att kunna spela flera gånger
System.Console.WriteLine("What is your name?");
name = Console.ReadLine();
System.Console.WriteLine("and who would you like to fight?");
op = Console.ReadLine();
hp= 100;//hp reset
    ehp = 100; //hp reset

while (hp > 0 && ehp > 0){
    
    System.Console.WriteLine("hit by pressing enter");
    Console.ReadLine();
    hitRoll = gen.Next(26);
    ehp -= hitRoll;
    ehitRoll = gen.Next(26);
    hp -= ehitRoll;
    System.Console.WriteLine($"{name} = {hp}");
    System.Console.WriteLine($"{op} = {ehp}");
    if (hitRoll >= 20){
        System.Console.WriteLine($"Critical Hit by {name}");
    }
    if (ehitRoll >= 20){
        System.Console.WriteLine($"Critical Hit by {op}");
    }
}

if(hp <= 0 && ehp > 0){
    System.Console.WriteLine($"{name} died");
}

if (ehp<=0 && hp > 0){
    System.Console.WriteLine($"{op} died");
}

if (hp <= 0 && ehp <= 0){
    System.Console.WriteLine("looks like a tie");
}

System.Console.WriteLine("Would you like to fight again? if so, type 'YES'"); //svara YES för att spela igen
answer = Console.ReadLine();
}

Console.ReadLine();