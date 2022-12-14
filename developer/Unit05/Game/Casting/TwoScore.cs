using System;


namespace Unit05_cycle.Game.Casting{

    public class TwoScore : Actor
    {
        private int points = 0;

        public TwoScore()
        {
            AddPointsTwo(0);
        }

        public void AddPointsTwo(int points)
        {
            this.points += points;
            SetText($"Player Two: {this.points}");
        }
    }
}