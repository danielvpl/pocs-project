/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class ssv_seal_plain_tkn4 : XdrAble
    {
        public byte[] sspt_confounder;
        public int sspt_ssv_seq;
        public byte[] sspt_orig_plain;
        public byte[] sspt_pad;

        public ssv_seal_plain_tkn4()
        {
        }

        public ssv_seal_plain_tkn4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(sspt_ssv_seq);
            xdr.xdrEncodeDynamicOpaque(sspt_orig_plain);
            xdr.xdrEncodeDynamicOpaque(sspt_pad);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            sspt_ssv_seq = xdr.xdrDecodeInt();
            sspt_orig_plain = xdr.xdrDecodeDynamicOpaque();
            sspt_pad = xdr.xdrDecodeDynamicOpaque();
        }
    }
} // End of ssv_seal_plain_tkn4.cs