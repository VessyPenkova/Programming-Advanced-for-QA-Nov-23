using _1202._Song;

namespace _1202._SongTests
{
    public class SongTests
    {
        private Song _song;

        [SetUp]
        public void Setup()
        {
            this._song = new();
        }

        [Test]
        public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
        {
            // Arrange
            string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
            string wantedList = "all";
            string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";
            // Act

            var result = _song.AddAndListSongs(songs, wantedList);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
        {
            // Arrange
            string[] songs = { "Pop_Song1_3:30", "Pop_Song2_4:15", "Pop_Song3_3:00" };
            string wantedList = "Pop";
            string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";
            // Act

            var result = _song.AddAndListSongs(songs, wantedList);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
        {
            // Arrange
            string[] songs = { "Pop_Song1_3:30", "Pop_Song2_4:15", "Pop_Song3_3:00" };
            string wantedList = "Rocks";
            string expected = "";
            // Act

            var result = _song.AddAndListSongs(songs, wantedList);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}