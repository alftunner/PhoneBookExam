using System.Collections;

namespace StandartCollections;

public class PhoneBook
{
    private Hashtable phoneBook = new Hashtable();

    public bool addContact(string name, string phone)
    {
        if (name.Trim() == "")
        {
            return false;
        }
        else
        {
            try
            {
                phoneBook.Add(name, phone);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public bool deleteContact(string name)
    {
        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
            return true;
        }
        return false;
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