using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinanceManager.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Code { get; set; }
        public string Balance { get; set; }
        public string? AvatarHash { get; set; }

        public List<OperationHistory> OperationHistories { get; set; }
    }
}
