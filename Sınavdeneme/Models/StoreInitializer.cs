using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sınavdeneme.Models
{
    public class StoreInitiliazer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {

            List<Category> category = new List<Category>
            {
                new Category(){CategoryName="Gül"},
                new Category(){CategoryName="Papatya"},
                new Category(){CategoryName="Orkide"},
                new Category(){CategoryName="Lale"},
            };

            foreach (var item in category)
            {
                context.t_category.Add(item);
            }

            context.SaveChanges();

            List<Flower> products = new List<Flower>
            {
                new Flower(){Name="Kırmızı Gül",Price=89.99,Content="Kırmızı güller çok güzel...",Image="resim1.jpg",CategoryId=1},
                new Flower(){Name="Taze Papatya",Price=59.99,Content="Papatyalar çok güzel...",Image="resim2.jpg",CategoryId=2},
                new Flower(){Name="Asil Orkide",Price=89.99,Content="Beyaz Orkideler çok güzel...",Image="resim3.jpg",CategoryId=3},
                new Flower(){Name="Laleler",Price=89.99,Content="Laleler çok güzel...",Image="resim4.jpg",CategoryId=4},
            };

            foreach (var item in products)
            {
                context.t_flower.Add(item);
            }

            context.SaveChanges();




            base.Seed(context);
        }

    }
}