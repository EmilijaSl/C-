using NUnit.Framework;
using Restaurant.Meniu;
using Restaurant.Repozitorijos;

namespace RestoranoTestai
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StaliukasRetriveByID()
        {
            var staliukoR = new StaliukoRepozitorija();
            var expectedResult = staliukoR.Staliukai[1];

            staliukoR.RetriveByID(2);
            var actualResult = staliukoR.RetriveByID(2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void StaliukasArLaisvas()
        {
            var staliukoR = new StaliukoRepozitorija();
            bool expectedResult = false;

            staliukoR.PakeiskStaliukoStatusa(1, false);
            var actualResult = staliukoR.Staliukai[0].ArLaisvas;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GerimasRetriveByID()
        {
            var gerimuR = new GerimuRepozitorija();
            var expectedResult = gerimuR.Gerimai[0];

            gerimuR.RetriveByID(1);
            var actualResult = gerimuR.RetriveByID(1);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void PadavejaRetriveByID()
        {
            var padavejosR = new PadavejosRepozitorija();
            var expectedResult = padavejosR.Padavejos[3];

            padavejosR.RetriveByID(4);
            var actualResult = padavejosR.RetriveByID(4);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
