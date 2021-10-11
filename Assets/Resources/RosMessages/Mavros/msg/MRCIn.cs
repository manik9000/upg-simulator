//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MRCIn : Message
    {
        public const string RosMessageName = "mavros_msgs/RCIn";

        //  RAW RC input state
        public Std.MHeader header;
        public byte rssi;
        public ushort[] channels;

        public MRCIn()
        {
            this.header = new Std.MHeader();
            this.rssi = 0;
            this.channels = new ushort[0];
        }

        public MRCIn(Std.MHeader header, byte rssi, ushort[] channels)
        {
            this.header = header;
            this.rssi = rssi;
            this.channels = channels;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(new[]{this.rssi});
            
            listOfSerializations.Add(BitConverter.GetBytes(channels.Length));
            foreach(var entry in channels)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.rssi = data[offset];;
            offset += 1;
            
            var channelsArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.channels= new ushort[channelsArrayLength];
            for(var i = 0; i < channelsArrayLength; i++)
            {
                this.channels[i] = BitConverter.ToUInt16(data, offset);
                offset += 2;
            }

            return offset;
        }

        public override string ToString()
        {
            return "MRCIn: " +
            "\nheader: " + header.ToString() +
            "\nrssi: " + rssi.ToString() +
            "\nchannels: " + System.String.Join(", ", channels.ToList());
        }
    }
}