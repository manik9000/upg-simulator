//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MHilGPS : Message
    {
        public const string RosMessageName = "mavros_msgs/HilGPS";

        //  HilControls.msg
        // 
        //  ROS representation of MAVLink HIL_GPS
        //  See mavlink message documentation here:
        //  https://mavlink.io/en/messages/common.html#HIL_GPS
        public Std.MHeader header;
        public byte fix_type;
        public Geographic.MGeoPoint geo;
        public ushort eph;
        public ushort epv;
        public ushort vel;
        public short vn;
        public short ve;
        public short vd;
        public ushort cog;
        public byte satellites_visible;

        public MHilGPS()
        {
            this.header = new Std.MHeader();
            this.fix_type = 0;
            this.geo = new Geographic.MGeoPoint();
            this.eph = 0;
            this.epv = 0;
            this.vel = 0;
            this.vn = 0;
            this.ve = 0;
            this.vd = 0;
            this.cog = 0;
            this.satellites_visible = 0;
        }

        public MHilGPS(Std.MHeader header, byte fix_type, Geographic.MGeoPoint geo, ushort eph, ushort epv, ushort vel, short vn, short ve, short vd, ushort cog, byte satellites_visible)
        {
            this.header = header;
            this.fix_type = fix_type;
            this.geo = geo;
            this.eph = eph;
            this.epv = epv;
            this.vel = vel;
            this.vn = vn;
            this.ve = ve;
            this.vd = vd;
            this.cog = cog;
            this.satellites_visible = satellites_visible;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(new[]{this.fix_type});
            listOfSerializations.AddRange(geo.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.eph));
            listOfSerializations.Add(BitConverter.GetBytes(this.epv));
            listOfSerializations.Add(BitConverter.GetBytes(this.vel));
            listOfSerializations.Add(BitConverter.GetBytes(this.vn));
            listOfSerializations.Add(BitConverter.GetBytes(this.ve));
            listOfSerializations.Add(BitConverter.GetBytes(this.vd));
            listOfSerializations.Add(BitConverter.GetBytes(this.cog));
            listOfSerializations.Add(new[]{this.satellites_visible});

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.fix_type = data[offset];;
            offset += 1;
            offset = this.geo.Deserialize(data, offset);
            this.eph = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.epv = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.vel = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.vn = BitConverter.ToInt16(data, offset);
            offset += 2;
            this.ve = BitConverter.ToInt16(data, offset);
            offset += 2;
            this.vd = BitConverter.ToInt16(data, offset);
            offset += 2;
            this.cog = BitConverter.ToUInt16(data, offset);
            offset += 2;
            this.satellites_visible = data[offset];;
            offset += 1;

            return offset;
        }

        public override string ToString()
        {
            return "MHilGPS: " +
            "\nheader: " + header.ToString() +
            "\nfix_type: " + fix_type.ToString() +
            "\ngeo: " + geo.ToString() +
            "\neph: " + eph.ToString() +
            "\nepv: " + epv.ToString() +
            "\nvel: " + vel.ToString() +
            "\nvn: " + vn.ToString() +
            "\nve: " + ve.ToString() +
            "\nvd: " + vd.ToString() +
            "\ncog: " + cog.ToString() +
            "\nsatellites_visible: " + satellites_visible.ToString();
        }
    }
}