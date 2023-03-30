using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LanApp6_1Multicast
{
    public enum MessageType { None, Text, File, Image}

    [Serializable]
    public class MessagePacket
    {
        public MessageType Type;
        public object Data;

        private static BinaryFormatter bf = new BinaryFormatter();
        public override string ToString()
        {
            return Data.ToString();
        }
        public static MessagePacket FromByteArray(byte[] data)
        {
            MessagePacket result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(data, 0, data.Length);
                ms.Position = 0;
                result = (MessagePacket)bf.Deserialize(ms);
            }
            return result;
        }
        public static MessagePacket FromStream(Stream stream)
        {
            return bf.Deserialize(stream) as MessagePacket;
        }

        public byte[] ToByteArray()
        {
            MemoryStream ms = new MemoryStream();   
            bf.Serialize(ms, this);
            ms.Position = 0;
            return ms.ToArray();
        }
    }
}
