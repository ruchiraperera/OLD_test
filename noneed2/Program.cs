using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed2
{
    public enum Priorities
    {
        High,
        Low,
        BulkAct,
        JVAct,
        CreatAcc
    }

    public class ServerID
    {
        public int ID { get; set; }
        public string ServerName { get; set; }
    }


    class Program
    {
        static List<Priorities> restrictedPriorities = new List<Priorities> { Priorities.JVAct, Priorities.BulkAct };
        static List<ServerID> ServersList = new List<ServerID>();
        static string ServerName = "den1";
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                ServerID serverID = new ServerID();
                serverID.ID = i;
                if (i == 0)
                {
                    serverID.ServerName = "den";
                }
                else
                {
                    serverID.ServerName = "den" + i;
                }
                ServersList.Add(serverID);
            }


            foreach (var item in ServersList)
            {
                foreach (var priority in Enum.GetValues(typeof(Priorities)))
                {
                    Priorities prv = (Priorities)priority;

                    if (!(restrictedPriorities.Contains(prv)) && item.ServerName != "DEN")
                    {
                        Console.WriteLine(prv);
                    }

                    // Console.WriteLine(prv);
                }
                Console.WriteLine("----------------------------------------");
            }

            Console.Read();
        }
    }
}
