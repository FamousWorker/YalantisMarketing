using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
    class EmptyResultBuilder : AParseResultBuilder
    {
        public override string Build(string domain)
        {
            return domain;
        }

        public override string BuildHeader()
        {
            return "";
        }
    }
}
