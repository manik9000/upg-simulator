//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MParamPullRequest : Message
    {
        public const string RosMessageName = "mavros_msgs/ParamPull";

        //  Request parameters from device
        // 
        //  Returns success status and param_recived count
        public bool force_pull;

        public MParamPullRequest()
        {
            this.force_pull = false;
        }

        public MParamPullRequest(bool force_pull)
        {
            this.force_pull = force_pull;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.force_pull));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.force_pull = BitConverter.ToBoolean(data, offset);
            offset += 1;

            return offset;
        }

        public override string ToString()
        {
            return "MParamPullRequest: " +
            "\nforce_pull: " + force_pull.ToString();
        }
    }
}