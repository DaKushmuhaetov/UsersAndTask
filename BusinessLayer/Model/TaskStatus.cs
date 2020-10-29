using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Model
{
    public enum TaskStatus
    {
        DontStart,
        Process,
        Complete,
        Canceled,
        Rejected
    }
}
