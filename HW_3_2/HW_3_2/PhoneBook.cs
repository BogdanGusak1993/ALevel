using System.Text.RegularExpressions;

namespace HW_3_2
{
    public class PhoneBook
    {
        public Dictionary<string, List<Contact>> PhonesColection { get; set; }

        public PhoneBook()
        {
            PhonesColection = new Dictionary<string, List<Contact>>();
            PhonesColection.Add("English", new List<Contact>());
            PhonesColection.Add("Ukraine", new List<Contact>());
            PhonesColection.Add("Numbers", new List<Contact>());
            PhonesColection.Add("#", new List<Contact>());
        }

        public void Add(Contact contact)
        {

            if (new string(contact.phone.Take(4).ToArray()) == "+440")
            {
                var list = PhonesColection["English"];
                list.Add(contact);
                PhonesColection.Remove("English");
                PhonesColection.Add("English", list);
            }
            if (new string(contact.phone.Take(4).ToArray()) == "+380")
            {
                var list = PhonesColection["Ukraine"];
                list.Add(contact);
                PhonesColection.Remove("Ukraine");
                PhonesColection.Add("Ukraine", list);
            }
            if (Regex.IsMatch(contact.phone, @"^\d+"))
            {
                var list = PhonesColection["Numbers"];
                list.Add(contact);
                PhonesColection.Remove("Numbers");
                PhonesColection.Add("Numbers", list);
            }
            else
            {
                var list = PhonesColection["#"];
                list.Add(contact);
                PhonesColection.Remove("#");
                PhonesColection.Add("#", list);
            }
        }
    }
}
