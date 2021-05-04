using NUnit.Framework;

namespace Collection.UnitTest
{
    public class CollectionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CancelledBy_UserisAdmin_Expected_ReturnTrue()
        {

            // arrange parte dove si inizializza l'oggetto da testare aggiungere riferimento

            var reservation = new Reservation();


            //act  parte dove si testa il metodo

            var result = reservation.CancelledBy(new User { IsAdmin = true });


            //assert parte in cui si verifica se il risultato è corretto in questo caso deve essere true uso isTrue metodo 


            Assert.IsTrue(result);
        }
    }
}