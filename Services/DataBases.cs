using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repository;

namespace Services
{
    public class DataBases
    {
        SQLProductRepository ProductRep = new SQLProductRepository();
        SQLAccountRepository AccountRep = new SQLAccountRepository();
        SQLRecallRepository RecallRep = new SQLRecallRepository();
        SQLPurchaseRepository PurchaseRep = new SQLPurchaseRepository();
        public void AddProduct(Product p)
        {
            ProductRep.Create(p);
            ProductRep.Save();
        }

        public void RemoveProduct(int id)
        {
            ProductRep.Delete(id);
            ProductRep.Save();
        }

        public void AddToCart(int id, string name)
        {
            Purchase pur = new Purchase()
            {
                ProductID = id,
                AccountName = name
            };
            PurchaseRep.Create(pur);
            PurchaseRep.Save();
        }

        public void AddRecall(Recall rec)
        {
            RecallRep.Create(rec);
            RecallRep.Save();
        }

        public void RemoveRecall(int id)
        {
            RecallRep.Delete(id);
            RecallRep.Save();
        }

        public IEnumerable<Recall> ReturnRecall()
        {
            return RecallRep.GetList();
        }

        public IEnumerable<Product> ReturnProduct()
        {
            return ProductRep.GetList();
        }

        public IEnumerable<Purchase> ReturnPurchases()
        {
            return PurchaseRep.GetList();
        }
        
        public void RemovePurchase(int id)
        {

            PurchaseRep.Delete(id);
            PurchaseRep.Save();
        }
    }
}
