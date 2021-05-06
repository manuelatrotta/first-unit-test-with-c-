using NUnit.Framework;

namespace Collection.UnitTest
{
    public class CollectionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class DeclarationTest
        {    [Test]
            public void CancelledBy_UserisAdmin_Expected_ReturnTrue()
            {

                // arrange parte dove si inizializza l'oggetto da testare aggiungere riferimento

                var reservation = new Reservation();


                //act  parte dove si testa il metodo

                var result = reservation.CancelledBy(new User { IsAdmin = true });


                //assert parte in cui si verifica se il risultato è corretto in questo caso deve essere true uso isTrue metodo 


                Assert.That(result == true);
            }
            [Test]
            public void CancelledBy_MadeBy_Expected_ReturnTrue()
            {

                // creo sia la reservation che l'user nella reservation imposto che è stata effettuata dall'user 
                var user = new User { };
                var reservation = new Reservation { MadeBy = user };


                var result1 = reservation.CancelledBy(user);

                Assert.IsTrue(result1);
            }

            [Test]
            public void CancelledBy_NoAdminMadeBy_ReturnFalse()
            {
                var user = new User();
                var reservation = new Reservation();

                var result = reservation.CancelledBy(user);

                Assert.False(result);

            }
        }
    }
}