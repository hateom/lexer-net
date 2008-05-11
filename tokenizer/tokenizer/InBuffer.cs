using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tokenizer
{
    class InBuffer
    {
        private string buffer;
        public string Buffer { get { return buffer;  } }

        private bool isEnd;
        public bool IsEnd { get { return isEnd;  } }

        private int startPos;
        private int len;

        public InBuffer( string buf )
        {
            buffer = buf;
            startPos = 0;
            len = 0;
        }

        public string Move()
        {
            len++;
            if( startPos + len > buffer.Length)
            {
                len--;
            }

            if( startPos + len == buffer.Length ) isEnd = true;
            return buffer.Substring( startPos, len );
        }

        public string MoveBack()
        {
            if( len > 0 ) len--;
            return buffer.Substring( startPos, len );
        }

        public string Accept()
        {
            if(isEnd) return Move();
            string output = buffer.Substring( startPos, len );
            startPos += len;
            len = 0;
            if(startPos == buffer.Length) isEnd = true;
            return output;
        }
    }
}
