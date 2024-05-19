/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class deviceid4 : XdrAble
    {
        public byte[] value;

        public deviceid4()
        {
        }

        public deviceid4(byte[] value)
        {
            this.value = value;
        }

        public deviceid4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeOpaque(value, NFSv4Protocol.NFS4_DEVICEID4_SIZE);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            value = xdr.xdrDecodeOpaque(NFSv4Protocol.NFS4_DEVICEID4_SIZE);
        }
    }
} // End of  deviceid4.cs