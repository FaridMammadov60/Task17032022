using System;
using System.Text.RegularExpressions;

namespace ConsoleAppTask.Model
{
    internal class User
    {
        #region Fields
        int age;
        #endregion

        #region Property
        public string Username { get; set; }
        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                if (value.Length < 7)
                {
                    Console.WriteLine("Uzunluğu 8den kiçik ola bilmez");

                }
                else if (string.IsNullOrEmpty(value))

                {
                    Console.WriteLine("Boşdur");
                }
                else if (BigAlfb(value) == false)
                {
                    Console.WriteLine("Parametrler uygun deyil");
                }

            }

        }
        public int Age
        {
            get
            {
                return Age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yaş mənfi ola bilmez");


                }
                else
                {
                    age = value;
                }
            }
        }
        #endregion

        #region Construction
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

        }
        #endregion


        public override string ToString()
        {
            return $"User name: {Username}\n" +
                $"User age: {Age}\n" +
                $"User password: {Password}\n";
        }

       /// <summary>
       /// Qebul edilmis stringi Reqem boyuk herf ve kicik herf olaraq yoxlayir
       /// </summary>
       /// <param name="password"></param>
       /// <returns></returns>
        bool BigAlfb(string password)
        {
            int numericCount = Regex.Matches(password, @"\d").Count;
            int upperCount = Regex.Matches(password, @"[A-Z]").Count;
            int lowerCount = Regex.Matches(password, @"[a-z]").Count;
            
            if (numericCount==0)
            {
                return false;
            }
            else if (upperCount == 0)
            {
                return false;
            }
            if (lowerCount == 0)
            {
                return false;
            }
            return true;
        }


}
   
    
   
}
