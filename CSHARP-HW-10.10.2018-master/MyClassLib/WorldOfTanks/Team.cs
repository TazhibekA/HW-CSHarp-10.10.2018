using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Team
    {

        public string Name { get; set; }
        public List<Tank> Tanks { get; set; }

        public Team(string name, List<Tank> tanks)
        {
            Tanks = new List<Tank>();
            Name = name;
            Tanks = tanks;
        }


        public void  AddTank(Tank tank) {
            Tanks.Add(tank);
        }
 

        public static  Team operator *(Team firstTeam, Team secondTeam)
        {
            int firstTeamPoints = 0;
            int secondTeamPoints = 0;

            for (int i = 0; i < 5; i++)
            {
                if (firstTeam.Tanks[i].AmmunitionLevel > secondTeam.Tanks[i].AmmunitionLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;

                if (firstTeam.Tanks[i].ArmorLevel > secondTeam.Tanks[i].ArmorLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;

                if (firstTeam.Tanks[i].ManeuverabilityLevel > secondTeam.Tanks[i].ManeuverabilityLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;
            }

          

            if (firstTeamPoints > secondTeamPoints)
                return firstTeam;
            else
                return secondTeam;
        }

        public void Show()
        {
            Console.WriteLine("Name: " + Tanks[0].Name + "  Ammunition Level: " + Tanks[0].AmmunitionLevel + "  Armor Level: " + Tanks[0].ArmorLevel + "  Maneuverability Level: " + Tanks[0].ManeuverabilityLevel);
            Console.WriteLine("Name: " + Tanks[1].Name + "  Ammunition Level: " + Tanks[1].AmmunitionLevel + "  Armor Level: " + Tanks[1].ArmorLevel + "  Maneuverability Level: " + Tanks[1].ManeuverabilityLevel);
            Console.WriteLine("Name: " + Tanks[2].Name + "  Ammunition Level: " + Tanks[2].AmmunitionLevel + "  Armor Level: " + Tanks[2].ArmorLevel + "  Maneuverability Level: " + Tanks[2].ManeuverabilityLevel);
            Console.WriteLine("Name: " + Tanks[3].Name + "  Ammunition Level: " + Tanks[3].AmmunitionLevel + "  Armor Level: " + Tanks[3].ArmorLevel + "  Maneuverability Level: " + Tanks[3].ManeuverabilityLevel);
            Console.WriteLine("Name: " + Tanks[4].Name + "  Ammunition Level: " + Tanks[4].AmmunitionLevel + "  Armor Level: " + Tanks[4].ArmorLevel + "  Maneuverability Level: " + Tanks[4].ManeuverabilityLevel);

        
        }
    }
}
