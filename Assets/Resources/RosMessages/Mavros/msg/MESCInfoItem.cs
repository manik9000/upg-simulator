//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MESCInfoItem : Message
    {
        public const string RosMessageName = "mavros_msgs/ESCInfoItem";

        //  ESCInfoItem.msg
        // 
        // 
        //  See mavlink message documentation here:
        //  https://mavlink.io/en/messages/common.html#ESC_INFO
        public Std.MHeader header;
        public ushort failure_flags;
        public uint error_count;
        public byte temperature;

        public MESCInfoItem()
        {
            this.header = new Std.MHeader();
            this.failure_flags = 0;
            this.error_count = 0;
            this.temperature = 0;
        }

        public MESCInfoItem(Std.MHeader header, ushort failure_flags, uint error_count, byte temperature)
        {
            this.header = header;
            this.failure_flags = failure_flags;
            this.error_count = error_count;
            this.temperature = temperature;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.failure_flags));
            listOfSerializations.Add(BitConverter.GetBytes(this.error_count));
            listOfSerializations.Add(new[]{this.temperature});

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.failure_flags = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.error_count = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.temperature = data[offset];;
            offset += 1;

            return offset;
        }

        public override string ToString()
        {
            return "MESCInfoItem: " +
            "\nheader: " + header.ToString() +
            "\nfailure_flags: " + failure_flags.ToString() +
            "\nerror_count: " + error_count.ToString() +
            "\ntemperature: " + temperature.ToString();
        }
    }
}