using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class VisitorPatternTest
    {
        List<IStore> store = new List<IStore>();
        public VisitorPatternTest()
        {            
            store.Add(new Car() { Price = 200 });
            store.Add(new Car() { Price = 100 });

            store.Add(new Bike() { Price = 50 });
            store.Add(new Bike() { Price = 30 });
        }

        [TestMethod]
        public void PricesWithDiscountTest()
        {
            DiscountVisitor visitor = new DiscountVisitor();
            store[0].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterDicount == 160);
            store[1].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterDicount == 80);
        }
    }

    public interface IStore
    {
        void Visit(IVisitor visitor);
    }

    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }

    public class Car : IStore
    {        
        public decimal Price { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);            
        }
    }

    public class Bike : IStore
    {        
        public decimal Price { get; set; }        

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }

    public class DiscountVisitor : IVisitor
    {
        private const int CAR_DISCOUNT = 20;
        private const int BIKE_DISCOUNT = 10;

        public decimal PriceAfterDicount;

        public void Accept(Car car)
        {
            PriceAfterDicount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);            
        }

        public void Accept(Bike bike)
        {
            PriceAfterDicount = bike.Price - ((bike.Price / 100) * BIKE_DISCOUNT);            
        }
    }

    public class PriceWithTaxVisitor : IVisitor
    {
        private const int VAT = 20;
        
        public decimal PriceAfterTax;

        public void Accept(Car car)
        {
            PriceAfterTax = car.Price + ((car.Price / 100) * VAT);
        }

        public void Accept(Bike bike)
        {
            PriceAfterTax = bike.Price - ((bike.Price / 100) * VAT);
        }
    }
}
