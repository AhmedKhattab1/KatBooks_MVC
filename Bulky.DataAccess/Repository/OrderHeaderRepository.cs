using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
	public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
		private readonly ApplicationDbContext _context;

		public OrderHeaderRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Save()
		{
			_context.SaveChanges();
		}

		public void Update(OrderHeader obj)
		{
			_context.OrderHeaders.Update(obj);
		}

		public void UpdateStatus(int id, string OrderStatus, string? paymentStatus = null)
		{
			var orderFromDb = _context.OrderHeaders.FirstOrDefault(u => u.Id == id);
			if(orderFromDb != null)
			{
				orderFromDb.OrderStatus = OrderStatus;
				if(!string.IsNullOrEmpty(paymentStatus))
				{
					orderFromDb.PaymentStatus= paymentStatus;
				}
			}
		}

		public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
		{
			var orderFromDb = _context.OrderHeaders.FirstOrDefault(u => u.Id == id);
			if(!string.IsNullOrEmpty(sessionId))
			{
				orderFromDb.SessionId = sessionId;
			}
			if (!string.IsNullOrEmpty(paymentIntentId))
			{
				orderFromDb.PaymentIntentId = paymentIntentId;
				orderFromDb.PaymentDate = DateTime.Now;
			}
		}
	}
}
