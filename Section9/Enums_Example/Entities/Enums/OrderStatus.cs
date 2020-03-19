using System;
using System.Collections.Generic;
using System.Text;

namespace Enums_Example.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        shipped = 2,
        Delivered = 3
    }
}
