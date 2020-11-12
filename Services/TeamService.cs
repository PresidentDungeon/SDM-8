using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class TeamService
    {
        private ITeamRepository TeamRepository;


        public TeamService(ITeamRepository teamRepository)
        {
            this.TeamRepository = teamRepository ?? throw new ArgumentException("TeamRepository is missing");
        }

        public Team createTeam(int id, string teamName)
        {
            if (string.IsNullOrEmpty(teamName)){
                throw new ArgumentException("Team name can't be null or empty");
            }

            if(this.TeamRepository.GetById(id) != null)
            {
                throw new ArgumentException("Team with same ID already exists");
            }

            if(id < 0)
            {
                throw new ArgumentException("ID value can't be negative");
            }

            return new Team { ID = id, Name = teamName, Students = new List<Student>()};
        }
    }
}
