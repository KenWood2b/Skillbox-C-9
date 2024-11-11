using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepDiveintoOOPPart1ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите пользователя: 1 - Консультант, 2 - Менеджер");
            string choice = Console.ReadLine();
            Client client = new Client("Иванов", "Иван", "Иванович", "123-456", "1234 567890");

            if (choice == "1")
            {
                Consultant consultant = new Consultant();
                consultant.ViewClientInfo(client);

                Console.WriteLine("Введите новый номер телефона:");
                string newPhone = Console.ReadLine();
                consultant.UpdatePhoneNumber(client, newPhone, "Консультант");
                consultant.ViewClientInfo(client);
            }
            else if (choice == "2")
            {
                Manager manager = new Manager();
                Console.WriteLine("Создать нового клиента (Y/N)?");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.Write("Фамилия: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Отчество: ");
                    string middleName = Console.ReadLine();
                    Console.Write("Номер телефона: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Серия, номер паспорта: ");
                    string passportNumber = Console.ReadLine();

                    client = manager.AddClient(lastName, firstName, middleName, phoneNumber, passportNumber);
                }

                manager.ViewClientInfo(client);

                Console.WriteLine("Введите новые данные для клиента:");
                Console.Write("Фамилия: ");
                string newLastName = Console.ReadLine();
                Console.Write("Имя: ");
                string newFirstName = Console.ReadLine();
                Console.Write("Отчество: ");
                string newMiddleName = Console.ReadLine();
                Console.Write("Номер телефона: ");
                string newPhone = Console.ReadLine();
                Console.Write("Серия, номер паспорта: ");
                string newPassport = Console.ReadLine();

                manager.UpdateClientInfo(client, newLastName, newFirstName, newMiddleName, newPhone, newPassport, "Менеджер");
                manager.ViewClientInfo(client);
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
                Console.ReadKey();
            }
        }
    }
}
