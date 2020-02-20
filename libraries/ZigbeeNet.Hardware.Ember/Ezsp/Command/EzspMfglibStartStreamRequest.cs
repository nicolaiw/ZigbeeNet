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
    /// Class to implement the Ember EZSP command " mfglibStartStream ".
    /// Starts transmitting a random stream of characters. This is so that the radio modulation can
    /// be measured.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspMfglibStartStreamRequest : EzspFrameRequest
    {
        
        public const int FRAME_ID = 135;
        
        private EzspSerializer _serializer;
        
        public EzspMfglibStartStreamRequest()
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