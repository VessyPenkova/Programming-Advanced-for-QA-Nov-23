namespace _1401._TestApp.Tests
{
    public class ExceptionTests
    {
        private Exceptions _exceptions = null!;

        [SetUp]
        public void SetUp()
        {
            this._exceptions = new();
        }

        [Test]
        public void Test_Reverse_ValidString_ReturnsReversedString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = this._exceptions.ArgumentNullReverse(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Reverse_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;
            // Act & Assert
            Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
        }

        [Test]
        public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
        {
            //Arrange
            decimal totalPrice = 100.0m;
            decimal discount = 10.0m;

            //Act
            decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

            //Assert
            Assert.That(result, Is.EqualTo(90));
        }


        [Test]
        public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = -10.0m;

            // Act & Assert
            Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
        }


        [Test]
        public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
        {
            // Arrange
            decimal totalPrice = 100.0m;
            decimal discount = 110.0m;

            // Act & Assert
            Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.InstanceOf<ArgumentException>());
        }

        [Test]
        public void Test_GetElement_ValidIndex_ReturnsElement()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = 1;

            int expected = 20;

            // Act
            int result = this._exceptions.IndexOutOfRangeGetElement(array, index);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = -1;


            // Act & Assert
            Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
        }


        [Test]
        public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = array.Length;

            // Act & Assert
            Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
        }

        [Test]
        public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = array.Length * 2;

            // Act & Assert
            Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
        }

        [Test]
        public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
        {
            //Arrange
            bool isLoggedIn = true;

            //Act
            var result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

            //Assert
            Assert.That(result, Is.EqualTo("User logged in."));
        }

        [Test]
        public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
        {
            //Arrange
            bool isLoggedIn = false;

            //Act & Assert
            Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
        {
            //Arrange
            string input = "1";

            //Act
            var result = this._exceptions.FormatExceptionParseInt(input);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_ParseInt_InvalidInput_ThrowsFormatException()
        {
            //Arrange
            string input = "1.02ad";


            //Act & Assert
            Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
        {
            // Arrange
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                ["str"] = 1,
                ["str1"] = 2,
                ["str2"] = 3,

            };
            string key = "str";

            //Act
            int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                ["str"] = 1,
                ["str1"] = 2,
                ["str2"] = 3,

            };
            string key = "hey";

            //Act & Assert
            Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
        }

        [Test]
        public void Test_AddNumbers_NoOverflow_ReturnsSum()
        {
            //Arrange
            int firstNumber = 1;
            int secondNumber = 2;

            //Act
            int result = this._exceptions.OverflowAddNumbers(firstNumber, secondNumber);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
        {
            //Arrange
            int numberOne = int.MaxValue;
            int secondNumber = int.MaxValue;

            //Act &Assert
            Assert.That(() => this._exceptions.OverflowAddNumbers(numberOne, secondNumber), Throws.InstanceOf<OverflowException>());
        }

        [Test]
        public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
        {
            //Arrange
            int numberOne = int.MinValue;
            int secondNumber = int.MinValue;

            //Act &Assert
            Assert.That(() => this._exceptions.OverflowAddNumbers(numberOne, secondNumber), Throws.InstanceOf<OverflowException>());
        }

        [Test]
        public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
        {
            // Arrange
            int dividend = 9;
            int divisor = 3;

            // Act
            int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int dividend = 9;
            int divisor = 0;

            //Act & Assert
            Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor), Throws.InstanceOf<DivideByZeroException>());
        }

        [Test]
        public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
        {
            // Arrange
            int[]? collection = new int[] { 1, 2, };
            int index = 1;

            //Act
            var result = this._exceptions.SumCollectionElements(collection, index);

            //Assert
            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
        {
            // Arrange
            int[]? collection = null;
            int index = 1;

            //Act
            //var result = this._exceptions.SumCollectionElements(collection, index);

            //Act & Assert
            Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
        {
            // Arrange
            int[]? collection = new int[] { 1, 2, };
            int index = 7;

            //Act
            //var result = this._exceptions.SumCollectionElements(collection, index);

            //Assert
            Assert.That(() => this._exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
        }

        [Test]
        public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                ["firstNumber"] = "1",
                ["secongNumber"] = "2",
                ["tirsdNumber"] = "3"
            };
            string key = "firstNumber";

            //Act
            int result = this._exceptions.GetElementAsNumber(dictionary, key);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                ["firstNumber"] = "1",
                ["secongNumber"] = "2",
                ["tirsdNumber"] = "3"
            };
            string key = "number";

            //Assert
            Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<KeyNotFoundException>());
        }

        [Test]
        public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                ["firstNumber"] = "1",
                ["secongNumber"] = "2",
                ["tirsdNumber"] = "l;iouop;12"
            };
            string key = "tirsdNumber";

            //Assert
            Assert.That(() => this._exceptions.GetElementAsNumber(dictionary, key), Throws.InstanceOf<FormatException>());
        }
    }
}