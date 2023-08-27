using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    
    public class Person
    {
        int id;
        string name;
        string surname;
        DateTime creationTime;
        string username;
        string password;
        string authority;

        public Person()
        {
                
        }

        public Person(int id,string name,string surname,DateTime creationTime,string username,string password,string authority)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.creationTime = creationTime;
            this.username = username;
            this.password = password;
            this.authority = authority;
        }
    }
}
