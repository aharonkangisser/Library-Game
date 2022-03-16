using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POE
{
    public class Point
    {
        private int id;
        private Game game;
        private User user;
        private DateTime date;
        private int amount;

        //constructor
        public Point() {
            this.id = 0;
            this.game = null;
            this.user = null;
            this.amount = 0;

        }
        public Point(int id, Game game, User user, DateTime date, int amount) {
            this.id = id;
            this.game = game;
            this.user = user;
            this.date = date;
            this.amount = amount;
        }
        //accessors
        public int getId() {
            return this.id;
        }
        public Game GetGame()
        {
            return this.game;
        }
        public User GetUser()
        {
            return this.user;
        }
        public DateTime GetDate()
        {
            return this.date;
        }
        public int getAmount()
        {
            return this.amount;
        }
        //mutators
        public void setId(int id)
        {
            this.id = id;
        }
        public void setGame(Game game)
        {
            this.game = game;
        }
        public void setUser(User user)
        {
            this.user = user;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }
        public void setAmount(int amount)
        {
            this.amount = amount;
        }

    }
}
