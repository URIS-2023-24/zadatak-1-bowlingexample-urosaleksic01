
namespace ConsoleApp6
{
    class Frame
    {


        public int prvoBacanje { get; set; }
        public int drugoBacanje { get; set; }
        public int bonus { get; set; }
        public int treceBacanje { get; set; }

        public Frame(int prvoBacanje, int drugoBacanje)
        {
            this.prvoBacanje = prvoBacanje;
            this.drugoBacanje = drugoBacanje;
        }


        public int Izracunaj()
        {
            int score = prvoBacanje + drugoBacanje + bonus + treceBacanje;
            return score;
        }


    }

}

