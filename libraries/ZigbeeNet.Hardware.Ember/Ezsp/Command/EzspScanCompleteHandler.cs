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
    /// Class to implement the Ember EZSP command " scanCompleteHandler ".
    /// Returns the status of the current scan of type EZSP_ENERGY_SCAN or EZSP_ACTIVE_SCAN.
    /// EMBER_SUCCESS signals that the scan has completed. Other error conditions signify a
    /// failure to scan on the channel specified.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspScanCompleteHandler : EzspFrameResponse
    {
        
        public const int FRAME_ID = 28;
        
        /// <summary>
        ///  The channel on which the current error occurred. Undefined for the case of EMBER_SUCCESS.
        /// </summary>
        private int _channel;
        
        /// <summary>
        ///  The error condition that occurred on the current channel. Value will be EMBER_SUCCESS when
        /// the scan has completed.
        /// </summary>
        private EmberStatus _status;
        
        public EzspScanCompleteHandler(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _channel = deserializer.DeserializeUInt8();
            _status = deserializer.DeserializeEmberStatus();
        }
        
        /// <summary>
        /// The channel to set as <see cref="uint8_t"/> </summary>
        public void SetChannel(int channel)
        {
            _channel = channel;
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        ///  The channel on which the current error occurred. Undefined for the case of EMBER_SUCCESS.
        /// Return the channel as <see cref="System.Int32"/>
        /// </summary>
        public int GetChannel()
        {
            return _channel;
        }
        
        /// <summary>
        ///  The error condition that occurred on the current channel. Value will be EMBER_SUCCESS when
        /// the scan has completed.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspScanCompleteHandler [channel=");
            builder.Append(_channel);
            builder.Append(", status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}