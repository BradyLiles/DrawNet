using System;
using System.Collections.Generic;

namespace DrawNet.Core.Membership.Base
{
    public class User
    {
        public class UserRegistrationInvite
        {
            internal string Email;
            internal DateTime Expiration { get; set; } = DateTime.Now.AddDays( 3 );
            public List<lkp_UserInvite_Role> UserRoles;

            public static void SendUserRegistrationInvite(UserRegistrationInvite userInvite)
            {

            }

            private static void CreateUserInvite( UserRegistrationInvite userInvite )
            {
                using ( var ctx = new DrawNetEntities() )
                {
                    Guid inviteCode = Guid.NewGuid();

                    ctx.tbl_UserInvite.Add( new tbl_UserInvite()
                    {
                        UserInvite_ID = Guid.NewGuid(),
                        Email = userInvite.Email,
                        ExpireDate = userInvite.Expiration,
                        InviteCode = inviteCode,
                        SentDate = DateTime.Now,
                        lkp_UserInvite_Role = new List<lkp_UserInvite_Role>( userInvite.UserRoles )
                    } );
                }
            }

        }
    }
}