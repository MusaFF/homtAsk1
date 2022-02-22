using System;

namespace P129HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gmail Adinizi Daxil edin");
            string username = Console.ReadLine();

            User user = new User(username);

            Console.WriteLine("Ad duzgun qeyde alinmisdir");
            Console.WriteLine("PArolu Daxil et");
            string password = Console.ReadLine();
            user.Password = password;

            Console.WriteLine("Tesdiqlendi. Gamil adiniz ve parolunuz dogrudur.hesaba kecid ede bilersiniz. ");

        }
    }
}

