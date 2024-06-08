using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.WPF.Models
{
    public class GoalKeeperViewer
    {

        public string LastName { get; set; }
        public bool Crosses { get; set; }
        public bool GoalLine { get; set; }

        public GoalKeeperViewer(string lastName, bool crosses, bool goalLine)
        {
            LastName = lastName;
            Crosses = crosses;
            GoalLine = goalLine;
        }
    }
}
