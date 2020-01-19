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
    /// Extended Simple Descriptor Response value object class.
    ///
    ///
    /// The Extended_Simple_Desc_rsp is generated by a remote device in response to an
    /// Extended_Simple_Desc_req directed to the remote device. This command shall be
    /// unicast to the originator of the Extended_Simple_Desc_req command.
    ///
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class ExtendedSimpleDescriptorResponse : ZdoResponse
    {
        /// <summary>
        /// The ZDO cluster ID.
        /// </summary>
        public const ushort CLUSTER_ID = 0x801D;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ExtendedSimpleDescriptorResponse()
        {
            ClusterId = CLUSTER_ID;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("ExtendedSimpleDescriptorResponse [");
            builder.Append(base.ToString());
            builder.Append(']');

            return builder.ToString();
        }
    }
}
