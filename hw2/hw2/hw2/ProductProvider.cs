using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    public class ProductProvider
    {
        public ProductProvider()
        {
            Products = new Product[21];
            Init();
        }

        public Product[] Products { get; }
        public void Init()
        {
            Products[0] = new Product("Картопля", 30);
            Products[1] = new Product("Огірок", 20);
            Products[2] = new Product("Томати", 40);
            Products[3] = new Product("Печериці", 60);
            Products[4] = new Product("Перець", 65);
            Products[5] = new Product("Сир", 350);
            Products[6] = new Product("Куриця", 120);
            Products[7] = new Product("Свинина", 140);
            Products[8] = new Product("Творог", 45);
            Products[9] = new Product("Капуста", 10);
            Products[10] = new Product("Гречка", 30);
            Products[11] = new Product("Рис", 20);
            Products[12] = new Product("Пшениця", 25);
            Products[13] = new Product("Булгур", 43);
            Products[14] = new Product("Пиво", 45);
            Products[15] = new Product("Чіпси", 30);
            Products[16] = new Product("Сметана", 45);
            Products[17] = new Product("Молоко", 20);
            Products[18] = new Product("Каша вівсяна", 20);
            Products[19] = new Product("Лимонад", 10);
            Products[20] = new Product("Яйця", 25);
        }
    }
}
