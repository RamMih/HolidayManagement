﻿using HolidayManagement.Repository.Interfaces;
using HolidayManagement.Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace HolidayManagement.Repository
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public Team GetTeamById(int teamId)
        {
            return DbContext.Teams.FirstOrDefault(x => x.ID == teamId);
        }      

        public List<Team> GetTeams()
        {
            return DbContext.Teams.ToList();
        }        
    }
}
