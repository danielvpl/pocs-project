/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V2.RPC
{
    public class ItemOperationStatus : XdrAble
    {
        private NFSStats _status;
        private ItemOperationAccessOK _ok;

        public ItemOperationStatus()
        { }

        public ItemOperationStatus(XdrDecodingStream xdr)
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
                    this._ok = new ItemOperationAccessOK(xdr);
                    break;

                default:
                    break;
            }
        }

        public ItemOperationAccessOK OK
        {
            get
            { return this._ok; }
        }

        public NFSStats Status
        {
            get
            { return this._status; }
        }
    }

    public class ItemOperationAccessOK : XdrAble
    {
        private NFSHandle _item;
        private FileAttributes _attributes;

        public ItemOperationAccessOK()
        { }

        public ItemOperationAccessOK(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._item.xdrEncode(xdr);
            this._attributes.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._item = new NFSHandle();
            this._item.Version = V2.RPC.NFSv2Protocol.NFS_VERSION;
            this._item.xdrDecode(xdr);
            this._attributes = new FileAttributes(xdr);
        }

        public NFSHandle HandleObject
        {
            get
            { return this._item; }
        }

        public FileAttributes Attributes
        {
            get
            { return this._attributes; }
        }
    }

    // End of diropres.cs
}