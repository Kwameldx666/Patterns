namespace Patterns.Repeat.Visitor2
{
    public interface ICharacterVisitor
    {
        public void VisitEnemy(Enemy enemy);
        public void VisitWarrior(Warrior warrior);
    }
}