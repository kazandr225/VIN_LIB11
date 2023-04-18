using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetVINCountry_CorrectValue_Oceania() //номер Океании
        {           
            string vin = "61NXBB02E9TZ393131";
            string expected = "Океания";
            
            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_Africa() //номер Африки
        {
            string vin = "AJH4KA4561JC021254";
            string expected = "Африка";

            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_Azia() //номер Азии
        {
            string vin = "AJH4KA4561JC021254";
            string expected = "Африка";

            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_Europ() //номер Европы
        {
            string vin = "S2T1KR32EX4C175599";
            string expected = "Европа";

            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_NorthernAmerica() //номер Северной Америки
        {
            string vin = "1JH4KA4640JC021212";
            string expected = "Северная Америка";

            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_SouthAmerica() //номер Южной Америки
        {
            string vin = "9SAJWA1C78D8V38055";
            string expected = "Южная Америка";

            Class1 class1 = new Class1();
            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        //
    }
}


