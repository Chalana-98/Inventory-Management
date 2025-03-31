using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventry_Pro.BL.Dtos
{
    public class AccountDto
    {
    }
    public class AccountGridViewResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactPrimary { get; set; }
        public string ContactAditional { get; set; }
        public string PrimaryAddress { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? Join_date { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public bool? EmailConfirmed { get; set; }

    }
}
