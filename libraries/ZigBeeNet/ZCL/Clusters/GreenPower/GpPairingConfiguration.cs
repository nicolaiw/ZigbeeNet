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
    /// Gp Pairing Configuration value object class.
    ///
    /// Cluster: Green Power. Command ID 0x09 is sent TO the server.
    /// This command is a specific command used for the Green Power cluster.
    ///
    /// The command is generated to configure the Sink Table of a sink, to
    /// create/update/replace/remove a pairing to a GPD and/or trigger the sending of GP
    /// Pairing command.
    /// In the current version of the specification, a device shall only send GP Pairing
    /// Configuration command with the Number of paired endpoints field set to 0xfe, if the
    /// CommunicationMode is equal to Pre-Commissioned Groupcast.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class GpPairingConfiguration : ZclCommand
    {
        /// <summary>
        /// The cluster ID to which this command belongs.
        /// </summary>
        public const ushort CLUSTER_ID = 0x0021;

        /// <summary>
        /// The command ID.
        /// </summary>
        public const byte COMMAND_ID = 0x09;

        /// <summary>
        /// Actions command message field.
        /// </summary>
        public byte Actions { get; set; }

        /// <summary>
        /// Options command message field.
        /// </summary>
        public ushort Options { get; set; }

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
        /// Device ID command message field.
        /// </summary>
        public byte DeviceId { get; set; }

        /// <summary>
        /// Group List Count command message field.
        /// </summary>
        public byte GroupListCount { get; set; }

        /// <summary>
        /// Group List command message field.
        /// </summary>
        public GpPairingConfigurationGroupList GroupList { get; set; }

        /// <summary>
        /// Gpd Assigned Alias command message field.
        /// </summary>
        public ushort GpdAssignedAlias { get; set; }

        /// <summary>
        /// Forwarding Radius command message field.
        /// </summary>
        public byte ForwardingRadius { get; set; }

        /// <summary>
        /// Security Options command message field.
        /// </summary>
        public byte SecurityOptions { get; set; }

        /// <summary>
        /// Gpd Security Frame Counter command message field.
        /// </summary>
        public uint GpdSecurityFrameCounter { get; set; }

        /// <summary>
        /// Gpd Security Key command message field.
        /// </summary>
        public ZigBeeKey GpdSecurityKey { get; set; }

        /// <summary>
        /// Number Of Paired Endpoints command message field.
        /// </summary>
        public byte NumberOfPairedEndpoints { get; set; }

        /// <summary>
        /// Paired Endpoints command message field.
        /// </summary>
        public byte PairedEndpoints { get; set; }

        /// <summary>
        /// Application Information command message field.
        /// </summary>
        public byte ApplicationInformation { get; set; }

        /// <summary>
        /// Manufacturer ID command message field.
        /// </summary>
        public ushort ManufacturerId { get; set; }

        /// <summary>
        /// Mode ID command message field.
        /// </summary>
        public ushort ModeId { get; set; }

        /// <summary>
        /// Number Of Gpd Commands command message field.
        /// </summary>
        public byte NumberOfGpdCommands { get; set; }

        /// <summary>
        /// Gpd Command ID List command message field.
        /// </summary>
        public byte GpdCommandIdList { get; set; }

        /// <summary>
        /// Cluster ID List Count command message field.
        /// </summary>
        public byte ClusterIdListCount { get; set; }

        /// <summary>
        /// Cluster List Server command message field.
        /// </summary>
        public ushort ClusterListServer { get; set; }

        /// <summary>
        /// Cluster List Client command message field.
        /// </summary>
        public ushort ClusterListClient { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GpPairingConfiguration()
        {
            ClusterId = CLUSTER_ID;
            CommandId = COMMAND_ID;
            GenericCommand = false;
            CommandDirection = ZclCommandDirection.CLIENT_TO_SERVER;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Actions, DataType.BITMAP_8_BIT);
            serializer.Serialize(Options, DataType.BITMAP_16_BIT);
            serializer.Serialize(GpdSrcId, DataType.UNSIGNED_32_BIT_INTEGER);
            serializer.Serialize(GpdIeee, DataType.IEEE_ADDRESS);
            serializer.Serialize(Endpoint, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(DeviceId, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(GroupListCount, DataType.UNSIGNED_8_BIT_INTEGER);
            GroupList.Serialize(serializer);
            serializer.Serialize(GpdAssignedAlias, DataType.UNSIGNED_16_BIT_INTEGER);
            serializer.Serialize(ForwardingRadius, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(SecurityOptions, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(GpdSecurityFrameCounter, DataType.UNSIGNED_32_BIT_INTEGER);
            serializer.Serialize(GpdSecurityKey, DataType.SECURITY_KEY);
            serializer.Serialize(NumberOfPairedEndpoints, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(PairedEndpoints, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(ApplicationInformation, DataType.BITMAP_8_BIT);
            serializer.Serialize(ManufacturerId, DataType.UNSIGNED_16_BIT_INTEGER);
            serializer.Serialize(ModeId, DataType.UNSIGNED_16_BIT_INTEGER);
            serializer.Serialize(NumberOfGpdCommands, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(GpdCommandIdList, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(ClusterIdListCount, DataType.UNSIGNED_8_BIT_INTEGER);
            serializer.Serialize(ClusterListServer, DataType.UNSIGNED_16_BIT_INTEGER);
            serializer.Serialize(ClusterListClient, DataType.UNSIGNED_16_BIT_INTEGER);
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Actions = deserializer.Deserialize<byte>(DataType.BITMAP_8_BIT);
            Options = deserializer.Deserialize<ushort>(DataType.BITMAP_16_BIT);
            GpdSrcId = deserializer.Deserialize<uint>(DataType.UNSIGNED_32_BIT_INTEGER);
            GpdIeee = deserializer.Deserialize<IeeeAddress>(DataType.IEEE_ADDRESS);
            Endpoint = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            DeviceId = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            GroupListCount = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            GroupList = new GpPairingConfigurationGroupList();
            GroupList.Deserialize(deserializer);
            GpdAssignedAlias = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
            ForwardingRadius = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            SecurityOptions = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            GpdSecurityFrameCounter = deserializer.Deserialize<uint>(DataType.UNSIGNED_32_BIT_INTEGER);
            GpdSecurityKey = deserializer.Deserialize<ZigBeeKey>(DataType.SECURITY_KEY);
            NumberOfPairedEndpoints = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            PairedEndpoints = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            ApplicationInformation = deserializer.Deserialize<byte>(DataType.BITMAP_8_BIT);
            ManufacturerId = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
            ModeId = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
            NumberOfGpdCommands = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            GpdCommandIdList = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            ClusterIdListCount = deserializer.Deserialize<byte>(DataType.UNSIGNED_8_BIT_INTEGER);
            ClusterListServer = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
            ClusterListClient = deserializer.Deserialize<ushort>(DataType.UNSIGNED_16_BIT_INTEGER);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("GpPairingConfiguration [");
            builder.Append(base.ToString());
            builder.Append(", Actions=");
            builder.Append(Actions);
            builder.Append(", Options=");
            builder.Append(Options);
            builder.Append(", GpdSrcId=");
            builder.Append(GpdSrcId);
            builder.Append(", GpdIeee=");
            builder.Append(GpdIeee);
            builder.Append(", Endpoint=");
            builder.Append(Endpoint);
            builder.Append(", DeviceId=");
            builder.Append(DeviceId);
            builder.Append(", GroupListCount=");
            builder.Append(GroupListCount);
            builder.Append(", GroupList=");
            builder.Append(GroupList);
            builder.Append(", GpdAssignedAlias=");
            builder.Append(GpdAssignedAlias);
            builder.Append(", ForwardingRadius=");
            builder.Append(ForwardingRadius);
            builder.Append(", SecurityOptions=");
            builder.Append(SecurityOptions);
            builder.Append(", GpdSecurityFrameCounter=");
            builder.Append(GpdSecurityFrameCounter);
            builder.Append(", GpdSecurityKey=");
            builder.Append(GpdSecurityKey);
            builder.Append(", NumberOfPairedEndpoints=");
            builder.Append(NumberOfPairedEndpoints);
            builder.Append(", PairedEndpoints=");
            builder.Append(PairedEndpoints);
            builder.Append(", ApplicationInformation=");
            builder.Append(ApplicationInformation);
            builder.Append(", ManufacturerId=");
            builder.Append(ManufacturerId);
            builder.Append(", ModeId=");
            builder.Append(ModeId);
            builder.Append(", NumberOfGpdCommands=");
            builder.Append(NumberOfGpdCommands);
            builder.Append(", GpdCommandIdList=");
            builder.Append(GpdCommandIdList);
            builder.Append(", ClusterIdListCount=");
            builder.Append(ClusterIdListCount);
            builder.Append(", ClusterListServer=");
            builder.Append(ClusterListServer);
            builder.Append(", ClusterListClient=");
            builder.Append(ClusterListClient);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
