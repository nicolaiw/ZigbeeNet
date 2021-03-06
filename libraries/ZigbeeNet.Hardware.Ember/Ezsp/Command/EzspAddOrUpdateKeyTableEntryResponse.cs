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
    /// Class to implement the Ember EZSP command " addOrUpdateKeyTableEntry ".
    /// This function updates an existing entry in the key table or adds a new one. It first searches
    /// the table for an existing entrythat matches the passed EUI64 address. If no entry is found, it
    /// searches for the first free entry. If successful, it updates the key data and resets the
    /// associated incoming frame counter. If it fails to find an existing entry and no free one
    /// exists, it returns a failure.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspAddOrUpdateKeyTableEntryResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 102;
        
        /// <summary>
        ///  The success or failure error code of the operation.
        /// </summary>
        private EmberStatus _status;
        
        public EzspAddOrUpdateKeyTableEntryResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        ///  The success or failure error code of the operation.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspAddOrUpdateKeyTableEntryResponse [status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
