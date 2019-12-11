using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Base;
using PcapDotNet.Packets;

namespace PacketGenerateor
{
    abstract class TLS13Layer : Layer, IEquatable<TLS13Layer>
    {
        public HandshakeType msg_type;
        public UInt24 length;
        public UInt16 ProtocolVersion;

        protected TLS13Layer(HandshakeType msg_type, UInt24 length, ushort protocolVersion)
        {
            this.msg_type = msg_type;
            this.length = length;
            ProtocolVersion = protocolVersion;
        }

        public enum HandshakeType : byte
        {
            client_hello = 1,
            server_hello = 2,
            new_session_ticket = 4,
            end_of_early_data = 5,
            encrypted_extensions = 8,
            certificate = 11,
            certificate_request = 13,
            certificate_verify = 15,
            finished = 20,
            key_update = 24,
            message_hash = 254
        }
        public bool Equals(TLS13Layer other)
        {
            return Equals(other as TLS13Layer);
        }

    }
}
