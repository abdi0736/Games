namespace Games
{
    // World class to manage the game world
    public class World
    {
        public int MaxX { get; private set; }
        public int MaxY { get; private set; }
        private List<Creature> creatures;
        private List<WorldObject> objects;

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            creatures = new List<Creature>();
            objects = new List<WorldObject>();
        }

        // Add a creature to the world at a given position
        public void AddCreature(Creature creature, int x, int y)
        {
            if (IsWithinBounds(x, y))
            {
                creatures.Add(creature);
                Console.WriteLine($"{creature.Name} added to the world at position ({x}, {y})");
            }
            else
            {
                Console.WriteLine($"Position ({x}, {y}) is out of bounds. Creature could not be added.");
            }
        }

        // Add an object to the world
        public void AddObject(WorldObject worldObject, int x, int y)
        {
            if (IsWithinBounds(x, y))
            {
                objects.Add(worldObject);
                Console.WriteLine($"{worldObject.Name} added to the world at position ({x}, {y})");
            }
            else
            {
                Console.WriteLine($"Position ({x}, {y}) is out of bounds. Object could not be added.");
            }
        }

        // Check if a position is within bounds
        private bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < MaxX && y >= 0 && y < MaxY;
        }

        // Move a creature to a new position
        public bool MoveCreature(Creature creature, int newX, int newY)
        {
            if (IsWithinBounds(newX, newY))
            {
                Console.WriteLine($"{creature.Name} moves to position ({newX}, {newY})");
                return true;
            }
            else
            {
                Console.WriteLine($"Move to ({newX}, {newY}) is out of bounds.");
                return false;
            }
        }

        // Get all creatures in the world
        public List<Creature> GetCreatures() => creatures;

        // Get all objects in the world
        public List<WorldObject> GetObjects() => objects;
    }