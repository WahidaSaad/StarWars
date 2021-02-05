using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace TeleQuebecStarWars.Models
{
    public interface IRepository
    {
        IEnumerable<PersonnageModel> Personnages { get; }
    }
}
