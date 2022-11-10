
using System;
using Casino;
using Casino.BlackjackGame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Blackjack //renamed from BlackjackGame to make program runnable
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Clams Casino! Please enter your name:");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.Write("How much money will you be betting today ?\n$");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }


            Console.WriteLine("Hello, {0}, would you like to join a game of Blackjack? (y/n)", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid(); //Globally Unique IDentifier

                using (StreamWriter file = new StreamWriter(@"C:\Users\saman\Desktop\BlackjackGameLog.txt", true)) //'true' appends to the file
                {
                    file.WriteLine(player.Id); //tracks GUID of player in log
                }

                Game game = new BlackjackGame(); //polymorphism to inherit Game properties
                game += player; //player added to game
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oops, an error occured. Contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();
        }


        //updating database with exception catches; using ADO.NET
        private static void UpdateDbWithException(Exception ex) //will catch all exceptions; polymorphism
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BlackjackGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //placeholders to be sub with actual values; protects datatype of SQL injections 

            using (SqlConnection connection = new SqlConnection(connectionString)) //'using' helps with managing and controlling memory; auto shuts off the connection
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //insert statement = nonQuery
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BlackjackGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions"; //pulling everything

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //loops thru each object
                {
                    ExceptionEntity exception = new ExceptionEntity(); //initializes an entity
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions; //returns list of exception entities
        }
    }
}

