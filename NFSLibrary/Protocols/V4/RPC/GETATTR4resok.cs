/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class GETATTR4resok : XdrAble
    {
        public fattr4 obj_attributes;

        public GETATTR4resok()
        {
        }

        public GETATTR4resok(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            obj_attributes.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            obj_attributes = new fattr4(xdr);
        }
    }
} // End of  GETATTR4resok.cs