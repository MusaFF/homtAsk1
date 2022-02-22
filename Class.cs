using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork1
{
    class User
    {
        private string _userName;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("Xais Olunur duzgun Parol daxil edin");
                    value = Console.ReadLine();
                }
                _userName = value;
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                bool check = true;
                while (check)
                {
                    if (value.Length >= 8)
                    {
                        bool checkDigit = false;
                        bool checkLower = false;
                        bool checkUpper = false;

                        foreach (char item in value)
                        {
                            if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }
                            else if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }

                            if (checkDigit && checkLower && checkUpper == true)
                            {
                                _password = value;
                                check = false;
                                break;
                            }
                        }

                        if (!checkDigit || !checkLower || !checkUpper)
                        {
                            Console.WriteLine("Yalns Parol");
                            value = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parol duzgun deyil.");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public User(string username)
        {
            UserName = username;
        }
    }
}