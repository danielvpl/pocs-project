/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V2.RPC
{
    public class FSStatStatus : XdrAble
    {
        private NFSStats _status;
        private Info _ok;

        public FSStatStatus()
        { }

        public FSStatStatus(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt((int)this._status);

            switch (this._status)
            {
                case NFSStats.NFS_OK:
                    this._ok.xdrEncode(xdr);
                    break;

                default:
                    break;
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._status = (NFSStats)xdr.xdrDecodeInt();

            switch (this._status)
            {
                case NFSStats.NFS_OK:
                    this._ok = new Info(xdr);
                    break;

                default:
                    break;
            }
        }

        public NFSStats Status
        {
            get
            { return this._status; }
        }

        public Info OK
        {
            get
            { return this._ok; }
        }
    }

    // End of statfsres.cs
}