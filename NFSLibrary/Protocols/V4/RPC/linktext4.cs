/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class linktext4 : XdrAble
    {
        public utf8str_cs value;

        public linktext4()
        {
        }

        public linktext4(utf8str_cs value)
        {
            this.value = value;
        }

        public linktext4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            value.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            value = new utf8str_cs(xdr);
        }
    }
} // End of linktext4.cs