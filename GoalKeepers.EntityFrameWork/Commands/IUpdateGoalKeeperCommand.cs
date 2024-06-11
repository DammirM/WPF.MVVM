using GoalKeepers.EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork.Commands
{
    public interface IUpdateGoalKeeperCommand
    {
        Task Execute(GoalKeeperViewer goalKeeperViewer);
    }
}
