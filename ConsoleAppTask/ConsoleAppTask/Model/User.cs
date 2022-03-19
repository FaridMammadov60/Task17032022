using System;
using System.Text.RegularExpressions;

namespace ConsoleAppTask.Model
{
    public class User
    {
        #region Fields
        int age;
        string password;
        #endregion

        #region Property
        public string Username { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 7)
                {
                    Console.WriteLine("Uzunluğu 8den kiçik ola bilmez");
                    return;

                }
                else if (string.IsNullOrEmpty(value))

                {
                    Console.WriteLine("Boşdur");
                    return ;
                }
                else if (BigAlfb(value) == false)
                {
                    Console.WriteLine("Parametrler uygun deyil");
                    return;
                }
                password = value;

            }

        }
        public int Age
        {
            get
            {
               return age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yaş mənfi ola bilmez");

                    return;
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
        /// İçində ən az bir böyük hərf olmalıdır
        /// İçində ən az bir rəqəm olmalıdır
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool BigAlfb(string password)
        {
            int numericCount = Regex.Matches(password, @"\d").Count;
            int upperCount = Regex.Matches(password, @"[A-Z]").Count;
            
            
            if (numericCount==0)
            {
                return false;
            }
            else if (upperCount == 0)
            {
                return false;
            }
           
            return true;
        }


}
   
    
   
}
