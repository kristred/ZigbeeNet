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
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " permitJoining ".
    /// Tells the stack to allow other nodes to join the network with this node as their parent.
    /// Joining is initially disabled by default.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspPermitJoiningRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 34;
        
        /// <summary>
        ///  A value of 0x00 disables joining. A value of 0xFF enables joining. Any other value enables
        /// joining for that number of seconds.
        /// </summary>
        private int _duration;
        
        private EzspSerializer _serializer;
        
        public EzspPermitJoiningRequest()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The duration to set as <see cref="uint8_t"/> </summary>
        public void SetDuration(int duration)
        {
            _duration = duration;
        }
        
        /// <summary>
        ///  A value of 0x00 disables joining. A value of 0xFF enables joining. Any other value enables
        /// joining for that number of seconds.
        /// Return the duration as <see cref="System.Int32"/>
        /// </summary>
        public int GetDuration()
        {
            return _duration;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeUInt8(_duration);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspPermitJoiningRequest [duration=");
            builder.Append(_duration);
            builder.Append(']');
            return builder.ToString();
        }
    }
}