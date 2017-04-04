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

        public void AddToCart(int id)
        {
            Purchase pc = new Purchase() { ProductID = id, AccountID = 228,};
            PurchaseRep.Create(pc);
            PurchaseRep.Save();
        }

        public string Registry(Account acc)
        {
            int n = 0;
            foreach (var a in AccountRep.GetList())
                if (a.Mail != acc.Mail)
                    n++;
            if (AccountRep.GetList().Count() == n)
                if (acc.Password1 == acc.Password2)
                {
                    acc.Password = acc.Password1;
                    AccountRep.Create(acc);
                    AccountRep.Save();
                    return "Регистрация прошла успешно";
                }
            return "Вы ввели некорректные данные, пожалуйста, повторите попытку и будьте внимательнее. Скорее всего аккаунт с такой почтой уже зарегистрирован, или вы ввели разные пароли";
        }

        public void AddRecall(Recall rec)
        {
            RecallRep.Create(rec);
            RecallRep.Save();
        }

        public void RemoveRecall(Recall rec)
        {
            RecallRep.Delete(rec.ID);
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
    }
}
