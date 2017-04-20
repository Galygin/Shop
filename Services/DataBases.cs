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
        /*SQLProductRepository ProductRep = new SQLProductRepository();
        SQLAccountRepository AccountRep = new SQLAccountRepository();
        SQLRecallRepository RecallRep = new SQLRecallRepository();
        SQLPurchaseRepository PurchaseRep = new SQLPurchaseRepository();*/
        //ProductContext db = new ProductContext();
        //ProductRepository<Product> Products = new ProductRepository<Product>(new ProductContext()); 

        ProductRepository products = new ProductRepository(new ProductContext());

        public void AddProduct(Product p)
        {
            products.Add(p);
            products.Save();
        }

        public IEnumerable<Product> ReturnProduct()
        {
            return products.Entities();
        }

        public void RemoveProduct(int id)
        {
            products.Delete(id);
            products.Save();
        }

        public void AddToCart(int id, string name)
        {
            /*Purchase pur = new Purchase()
            {
                ProductID = id,
                AccountName = name
            };
            PurchaseRep.Create(pur);
            PurchaseRep.Save();*/
        }

        public void AddRecall(/*Recall rec*/)
        {
           /* RecallRep.Create(rec);
            RecallRep.Save();*/
        }

        //public void RemoveRecall(int id)
        
            /*RecallRep.Delete(id);
            RecallRep.Save();*/
        

        //public IEnumerable<Recall> ReturnRecall()
        //{
            /*return RecallRep.GetList();*/
        //}


        //public IEnumerable<Purchase> ReturnPurchases()
       // {
           /* return PurchaseRep.GetList();*/
       // }
        
        public void RemovePurchase(int id)
        {

            /*PurchaseRep.Delete(id);
            PurchaseRep.Save();*/
        }
    }
}
