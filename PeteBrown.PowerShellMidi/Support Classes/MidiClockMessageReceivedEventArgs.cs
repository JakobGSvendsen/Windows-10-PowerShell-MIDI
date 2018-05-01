using System;
using Windows.Devices.Midi;
using Windows.Storage.Streams;

namespace PeteBrown.PowerShellMidi
{
    public class MidiClockMessageReceivedEventArgs : EventArgs
    {

        public IBuffer RawData { get; private set; }
        public TimeSpan TimeStamp { get; private set; }
        public MidiMessageType Type { get; private set; }
        public MidiClockMessageReceivedEventArgs(IBuffer rawData, TimeSpan timestamp, MidiMessageType type)
        {
            RawData = rawData;
            TimeStamp = timestamp;
            Type = type;

        }
    }
}
