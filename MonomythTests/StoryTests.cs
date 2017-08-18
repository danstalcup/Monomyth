using NUnit.Framework;
using FluentAssertions;
using Monomyth.Impl;

namespace MonomythTests
{
    [TestFixture]
    public class StoryTests
    {
        [Test]
        public void Story_GetFull_NotNull()
        {
            // act
            var result = new Story().GetFull;

            // assert
            result.Should().NotBe(null);
        }
    }
}
