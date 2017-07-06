using System;
using System.Collections.Generic;
using Module5.Regular.ReadStack.Model;

namespace Module5.Regular.Server.Models
{
    public class RegisterViewModel : ViewModelBase
    {
        public RegisterViewModel()
        {
            Id = "";
            Team1 = "";
            Team2 = "";
            Matches = new List<Match>();
        }

        public IList<Match> Matches { get; set; }
        public String Team1 { get; set; }
        public String Team2 { get; set; }
        public String Id { get; set; }
    }
}