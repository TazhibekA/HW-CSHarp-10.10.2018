using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyClassLib;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClassLib.WordOfTanks.Tank firstTank = new MyClassLib.WordOfTanks.Tank("T34");
            MyClassLib.WordOfTanks.Tank secondTank = new MyClassLib.WordOfTanks.Tank("T34");
            MyClassLib.WordOfTanks.Tank thirdTank = new MyClassLib.WordOfTanks.Tank("T34");
            MyClassLib.WordOfTanks.Tank fourthTank = new MyClassLib.WordOfTanks.Tank("T34");
            MyClassLib.WordOfTanks.Tank fifthTank = new MyClassLib.WordOfTanks.Tank("T34");

            List<MyClassLib.WordOfTanks.Tank> firstTeamOfTanks = new List<MyClassLib.WordOfTanks.Tank>() { firstTank , secondTank, thirdTank, fourthTank, fifthTank };
            //firstTeamOfTanks.Add(firstTank);
            //firstTeamOfTanks.Add(secondTank);
            //firstTeamOfTanks.Add(thirdTank);
            //firstTeamOfTanks.Add(fourthTank);
            //firstTeamOfTanks.Add(fifthTank);


            MyClassLib.WordOfTanks.Team firstTeam = new MyClassLib.WordOfTanks.Team("T34_Team", firstTeamOfTanks);
     
            MyClassLib.WordOfTanks.Tank sixthTank = new MyClassLib.WordOfTanks.Tank("Pantera");
            MyClassLib.WordOfTanks.Tank seventhTank = new MyClassLib.WordOfTanks.Tank("Pantera");
            MyClassLib.WordOfTanks.Tank eighthTank = new MyClassLib.WordOfTanks.Tank("Pantera");
            MyClassLib.WordOfTanks.Tank ninthTank = new MyClassLib.WordOfTanks.Tank("Pantera");
            MyClassLib.WordOfTanks.Tank tenthTank = new MyClassLib.WordOfTanks.Tank("Pantera");

            List<MyClassLib.WordOfTanks.Tank> secondTeamOfTanks = new List<MyClassLib.WordOfTanks.Tank>() { sixthTank , seventhTank , eighthTank, ninthTank, tenthTank };
            //secondTeamOfTanks.Add(sixthTank);
            //secondTeamOfTanks.Add(seventhTank);
            //secondTeamOfTanks.Add(eighthTank);
            //secondTeamOfTanks.Add(ninthTank);
            //secondTeamOfTanks.Add(tenthTank);

            MyClassLib.WordOfTanks.Team secondTeam = new MyClassLib.WordOfTanks.Team("Pantera_Team", secondTeamOfTanks);

            Console.WriteLine("First Team: ");
            firstTeam.Show();

            Console.WriteLine("Second Team: ");
            secondTeam.Show();

            Console.ReadLine();

            Console.WriteLine("Win =====> " + (firstTeam * secondTeam).Name + '!');
            Console.WriteLine("Winned Team Information: ");
            (firstTeam * secondTeam).Show();

            Console.ReadLine();

        }
    }
}
