using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monomyth.Impl
{
    public class StoryGenerator : IStoryGenerator
    {
        public Story Story { get; set; }

        public string GenerateStory()
        {
            Story = new Story();
            Story.Assemble();

            return Story.GetFull;
        }
    }
}
