

using System;


namespace Chess
{
    public interface IPlayerObserver
    {
        void OnPlayerMove(Player player, Piece piece, int startX, int startY, int endX, int endY);
    }


    public class Player
    {
        private List<IPlayerObserver> observers;
        public string Name { get; set; }
        public string Color { get; set; }
        

        public Player(string name, string color)
        {   
            Name = name;
            Color = color;
            observers = new List<IPlayerObserver>();
        }

        public void RegisterObserver(IPlayerObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IPlayerObserver observer)
        {
            observers.Remove(observer);
        }

        public void MakeMove(Piece piece, int startX, int startY, int endX, int endY)
        {
            // Perform the player's move
            
            // Notify observers about the move
            foreach (var observer in observers)
            {
                observer.OnPlayerMove(this, piece, startX, startY, endX, endY);
            }
        }
    }

}