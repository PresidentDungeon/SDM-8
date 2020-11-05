using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetAll();
        Team GetById(int id);
        void Add(Team t);
        void Update(Team t);
        void Remove(Team t);
    }
}
