//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Detailed Version ".
    /// AT Command <b>VL</b></p>Shows detailed version information, device type, time stamp for
    /// the build, Ember stack version, and bootloader version. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeDetailedVersionResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        /// </summary>
        private int[] _versionInfo;
        
        /// <summary>
        ///  Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        ///  Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        ///  Return the versionInfo as <see cref="System.Int32"/>
        /// </summary>
        public int[] GetVersionInfo()
        {
            return _versionInfo;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _frameId = DeserializeInt8();
            DeserializeAtCommand();
            _commandStatus = DeserializeCommandStatus();
            if (_commandStatus != CommandStatus.OK || IsComplete())
            {
                    return;
            }
            _versionInfo = DeserializeData();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(477);
            builder.Append("XBeeDetailedVersionResponse [frameId=");
            builder.Append(_frameId);
            builder.Append(", commandStatus=");
            builder.Append(_commandStatus);
            if (_commandStatus == CommandStatus.OK)
            {
                builder.Append(", versionInfo=");
                if (_versionInfo == null)
                {
                builder.Append("null");
                }
                else
                {
                    for (int cnt = 0
                    ; cnt < _versionInfo.Length; cnt++
                    )
                    {
                        if (cnt > 0)
                        {
                        builder.Append(' ');
                        }
                        builder.Append(string.Format("0x{0:X2}", _versionInfo[cnt]));
                    }
                }
            }
            builder.Append(_commandStatus);
            builder.Append(']');
            return builder.ToString();
        }
    }
}