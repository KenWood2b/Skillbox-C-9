﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepDiveintoOOPPart1ConsoleApp
{
    public class Manager : Consultant, IManagerEditable
    {
        public Client AddClient(string lastName, string firstName, string middleName, string phoneNumber, string passportNumber)
        {
            return new Client(lastName, firstName, middleName, phoneNumber, passportNumber);
        }

        public void UpdateClientInfo(Client client, string lastName, string firstName, string middleName, string phoneNumber, string passportNumber, string editorType)
        {
            client.LastName = lastName;
            client.FirstName = firstName;
            client.MiddleName = middleName;
            client.PhoneNumber = phoneNumber;
            client.PassportNumber = passportNumber;

            client.UpdateModificationInfo("All Fields", "Полное изменение", editorType);
            Console.WriteLine("Данные клиента успешно обновлены.");
            Console.ReadKey();
        }
    }
}
