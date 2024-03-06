namespace FIzzBuzzTDD
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(98)]
        [InlineData(100)]

        public void Test_FizzBuzz(int number)
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Generate(number);
            if (number % 3 == 0 && number % 5 == 0)
                Assert.Equal("FizzBuzz", result);
            else if (number % 3 == 0)
                Assert.Equal("Fizz", result);
            else if (number % 5 == 0)
                Assert.Equal("Buzz", result);
            else
                Assert.Equal(number.ToString(), result);
        }

        [Fact]
        public void Print_FizzBuzz()
        {

            var fizzBuzz = new FizzBuzz();
            var FizzBuzzSequence = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                FizzBuzzSequence.Add(fizzBuzz.Generate(i));
            }
            foreach (var item in FizzBuzzSequence)
            {
                Console.WriteLine(item);
            }
        }



        //[Fact]
        //public void Test_Fizz()
        //{
        //    var fizzBuzz = new FizzBuzz();

        //    var result = fizzBuzz.Generate(3);

        //    Assert.Equal("Fizz", result);
        //}
        //[Fact]
        //public void Test_Buzz()
        //{
        //    var fizzBuzz = new FizzBuzz();

        //    var result = fizzBuzz.Generate(5);

        //    Assert.Equal("Buzz", result);
        //}
        //[Fact]
        //public void Test_FizzBuzz()
        //{
        //    var fizzBuzz = new FizzBuzz();

        //    var result = fizzBuzz.Generate(15);

        //    Assert.Equal("FizzBuzz", result);
        //}
        //[Fact]
        //public void Test_Number()
        //{
        //    var fizzBuzz = new FizzBuzz();
        //    var result = fizzBuzz.Generate(4);

        //    Assert.Equal("4", result);
        //}
    }

}