namespace StandartCollections;

public static class PhoneBookConsoleManager
{
    public static void addContactConsole(PhoneBook phoneBook, string name, string phone)
    {
        if (phoneBook.addContact(name, phone))
        {
            Console.WriteLine("Контакт добавлен:");
            Console.WriteLine($"Телефон {name}: {phone}");
        }
        else
        {
            Console.WriteLine("Нужно ввести имя!");
        }
    }

    public static void deleteContactConsole(PhoneBook phoneBook, string name)
    {
        if (phoneBook.deleteContact(name))
        {
            Console.WriteLine($"Контакт {name} успешно удалён из телефонного справочника!");
        }
        else
        {
            Console.WriteLine("Контакта с таким именем нет в телефонном справочнике!");
        }
    } 
}