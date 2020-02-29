using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Test
{
    class Storeable <I>: IStoreable<I>
    {
        public I Id { get; set; }
    }
}
