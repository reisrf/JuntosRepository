using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public enum PurchaseStatus
    {
        Open,
        WaitingPayment,
        Done,
        NotAuthorized,
        Canceled
    }

}
