using DAL;
using DAL.Entity;
using System;
using System.Linq;
using System.Web.Security;

namespace UI.Utils
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] role = new string[] { };

            using(ApplicationContext db = new ApplicationContext())
            {
                User user = db.Userr.FirstOrDefault(p => p.Name == username);

                if(user != null)
                {
                    Role userRole = db.Roless.Find(user.RoleId);

                    if(userRole != null)
                    {
                        role = new string[] { userRole.Name };
                    }
                }
            }
                return role;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool result = false;

            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Userr.FirstOrDefault(p => p.Name == username);

                if(user != null)
                {
                    Role userRole = db.Roless.Find(user.RoleId);

                    if (userRole != null && userRole.Name == roleName)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}