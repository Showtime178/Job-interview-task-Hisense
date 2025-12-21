using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class RepositoryResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
    
}
