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
    /// Class to implement the Ember EZSP command " getPolicy ".
    /// Allows the Host to read the policies used by the NCP to make fast decisions.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetPolicyResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 86;
        
        /// <summary>
        ///  EZSP_SUCCESS if the policy was changed, EZSP_ERROR_INVALID_ID if the NCP does not
        /// recognize policyId.
        /// </summary>
        private EzspStatus _status;
        
        /// <summary>
        ///  The current decision for the specified policy.
        /// </summary>
        private EzspDecisionId _decisionId;
        
        public EzspGetPolicyResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEzspStatus();
            _decisionId = deserializer.DeserializeEzspDecisionId();
        }
        
        /// <summary>
        /// The status to set as <see cref="EzspStatus"/> </summary>
        public void SetStatus(EzspStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The decisionId to set as <see cref="EzspDecisionId"/> </summary>
        public void SetDecisionId(EzspDecisionId decisionId)
        {
            _decisionId = decisionId;
        }
        
        /// <summary>
        ///  EZSP_SUCCESS if the policy was changed, EZSP_ERROR_INVALID_ID if the NCP does not
        /// recognize policyId.
        /// Return the status as <see cref="EzspStatus"/>
        /// </summary>
        public EzspStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  The current decision for the specified policy.
        /// Return the decisionId as <see cref="EzspDecisionId"/>
        /// </summary>
        public EzspDecisionId GetDecisionId()
        {
            return _decisionId;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetPolicyResponse [status=");
            builder.Append(_status);
            builder.Append(", decisionId=");
            builder.Append(_decisionId);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
