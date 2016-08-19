using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Diagnostics;
using Autofac;

namespace CslaDISerialization.Lib
{
    [Serializable]
    public class DIBusinessBase<T> : BusinessBase<T>
        where T :DIBusinessBase<T>
    {

        protected override void OnDeserialized(StreamingContext context)
        {

            Debug.WriteLine($"Deserialized: {typeof(T).Name}");
            base.OnDeserialized(context);

            // Key is here
            // OnDeserialized gets called for each and every class that is deserialized - Yay!
            var scope = (ILifetimeScope)context.Context;

            
            var properties = typeof(T).GetProperties().ToList();

            properties.ForEach(p =>
            {
                if(p.GetCustomAttributes(false).Where(a=>a.GetType() == typeof(DependencyAttribute)).FirstOrDefault() != null)
                {

                    object value = scope.Resolve(p.PropertyType);
                    p.SetValue(this, value);
                }
            });


        }

    }
}
