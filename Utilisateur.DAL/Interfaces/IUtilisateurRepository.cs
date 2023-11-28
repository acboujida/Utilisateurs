using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilisateur.DTO;

namespace Utilisateur.DAL.Interfaces
{
    public interface IUtilisateurRepository
    {
        public IEnumerable<UtilisateurDTO> Get();
    }
}
