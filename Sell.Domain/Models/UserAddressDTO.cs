using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell.Domain.Models
{
    public class UserAddressDTO
    {
        public string Address { get; set; }
        public bool IsCurrentAddress { get; set; }
    }
}
