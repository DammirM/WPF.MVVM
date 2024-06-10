using GoalKeepers.Domain.Models;
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
        Task<IEnumerable<GoalKeeperData>> GetAll();
        Task<GoalKeeperData> GetByName(string lastName);
        Task<GoalKeeperData> GetByHeight(int height);
        Task<GoalKeeperData> Create(GoalKeeperData Entity);
        Task<GoalKeeperData> Update(int Id, GoalKeeperData Entity);
        Task<GoalKeeperData> Delete(int Id);

        Task<IEnumerable<GoalKeeperViewer>> Execute();

    }
}
