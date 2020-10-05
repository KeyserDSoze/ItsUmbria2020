
using ItsUmbria2020.OnlineGame.Library.Base.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace ItsUmbria2020.OnlineGame.Library.Orchestration
{
    public class Controller
    {
        private static readonly object trafficLight = new object(); 
        private static Controller gameManager = null;
        public static Controller Instance()
        {
            if (gameManager == null)
            {
                lock (trafficLight)
                { 
                    if (gameManager == null) 
                    { 
                        gameManager = new Controller();
                    }
                }
            }
            return gameManager;
        }
        public static Dictionary<string, Lobby> Lobbies { get; } = new Dictionary<string, Lobby>();
        public void PrintAllPlayers()
        {
            foreach (Lobby lobby in Lobbies.Values)
            {
                Console.WriteLine($"\n{lobby.Name}");
                foreach (var character in lobby.Characters)
                {
                    character.PrintInfo();
                }
            }
        }
        public Lobby GetLobbyInstance(string id, string name) 
        {
            Lobby lobby = null;
            if (Lobbies.ContainsKey(id))
            {
                lobby = Lobbies[id];
            }
            else 
            {
                lock (trafficLight) 
                {
                    if (Lobbies.ContainsKey(id))
                    {
                        lobby = Lobbies[id];
                    }
                    else
                    {
                        CreateLobby(name);
                    }
                }
            }
            return lobby;
        }
        public void CreateLobby(string name) 
        {
            var lobby = new Lobby(name);
            Lobbies.Add(lobby.Id, lobby);
        }
        public void RemoveLobby(string id)
        {
            Lobbies.Remove(id);
        }
    }
}

