namespace Games;

// Defence item class
    public class DefenceItem : WorldObject
    {
        public int ReduceHitPoint { get; set; }

        public DefenceItem(string name, int reduceHitPoint)
            : base(name, true, false) // Lootable by default
        {
            ReduceHitPoint = reduceHitPoint;
        }
    }
