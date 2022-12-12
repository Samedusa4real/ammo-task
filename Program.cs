Console.WriteLine("1.FIRE!");
Console.WriteLine("2.SPRAY!");
Console.WriteLine("3.RELOAD!");
Console.WriteLine("4.AMOUNT OF BULLETS!");
Console.WriteLine("5.EXIT!");
Console.WriteLine("--------------CHOOSE--------------");
int ammo = 30;


while (ammo > 0)
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










//while (true)
//{
//    string number = Console.ReadLine();

//    while (number == "")
//    {
//        Console.WriteLine("Duzgun reqem daxil edin");
//        string NewNumber = Console.ReadLine();
//        number = NewNumber;
//    }

//    int num = int.Parse(number);

//    CheckNum(num);


//    if (num == 1)
//    {

//        if (ammo > 0)
//        {
//            ammo--;
//            Console.WriteLine("Gulle atildi");
//        }
//        else
//        {
//            Console.WriteLine("3 bassaraq gulle doldur");
//        }


//    }
//    else if (num == 2)
//    {
//        if (ammo > 0)
//        {
//            ammo = 0;
//            Console.WriteLine("Gulle hamisi atildi");
//        }
//        else
//        {
//            Console.WriteLine("3 bassaraq gulle doldur");
//        }
//    }
//    else if (num == 3)
//    {
//        ammo = 30;
//        Console.WriteLine("Gulle dolduruldu");
//    }
//    else if (num == 4)
//    {
//        Console.WriteLine("Oyundan cixildi");
//        return;
//    }
//    else if (num == 5)
//    {
//        Console.WriteLine(ammo + " gulleniz var");
//    }
//}


//static void CheckNum(int check)
//{

//    while (check < 1 || check > 5)
//    {
//        Console.WriteLine("Duzgun reqem daxil edin");
//        int NewNum = int.Parse(Console.ReadLine());
//        check = NewNum;
//    };
//}




