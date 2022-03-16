using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POE
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private int role;
        private string name;
        //leave out of constructor
        //create accessors and mutators
        private int totalPoints = 0;
        private int totalCurrency = 0;

        //constructor
        public User()
        {
            this.username = "";
            this.password = "";
            this.email = "";
            this.role = 0;
            this.name = "";
        }
        public User(string username,string password,string email,int role, string name)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
            this.name = name;
        }
        //accessors
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getEmail()
        {
            return this.email;
        }
        public int getRole()
        {
            return this.role;
        }
        public string getName()
        {
            return this.name;
        }
        public int getTotalPoints() {
            return this.totalPoints;
        }
        public int getTotalCurrency()
        {
            return this.totalCurrency;
        }
        //mutators
        public void setUsername(string username)
        {
             this.username = username;
        }
        public void setPassword(string password)
        {
             this.password = password;
        }
        public void setEmail(string email)
        {
             this.email = email;
        }
        public void setRole(int role)
        {
             this.role = role;
        }
        public void setName(string name)
        {
             this.name = name;
        }
        public void setTotalPoints(int totalPoints) {
            this.totalPoints = totalPoints;
        }
        public void setTotalCurrency(int totalCurrency)
        {
            this.totalCurrency = totalCurrency;
        }

        public void updatePoints(int points) 
        {
            this.totalPoints += points;
        }
        public void updateCurrency(int currency)
        {
            this.totalCurrency += currency;
        }
    }
}
