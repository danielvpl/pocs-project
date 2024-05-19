/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class WRITE4args : XdrAble
    {
        public stateid4 stateid;
        public offset4 offset;
        public int stable;
        public byte[] data;

        public WRITE4args()
        {
        }

        public WRITE4args(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            stateid.xdrEncode(xdr);
            offset.xdrEncode(xdr);
            xdr.xdrEncodeInt(stable);
            xdr.xdrEncodeDynamicOpaque(data);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            stateid = new stateid4(xdr);
            offset = new offset4(xdr);
            stable = xdr.xdrDecodeInt();
            data = xdr.xdrDecodeDynamicOpaque();
        }
    }
} // End of WRITE4args.cs