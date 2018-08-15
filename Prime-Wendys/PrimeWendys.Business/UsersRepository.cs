using System;
using System.Collections.Generic;
using System.Linq;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;
using System.Text;

namespace PrimeWendys.Business
{
    public class UsersRepository
    {
        private readonly PrimeWendysDB db;

        public UsersRepository(PrimeWendysDB db)
        {
            this.db = db;
        }
        public virtual UserLogin Login(UserCredentials user)
        {
            UserLogin loggedUser = null;
            try
            {
                var usr = db.Users.FirstOrDefault(u => u.Email.Equals(user.Email, StringComparison.CurrentCultureIgnoreCase) && u.Password.Equals(user.Password));
                if (usr != null)
                {
                    var roles = db.Roles.Where(r => r.User_Id == usr.User_Id);
                    ICollection<RoleDto> roleDto = new List<RoleDto>();

                    ICollection<PermissionDto> permissions = new List<PermissionDto>();
                    if (roleDto != null)
                    {
                        foreach (Role role in roles)
                        {
                            roleDto.Add(new RoleDto
                            {
                                Role_Id = role.Role_Id,
                                Name = role.Name,
                                User_Id = role.User_Id
                            });

                            var functions = db.Permissions.Where(p => p.Role_Id == role.Role_Id);
                            if (functions != null)
                            {
                                foreach (Permission function in functions)
                                {
                                    permissions.Add(new PermissionDto
                                    {
                                        Per_Id = function.Per_Id,
                                        Name = function.Name,
                                        Role_Id = function.Role_Id
                                    });

                                }
                            }
                        }
                        loggedUser = new UserLogin
                        {
                            User = new UserDto
                            {
                                Email = usr.Email,
                                First_Name = usr.First_Name,
                                Last_Name = usr.Last_Name
                            }
                        };
                    }
                }

                return loggedUser;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public virtual void AddUser(UserDto user)
        {
            try
            {
                db.Users.Add(Helper.GetUsers(user));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual ICollection<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public virtual User GetUsers(int Id)
        {
            return db.Users.FirstOrDefault(u => u.User_Id == Id);
        }
    }
}
