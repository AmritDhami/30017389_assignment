/*Amritpl Dhami
 * Student ID - 30017389*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUES_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************************Rotorua thermal Holiday park***********************************");
            Console.WriteLine("\n\tWelcome to the recent sign-in system");
            Console.WriteLine();
            //intializing result left off loops
            string result2 = "";
            string result = "";

            //use the loop for getting correct username
            do
            {
                Console.Write(" \nEnter the username (within limits of  8 character): ");
                string username = Console.ReadLine();
                Console.WriteLine(ValidateUsername(username));
                result = ValidateUsername(username);
                Console.WriteLine();
            } while (result != "A valid Username! ");


            /*use loop for getting correct accepting password*/
            do
            {
                Console.WriteLine("\nEnter the password (must be 8 character ): ");
                string Password1 = Console.ReadLine();
                Console.Write("\n Repeat the password for approving: ");
                string password2 = Console.ReadLine();
                Console.WriteLine(ValidatePassword(Password1, password2));
                result2 = ValidatePassword(Password1, password2);
                Console.WriteLine();
            } while (result2 != "*******Password successfully  accepted !*********");


            //Showing everything worked fine
            Console.WriteLine("Congrats!  Userame and password have been confirmed as well as set.");


            //HOLDING OUTPUT
            Console.ReadLine();

        }

        /*Validating username method checks username's length and returns result informing the user whether their username meet the requirements or not.*/

        static string ValidateUsername(string username)
        {
            string result;
            //if length of string is  greater than 8 or equal to 8
            if (username.Length >= 8)
            { result = "A valid Username! "; }
            else { result = "Invalid username! "; }
            return result;

        }


        /*check the password's length and also check the both password are same or not, displaying a message of password accepting if all creteria is correct otherwise it showing erreor*/
        static string ValidatePassword(string password1, string password2)
        {
            string result2;

            if (password1.Length >= 8)
            {
                if (password1 == password2)
                {
                    result2 = "****Password have been accepted successsfully!****";
                }
                else
                {
                    result2 = "It showimg some error because password don't same";
                }
            }
            else
            { result2 = "PASSWORD MUST BE OF 8 CHARACTERS  LONG"; }

            return result2;
        }
    }
}

        