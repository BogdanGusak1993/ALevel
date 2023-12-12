using System.Collections.Generic;

namespace HW_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook book = new PhoneBook();

            Contact contact = new Contact();
            contact.phone = "+44000";//UK code
            contact.name = "Test";

            Contact contact1 = new Contact();
            contact1.phone = "+38066";//Ukraine code
            contact1.name = "Test1";

            Contact contact2 = new Contact();
            contact2.phone = "adsdasd";
            contact2.name = "Test2";

            Contact contact3 = new Contact();
            contact3.phone = "11111";
            contact3.name = "Test3";
            
            Contact contact4 = new Contact();
            contact4.phone = "+44012323";
            contact4.name = "Test10";

            Contact contact5 = new Contact();
            contact5.phone = "+3806756";
            contact5.name = "Test8";

            Contact contact6 = new Contact();
            contact6.phone = "adsdasdas12sdad";
            contact6.name = "Test6";

            Contact contact7 = new Contact();
            contact7.phone = "222222";
            contact7.name = "Test4";
            

            book.Add(contact);
            book.Add(contact1);
            book.Add(contact2);
            book.Add(contact3);
            book.Add(contact4);
            book.Add(contact5);
            book.Add(contact6);
            book.Add(contact7);
        }
    }
}