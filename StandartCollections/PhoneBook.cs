using System.Collections;

namespace StandartCollections;

public class PhoneBook
{
    private Hashtable phoneBook = new Hashtable();

    public void addContact(string name, string phone)
    {
        if (name.Trim() == "")
        {
            Console.WriteLine("Нужно ввести имя!");
        }
        else
        {
            try
            {
                phoneBook.Add(name, phone);
                Console.WriteLine("Контакт добавлен:");
                Console.WriteLine($"Телефон {name}: {phone}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public void deleteContact(string name)
    {
        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
            Console.WriteLine($"Контакт {name} успешно удалён из телефонного справочника!");
        }
        else
        {
            Console.WriteLine("Контакта с таким именем нет в телефонном справочнике!");
        }
    }

    public void renameContact(string currentName, string newName)
    {
        if (phoneBook.ContainsKey(currentName))
        {
            string currentPhone = phoneBook[currentName].ToString();
            phoneBook.Remove(currentName);
            phoneBook.Add(newName, currentPhone);
            Console.WriteLine($"Контакт {currentName}->{newName} успешно изменён");
        }
        else
        {
            Console.WriteLine("Контакта с таким именем нет в телефонном справочнике!");
        }
    }

    public void changePhone(string name, string newPhone)
    {
        if (phoneBook.ContainsKey(name))
        {
            phoneBook[name] = newPhone;
            Console.WriteLine($"Телефон у контакта {name} успешно изменён");
        }
        else
        {
            Console.WriteLine("Контакта с таким именем нет в телефонном справочнике!");
        }
    }

    public void showContacts(string name = "")
    {
        if (this.phoneBook.Count == 0)
        {
            Console.WriteLine("Список контактов пуст!");
        }
        else
        {
            if (name == "")
            {
                Console.WriteLine("Список контактов:");
                foreach (var names in phoneBook.Keys)
                {
                    Console.WriteLine($"Имя - {names} | Телефон - {phoneBook[names]}");
                }
            }
            else
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"Телефон {name}: {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine("Контакта с таким именем нет в телефонном справочнике!");
                }
            }
        }
    }
}