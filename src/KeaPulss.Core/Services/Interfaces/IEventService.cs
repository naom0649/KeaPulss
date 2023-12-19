using KeaPulss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeaPulss.Core.Services.Interfaces
{
    public interface IEventService
    {
        public IEnumerable<EventPage>? GetAll();
    }
}
