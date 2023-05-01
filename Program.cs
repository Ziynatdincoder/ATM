using System;

namespace Bankomat;
public class Program
{
    public static void Main(string[] args)
    {
        string lang;
        Console.WriteLine("Select language / Tilni tanlang / Выберите язык");
        Console.WriteLine("1. English");
        Console.WriteLine("2. O'zbek");
        Console.WriteLine("3. Русский");
        lang = Console.ReadLine();

        switch (lang)
        {
            case "1":
                {
                    Console.WriteLine("Welcome to the ATM!");

                    Console.Write("Enter PIN code: ");
                    string pinCode = Console.ReadLine();

                    Account account = new Account("1234", 500000);
                    if (account.Pin == pinCode)
                    {
                        Bankomat atm = new Bankomat();
                        bool exit = true;
                        while (exit)
                        {
                            Console.WriteLine("Please select an option:");
                            Console.WriteLine("1. Withdraw");
                            Console.WriteLine("2. Deposit");
                            Console.WriteLine("3. Check balance");
                            Console.WriteLine("4. Change PIN");
                            Console.WriteLine("5. Exit");

                            string option = Console.ReadLine();

                            switch (option)
                            {
                                case "1":
                                    Console.Write("Enter amount to withdraw: ");
                                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                                    atm.Withdrawl(account, withdrawAmount, lang);
                                    break;

                                case "2":
                                    Console.Write("Enter amount to deposit: ");
                                    decimal depositAmount = decimal.Parse(Console.ReadLine());

                                    atm.Deposit(account, depositAmount, lang);
                                    break;

                                case "3":
                                    atm.CheckBalance(account, lang);
                                    break;

                                case "4":
                                    string changePin;
                                    Console.Write(" Enter a new PIN : ");
                                    changePin = Console.ReadLine();

                                    atm.ChangePIN(account, changePin, lang);
                                    break;

                                case "5":
                                    exit = true;
                                    Console.WriteLine("Thank you for using the ATM!");
                                    break;

                                default:
                                    Console.WriteLine("Invalid option.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid PINcode");
                    }
                    break;
                }
            case "2":
                {
                    Console.WriteLine("ATM ga xush kelibsiz!");

                    Console.Write(" Pin kodni kiriting: ");
                    string pinCode = Console.ReadLine();


                    Account account = new Account("1234", 500000);
                    if (account.Pin == pinCode)
                    {
                        Bankomat atm = new Bankomat();

                        bool exit = false;

                        while (!exit)
                        {
                            Console.WriteLine("Operatsiyani tanlang:");
                            Console.WriteLine("1. Naqd pul yechib olish");
                            Console.WriteLine("2. Kartaga pul to'lash");
                            Console.WriteLine("3. Balansni tekshirish");
                            Console.WriteLine("4. PIN kodni o'zgartirish");
                            Console.WriteLine("5. Chiqish");

                            string option = Console.ReadLine();

                            switch (option)
                            {
                                case "1":
                                    Console.Write("Chiqarib olish uchun summani kiriting: ");
                                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                                    atm.Withdrawl(account, withdrawAmount, lang);
                                    break;

                                case "2":
                                    Console.Write("Kartaga pul to'lash uchun summani kiriting: ");
                                    decimal depositAmount = decimal.Parse(Console.ReadLine());

                                    atm.Deposit(account, depositAmount, lang);
                                    break;

                                case "3":
                                    atm.CheckBalance(account, lang);
                                    break;

                                case "4":
                                    string changePin;
                                    Console.Write(" Yangi PIN kodni kiriting : ");
                                    changePin = Console.ReadLine();

                                    atm.ChangePIN(account, changePin, lang);
                                    break;

                                case "5":
                                    exit = true;
                                    Console.WriteLine("ATM dan foydalanganingiz uchun rahmat!");
                                    break;

                                default:
                                    Console.WriteLine("Operatsiya xato berildi.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("PIN kod xato kiritildi:");
                    }
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Добро пажаловать в наш ATM!");

                    Console.Write(" Введиту пожалуйста ПИН код: ");
                    string pinCode = Console.ReadLine();


                    Account account = new Account("1234", 500000);
                    if (account.Pin == pinCode)
                    {
                        Bankomat atm = new Bankomat();

                        bool exit = false;

                        while (!exit)
                        {
                            Console.WriteLine("Выберите операцию:");
                            Console.WriteLine("1. Снять наличные деньги");
                            Console.WriteLine("2. Пополнить карту");
                            Console.WriteLine("3. Баланс");
                            Console.WriteLine("4. Поменять ПИН код");
                            Console.WriteLine("5. Выход");

                            string option = Console.ReadLine();

                            switch (option)
                            {
                                case "1":
                                    Console.Write("Какую сумму вы хотите снять: ");
                                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                                    atm.Withdrawl(account, withdrawAmount, lang);
                                    break;

                                case "2":
                                    Console.Write("На какой суммы хотите пополнить карту: ");
                                    decimal depositAmount = decimal.Parse(Console.ReadLine());

                                    atm.Deposit(account, depositAmount, lang);
                                    break;

                                case "3":
                                    atm.CheckBalance(account, lang);
                                    break;

                                case "4":
                                    string changePin;
                                    Console.Write(" Введите новый ПИН код : ");
                                    changePin = Console.ReadLine();

                                    atm.ChangePIN(account, changePin, lang);
                                    break;

                                case "5":
                                    exit = true;
                                    Console.WriteLine("Спасибо что исползовали сервисы наш ATM !");
                                    break;

                                default:
                                    Console.WriteLine("Вы выбрали неправилную операцию.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Пин код неправильно:");
                    }
                    break;
                }
        }

        

        
    }
}

