using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person Jeronimo;

        [SetUp]
        public void Setup()
        {
            Jeronimo = new Person("Jeronimo","5.309.239.3");
        }

        [Test]
        public void NombreVerdadero() // Aca hago el test que el nombre se cambie correctamente pasandole un nombre correcto
        {
            string ExpectedName= Jeronimo.Name;
            Jeronimo.Name = "Federico";
            Assert.AreEqual(ExpectedName,Jeronimo.Name);
        }
        [Test]
        public void NombreFalso() // Aca hago el test que el nombre no cambie porque le paso un valor vacio
        {
            string ExpectedName = Jeronimo.Name;
            Jeronimo.Name = "";
            Assert.AreEqual(ExpectedName,Jeronimo.Name);
        }
        [Test]
        public void CedulaVerdadera() // Aca hago el test para que cambie la cedula correctamente pasandole una cedula verdadera
        {
            string ExpectedID = Jeronimo.ID;
            Jeronimo.ID = "1.234.567-8";
            Assert.AreEqual(ExpectedID,Jeronimo.ID);
        }
        [Test]
        public void CeulaFalsa() // Aca hago el test para que no cambie la cedula pasandole una cedula trucha
        {
            string ExpectedID = Jeronimo.ID;
            Jeronimo.ID = "5.309.239-8";
            Assert.AreEqual(ExpectedID,Jeronimo.ID);
        }
    }
}