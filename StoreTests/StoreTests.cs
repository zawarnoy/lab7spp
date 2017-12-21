using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreApplication.Store.CashBox;
using StoreApplication.Store.Products.MilkProducts;
using StoreApplication.Store.Products.MilkProducts.Milk;
using StoreApplication.Store.Products.Sweets.Candies;
using StoreApplication.Store.CashBox.Scanner;

namespace StoreTests
{
    [TestClass]
    public class StoreTests
    {

        CashBox cashBox = new CashBox();
        MilkProstokvashino milk = new MilkProstokvashino();
        CandyBelochka candy = new CandyBelochka();


        [TestMethod]
        public void addProstokvashino_getPrice20()
        {

            // arrange
            double expected = 20;


            // act
            cashBox.addProductToCheck(milk);
            double actual = cashBox.getPrice();

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void addProstokvashino5x_getPrice80()
        {

            // arrange
            double expected = 80;
            
            // act
            for(int i=0; i<5; i++)
                cashBox.addProductToCheck(milk);

            double actual = cashBox.getPrice();

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void addProstokvashino5x_addCandyBelochka_getPrice90()
        {

            // arrange
            double expected = 90;

            // act
            for (int i = 0; i < 5; i++)
                cashBox.addProductToCheck(milk);
            cashBox.addProductToCheck(candy);
            double actual = cashBox.getPrice();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void addProstokvashino5x_addCandyBelochka6x_getPrice110()
        {

            // arrange
            CashBox cashBox = new CashBox();
            MilkProstokvashino milk = new MilkProstokvashino();
            CandyBelochka candy = new CandyBelochka();
            double expected = 110;

            // act
            for (int i = 0; i < 5; i++)
                cashBox.addProductToCheck(milk);
            for (int i = 0; i < 6; i++)
                cashBox.addProductToCheck(candy);
            double actual = cashBox.getPrice();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void testScannerOnMilk()
        {
            //arrage
            BarcodeScanner scanner = new BarcodeScanner();

            //act
            string actual = scanner.scanProduct(milk);

            //assert
            Assert.AreEqual(milk.barcode, actual);
        }

        [TestMethod]
        public void testScannerOnCandy()
        {
            //arrage
            BarcodeScanner scanner = new BarcodeScanner();

            //act
            string actual = scanner.scanProduct(candy);

            //assert
            Assert.AreEqual(candy.barcode, actual);
        }



    }
}
