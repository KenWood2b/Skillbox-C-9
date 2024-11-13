using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepDiveintoOOPPart1ConsoleApp
{
    public class Client
    {
        public string LastName { get; internal set; }
        public string FirstName { get; internal set; }
        public string MiddleName { get; internal set; }
        public string PhoneNumber { get; set; }
        private string PassportNumber { get; set; }  // Установим PassportNumber как приватное

        // Дополнительные поля для истории изменений
        public DateTime LastModified { get; private set; }
        public string ModifiedField { get; private set; }
        public string ModificationType { get; private set; }
        public string Editor { get; private set; }

        public Client(string lastName, string firstName, string middleName, string phoneNumber, string passportNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            PhoneNumber = phoneNumber;
            PassportNumber = passportNumber;
        }

        // Метод для возвращения скрытого паспорта для консультанта
        public string GetProtectedPassportNumber()
        {
            return string.IsNullOrEmpty(PassportNumber) ? "" : "******************";
        }

        // Метод для получения полного паспорта для менеджера
        public string GetFullPassportNumber()
        {
            return PassportNumber;
        }

        // Метод для изменения паспорта менеджером
        public void SetPassportNumber(string passportNumber)
        {
            PassportNumber = passportNumber;
        }

        // Метод для обновления истории изменений
        public void UpdateModificationInfo(string field, string type, string editor)
        {
            LastModified = DateTime.Now;
            ModifiedField = field;
            ModificationType = type;
            Editor = editor;
        }
    }
}
