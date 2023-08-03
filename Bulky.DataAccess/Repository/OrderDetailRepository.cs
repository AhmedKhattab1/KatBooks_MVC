﻿using Bulky.DataAccess.Data;
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
	public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
		private readonly ApplicationDbContext _context;

		public OrderDetailRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Save()
		{
			_context.SaveChanges();
		}

		public void Update(OrderDetail obj)
		{
			_context.OrderDetails.Update(obj);
		}
	}
}