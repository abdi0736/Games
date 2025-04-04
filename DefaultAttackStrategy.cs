using System;
using System.Collections.Generic;
using System.Linq;

namespace Games
{
    // Default attack strategy
    public class DefaultAttackStrategy : IAttackStrategy
    {
        public int CalculateAttack(List<AttackItem> items)
        {
            int total = items.Sum(a => a.Hit);
            return total > 0 ? total : new Random().Next(5, 15); // Basic attack with randomness
        }
    }
    
}