using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplicaWhatsApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> TopFollowers { get; set; }
        public IEnumerable<string> FavoriteTech { get; set; }
        public IEnumerable<string> Achievements { get; set; }
        public ObservableCollection<string> ObservableAchievements { get; set; }
    }
}
