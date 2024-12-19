string folderPath = @"C:\Data";
string fileName = "Poenimekiri.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppinglist = new List<string>();

if (File.Exists(filePath))
{
    List<string> myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"Loodi uus fail nimega {fileName}.");
    List<string> myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Lisa toode poe nimekirja (lisa) või välju rakendusest (välju):");
        string userChoise = Console.ReadLine();

        if (userChoise == "lisa")
        {
            Console.WriteLine("Lisa poe nimekirja:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else if (userChoise == "välju")
        {
            Console.WriteLine($"Tänud, et kasutasid minu rakendust, ootame sind jälle!");
            break;
        }
        else
        {
            Console.WriteLine("ei saanud käsust aru, proovi uuesti!");
        }
    }
    return userList;
    static void ShowItemsFromList(List<string> someList)
    {
        Console.Clear();

        int listLength = someList.Count;
        Console.WriteLine($"Sul on poenimekirjas {listLength} toodet.");

        int i = 1;

        foreach (string item in someList)
        {
            Console.WriteLine($"{i}. {item}");
            i++;
        }
    }
}

//static void ShowItemsFromList(List<string> someList)
//{
//    Console.Clear();

//    int listLength = someList.Count;
//    Console.WriteLine($"Sul on poenimekirjas {listLength} toodet.");

//    int i = 1;

//    foreach (string item in someList)
//    {
//        Console.WriteLine($"{i}. {item}");
//        i++;
//    }
//}