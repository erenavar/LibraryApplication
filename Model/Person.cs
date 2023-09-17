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

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setCreationTime(DateTime creationTime)
        {
            this.creationTime = creationTime;
        }

        public DateTime getCreationTime()
        {
            return this.creationTime;
        }

        public void setUsername(string username)
        {
            this.username = username;
                
        }

        public string getUsername()
        {
            return this.username;
        }

        public void setPassword(string password)
        {
            this.password = password;
                
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }

        public string getAuthority()
        {
            return this.authority;
        }

        public override string ToString()
        {
            return "Name - Surname: " + this.name + " " + this.surname;
        }



    }
}
