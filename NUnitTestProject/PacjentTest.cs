using NUnit.Framework;
using System.Reflection.Metadata;
using zadaniaRoznev2;

namespace NUnitTestProject
{
    [TestFixture]
    class PacjentTest
    {
        [Test]
        public void CanAddChorobaToList()
        {
            Pacjent pacjent = new Pacjent("probe", "20");
            Choroba choroba = new Choroba("name", "20.02.2020");
            pacjent.addChoroba(choroba);
            var wartosc = pacjent.chorobas;
            Assert.That(wartosc[0], Is.EqualTo(choroba));
        }

        [Test]
        [TestCase("name")]
        [TestCase("syfilis")]
        [TestCase("gruźlica")]
        [TestCase("Covid")]
        [TestCase("HIV")]
        
        public void returnChorobaByName(string name)
        {
            Pacjent pacjent = new Pacjent("probe", "20");
            Choroba choroba = new Choroba("name", "20.02.2020");
            Choroba choroba1 = new Choroba("syfilis", "20.02.2020");
            Choroba choroba2 = new Choroba("gruźlica", "20.02.2020");
            Choroba choroba3 = new Choroba("Covid", "20.02.2020");
            Choroba choroba4 = new Choroba("HIV", "20.02.2020");
            pacjent.addChoroba(choroba);
            pacjent.addChoroba(choroba1);
            pacjent.addChoroba(choroba2);
            pacjent.addChoroba(choroba3);
            pacjent.addChoroba(choroba4);

            var result = pacjent.showChorobaByName(name);
            Assert.That(result.Name, Is.EqualTo(name));
       }

        [Test]
        [TestCase(0, "name")]
        [TestCase(1, "syfilis")]
        [TestCase(2, "gruźlica")]
        [TestCase(3, "Covid")]
        [TestCase(4, "HIV")]

        public void ReturnChorobaByIndex(int index, string expected)
        {
            Pacjent pacjent1 = new Pacjent("probe", "20");
            Choroba choroba = new Choroba("name", "20.02.2020");
            Choroba choroba1 = new Choroba("syfilis", "20.02.2020");
            Choroba choroba2 = new Choroba("gruźlica", "20.02.2020");
            Choroba choroba3 = new Choroba("Covid", "20.02.2020");
            Choroba choroba4 = new Choroba("HIV", "20.02.2020");
            pacjent1.addChoroba(choroba);
            pacjent1.addChoroba(choroba1);
            pacjent1.addChoroba(choroba2);
            pacjent1.addChoroba(choroba3);
            pacjent1.addChoroba(choroba4);

            var result = pacjent1.showChorobaByIndex(index);
            Assert.That(result.Name, Is.EqualTo(expected));
            
        }
















    }
}
