using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels;
public class Role : IdentityRole<int>
{
    public virtual RoleValue RoleValue { get; set; }

    public Role(string name, RoleValue roleValue) 
    {
        this.RoleValue = roleValue;
        this.Name = name;
    }

    public Role()
    {
    }
}