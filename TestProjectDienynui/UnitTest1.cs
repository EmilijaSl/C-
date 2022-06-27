using Egzaminas_Dienynas;
using Egzaminas_Dienynas.Repozitorijos;
using NUnit.Framework;

namespace TestProjectDienynui
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Pazymiai_Repozitorija pazymiai_Repozitorija = new Pazymiai_Repozitorija();

            pazymiai_Repozitorija.Pazymiai.Clear();

            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(9, 1, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(2, 2, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(1, 3, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(10, 4, 1));


            var tikrasBalas = pazymiai_Repozitorija.RetriveID1(1).Balas; 
            var tiketinasBalas = 9;

            Assert.AreEqual(tiketinasBalas, tikrasBalas);

            
        }
        [Test]
        public void Test2()
        {
            Pazymiai_Repozitorija pazymiai_Repozitorija = new Pazymiai_Repozitorija();
            pazymiai_Repozitorija.Pazymiai.Clear();

            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(9, 1, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(2, 2, 2));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(1, 3, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(10, 4, 3));

            var tikrasBalas = pazymiai_Repozitorija.RetriveTrimestras1(2, 2).Balas;
            var tiketinasBalas = 2;

            Assert.AreEqual(tiketinasBalas, tikrasBalas);
        }
        [Test]
        public void Test3()
        {
            Pazymiai_Repozitorija pazymiai_Repozitorija = new Pazymiai_Repozitorija();
            pazymiai_Repozitorija.Pazymiai.Clear();

            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(9, 1, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(2, 2, 2));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(1, 3, 1));
            pazymiai_Repozitorija.Pazymiai.Add(new Pazymys(10, 4, 3));

            var tikrasBalas = pazymiai_Repozitorija.RetriveTrimestras1(2, 2).Balas;
            var tiketinasBalas = 2;

            Assert.AreEqual(tiketinasBalas, tikrasBalas);



        }
    }
}