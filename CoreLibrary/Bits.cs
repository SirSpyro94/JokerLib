using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerLib
{
    public class Bits
    {
        public static uint ReverseBytes(uint value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 | (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }

        public static byte[] ReverseArrayByDword(byte[] value)
        {
            if (value.Length % 4 != 0)
                throw new Exception("Invalid length");
            var builder = new List<byte>();
            for (int i = 0; i < value.Length - 4; i += 4)
            {
                var take = new byte[] { value[i], value[i + 1], value[i + 2], value[i + 3] };
                Array.Reverse(take);
                foreach (var c in take)
                    builder.Add(c);
            }
            return builder.ToArray();
        }
    }
}
