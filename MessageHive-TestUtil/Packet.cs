using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Message;

namespace MessageHive_TestUtil
{
    class Packet
    {
        public static byte[] Pack(Message.Container msg) 
        {
            byte[] data = Message.Container.SerializeToBytes(msg);
            byte[] len = BitConverter.GetBytes(data.Length);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(len);

            byte[] packet = new byte[len.Length + data.Length];
            len.CopyTo(packet, 0);
            data.CopyTo(packet, len.Length);
            return packet;
        }

        public static Message.Container UnPack(byte[] packet)
        {
            if(packet.Length < 4)
            {
                throw new FormatException("Need more data");
            }
            byte[] tmp = new byte[4];
            Array.ConstrainedCopy(packet, 0, tmp, 0, tmp.Length);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(tmp);
            }
            UInt32 length = BitConverter.ToUInt32(tmp, 0);
            if(packet.Length < 4 + length)
            {
                throw new FormatException("Need more data");
            }
            byte[] data = new byte[length];
            Array.ConstrainedCopy(packet, tmp.Length, data, 0, (int)length);
            Message.Container msg = new Message.Container();
            msg = Message.Container.Deserialize(data);
            return msg;
        }
    }
}
