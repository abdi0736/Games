   namespace Games;

public Creature(string name, int hitPoints, IAttackStrategy strategy)
        {
            Name = name;
            HitPoints = hitPoints;
            attackStrategy = strategy;
        }

        // Creature can attack
        public virtual int Hit()
        {
            return attackStrategy.CalculateAttack(attackItems);
        }

        // Creature receives hit damage
        public void ReceiveHit(int hit)
        {
            int totalDefense = defenceItems.Sum(d => d.ReduceHitPoint);
            HitPoints -= Math.Max(0, hit - totalDefense);

            if (HitPoints <= 0)
            {
                HitPoints = 0;
                Console.WriteLine($"{Name} has died.");
            }
            else
            {
                Console.WriteLine($"{Name} receives {hit} damage, reduced by {totalDefense}. Remaining HP: {HitPoints}");
            }
        }

        // Creature can loot an object (attack or defense items)
        public void Loot(WorldObject obj)
        {
            if (obj.Lootable)
            {
                Console.WriteLine($"{Name} looted {obj.Name}");

                if (obj is AttackItem attackItem)
                    EquipAttackItem(attackItem);
                else if (obj is DefenceItem defenceItem)
                    EquipDefenceItem(defenceItem);
            }
            else
            {
                Console.WriteLine($"{Name} cannot loot {obj.Name}");
            }
        }

        // Equip an attack item
        public void EquipAttackItem(AttackItem item)
        {
            attackItems.Add(item);
        }

        // Equip a defense item
        public void EquipDefenceItem(DefenceItem item)
        {
            defenceItems.Add(item);
        }
    }