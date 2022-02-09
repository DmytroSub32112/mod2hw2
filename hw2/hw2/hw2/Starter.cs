using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class Starter
    {
        private readonly CartService _cart;
        private readonly Person _person;
        private OrderService _order;
        public Starter()
        {
            _cart = new CartService();
            _person = new Person()
            {
                FirstName = "Subota",
                LastName = "Dima",
                Email = "subotic123@ukr.net",
                Telephone = "0953358307"
            };
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < 2; i++)
            {
                _cart.Add(rnd.Next(21));
            }

            _order = new OrderService()
            {
                Person = _person
            };

            _order.Make();
        }
    }
}
