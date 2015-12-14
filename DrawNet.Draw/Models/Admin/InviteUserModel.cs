using System.Collections.Generic;
using DrawNet.Core;

namespace DrawNet.Draw.Models.Admin
{
    public class InviteUserModel
    {
        public string UserEmail { get; set; } 
        public List< AspNetRole >  UserRoles { get; set; }
    }
}