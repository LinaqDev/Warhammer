using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer.Common
{
    public static class SkillsCollection
    {
        public static List<Skill> GetBasicSkills => basicSkills ?? (basicSkills = InitBasicSkills());
        public static List<Skill> GetAdvancedkills => advancedSkills ?? (advancedSkills = InitAdvancedSkills());


        private static List<Skill> basicSkills;
        private static List<Skill> advancedSkills;

        private static List<Skill> InitBasicSkills()
        {
            return new List<Skill>
            {
                new Skill{ Id = 1, Name = "Charakteryzacja"},
                new Skill{ Id = 2, Name = "Dowodzenie"},
                new Skill{ Id = 3, Name = "Hazard"},
                new Skill{ Id = 4, Name = "Jeździectwo"},
                new Skill{ Id = 5, Name = "Mocna Głowa"},
                new Skill{ Id = 6, Name = "Opieka nad zwierzętami"},
                new Skill{ Id = 7, Name = "Plotkowanie"},
                new Skill{ Id = 8, Name = "Pływanie"},
                new Skill{ Id = 9, Name = "Powożenie"},
                new Skill{ Id = 10, Name = "Przekonywanie"},
                new Skill{ Id = 11, Name = "Przeszukiwanie"},
                new Skill{ Id = 12, Name = "Skradanie się"},
                new Skill{ Id = 13, Name = "Spostrzegawczość"},
                new Skill{ Id = 14, Name = "Sztuka przetrwania"},
                new Skill{ Id = 15, Name = "Targowanie"},
                new Skill{ Id = 16, Name = "Ukrywanie się"},
                new Skill{ Id = 17, Name = "Wioślarstwo"},
                new Skill{ Id = 18, Name = "Wspinaczka"},
                new Skill{ Id = 19, Name = "Wycena"},
                new Skill{ Id = 20, Name = "Zastraszanie"}
            };
        }

        private static List<Skill> InitAdvancedSkills()
        {
            return new List<Skill>
            {
                new Skill{ Id =1 , Name ="Brzuchomóstwo" },
                new Skill{ Id =2 , Name ="Czytanie i pisanie" },
                new Skill{ Id =3 , Name ="Czytanie z warg" },
                new Skill{ Id =4 , Name ="Gadanina" },
                new Skill{ Id =5 , Name ="Hipnoza" },
                new Skill{ Id =6 , Name ="Język tajemny" },
                new Skill{ Id =7 , Name ="Kuglarstwo" },
                new Skill{ Id =8 , Name ="Leczenie" },
                new Skill{ Id =9 , Name ="Nauka (różne)" },
                new Skill{ Id =10 , Name ="Nawigacja" },
                new Skill{ Id =11 , Name ="Oswajanie" },
                new Skill{ Id =12 , Name ="Otwieranie zamków" },
                new Skill{ Id =13 , Name ="Rzemiosło (różne)" },
                new Skill{ Id =14 , Name ="Sekretne znaki (różne)" },
                new Skill{ Id =15 , Name ="Sekretny język (różne)" },
                new Skill{ Id =16 , Name ="Splatanie magii" },
                new Skill{ Id =17 , Name ="Śledzenie" },
                new Skill{ Id =18 , Name ="Torturowanie" },
                new Skill{ Id =19 , Name ="Tresura" },
                new Skill{ Id =21 , Name ="Tropienie" },
                new Skill{ Id =22 , Name ="Unik" },
                new Skill{ Id =23 , Name ="Warzenie trucizn" },
                new Skill{ Id =24 , Name ="Wiedza (różne)" },
                new Skill{ Id =25 , Name ="Wykrywanie magii" },
                new Skill{ Id =26 , Name ="Zastawianie pułapek" },
                new Skill{ Id =27 , Name ="Znajomość języka (różne)" },
                new Skill{ Id =28 , Name ="Zwinne palce" },
                new Skill{ Id =29 , Name ="Żeglarstwo" },
            };
        }
    }
}
