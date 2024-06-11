using GoalKeepers.EntityFrameWork.DTOs;
using GoalKeepers.EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.Domain.Services
{
    public interface IGoalKeeperService
    {

        // CRUD
        Task<IEnumerable<GoalKeeperViewer>> GetAll();
        Task<GoalKeeperViewer> Create(GoalKeeperViewer Entity);
        Task<GoalKeeperViewer> Update(GoalKeeperViewer Entity);
        Task<GoalKeeperViewer> Delete(Guid id);

        // Query

        Task<IEnumerable<GoalKeeperViewer>> Execute();

    }
}
