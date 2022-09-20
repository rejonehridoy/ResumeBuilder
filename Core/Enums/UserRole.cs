using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum UserRole
    {
        [Description("Registerd")]
        Registerd = 1,
        [Description("Admin")]
        Admin = 2
    }
}
