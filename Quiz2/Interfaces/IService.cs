using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Interfaces
{
    public interface IService
    {
        public string Transfer(string sourceCard , string destinationCard , float amount , string password);

    }
}
