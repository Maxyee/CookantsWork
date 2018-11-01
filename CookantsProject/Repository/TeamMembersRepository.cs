using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{

    #region // TeamMembersRepository Repository Interface
    public interface ITeamMembersRepository : IGenericRepository<TeamMember>
    {

    }
    #endregion

    #region TeamMembersRepository Repository Implementation
    public class TeamMembersRepository :
        GenericRepository<CookAntsDbContext, TeamMember>, ITeamMembersRepository
    {

    }
    #endregion
}
