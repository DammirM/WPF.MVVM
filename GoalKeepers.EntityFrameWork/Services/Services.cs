using GoalKeepers.Domain.Services;
using GoalKeepers.EntityFrameWork.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoalKeepers.EntityFrameWork.Models;

namespace GoalKeepers.EntityFrameWork.Services
{
    public class Services : IGoalKeeperService
    {
        private readonly GoalKeeperViewerDbContext _dbContext;

        public Services(GoalKeeperViewerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GoalKeeperViewer> Create(GoalKeeperViewer entity)
        {
            var dto = new GoalKeeperViewerDto
            {
                Id = entity.Id,
                LastName = entity.LastName,
                Team = entity.Team,
                Crosses = entity.Crosses,
                GoalLineKeeper = entity.GoalLineKeeper,
                Reflexes = entity.Reflexes,
                AttackingKeeper = entity.AttackingKeeper,
                GoodWithFeet = entity.GoodWithFeet,
                SweeperKeeper = entity.SweeperKeeper
            };

             _dbContext.GoalKeeperViewers.AddAsync(dto);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<GoalKeeperViewer> Delete(Guid id)
        {
            var keeperToDelete = await _dbContext.GoalKeeperViewers.FirstOrDefaultAsync(x => x.Id == id);
            if (keeperToDelete != null)
            {
                _dbContext.GoalKeeperViewers.Remove(keeperToDelete);
                await _dbContext.SaveChangesAsync();

                return new GoalKeeperViewer(
                    keeperToDelete.Id,
                    keeperToDelete.LastName,
                    keeperToDelete.Team,
                    keeperToDelete.Crosses,
                    keeperToDelete.GoalLineKeeper,
                    keeperToDelete.Reflexes,
                    keeperToDelete.AttackingKeeper,
                    keeperToDelete.GoodWithFeet,
                    keeperToDelete.SweeperKeeper);
            }
            return null;
        }

        public Task<IEnumerable<GoalKeeperViewer>> Execute()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GoalKeeperViewer>> GetAll()
        {
            var goalKeeperViewersDto = await _dbContext.GoalKeeperViewers.ToListAsync();
            return goalKeeperViewersDto.Select(g => new GoalKeeperViewer(
                g.Id,
                g.LastName,
                g.Team,
                g.Crosses,
                g.GoalLineKeeper,
                g.Reflexes,
                g.AttackingKeeper,
                g.GoodWithFeet,
                g.SweeperKeeper));
        }

        public async Task<GoalKeeperViewer> Update(GoalKeeperViewer entity)
        {
            var updateKeeper = await _dbContext.GoalKeeperViewers.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (updateKeeper != null)
            {
                updateKeeper.LastName = entity.LastName;
                updateKeeper.Team = entity.Team;
                updateKeeper.Crosses = entity.Crosses;
                updateKeeper.GoalLineKeeper = entity.GoalLineKeeper;
                updateKeeper.AttackingKeeper = entity.AttackingKeeper;
                updateKeeper.SweeperKeeper = entity.SweeperKeeper;
                updateKeeper.Reflexes = entity.Reflexes;
                updateKeeper.GoodWithFeet = entity.GoodWithFeet;

                await _dbContext.SaveChangesAsync();

                return new GoalKeeperViewer(
                    updateKeeper.Id,
                    updateKeeper.LastName,
                    updateKeeper.Team,
                    updateKeeper.Crosses,
                    updateKeeper.GoalLineKeeper,
                    updateKeeper.Reflexes,
                    updateKeeper.AttackingKeeper,
                    updateKeeper.GoodWithFeet,
                    updateKeeper.SweeperKeeper);
            }
            return null;
        }

    }
}
