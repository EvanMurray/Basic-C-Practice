using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace peopleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            
            playerList = populatePlayerList(playerList);
            printList(playerList);
            
        }

        static public List<Player> populatePlayerList(List<Player> playerList)
        {
            while (true)
            {
                Player player = new Player();
                Console.Write("Please enter a name or 'quit' to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return playerList;
                }
                else {
                    player.name = input;
                    playerList.Add(player);
                }
            }            
        }

        static public void printList(List<Player> playerList)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                Console.WriteLine(playerList[i].name);
                
            }
        }
    }
}   

