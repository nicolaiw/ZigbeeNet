using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.Security;
using ZigBeeNet.ZCL.Clusters.RssiLocation;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Protocol;


namespace ZigBeeNet.ZCL.Clusters.RssiLocation
{
    /// <summary>
    /// Set Absolute Location Command value object class.
    ///
    /// Cluster: RSSI Location. Command ID 0x00 is sent TO the server.
    /// This command is a specific command used for the RSSI Location cluster.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class SetAbsoluteLocationCommand : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x000B;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x00;

        /// <summary>
        /// Coordinate 1 command message field.
        /// </summary>
        public short Coordinate1 { get; set; }

        /// <summary>
        /// Coordinate 2 command message field.
        /// </summary>
        public short Coordinate2 { get; set; }

        /// <summary>
        /// Coordinate 3 command message field.
        /// </summary>
        public short Coordinate3 { get; set; }

        /// <summary>
        /// Power command message field.
        /// </summary>
        public short Power { get; set; }

        /// <summary>
        /// Path Loss Exponent command message field.
        /// </summary>
        public ushort PathLossExponent { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SetAbsoluteLocationCommand()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Coordinate1, DataType.SIGNED_16_BIT_INTEGER);
            serializer.Serialize(Coordinate2, DataType.SIGNED_16_BIT_INTEGER);
            serializer.Serialize(Coordinate3, DataType.SIGNED_16_BIT_INTEGER);
            serializer.Serialize(Power, DataType.SIGNED_16_BIT_INTEGER);
            serializer.Serialize(PathLossExponent, DataType.UNSIGNED_16_BIT_INTEGER);
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Coordinate1 = deserializer.Deserialize<short>(DataType.SIGNED_16_BIT_INTEGER);
            Coordinate2 = deserializer.Deserialize<short>(DataType.SIGNED_16_BIT_INTEGER);
            Coordinate3 = deserializer.Deserialize<short>(DataType.SIGNED_16_BIT_INTEGER);
            Power = deserializer.Deserialize<short>(DataType.SIGNED_16_BIT_INTEGER);
            PathLossExponent = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("SetAbsoluteLocationCommand [");
            builder.Append(base.ToString());
            builder.Append(", Coordinate1=");
            builder.Append(Coordinate1);
            builder.Append(", Coordinate2=");
            builder.Append(Coordinate2);
            builder.Append(", Coordinate3=");
            builder.Append(Coordinate3);
            builder.Append(", Power=");
            builder.Append(Power);
            builder.Append(", PathLossExponent=");
            builder.Append(PathLossExponent);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
