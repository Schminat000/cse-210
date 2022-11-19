using Unit05_cycle.Game.Casting;


namespace Unit05_cycle.Game.Scripting 
{
    public interface Action
    {
        void Execute(Cast cast, Script script);
    }
}