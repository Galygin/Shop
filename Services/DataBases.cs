using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository.Context;
using Repository.Repositories;

namespace Services
{
    public class DataBases
    {
        ProductRepository Products = new ProductRepository(new ProductContext());
        RecallRepository Recalls = new RecallRepository(new ProductContext());
        PurchaseRepository Purs = new PurchaseRepository(new ProductContext());


        //////////////////////// ДОБАВЛЕНИЕ УДАЛЕНИЕ ПРОДУКТОВ //////////////////////////////

        public void AddProduct(Product p)
        {
            Products.Add(p);
            Products.Save();
        }

        public IEnumerable<Product> ReturnProduct()
        {
            return Products.Entities();
        }

        public void RemoveProduct(int id)
        {
            Products.Delete(id);
            Products.Save();
        }

        /////////////////////////////// ДОБАВЛЕНИЕ УДАЛЕНИЕ ОТЗЫВОВ ///////////////////////////

        public void AddRecall(Recall rec)
        {
            Recalls.Add(rec);
            Recalls.Save();
        }

        public IEnumerable<Recall> ReturnRecalls()
        {
            return Recalls.Entities();
        }

        public void RemoveRecall(int id)
        {
            Recalls.Delete(id);
            Recalls.Save();
        }

        /////////////////////////////// ДОБАВЛЕНИЕ УДАЛЕНИЕ ПОКУПОК ///////////////////////////

        public void AddToCart(int id, string name)
        {
            var p = Purs.Entities();
            var l = Products.Entities();
            var buy = false;
            foreach (var i in p)
            {
                if ((i.ProductID == id) && (i.AccountName == name))
                {
                    Purchase pur1 = new Purchase()
                    {
                        ProductID = id,
                        AccountName = name,
                        Count = 1 + i.Count
                    };
                    Purs.Delete(i.ID);
                    Purs.Add(pur1);
                    buy = true;
                }
            }
            if (buy == false)
            {
                Purchase pur = new Purchase()
                {
                    ProductID = id,
                    AccountName = name,
                    Count = 1
                };
                Purs.Add(pur);
            }
            Purs.Save();
        }

        public IEnumerable<Purchase> ReturnPurchases()
        {
            return Purs.Entities();
        }

        public void RemovePurchase(int id)
        {

            Purs.Delete(id);
            Purs.Save();
        }
    }
}
