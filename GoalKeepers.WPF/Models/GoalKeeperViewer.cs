using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Models
{
    public class GoalKeeperViewer
    {
        
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public bool Crosses { get; set; }
        public bool GoalLineKeeper { get; set; }
        public bool SweeperKeeper { get; set; } = false;
        public bool GoodWithFeet { get; set; } = false;
        public bool Reflexes { get; set; } = false;
        public bool AttackingKeeper { get; set; } = false;

        public GoalKeeperViewer(Guid id, string lastName, string team, bool crosses, 
            bool goalLineKeeper, bool sweeperKeeper, bool goodWithFeet, bool reflexes, bool attackingKeeper)
        {
            Id = id;
            LastName = lastName;
            Team = team;
            Crosses = crosses;
            GoalLineKeeper = goalLineKeeper;
            SweeperKeeper = sweeperKeeper;
            GoodWithFeet = goodWithFeet;
            Reflexes = reflexes;
            AttackingKeeper = attackingKeeper;
        }




    }
}
