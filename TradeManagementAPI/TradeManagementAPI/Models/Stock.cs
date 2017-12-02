using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TradeManagementAPI
{
    public class Stock
    {
        [Key]
        public int StockId
        {
            get => default(int);
            set
            {
            }
        }

        public string StockName
        {
            get => default(string);
            set
            {
            }
        }

        public string StockCode
        {
            get => default(string);
            set
            {
            }
        }

        public double NSEPrice
        {
            get => default(double);
            set
            {
            }
        }

        public double BSEPrice
        {
            get => default(double);
            set
            {
            }
        }

        public bool AddStock()
        {
            throw new System.NotImplementedException();
        }

        public bool ModifyStock()
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteStock()
        {
            throw new System.NotImplementedException();
        }

        public List<Stock> GetStocks()
        {
            throw new System.NotImplementedException();
        }
    }
}