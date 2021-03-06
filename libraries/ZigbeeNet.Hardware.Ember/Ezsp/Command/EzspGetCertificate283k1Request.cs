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
    /// Class to implement the Ember EZSP command " getCertificate283k1 ".
    /// Retrieves the 283k1 certificate installed on the NCP.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetCertificate283k1Request : EzspFrameRequest
    {
        
        public const int FRAME_ID = 236;
        
        private EzspSerializer _serializer;
        
        public EzspGetCertificate283k1Request()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
