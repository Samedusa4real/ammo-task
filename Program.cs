Console.WriteLine("1.FIRE!");
Console.WriteLine("2.SPRAY!");
Console.WriteLine("3.RELOAD!");
Console.WriteLine("4.AMOUNT OF BULLETS!");
Console.WriteLine("5.EXIT!");
Console.WriteLine("--------------CHOOSE--------------");
int ammo = 30;


while (ammo > -1)
{
    string order = Console.ReadLine();
    switch (order)
    {
        case "1":
            if (ammo > 0)
            {
                ammo--;
                Console.WriteLine("PRRA!");
            }
            else
            {
                Console.WriteLine("CLICK 3 FOR RELOAD");
            }
            break;


        case "2":
            if (ammo > 0)
            {
                ammo = 0;
                Console.WriteLine("OUT OF BULLETS");
            }
            else
            {
                Console.WriteLine("CLICK 3 FOR RELOAD");
            }
            break;


        case "3":
            {
                ammo = 30;
                Console.WriteLine("RELOADING!");
            }
            break;


        case "4":
            {
                Console.WriteLine(ammo + " BULLETS YOU HAVE!");
            }
            break;

        case "5":
            {
                Console.WriteLine("QUITING...");
                return;
            }
            break;


        default:
            Console.WriteLine("GIVE THE CORRECT ORDER");
            break;
    }
}




