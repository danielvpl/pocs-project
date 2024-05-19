/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class layoutreturn_stateid : XdrAble
    {
        public bool lrs_present;
        public stateid4 lrs_stateid;

        public layoutreturn_stateid()
        {
        }

        public layoutreturn_stateid(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeBoolean(lrs_present);
            if (lrs_present == true)
            {
                lrs_stateid.xdrEncode(xdr);
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            lrs_present = xdr.xdrDecodeBoolean();
            if (lrs_present == true)
            {
                lrs_stateid = new stateid4(xdr);
            }
        }
    }
} // End of layoutreturn_stateid.cs