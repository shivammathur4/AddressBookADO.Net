using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to AddressBookADO.Net!");
            AddressBookRepository addressBookRepo = new AddressBookRepository();
            addressBookRepo.GetAllContacts();
            Console.ReadKey();
        }
    }
}
