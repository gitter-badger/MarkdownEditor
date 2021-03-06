﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qujck.MarkdownEditor.Infrastructure;

namespace Qujck.MarkdownEditor.Queries
{
    public static partial class Query
    {
        public static string Execute(this IQueryHandler<Scripts, string> handler)
        {
            return handler.Execute(new Scripts());
        }

        public sealed class Scripts : IQuery<string>
        {
            internal Scripts() { }
        }

        public static partial class Handlers
        {
            public sealed class ScriptsHandler : IQueryHandler<Scripts, string>
            {
                public string Execute(Scripts query)
                {
                    var scripts = new StringBuilder()
                        .AppendResource("Scripts.modernizr-2.8.3.js")
                        .AppendResource("Scripts.jquery-1.11.3.min.js")
                        .AppendResource("Scripts.bootstrap.min.js");

                    return scripts.ToString();
                }
            }
        }
    }
}
