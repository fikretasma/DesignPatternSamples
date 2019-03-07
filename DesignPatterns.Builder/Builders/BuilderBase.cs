using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders
{
    public abstract class BuilderBase
    {
        protected abstract void BuildHeader();
        protected abstract void BuildFooter();
        protected abstract void BuildMenu();
        protected abstract void BuildForms();

        public Screen Build()
        {
            BuildHeader();
            BuildFooter();
            BuildMenu();
            BuildForms();
            return new Screen();
        }

    }
}
