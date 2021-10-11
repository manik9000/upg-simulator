//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Mavros
{
    public class MOnboardComputerStatus : Message
    {
        public const string RosMessageName = "mavros_msgs/OnboardComputerStatus";

        //  Mavros message: ONBOARDCOMPUTERSTATUS
        public Std.MHeader header;
        public byte component;
        //  See enum MAV_COMPONENT
        public uint uptime;
        //  [ms] Time since system boot
        public byte type;
        //  Type of the onboard computer: 0: Mission computer primary, 1: Mission computer backup 1, 2: Mission computer backup 2, 3: Compute node, 4-5: Compute spares, 6-9: Payload computers.
        public byte[] cpu_cores;
        //  CPU usage on the component in percent (100 - idle). A value of UINT8_MAX implies the field is unused.
        public byte[] cpu_combined;
        //  Combined CPU usage as the last 10 slices of 100 MS (a histogram). This allows to identify spikes in load that max out the system, but only for a short amount of time. A value of UINT8_MAX implies the field is unused
        public byte[] gpu_cores;
        //  GPU usage on the component in percent (100 - idle). A value of UINT8_MAX implies the field is unused
        public byte[] gpu_combined;
        //  Combined GPU usage as the last 10 slices of 100 MS (a histogram). This allows to identify spikes in load that max out the system, but only for a short amount of time. A value of UINT8_MAX implies the field is unused.
        public sbyte temperature_board;
        //  [degC] Temperature of the board. A value of INT8_MAX implies the field is unused.
        public sbyte[] temperature_core;
        //  [degC] Temperature of the CPU core. A value of INT8_MAX implies the field is unused.
        public short[] fan_speed;
        //  [rpm] Fan speeds. A value of INT16_MAX implies the field is unused.
        public uint ram_usage;
        //  [MiB] Amount of used RAM on the component system. A value of UINT32_MAX implies the field is unused.
        public uint ram_total;
        //  [MiB] Total amount of RAM on the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] storage_type;
        //  Storage type: 0: HDD, 1: SSD, 2: EMMC, 3: SD card (non-removable), 4: SD card (removable). A value of UINT32_MAX implies the field is unused.
        public uint[] storage_usage;
        //  [MiB] Amount of used storage space on the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] storage_total;
        //  [MiB] Total amount of storage space on the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] link_type;
        //  Link type: 0-9: UART, 10-19: Wired network, 20-29: Wifi, 30-39: Point-to-point proprietary, 40-49: Mesh proprietary.
        public uint[] link_tx_rate;
        //  [KiB/s] Network traffic from the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] link_rx_rate;
        //  [KiB/s] Network traffic to the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] link_tx_max;
        //  [KiB/s] Network capacity from the component system. A value of UINT32_MAX implies the field is unused.
        public uint[] link_rx_max;
        //  [KiB/s] Network capacity to the component system. A value of UINT32_MAX implies the field is unused.

        public MOnboardComputerStatus()
        {
            this.header = new Std.MHeader();
            this.component = 0;
            this.uptime = 0;
            this.type = 0;
            this.cpu_cores = new byte[8];
            this.cpu_combined = new byte[10];
            this.gpu_cores = new byte[4];
            this.gpu_combined = new byte[10];
            this.temperature_board = 0;
            this.temperature_core = new sbyte[8];
            this.fan_speed = new short[4];
            this.ram_usage = 0;
            this.ram_total = 0;
            this.storage_type = new uint[4];
            this.storage_usage = new uint[4];
            this.storage_total = new uint[4];
            this.link_type = new uint[6];
            this.link_tx_rate = new uint[6];
            this.link_rx_rate = new uint[6];
            this.link_tx_max = new uint[6];
            this.link_rx_max = new uint[6];
        }

        public MOnboardComputerStatus(Std.MHeader header, byte component, uint uptime, byte type, byte[] cpu_cores, byte[] cpu_combined, byte[] gpu_cores, byte[] gpu_combined, sbyte temperature_board, sbyte[] temperature_core, short[] fan_speed, uint ram_usage, uint ram_total, uint[] storage_type, uint[] storage_usage, uint[] storage_total, uint[] link_type, uint[] link_tx_rate, uint[] link_rx_rate, uint[] link_tx_max, uint[] link_rx_max)
        {
            this.header = header;
            this.component = component;
            this.uptime = uptime;
            this.type = type;
            this.cpu_cores = cpu_cores;
            this.cpu_combined = cpu_combined;
            this.gpu_cores = gpu_cores;
            this.gpu_combined = gpu_combined;
            this.temperature_board = temperature_board;
            this.temperature_core = temperature_core;
            this.fan_speed = fan_speed;
            this.ram_usage = ram_usage;
            this.ram_total = ram_total;
            this.storage_type = storage_type;
            this.storage_usage = storage_usage;
            this.storage_total = storage_total;
            this.link_type = link_type;
            this.link_tx_rate = link_tx_rate;
            this.link_rx_rate = link_rx_rate;
            this.link_tx_max = link_tx_max;
            this.link_rx_max = link_rx_max;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.Add(new[]{this.component});
            listOfSerializations.Add(BitConverter.GetBytes(this.uptime));
            listOfSerializations.Add(new[]{this.type});
            
            Array.Resize(ref cpu_cores, 8);
            listOfSerializations.Add(this.cpu_cores);
            
            Array.Resize(ref cpu_combined, 10);
            listOfSerializations.Add(this.cpu_combined);
            
            Array.Resize(ref gpu_cores, 4);
            listOfSerializations.Add(this.gpu_cores);
            
            Array.Resize(ref gpu_combined, 10);
            listOfSerializations.Add(this.gpu_combined);
            listOfSerializations.Add(new[]{(byte)this.temperature_board});
            
            Array.Resize(ref temperature_core, 8);
            listOfSerializations.Add((byte[]) (Array)this.temperature_core);
            
            Array.Resize(ref fan_speed, 4);
            foreach(var entry in fan_speed)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            listOfSerializations.Add(BitConverter.GetBytes(this.ram_usage));
            listOfSerializations.Add(BitConverter.GetBytes(this.ram_total));
            
            Array.Resize(ref storage_type, 4);
            foreach(var entry in storage_type)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref storage_usage, 4);
            foreach(var entry in storage_usage)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref storage_total, 4);
            foreach(var entry in storage_total)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref link_type, 6);
            foreach(var entry in link_type)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref link_tx_rate, 6);
            foreach(var entry in link_tx_rate)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref link_rx_rate, 6);
            foreach(var entry in link_rx_rate)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref link_tx_max, 6);
            foreach(var entry in link_tx_max)
                listOfSerializations.Add(BitConverter.GetBytes(entry));
            
            Array.Resize(ref link_rx_max, 6);
            foreach(var entry in link_rx_max)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            this.component = data[offset];;
            offset += 1;
            this.uptime = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.type = data[offset];;
            offset += 1;
            
            this.cpu_cores= new byte[8];
            for(var i = 0; i < 8; i++)
            {
                this.cpu_cores[i] = data[offset];
                offset += 1;
            }
            
            this.cpu_combined= new byte[10];
            for(var i = 0; i < 10; i++)
            {
                this.cpu_combined[i] = data[offset];
                offset += 1;
            }
            
            this.gpu_cores= new byte[4];
            for(var i = 0; i < 4; i++)
            {
                this.gpu_cores[i] = data[offset];
                offset += 1;
            }
            
            this.gpu_combined= new byte[10];
            for(var i = 0; i < 10; i++)
            {
                this.gpu_combined[i] = data[offset];
                offset += 1;
            }
            this.temperature_board = (sbyte)data[offset];;
            offset += 1;
            
            this.temperature_core= new sbyte[8];
            for(var i = 0; i < 8; i++)
            {
                this.temperature_core[i] = (sbyte)data[offset];
                offset += 1;
            }
            
            this.fan_speed= new short[4];
            for(var i = 0; i < 4; i++)
            {
                this.fan_speed[i] = BitConverter.ToInt16(data, offset);
                offset += 2;
            }
            this.ram_usage = BitConverter.ToUInt32(data, offset);
            offset += 4;
            this.ram_total = BitConverter.ToUInt32(data, offset);
            offset += 4;
            
            this.storage_type= new uint[4];
            for(var i = 0; i < 4; i++)
            {
                this.storage_type[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.storage_usage= new uint[4];
            for(var i = 0; i < 4; i++)
            {
                this.storage_usage[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.storage_total= new uint[4];
            for(var i = 0; i < 4; i++)
            {
                this.storage_total[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.link_type= new uint[6];
            for(var i = 0; i < 6; i++)
            {
                this.link_type[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.link_tx_rate= new uint[6];
            for(var i = 0; i < 6; i++)
            {
                this.link_tx_rate[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.link_rx_rate= new uint[6];
            for(var i = 0; i < 6; i++)
            {
                this.link_rx_rate[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.link_tx_max= new uint[6];
            for(var i = 0; i < 6; i++)
            {
                this.link_tx_max[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }
            
            this.link_rx_max= new uint[6];
            for(var i = 0; i < 6; i++)
            {
                this.link_rx_max[i] = BitConverter.ToUInt32(data, offset);
                offset += 4;
            }

            return offset;
        }

        public override string ToString()
        {
            return "MOnboardComputerStatus: " +
            "\nheader: " + header.ToString() +
            "\ncomponent: " + component.ToString() +
            "\nuptime: " + uptime.ToString() +
            "\ntype: " + type.ToString() +
            "\ncpu_cores: " + System.String.Join(", ", cpu_cores.ToList()) +
            "\ncpu_combined: " + System.String.Join(", ", cpu_combined.ToList()) +
            "\ngpu_cores: " + System.String.Join(", ", gpu_cores.ToList()) +
            "\ngpu_combined: " + System.String.Join(", ", gpu_combined.ToList()) +
            "\ntemperature_board: " + temperature_board.ToString() +
            "\ntemperature_core: " + System.String.Join(", ", temperature_core.ToList()) +
            "\nfan_speed: " + System.String.Join(", ", fan_speed.ToList()) +
            "\nram_usage: " + ram_usage.ToString() +
            "\nram_total: " + ram_total.ToString() +
            "\nstorage_type: " + System.String.Join(", ", storage_type.ToList()) +
            "\nstorage_usage: " + System.String.Join(", ", storage_usage.ToList()) +
            "\nstorage_total: " + System.String.Join(", ", storage_total.ToList()) +
            "\nlink_type: " + System.String.Join(", ", link_type.ToList()) +
            "\nlink_tx_rate: " + System.String.Join(", ", link_tx_rate.ToList()) +
            "\nlink_rx_rate: " + System.String.Join(", ", link_rx_rate.ToList()) +
            "\nlink_tx_max: " + System.String.Join(", ", link_tx_max.ToList()) +
            "\nlink_rx_max: " + System.String.Join(", ", link_rx_max.ToList());
        }
    }
}