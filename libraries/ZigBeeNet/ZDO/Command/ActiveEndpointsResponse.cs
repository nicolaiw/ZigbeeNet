using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZDO.Field;


namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
    /// Active Endpoints Response value object class.
    ///
    ///
    /// The Active_EP_rsp is generated by a remote device in response to an Active_EP_req
    /// directed to the remote device. This command shall be unicast to the originator of the
    /// Active_EP_req command.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class ActiveEndpointsResponse : ZdoResponse
    {
        /// <summary>
        /// The ZDO cluster ID.
        /// </summary>
        public const ushort CLUSTER_ID = 0x8005;

        /// <summary>
        /// NWK Addr Of Interest command message field.
        /// </summary>
        public ushort NwkAddrOfInterest { get; set; }

        /// <summary>
        /// Active Ep List command message field.
        /// </summary>
        public List<byte> ActiveEpList { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ActiveEndpointsResponse()
        {
            ClusterId = CLUSTER_ID;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            base.Serialize(serializer);

            serializer.Serialize(Status, ZclDataType.Get(DataType.ZDO_STATUS));
            serializer.Serialize(NwkAddrOfInterest, ZclDataType.Get(DataType.NWK_ADDRESS));
            serializer.Serialize(ActiveEpList.Count, ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            for (int cnt = 0; cnt < ActiveEpList.Count; cnt++)
            {
                serializer.Serialize(ActiveEpList[cnt], ZclDataType.Get(DataType.ENDPOINT));
            }
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            base.Deserialize(deserializer);

            // Create lists
            ActiveEpList = new List<byte>();

            Status = deserializer.Deserialize<ZdoStatus>(ZclDataType.Get(DataType.ZDO_STATUS));
            if (Status != ZdoStatus.SUCCESS)
            {
                // Don't read the full response if we have an error
                return;
            }
            NwkAddrOfInterest = deserializer.Deserialize<ushort>(ZclDataType.Get(DataType.NWK_ADDRESS));
            byte? activeEpCnt = (byte?) deserializer.Deserialize(ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER));
            if (activeEpCnt != null)
            {
                for (int cnt = 0; cnt < activeEpCnt; cnt++)
                {
                    ActiveEpList.Add((byte) deserializer.Deserialize(ZclDataType.Get(DataType.ENDPOINT)));
                }
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("ActiveEndpointsResponse [");
            builder.Append(base.ToString());
            builder.Append(", Status=");
            builder.Append(Status);
            builder.Append(", NwkAddrOfInterest=");
            builder.Append(NwkAddrOfInterest);
            builder.Append(", ActiveEpList=");
            builder.Append(ActiveEpList == null? "" : string.Join(", ", ActiveEpList));
            builder.Append(']');

            return builder.ToString();
        }
    }
}
