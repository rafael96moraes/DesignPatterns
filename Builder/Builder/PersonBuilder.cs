using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal static class PersonBuilderExtensions
    {
        internal static PersonBuilder AddWork(this PersonBuilder builder, string position)
        {
            builder.Action.Add(p => { p.Position = position; });
            return builder;
        }
    }

    internal class PersonBuilder
    {
        public readonly List<Action<Person>> Action = new List<Action<Person>>();

        internal PersonBuilder Called(string name)
        {
            Action.Add(p => { p.Name = name; });
            return this;
        }


        internal Person Build()
        {
            var p = new Person();
            Action.ForEach(a => a(p));
            return p;
        }
    }
}
