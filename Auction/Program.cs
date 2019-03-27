using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizationRepository organizationRepository = new OrganizationRepository();
            Organization org = organizationRepository.Read(Guid.Parse("5729A5DF-026F-47D1-BC77-A1CB97008F94"));
            
            Console.WriteLine(org.OrganizationId);
            Console.WriteLine(org.OrganizationName);

        }
    }
}
