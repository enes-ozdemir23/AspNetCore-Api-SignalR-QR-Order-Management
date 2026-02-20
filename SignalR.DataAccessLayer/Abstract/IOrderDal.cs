using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IOrderDal:IGenericDal<Order>
    {
        public int TotalOrderCount();

        public int ActiveOrderCount();

        public decimal LastOrderPrice();

        decimal TodayTotalPrice();

    }
}
