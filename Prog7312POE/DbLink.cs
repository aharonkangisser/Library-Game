using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312POE
{
    public class DbLink
    {
        // this class performs all the operations that invloves reading and writing to the database


        //this connection string connects the code to the database

        private string DBConnectionString = @"Data Source=DESKTOP-R2LMNPF\SQLEXPRESS;Initial Catalog=PROGPOE7312;Integrated Security=True";
        private SqlConnection DBConnection;

        public void connect()
        {
            DBConnection = new SqlConnection(DBConnectionString);
            DBConnection.Open();
        }
        public bool autenticateUser(string username, string password)
        {
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT username FROM dbo.Users WHERE dbo.Users.[username] = '" + username + "' AND dbo.Users.[password] = '" + password + "';";
            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            bool authValid = false;
            while (DataReader.Read())
            {
                if (DataReader.GetValue(0).ToString() == username)
                {

                    authValid = true;
                }
            }
            DataReader.Close();
            return authValid;
        }
        public User getUser(string username)
        {
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT username, password, email, role, fullName FROM dbo.Users WHERE dbo.Users.[username] = '" + username + "';";
            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            bool authValid = false;
            while (DataReader.Read())
            {
                User user = new User(DataReader.GetValue(0).ToString(), DataReader.GetValue(1).ToString(), DataReader.GetValue(2).ToString(), DataReader.GetInt32(3), DataReader.GetValue(4).ToString());
                DataReader.Close();
                user.setTotalPoints(getPointBalance(user));
                user.setTotalCurrency(getCurrencyBalance(user));
                return user;
            }

            return null;
        }
        public bool RegisterUser(User user)
        {
            try
            {
                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter Adapter = new SqlDataAdapter();

                string sql = "INSERT into dbo.users (username,password,email,role,fullName) values ('" + user.getUsername() + "','" + user.getPassword() + "','" + user.getEmail() + "'," + user.getRole() + ",'" + user.getName() + "');";
                command = new SqlCommand(sql, DBConnection);
                Adapter.InsertCommand = command;

                Adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check provided values", "Error");
                return false;

            }

        }
        public List<DeweyDecimal> generateReplacingBookList(int count)
        {
            List<DeweyDecimal> ddList = new List<DeweyDecimal>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                //005.73 JAM

                int callNumber1 = random.Next(0, 999); //005 -005
                int callNumber2 = random.Next(0, 999); // 73 - 03
                string cNumber1 = callNumber1.ToString();
                while (cNumber1.Length < 3)
                {
                    cNumber1 = "0" + cNumber1;
                }
                string cNumber2 = callNumber2.ToString();
                while (cNumber2.Length < 3)
                {
                    cNumber2 = "0" + cNumber2;
                }

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";// JAM
                string bookName = "";
                for (int j = 0; j < 3; j++)
                {
                    bookName = bookName + chars[random.Next(chars.Length)];
                }

                string callNumber = cNumber1 + "." + cNumber2 + " " + bookName;
                ddList.Add(new DeweyDecimal(callNumber, "", ""));
            }
            return ddList;
        }
        public List<DeweyDecimal> sortCallNumbers(List<DeweyDecimal> ddList)
        {
            //bubble sort algorith to check if 2 item adjacent to each other is smaller than the next item. 
            for (int i = 0; i < ddList.Count; i++)
            {
                for (int j = i; j < ddList.Count; j++)
                {
                    if (!ddList[i].isFullCallNumberBigger(ddList[j].getCallNumber()))
                    {
                        DeweyDecimal temp = ddList[i];
                        ddList[i] = ddList[j];
                        ddList[j] = temp;
                    }
                }
            }
            return ddList;
        }

        public bool updatePoints(User user, string description, int pointCount)
        {
            try
            {
                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter Adapter = new SqlDataAdapter();

                string sql = "INSERT into dbo.points (userid,pointDate,pointAmount,pointDescription) values ('" + user.getUsername() + "'," + DateTime.Now.ToShortDateString() + "," + pointCount + ",'" + description + "');";

                command = new SqlCommand(sql, DBConnection);
                Adapter.InsertCommand = command;

                Adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check provided values", "Error");
                return false;

            }
        }
        public bool updateCurrency(User user, string description, int currencyCount)
        {
            try
            {
                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter Adapter = new SqlDataAdapter();

                string sql = "INSERT into dbo.currency (userid,currencyDate,currencyAmount,currencyDescription) values ('" + user.getUsername() + "'," + DateTime.Now.ToShortDateString() + "," + currencyCount + ",'" + description + "');";

                command = new SqlCommand(sql, DBConnection);
                Adapter.InsertCommand = command;

                Adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check provided values", "Error");
                return false;

            }
        }
        public int getPointBalance(User user)
        {
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT SUM(pointAmount) FROM dbo.points WHERE userId = '" + user.getUsername() + "';";

            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            int points = 0;
            while (DataReader.Read())
            {
                try
                {
                    points = DataReader.GetInt32(0);
                }
                catch (Exception ex)
                {

                }
            }
            DataReader.Close();
            return points;
        }
        public int getCurrencyBalance(User user)
        {
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT SUM(currencyAmount) FROM dbo.currency WHERE userId = '" + user.getUsername() + "';";

            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            int currency = 0;
            while (DataReader.Read())
            {
                try
                {
                    currency = DataReader.GetInt32(0);
                }
                catch (Exception ex)
                {

                }
            }
            DataReader.Close();
            return currency;
        }

        public string getLeaderBoard()
        {
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT TOP(10) SUM(pointAmount), userId FROM dbo.points GROUP BY userId ORDER BY SUM(pointAmount) DESC;";

            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            string leaderboard = "";
            while (DataReader.Read())
            {
                try
                {
                    leaderboard += DataReader.GetValue(1).ToString() + ":\t" + DataReader.GetInt32(0) + "\n";
                }
                catch (Exception ex)
                {

                }
            }
            DataReader.Close();
            return leaderboard;
        }

        public DeweyDecimalTree buildTree()
        {
            DeweyDecimalTree tree = new DeweyDecimalTree();

            //Order by callnumber 000 001 002 003 004

            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT callNumber, definition, description FROM DeweyDecimal ORDER BY callNumber;"; // this builds the tree

            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();

            while (DataReader.Read())
            {
                try
                {
                    string callNumber = DataReader.GetValue(0).ToString();
                    string definition = DataReader.GetValue(1).ToString();
                    string description = DataReader.GetValue(2).ToString();
                    tree.addNode(new DeweyDecimal(callNumber, definition, description));
                }
                catch (Exception ex)
                {
                    int x = 0;
                }
            }
            DataReader.Close();
            return tree;
        }


        public Dictionary<String, String> getAreas(int count)
        {
            //SELECT TOP (7) callNumber, definition FROM DeweyDecimal ORDER BY NEWID();
            SqlCommand command;
            SqlDataReader DataReader;

            string sql = "SELECT TOP (" + count + ") callNumber, description FROM DeweyDecimal ORDER BY NEWID();"; //callNumber  description
                                                                                                                   //   string sql = "SELECT TOP (" + count + ") callNumber, definition FROM DeweyDecimal ORDER BY NEWID();"; //callNumber  description

            command = new SqlCommand(sql, DBConnection);
            DataReader = command.ExecuteReader();
            Dictionary<String, String> areas = new Dictionary<string, string>();
            while (DataReader.Read())
            {
                try
                {
                    areas.Add(DataReader.GetValue(0).ToString(), DataReader.GetValue(1).ToString());
                }
                catch (Exception ex)
                {

                }
            }
            DataReader.Close();
            return areas;

        }
    }


}
