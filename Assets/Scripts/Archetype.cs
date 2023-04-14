namespace DefaultNamespace
{
    public static class Archetype
    {
        public static readonly Stats Analyst = new Stats(44,26,18,59);
        public static readonly Stats Diplomat = new Stats(56,35,40,69);
        public static readonly Stats Explorer = new Stats(38,54,29,48);
        public static readonly Stats Sentinel = new Stats(49,23,45,56);

        public struct Stats
        {
            public int hunger;
            public int sold;
            public int sociability;
            public int knowledge;

            public Stats(int hunger , int sold, int sociability, int knowledge)
            {
                this.hunger = hunger;
                this.sold = sold;
                this.sociability = sociability;
                this.knowledge = knowledge;
            }
        }
    }
}