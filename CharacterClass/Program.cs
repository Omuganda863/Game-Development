
namespace CharacterClass;
class Alien
{
public string name;
public string sector;
public string abilities;
public int xp = 0;

public void powers(){
Console.WriteLine("My name is "+ name +" from the " + sector);
Console.WriteLine("Witness the the beauty of destruction!");
Console.WriteLine(name + " Uses "+ abilities);
xp ++;

}

}

class Program
{
    static void Main(string[] args)
    {

    Alien alien1 = new Alien ();
    alien1.name = "Xenomorph";
    alien1.sector = "Promethian Sector";
    alien1.abilities = "Telekinesis";

     alien1.powers ();

    Console.ReadKey();

    
    }
}
