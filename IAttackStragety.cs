namespace Games;

public interface IAttackStrategy
{
    int CalculateAttack(List<AttackItem> items);
}
