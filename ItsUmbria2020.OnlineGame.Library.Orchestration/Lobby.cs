using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;
using ItsUmbria2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Orchestration
{
    public class Lobby : GameObject
    {
        public Lobby(string name) => Name = name;
        public string Name { get; }
        public List<Character> Characters { get; } = new List<Character>();
        public void AddPlayers(params Character[] characters) => Characters.AddRange(characters);
        public void RemovePlayers(params Character[] characters)
        {
            foreach (var character in characters)
            {
                Characters.Remove(character);
            }
        }
        public Character GetFirstPlayer() => this.Characters.FirstOrDefault();
        public Character GetSecondPlayer() => this.Characters.Skip(1).FirstOrDefault();
    }
}
