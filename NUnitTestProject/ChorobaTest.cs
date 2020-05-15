using NUnit.Framework;
using System.Collections.Generic;
using zadaniaRoznev2;

namespace NUnitTestProject
{
    [TestFixture]
    class TestChoroba
    {
        [Test]

        public void CanAddMedicineToList()
        {
            var choroba = new Choroba("name", "startDate");
            choroba.addMedicine("Apap");

            Assert.That(choroba.Medicines[0], Is.EqualTo("Apap"));
        }
        [Test]

        public void ReturnChorobaName()
        {
            var choroba = new Choroba("name", "startDate");
            var name = choroba.getName();
           
            Assert.That(name, Is.EqualTo("name"));
           
        }
        
        [Test]
        [TestCase("19.02.20")]
        public void UpdateEndDateChoroba(string endDate)
        {
            var choroba = new Choroba("name", "startDate");

            var result = choroba.endChoroba(endDate);
            Assert.That(result, Is.EqualTo(true));
       }
        [Test]
        [TestCase(0, "Paracetamol")]
        [TestCase(1, "Ibuprom")]
        [TestCase(2, "Apap")]
        public void ProperlyShowsMedicinesByIndex(int index, string expected)
        {
            var choroba = new Choroba("nazwa", "startDate");
            choroba.addMedicine("Paracetamol");
            choroba.addMedicine("Ibuprom");
            choroba.addMedicine("Apap");
            var wartosc = choroba.showMedincineByIndex(index);
            Assert.That(wartosc, Is.EqualTo(expected));
        }

    }
}