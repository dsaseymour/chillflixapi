using System;
namespace Entities.Models
{

    public enum ERequestResponseStatus
    {
        None,
        Sent,
        Received,
        Accepted,
        Rejected,
        Blocked,
        Spam
    }

}
