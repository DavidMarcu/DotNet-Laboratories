using System;

namespace Product.Data
{
    public class Product
    {
        public int Id{get; set;}
        public String Name{get; set;}
        public String Description{get; set;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public float Price{get; set;}
        public float VAT{get; set;}

        public bool IsValid(){
         //   if(this.startDate == null || this.endDate == null)
         //       return false;
            return this.StartDate < this.EndDate;
        }

        public float ComputeVat(){
            return this.Price * 0.1f;
        }
    }
}

