/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class open_none_delegation4 : XdrAble
    {
        public int ond_why;
        public bool ond_server_will_push_deleg;
        public bool ond_server_will_signal_avail;

        public open_none_delegation4()
        {
        }

        public open_none_delegation4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(ond_why);
            switch (ond_why)
            {
                case why_no_delegation4.WND4_CONTENTION:
                    xdr.xdrEncodeBoolean(ond_server_will_push_deleg);
                    break;

                case why_no_delegation4.WND4_RESOURCE:
                    xdr.xdrEncodeBoolean(ond_server_will_signal_avail);
                    break;

                default:
                    break;
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            ond_why = xdr.xdrDecodeInt();
            switch (ond_why)
            {
                case why_no_delegation4.WND4_CONTENTION:
                    ond_server_will_push_deleg = xdr.xdrDecodeBoolean();
                    break;

                case why_no_delegation4.WND4_RESOURCE:
                    ond_server_will_signal_avail = xdr.xdrDecodeBoolean();
                    break;

                default:
                    break;
            }
        }
    }
} // End of open_none_delegation4.cs