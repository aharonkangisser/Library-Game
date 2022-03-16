using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7312POE
{
    public class Game
    {
        private int id;
        private string gameName;
        // constructor
        public Game() {
            this.id = 0;
            this.gameName = "";
        }
        public Game(int id, string gameName){
            this.id = id;
            this.gameName = gameName;
            }
        //accessors
        public int getId() {
            return this.id;
        }
        public string getGameName() {
            return this.gameName;
        }
        //mutators
        public void setId(int id) {
            this.id = id;
        }
        public void setGameName(string gameName) {
            this.gameName = gameName;
}
    }

}
