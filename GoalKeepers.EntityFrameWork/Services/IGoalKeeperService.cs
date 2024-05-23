using GoalKeepers.Domain.Models;
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
        Task<GoalKeeperData> Create(GoalKeeperData Entity);
        Task<GoalKeeperData> Update(int Id, GoalKeeperData Entity);
        Task<GoalKeeperData> Delete(int Id);
    }
}
