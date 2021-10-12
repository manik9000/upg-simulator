//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    [Serializable]
    public class RadioStatusMsg : Message
    {
        public const string k_RosMessageName = "mavros_msgs/RadioStatus";
        public override string RosMessageName => k_RosMessageName;

        //  RADIO_STATUS message
        public Std.HeaderMsg header;
        //  message data
        public byte rssi;
        public byte remrssi;
        public byte txbuf;
        public byte noise;
        public byte remnoise;
        public ushort rxerrors;
        public ushort @fixed;
        //  calculated
        public float rssi_dbm;
        public float remrssi_dbm;

        public RadioStatusMsg()
        {
            this.header = new Std.HeaderMsg();
            this.rssi = 0;
            this.remrssi = 0;
            this.txbuf = 0;
            this.noise = 0;
            this.remnoise = 0;
            this.rxerrors = 0;
            this.@fixed = 0;
            this.rssi_dbm = 0.0f;
            this.remrssi_dbm = 0.0f;
        }

        public RadioStatusMsg(Std.HeaderMsg header, byte rssi, byte remrssi, byte txbuf, byte noise, byte remnoise, ushort rxerrors, ushort @fixed, float rssi_dbm, float remrssi_dbm)
        {
            this.header = header;
            this.rssi = rssi;
            this.remrssi = remrssi;
            this.txbuf = txbuf;
            this.noise = noise;
            this.remnoise = remnoise;
            this.rxerrors = rxerrors;
            this.@fixed = @fixed;
            this.rssi_dbm = rssi_dbm;
            this.remrssi_dbm = remrssi_dbm;
        }

        public static RadioStatusMsg Deserialize(MessageDeserializer deserializer) => new RadioStatusMsg(deserializer);

        private RadioStatusMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.rssi);
            deserializer.Read(out this.remrssi);
            deserializer.Read(out this.txbuf);
            deserializer.Read(out this.noise);
            deserializer.Read(out this.remnoise);
            deserializer.Read(out this.rxerrors);
            deserializer.Read(out this.@fixed);
            deserializer.Read(out this.rssi_dbm);
            deserializer.Read(out this.remrssi_dbm);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.rssi);
            serializer.Write(this.remrssi);
            serializer.Write(this.txbuf);
            serializer.Write(this.noise);
            serializer.Write(this.remnoise);
            serializer.Write(this.rxerrors);
            serializer.Write(this.@fixed);
            serializer.Write(this.rssi_dbm);
            serializer.Write(this.remrssi_dbm);
        }

        public override string ToString()
        {
            return "RadioStatusMsg: " +
            "\nheader: " + header.ToString() +
            "\nrssi: " + rssi.ToString() +
            "\nremrssi: " + remrssi.ToString() +
            "\ntxbuf: " + txbuf.ToString() +
            "\nnoise: " + noise.ToString() +
            "\nremnoise: " + remnoise.ToString() +
            "\nrxerrors: " + rxerrors.ToString() +
            "\n@fixed: " + @fixed.ToString() +
            "\nrssi_dbm: " + rssi_dbm.ToString() +
            "\nremrssi_dbm: " + remrssi_dbm.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}