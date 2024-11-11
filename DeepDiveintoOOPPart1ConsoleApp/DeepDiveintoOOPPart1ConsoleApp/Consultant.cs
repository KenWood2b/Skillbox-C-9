using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepDiveintoOOPPart1ConsoleApp
{
    public class Consultant : IEditable
    {
        public void ViewClientInfo(Client client)
        {
            Console.WriteLine("Фамилия: " + client.LastName);
            Console.WriteLine("Имя: " + client.FirstName);
            Console.WriteLine("Отчество: " + client.MiddleName);
            Console.WriteLine("Номер телефона: " + client.PhoneNumber);
            Console.WriteLine("Серия, номер паспорта: " + client.PassportNumber);
        }

        public void UpdatePhoneNumber(Client client, string newPhoneNumber, string editorType)
        {
            client.PhoneNumber = newPhoneNumber;
            client.UpdateModificationInfo("PhoneNumber", "Изменение", editorType);
            Console.WriteLine("Номер телефона обновлен.");
            Console.ReadKey();
        }
    }
}
