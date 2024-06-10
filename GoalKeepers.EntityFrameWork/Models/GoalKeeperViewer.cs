using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork.Models
{
    public class GoalKeeperViewer
    {

        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public bool Crosses { get; set; }
        public bool GoalLineKeeper { get; set; }
        public bool SweeperKeeper { get; set; }
        public bool GoodWithFeet { get; set; }
        public bool Reflexes { get; set; }
        public bool AttackingKeeper { get; set; }

        public GoalKeeperViewer(Guid id, string lastName, string team, bool crosses,
            bool goalLineKeeper, bool reflexes, bool attackingKeeper, bool goodWithFeet, bool sweeperKeeper)
        {
            Id = id;
            LastName = lastName;
            Team = team;
            Crosses = crosses;
            GoalLineKeeper = goalLineKeeper;
            Reflexes = reflexes;
            AttackingKeeper = attackingKeeper;
            GoodWithFeet = goodWithFeet;
            SweeperKeeper = sweeperKeeper;
        }
    }
}
