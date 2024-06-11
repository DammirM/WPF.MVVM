using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork.DTOs
{
    public class GoalKeeperViewerDto
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

    }
}
