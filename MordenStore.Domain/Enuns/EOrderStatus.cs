using System;

namespace MordenStore.Domain.Enuns
{
    public enum EOrderStatus
    {
        Created = 1,
        InProgress = 2,
        OutForDelivery = 3,
        Delivery = 4,
        Canceled = 5
    }
}
