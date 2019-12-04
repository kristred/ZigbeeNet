using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.GreenPower;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.GreenPower
{
    /// <summary>
    /// Gp Pairing value object class.
    ///
    /// Cluster: Green Power. Command ID 0x01 is sent FROM the server.
    /// This command is a specific command used for the Green Power cluster.
    ///
    /// The GP Pairing command is generated by the sink to manage pairing information. The GP
    /// Pairing command is typically sent using network-wide broadcast. If the
    /// CommunicationMode sub-field is set to 0b11, GP Pairing command may be sent in unicast to
    /// the selected proxy.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class GpPairing : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0021;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x01;

        /// <summary>
        /// Options command message field.
        /// </summary>
        public int Options { get; set; }

        /// <summary>
        /// Gpd Src ID command message field.
        /// </summary>
        public uint GpdSrcId { get; set; }

        /// <summary>
        /// Gpd IEEE command message field.
        /// </summary>
        public IeeeAddress GpdIeee { get; set; }

        /// <summary>
        /// Endpoint command message field.
        /// </summary>
        public byte Endpoint { get; set; }

        /// <summary>
        /// Sink IEEE Address command message field.
        /// </summary>
        public IeeeAddress SinkIeeeAddress { get; set; }

        /// <summary>
        /// Sink NWK Address command message field.
        /// </summary>
        public ushort SinkNwkAddress { get; set; }

        /// <summary>
        /// Sink Group ID command message field.
        /// </summary>
        public ushort SinkGroupId { get; set; }

        /// <summary>
        /// Device ID command message field.
        /// </summary>
        public byte DeviceId { get; set; }

        /// <summary>
        /// Gpd Security Frame Counter command message field.
        /// </summary>
        public uint GpdSecurityFrameCounter { get; set; }

        /// <summary>
        /// Gpd Key command message field.
        /// </summary>
        public ZigBeeKey GpdKey { get; set; }

        /// <summary>
        /// Assigned Alias command message field.
        /// </summary>
        public ushort AssignedAlias { get; set; }

        /// <summary>
        /// Forwarding Radius command message field.
        /// </summary>
        public byte ForwardingRadius { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GpPairing()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Options, ZclDataType.Get(DataType.BITMAP_24_BIT));
            serializer.Serialize(GpdSrcId, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(GpdIeee, ZclDataType.Get(DataType.IEEE_ADDRESS));
            serializer.Serialize(Endpoint, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            serializer.Serialize(SinkIeeeAddress, ZclDataType.Get(DataType.IEEE_ADDRESS));
            serializer.Serialize(SinkNwkAddress, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(SinkGroupId, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(DeviceId, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            serializer.Serialize(GpdSecurityFrameCounter, ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            serializer.Serialize(GpdKey, ZclDataType.Get(DataType.SECURITY_KEY));
            serializer.Serialize(AssignedAlias, ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            serializer.Serialize(ForwardingRadius, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Options = deserializer.Deserialize<int>(ZclDataType.Get(DataType.BITMAP_24_BIT));
            GpdSrcId = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            GpdIeee = deserializer.Deserialize<IeeeAddress>(ZclDataType.Get(DataType.IEEE_ADDRESS));
            Endpoint = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            SinkIeeeAddress = deserializer.Deserialize<IeeeAddress>(ZclDataType.Get(DataType.IEEE_ADDRESS));
            SinkNwkAddress = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            SinkGroupId = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            DeviceId = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
            GpdSecurityFrameCounter = deserializer.Deserialize<uint>(ZclDataType.Get(DataType.UNSIGNED_32_BIT_INTEGER));
            GpdKey = deserializer.Deserialize<ZigBeeKey>(ZclDataType.Get(DataType.SECURITY_KEY));
            AssignedAlias = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER));
            ForwardingRadius = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("GpPairing [");
            builder.Append(base.ToString());
            builder.Append(", Options=");
            builder.Append(Options);
            builder.Append(", GpdSrcId=");
            builder.Append(GpdSrcId);
            builder.Append(", GpdIeee=");
            builder.Append(GpdIeee);
            builder.Append(", Endpoint=");
            builder.Append(Endpoint);
            builder.Append(", SinkIeeeAddress=");
            builder.Append(SinkIeeeAddress);
            builder.Append(", SinkNwkAddress=");
            builder.Append(SinkNwkAddress);
            builder.Append(", SinkGroupId=");
            builder.Append(SinkGroupId);
            builder.Append(", DeviceId=");
            builder.Append(DeviceId);
            builder.Append(", GpdSecurityFrameCounter=");
            builder.Append(GpdSecurityFrameCounter);
            builder.Append(", GpdKey=");
            builder.Append(GpdKey);
            builder.Append(", AssignedAlias=");
            builder.Append(AssignedAlias);
            builder.Append(", ForwardingRadius=");
            builder.Append(ForwardingRadius);
            builder.Append(']');

            return builder.ToString();
        }
    }
}