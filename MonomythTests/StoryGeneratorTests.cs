using System;
using Monomyth.Impl;
using NUnit.Framework;
using FluentAssertions;

namespace MonomythTests
{
    [TestFixture]
    public class StoryGeneratorTests
    {
        [Test]
        public void StoryGenerator_GenerateStory_NotNull()
        {
            // act
            var result = new StoryGenerator().GenerateStory();

            // assert
            result.Should().NotBe(null);
        }


        [Test]
        public void StoryGenerator_GenerateStory_StoryNotNull()
        {
            // arrange
            var gen = new StoryGenerator();
            gen.GenerateStory();

            // act
            var result = gen.Story;

            // assert
            result.Should().NotBe(null);
        }
    }
}
