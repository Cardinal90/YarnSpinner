using System;
using System.Collections.Generic;

namespace Yarn
{
    /// <summary>
    /// Provides the abstract base class for all types.
    /// </summary>
    internal abstract class TypeBase : IType
    {
        public abstract string Name { get; }
        public abstract IType Parent { get; }
        public abstract string Description { get; }

        public IReadOnlyDictionary<string, Delegate> Methods => methods;

        private Dictionary<string, Delegate> methods = new Dictionary<string, Delegate>();

        protected TypeBase(IReadOnlyDictionary<string, Delegate> methods) {
            if (methods == null) {
                return;
            }
            
            foreach (var method in methods) {
                this.methods.Add(method.Key, method.Value);
            }
        }
    }
}
