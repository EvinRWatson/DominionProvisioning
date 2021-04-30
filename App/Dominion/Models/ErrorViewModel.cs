using System;

namespace Dominion.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
