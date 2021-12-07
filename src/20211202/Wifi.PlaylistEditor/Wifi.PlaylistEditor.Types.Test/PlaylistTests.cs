using NUnit.Framework;

namespace Wifi.PlaylistEditor.Types.Test
{
    [TestFixture]
    public class PlaylistTests
    {
        private Playlist _fixture;

        [Test]
        public void DummyTest()
        {
            //Arrange
            int eineZahl = 5;

            //Act
            var result = eineZahl + 15;

            //Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Name_get()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            //Act
            var result = _fixture.Name;

            //Assert
            Assert.That(result, Is.EqualTo("NoName"));
        }

        [Test]
        public void Author_get()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            //Act
            var result = _fixture.Author;

            //Assert
            Assert.That(result, Is.EqualTo("Gandalf"));
        }
    }
}
