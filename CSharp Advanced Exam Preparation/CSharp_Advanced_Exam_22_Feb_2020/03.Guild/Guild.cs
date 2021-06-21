using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private const string RANK_MEMBER = "Member";
        private const string RANK_TRIAL = "Trial";

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Roster = new HashSet<Player>();
        }

        public HashSet<Player> Roster { get; set; }

        public string Name { get; set; }

        public int Capacity { get; private set; }

        public int Count => Roster.Count;

        public void AddPlayer(Player player)
        {
            if (this.Count < this.Capacity)
            {
                this.Roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player playerToRemove = this.Roster.FirstOrDefault(p => p.Name == name);

            if (playerToRemove != null)
            {
                Roster.Remove(playerToRemove);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player playerToChangeRank = this.Roster.FirstOrDefault(p => p.Name == name);

            if (playerToChangeRank != null)
            {
                playerToChangeRank.Rank = RANK_MEMBER;
            }
        }

        public void DemotePlayer(string name)
        {
            Player playerToChangeRank = this.Roster.FirstOrDefault(p => p.Name == name);

            if (playerToChangeRank != null)
            {
                playerToChangeRank.Rank = RANK_TRIAL;
            }
        }

        public Player[] KickPlayersByClass(string klass)
        {
            Player[] removedPlayers = this.Roster.Where(p => p.Class == klass).ToArray();

            if (removedPlayers != null)
            {
                this.Roster = this.Roster.Where(p => p.Class != klass).ToHashSet();
            }

            return removedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in this.Roster)
            {
                sb.AppendLine($"{player}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
