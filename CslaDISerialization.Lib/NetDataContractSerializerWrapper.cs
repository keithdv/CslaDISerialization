using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Csla.Serialization;
using Autofac;

namespace CslaDISerialization.Lib
{
    public class NetDataContractSerializerWrapper : ISerializationFormatter
    {
        private NetDataContractSerializer _formatter = new NetDataContractSerializer(new StreamingContext(StreamingContextStates.All, _state));
        private static object _state;

        public void SetState(object state)
        {
            _state = state;
        }

        #region ISerializationFormatter Members

        /// <summary>
        /// Converts a serialization stream into an
        /// object graph.
        /// </summary>
        /// <param name="serializationStream">
        /// Byte stream containing the serialized data.</param>
        /// <returns>A deserialized object graph.</returns>
        public object Deserialize(System.IO.Stream serializationStream)
        {
            var o = _formatter.Deserialize(serializationStream);
            return o;
        }

        /// <summary>
        /// Converts an object graph into a byte stream.
        /// </summary>
        /// <param name="serializationStream">
        /// Stream that will contain the the serialized data.</param>
        /// <param name="graph">Object graph to be serialized.</param>
        public void Serialize(System.IO.Stream serializationStream, object graph)
        {
            _formatter.Serialize(serializationStream, graph);
        }

        #endregion

        /// <summary>
        /// Gets a reference to the underlying
        /// <see cref="NetDataContractSerializer"/>
        /// object.
        /// </summary>
        public NetDataContractSerializer Formatter
        {
            get
            {
                return _formatter;
            }
        }
    }
}
