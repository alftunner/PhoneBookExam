using StandartCollections;
using static System.Console;


PhoneBook myBook = new PhoneBook();

WriteLine("Пожалуйста введите ваше имя: ");
string name = ReadLine();

WriteLine($"Здавствуйте {name}");

int options = 1;
while (options != 0)
{
    WriteLine("--------------Пожалуйста выберите действие от 1 до 5----------------");
    Write("0 - Выход из программмы \t");
    Write("1 - Добавить контакты \t");
    WriteLine("2 - Показать список контактов ");
    Write("3 - Удалить контакт\t");
    WriteLine("4 - Переименовать контакт");
    WriteLine("5 - Изменить номер контакта");
    while (!Int32.TryParse(ReadLine(), out options) || (options > 5 || options < 0)) 
    {
        WriteLine("Ошибка! Пожалуйста выберите действие от 0 до 5 ");
    }
    switch (options)
    {
        case 0:
            WriteLine("Приходите к нам ещё!");
            break;
        case 1:
            WriteLine("Введите имя контакта:");
            string nameAddContact = ReadLine();
            WriteLine("Введите номер контакта:");
            string numberAddContact = ReadLine();
            PhoneBookConsoleManager.addContactConsole(myBook, nameAddContact, numberAddContact);
            break;
        case 2:
            myBook.showContacts();
            break;
        case 3:
            WriteLine("Введите имя контакта для удаления:");
            string nameDeleteContact = ReadLine();
            PhoneBookConsoleManager.deleteContactConsole(myBook, nameDeleteContact);
            break;
        case 4:
            WriteLine("Введите имя контакта который хотите переименовать:");
            string oldname = ReadLine();
            WriteLine("Введите новое имя контакта:");
            string newname = ReadLine();
            myBook.renameContact(oldname, newname);
            break;
        case 5:
            WriteLine("Введите имя контакта у которого хотите поменять номер:");
            string nameChangePhone = ReadLine();
            WriteLine("Введите новый номер:");
            string numberChangePhone = ReadLine();
            myBook.changePhone(nameChangePhone, numberChangePhone);
            break;
    }

    if (options != 0)
    {
        WriteLine("Хотите сделать что нибудь еще?");
        WriteLine("0 - закончить использование программы \t 1 - Выбрать новое действие");

        while (!Int32.TryParse(ReadLine(), out options) || (options != 0 && options != 1))
        {
            WriteLine("Ошибка! Выберите один из предложенных вариантов:\n1 - Выбрать новое действие \t 0 - закончить использование программы");
        }

        if (options == 0)
        {
            WriteLine("Хорошего дня");
        }    
    }
}


    


    
    
    
    
    
    







    



