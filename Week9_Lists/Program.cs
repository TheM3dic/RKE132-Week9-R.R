string folderPath = @"E:\Data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();


if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{
    List<string> myShoppingList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add and item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter and item:");
            string userItem = Console.ReadLine();
            myShoppingList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye");
            break;
        }
    }
    return myShoppingList;
}

static void showItemsFromList (List<string> myItems)
{
    Console.Clear();

    int listLength = myItems.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in myItems)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}

