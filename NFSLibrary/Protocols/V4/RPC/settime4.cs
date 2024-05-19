/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class settime4 : XdrAble
    {
        public int set_it;
        public nfstime4 time;

        public settime4()
        {
        }

        public settime4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(set_it);
            switch (set_it)
            {
                case time_how4.SET_TO_CLIENT_TIME4:
                    time.xdrEncode(xdr);
                    break;

                default:
                    break;
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            set_it = xdr.xdrDecodeInt();
            switch (set_it)
            {
                case time_how4.SET_TO_CLIENT_TIME4:
                    time = new nfstime4(xdr);
                    break;

                default:
                    break;
            }
        }
    }
} // End of settime4.cs