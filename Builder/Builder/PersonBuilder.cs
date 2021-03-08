using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    #region Builder Extension
    internal static class PersonBuilderExtensions
    {
        internal static PersonBuilder AddWork(this PersonBuilder builder, string position)
        {
            builder.Action.Add(p => { p.Work = position; });
            return builder;
        }
    }
    #endregion

    internal class PersonBuilder
    {
        internal readonly List<Action<Person>> Action = new List<Action<Person>>();

        internal PersonBuilder AddName(string name)
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
