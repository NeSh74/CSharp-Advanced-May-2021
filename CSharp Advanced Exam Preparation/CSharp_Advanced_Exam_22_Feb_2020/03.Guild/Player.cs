using System.Text;

namespace Guild
{
    public class Player
    {
        private const string DEFAULT_RANK = "Trial";
        private const string DEFAULT_DISCREPTION = "n/a";

        public Player(string name, string klass)
        {
            this.Name = name;
            this.Class = klass;
            this.Rank = DEFAULT_RANK;
            this.Description = DEFAULT_DISCREPTION;
        }

        public string Name { get; private set; }

        public string Class { get; private set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.AppendLine($"Description: {this.Description}");
            return sb.ToString().TrimEnd();
        }
    }
}