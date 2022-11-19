using System.Collections.Generic;
using Unit05_cycle.Game.Casting;


namespace Unit05_cycle.Game.Scripting
{
    public class MoveActorsAction : Action
    {
        public MoveActorsAction()
        {
        }

        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            foreach(Actor actor in actors)
            {
                actor.MoveNext();
            }
        }
    }
}