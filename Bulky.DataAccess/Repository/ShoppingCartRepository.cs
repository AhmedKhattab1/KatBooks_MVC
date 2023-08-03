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
	public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
		private readonly ApplicationDbContext _context;

		public ShoppingCartRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Save()
		{
			_context.SaveChanges();
		}

		public void Update(ShoppingCart obj)
		{
			_context.ShoppingCarts.Update(obj);
		}
	}
}
