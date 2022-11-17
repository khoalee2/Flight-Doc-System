using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flight_Doc_System.Models
{
    public class RoleViewModel
    {
        public RoleViewModel()
        {

        }

        public RoleViewModel(ApplicationRole role)
        {
            RoleName = role.Name;
            Id = role.Id;
        }

        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}