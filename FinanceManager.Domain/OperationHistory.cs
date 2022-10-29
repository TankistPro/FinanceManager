using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Domain
{
    public class OperationHistory
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string? Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool isDeleted { get; set; } = false;

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
