using _1206._Article;

namespace _1206._ArticleTests
{
    public class ArticleTests
    {
        private Article _article;

        [SetUp]
        public void Setup()
        {
            this._article = new();
        }

        [Test]
        public void Test_AddArticles_ReturnsArticleWithCorrectData()
        {
            // Arrange
            string[] articleData =
            {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3"
        };

            // Act
            Article result = this._article.AddArticles(articleData);

            // Assert
            Assert.That(result.ArticleList, Has.Count.EqualTo(3));
            Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
            Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
            Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
        }

        [Test]
        public void Test_GetArticleList_SortsArticlesByTitle()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new()
            {
              new Article()
              {
                  Author = "Veselina",
                  Content = "some Content",
                  Title = "Begginers Coding"
              },
              new Article()
              {
                   Author = "Ivan",
                  Content = "some other Content",
                  Title ="A overview of athitecture"
              }

            }
            };
            string expected = $"A overview of athitecture - some other Content: Ivan{Environment.NewLine}Begginers Coding - some Content: Veselina";

            //Act
            string actual = this._article.GetArticleList(inputArticle, "title");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new()
            {
              new Article()
              {
                  Author = "Veselina",
                  Content = "some Content",
                  Title = "Begginers Coding"
              },
              new Article()
              {
                   Author = "Ivan",
                  Content = "some other Content",
                  Title ="A overview of athitecture"
              }

            }
            };
            string expected = $"A overview of athitecture - some other Content: Ivan{Environment.NewLine}Begginers Coding - some Content: Veselina";

            //Act
            string actual = this._article.GetArticleList(inputArticle, "not-cretaria");

            //Assert
            Assert.AreEqual(string.Empty, actual);
        }

        [Test]
        public void Test_GetArticleList_ReturnsEmptyString_WhenArticleHasNoArticleInArticleList()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new()
            };
            string expected = $"A overview of athitecture - some other Content: Ivan{Environment.NewLine}Begginers Coding - some Content: Veselina";

            //Act
            string actual = this._article.GetArticleList(inputArticle, "title");

            //Assert
            Assert.AreEqual(string.Empty, actual);
        }

        [Test]
        public void Test_GetArticleList_SortsArticlesByContent()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new()
            {
              new Article()
              {
                  Author = "Veselina",
                  Content = "some Content",
                  Title = "Begginers Coding"
              },
              new Article()
              {
                   Author = "Ivan",
                  Content = "Other Content",
                  Title ="A overview of athitecture"
              }

            }
            };
            string expected = $"A overview of athitecture - Other Content: Ivan{Environment.NewLine}Begginers Coding - some Content: Veselina";

            //Act
            string actual = this._article.GetArticleList(inputArticle, "content");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetArticleList_SortsArticlesByAutor()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new()
            {
              new Article()
              {
                  Author = "Veselina",
                  Content = "some Content",
                  Title = "Begginers Coding"
              },
              new Article()
              {
                   Author = "Ivan",
                  Content = "some other Content",
                  Title ="A overview of athitecture"
              }

            }
            };
            string expected = $"A overview of athitecture - some other Content: Ivan{Environment.NewLine}Begginers Coding - some Content: Veselina";

            //Act
            string actual = this._article.GetArticleList(inputArticle, "author");

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}