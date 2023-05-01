using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bankomat
    {
        public void Withdrawl(Account account, decimal amount, string selectLang)
        {
            switch(selectLang)
            {
                case "1":
                    if (account.Balance < amount)
                    {
                        Console.WriteLine("Insufficient balance.");
                        return;
                    }
                    account.Balance -= amount;
                    Console.WriteLine($"Successfully withdrew ${amount}, new balance is ${account.Balance}.");
                    break;
                case "2":
                    if (account.Balance < amount)
                    {
                        Console.WriteLine("Balans yetarli emas.");
                        return;
                    }
                    account.Balance -= amount;
                    Console.WriteLine($"Pul yechib olish muvafaqqiyatli bajarildi ${amount}, qolgan balans ${account.Balance}.");
                    break;
                case "3":
                    if (account.Balance < amount)
                    {
                        Console.WriteLine("Баланс недостаточна.");
                        return;
                    }
                    account.Balance -= amount;
                    Console.WriteLine($"Снять выпольнено ${amount}, остаток баланса ${account.Balance}.");
                    break;
            }
            
        }

        public void Deposit(Account account, decimal amount, string selectLang)
        {
            switch(selectLang)
            {
                case "1":
                    account.Balance += amount;
                    Console.WriteLine($"Successfully deposited ${amount}, new balance is ${account.Balance}.");
                    break;
                case "2":
                    account.Balance += amount;
                    Console.WriteLine($"Hisobni to'dirish muvafaqqiyatli bajarildi ${amount}, va hisobingizda ${account.Balance} pul bor.");
                    break;
                case "3":
                    account.Balance += amount;
                    Console.WriteLine($"Попольнения счета выполнено ${amount}, новый баланс ${account.Balance}.");
                    break;
            }
        }

        public void CheckBalance(Account account, string selectLang)
        {
            switch(selectLang)
            {
                case "1":
                    Console.WriteLine($"Current balance is ${account.Balance}.");
                    break;
                case "2":
                    Console.WriteLine($"Sizning balansingiz ${account.Balance}.");
                    break;
                case "3":
                    Console.WriteLine($"Ваш баланс ${account.Balance}.");
                    break;
            }
            
        }
        public void ChangePIN(Account account, string changePin, string selectLang)
        {
            switch(selectLang)
            {
                case "1":
                    changePin = account.Pin;
                    Console.WriteLine($"The PIN code has been changed");
                    break;
                case "2":
                    changePin = account.Pin;
                    Console.WriteLine($"PIN kod o'zgartirildi");
                    break;
                case "3":
                    changePin = account.Pin;
                    Console.WriteLine($"ПИН код изменено");
                    break;
            }

            
        }

        
    }
}
