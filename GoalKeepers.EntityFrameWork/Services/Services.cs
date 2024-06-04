using GoalKeepers.Domain.Models;
using GoalKeepers.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork.Services
{
    public class Services : IGoalKeeperService
    {

        private readonly GoalKeeperDataDbContext _dbContext;

        public Services(GoalKeeperDataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GoalKeeperData> Create(GoalKeeperData Entity)
        {
            var createKeeper = await _dbContext.AddAsync(Entity);
            await _dbContext.SaveChangesAsync();
            return createKeeper.Entity;
        }

        public async Task<GoalKeeperData> Delete(int Id)
        {
            var keeperToDelete = await _dbContext.keepers.FirstOrDefaultAsync(x => x.ID == Id);
            if (keeperToDelete != null)
            {
                _dbContext.keepers.Remove(keeperToDelete);
                await _dbContext.SaveChangesAsync();
                return keeperToDelete;
            }
            return null;
        }

        public async Task<IEnumerable<GoalKeeperData>> GetAll()
        {
            return await _dbContext.keepers.ToListAsync();
        }

        public async Task<GoalKeeperData> GetByHeight(int height)
        {
            var getByHeight = await _dbContext.keepers.FirstOrDefaultAsync(x => x.Height == height);
            if (getByHeight == null)
            {
                return getByHeight;
            }
            return null;
        }

        public async Task<GoalKeeperData> GetByName(string lastName)
        {
            var getById = await _dbContext.keepers.FirstOrDefaultAsync(x => x.LastName == lastName);
            if (getById == null)
            {
                return getById;
            }
            return null;
        }

        public async Task<GoalKeeperData> Update(int Id, GoalKeeperData Entity)
        {
            var updateKeeper = await _dbContext.keepers.FirstOrDefaultAsync(x => x.ID == Entity.ID);
            if (updateKeeper != null)
            {
                updateKeeper.GoodFeet = Entity.GoodFeet;
                updateKeeper.GoalLine = Entity.GoalLine;
                updateKeeper.Crosses = Entity.Crosses;
                updateKeeper.Reflexes = Entity.Reflexes;
                updateKeeper.AttackingKeeper = Entity.AttackingKeeper;
                updateKeeper.FirstName = Entity.FirstName;
                updateKeeper.LastName = Entity.LastName;
                updateKeeper.Team = Entity.Team;
                updateKeeper.Height = Entity.Height;
                updateKeeper.SweeperKeeper = Entity.SweeperKeeper;

                await _dbContext.SaveChangesAsync();


                return updateKeeper;
            }
            return null;
        }
    }
}
