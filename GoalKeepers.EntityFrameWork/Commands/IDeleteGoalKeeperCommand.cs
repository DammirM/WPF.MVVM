﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork.Commands
{
    public interface IDeleteGoalKeeperCommand
    {
        Task Execute(Guid Id);
    }
}
