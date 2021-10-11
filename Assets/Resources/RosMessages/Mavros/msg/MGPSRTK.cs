//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MGPSRTK : Message
    {
        public const string RosMessageName = "mavros_msgs/GPSRTK";

        //  FCU GPS RTK message for the gps_status plugin
        //  A copy of <a href="https://mavlink.io/en/messages/common.html#GPS_RTK">mavlink GPS_RTK message</a>
        public Std.MHeader header;
        public byte rtk_receiver_id;
        //  Identification of connected RTK receiver.
        public short wn;
        //  GPS Week Number of last baseline.
        public uint tow;
        //  [ms] GPS Time of Week of last baseline.
        public byte rtk_health;
        //  GPS-specific health report for RTK data.
        public byte rtk_rate;
        //  [Hz] Rate of baseline messages being received by GPS.
        public byte nsats;
        //  Current number of sats used for RTK calculation.
        public int baseline_a;
        //  [mm] Current baseline in ECEF x or NED north component, depends on header.frame_id.
        public int baseline_b;
        //  [mm] Current baseline in ECEF y or NED east component, depends on header.frame_id.
        public int baseline_c;
        //  [mm] Current baseline in ECEF z or NED down component, depends on header.frame_id.
        public uint accuracy;
        //  Current estimate of baseline accuracy.
        public int iar_num_hypotheses;
        //  Current number of integer ambiguity hypotheses.

        public MGPSRTK()
        {
            this.header = new Std.MHeader();
            this.rtk_receiver_id = 0;
            this.wn = 0;
            this.tow = 0;
            this.rtk_health = 0;
            this.rtk_rate = 0;
            this.nsats = 0;
            this.baseline_a = 0;
            this.baseline_b = 0;
            this.baseline_c = 0;
            this.accuracy = 0;
            this.iar_num_hypotheses = 0;
        }

        public MGPSRTK(Std.MHeader header, byte rtk_receiver_id, short wn, uint tow, byte rtk_health, byte rtk_rate, byte nsats, int baseline_a, int baseline_b, int baseline_c, uint accuracy, int iar_num_hypotheses)
        {
            this.header = header;
            this.rtk_receiver_id = rtk_receiver_id;
            this.wn = wn;
            this.tow = tow;
            this.rtk_health = rtk_health;
            this.rtk_rate = rtk_rate;
            this.nsats = nsats;
            this.baseline_a = baseline_a;
            this.baseline_b = baseline_b;
            this.baseline_c = baseline_c;
            this.accuracy = accuracy;
            this.iar_num_hypotheses = iar_num_hypotheses;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(new[]{this.rtk_receiver_id});
            listOfSerializations.Add(BitConverter.GetBytes(this.wn));
            listOfSerializations.Add(BitConverter.GetBytes(this.tow));
            listOfSerializations.Add(new[]{this.rtk_health});
            listOfSerializations.Add(new[]{this.rtk_rate});
            listOfSerializations.Add(new[]{this.nsats});
            listOfSerializations.Add(BitConverter.GetBytes(this.baseline_a));
            listOfSerializations.Add(BitConverter.GetBytes(this.baseline_b));
            listOfSerializations.Add(BitConverter.GetBytes(this.baseline_c));
            listOfSerializations.Add(BitConverter.GetBytes(this.accuracy));
            listOfSerializations.Add(BitConverter.GetBytes(this.iar_num_hypotheses));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.rtk_receiver_id = data[offset];;
            offset += 1;
            this.wn = BitConverter.ToInt16(data, offset);
            offset += 2;
            this.tow = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.rtk_health = data[offset];;
            offset += 1;
            this.rtk_rate = data[offset];;
            offset += 1;
            this.nsats = data[offset];;
            offset += 1;
            this.baseline_a = BitConverter.ToInt32(data, offset);
            offset += 4;
            this.baseline_b = BitConverter.ToInt32(data, offset);
            offset += 4;
            this.baseline_c = BitConverter.ToInt32(data, offset);
            offset += 4;
            this.accuracy = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.iar_num_hypotheses = BitConverter.ToInt32(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "MGPSRTK: " +
            "\nheader: " + header.ToString() +
            "\nrtk_receiver_id: " + rtk_receiver_id.ToString() +
            "\nwn: " + wn.ToString() +
            "\ntow: " + tow.ToString() +
            "\nrtk_health: " + rtk_health.ToString() +
            "\nrtk_rate: " + rtk_rate.ToString() +
            "\nnsats: " + nsats.ToString() +
            "\nbaseline_a: " + baseline_a.ToString() +
            "\nbaseline_b: " + baseline_b.ToString() +
            "\nbaseline_c: " + baseline_c.ToString() +
            "\naccuracy: " + accuracy.ToString() +
            "\niar_num_hypotheses: " + iar_num_hypotheses.ToString();
        }
    }
}