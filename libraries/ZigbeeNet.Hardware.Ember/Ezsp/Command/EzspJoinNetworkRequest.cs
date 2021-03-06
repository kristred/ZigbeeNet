//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " joinNetwork ".
    /// Causes the stack to associate with the network using the specified network parameters. It
    /// can take several seconds for the stack to associate with the local network. Do not send
    /// messages until the stackStatusHandler callback informs you that the stack is up.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspJoinNetworkRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 31;
        
        /// <summary>
        ///  Specification of the role that this node will have in the network. This role must not be
        /// EMBER_COORDINATOR. To be a coordinator, use the formNetwork command.
        /// </summary>
        private EmberNodeType _nodeType;
        
        /// <summary>
        ///  Specification of the network with which the node should associate.
        /// </summary>
        private EmberNetworkParameters _parameters;
        
        private EzspSerializer _serializer;
        
        public EzspJoinNetworkRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The nodeType to set as <see cref="EmberNodeType"/> </summary>
        public void SetNodeType(EmberNodeType nodeType)
        {
            _nodeType = nodeType;
        }
        
        /// <summary>
        /// The parameters to set as <see cref="EmberNetworkParameters"/> </summary>
        public void SetParameters(EmberNetworkParameters parameters)
        {
            _parameters = parameters;
        }
        
        /// <summary>
        ///  Specification of the role that this node will have in the network. This role must not be
        /// EMBER_COORDINATOR. To be a coordinator, use the formNetwork command.
        /// Return the nodeType as <see cref="EmberNodeType"/>
        /// </summary>
        public EmberNodeType GetNodeType()
        {
            return _nodeType;
        }
        
        /// <summary>
        ///  Specification of the network with which the node should associate.
        /// Return the parameters as <see cref="EmberNetworkParameters"/>
        /// </summary>
        public EmberNetworkParameters GetParameters()
        {
            return _parameters;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeEmberNodeType(_nodeType);
            _serializer.SerializeEmberNetworkParameters(_parameters);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspJoinNetworkRequest [nodeType=");
            builder.Append(_nodeType);
            builder.Append(", parameters=");
            builder.Append(_parameters);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
