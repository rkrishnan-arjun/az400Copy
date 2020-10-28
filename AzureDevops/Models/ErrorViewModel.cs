using System;

namespace AzureDevops.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        // Merge commit.
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
