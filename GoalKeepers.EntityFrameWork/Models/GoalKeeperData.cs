using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.Domain.Models
{
    public class GoalKeeperData
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public int Height { get; set; }
        public bool Crosses { get; set; } = false;
        public bool GoalLine { get; set; } = false;
        public bool SweeperKeeper { get; set; } = false;
        public bool GoodFeet { get; set; } = false;
        public bool Reflexes { get; set; } = false;
        public bool AttackingKeeper { get; set; } = false;

    }
}
