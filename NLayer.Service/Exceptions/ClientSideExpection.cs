using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Exceptions
{
    public class ClientSideExpection:Exception
    {
        public ClientSideExpection(string message):base(message) 
        {
            
        }
    }
}
