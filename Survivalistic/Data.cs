using System.Collections.Generic;

namespace Survivalistic
{
    public class Data
    {
        public float actual_hunger { get; set; } = 100;
        public float actual_thirst { get; set; } = 100;

        public float max_hunger { get; set; } = 100;
        public float max_thirst { get; set; } = 100;

        public float initial_hunger { get; set; } = 100;
        public float initial_thirst { get; set; } = 100;

        public int actual_day { get; set; } = 0;
        public int actual_season { get; set; } = 0;
        public int actual_year { get; set; } = 0;
        public int actual_tick { get; set; } = 0;

        public static Dictionary<string, string> foodDatabase { get; set; }
    }
}
