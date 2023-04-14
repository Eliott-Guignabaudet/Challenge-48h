namespace DefaultNamespace
{
    public static class Archetype
    {
        public static readonly Stats Ratus = new Stats(37,70,20,59);
        public static readonly Stats Leader = new Stats(45,20,70,50);
        public static readonly Stats Acharné = new Stats(20,51,45,70);
        public static readonly Stats Gamer = new Stats(70,47,51,20);

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