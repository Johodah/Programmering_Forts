namespace SAABKlock
{
    public class TimeTests
    {
        [Fact]
        public void IsValidTime()
        {
            var validTime = new Time(12, 30, 45);
            Assert.True(validTime.IsValid());

        }
    }
}