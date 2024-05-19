/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */

using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V2.RPC
{
    public class FileAttributes : XdrAble
    {
        private NFSItemTypes _type;
        private NFSPermission _mode;
        private int _nlink;
        private int _uid;
        private int _gid;
        private long _size;
        private int _blocksize;
        private int _rdev;
        private int _blocks;
        private int _fsid;
        private int _fileid;
        private NFSTimeValue _atime;
        private NFSTimeValue _mtime;
        private NFSTimeValue _ctime;

        public FileAttributes()
        { }

        public FileAttributes(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt((int)this._type);
            xdr.xdrEncodeInt(this._mode.Mode);
            xdr.xdrEncodeInt(this._nlink);
            xdr.xdrEncodeInt(this._uid);
            xdr.xdrEncodeInt(this._gid);
            xdr.xdrEncodeInt((int)this._size);
            xdr.xdrEncodeInt(this._blocksize);
            xdr.xdrEncodeInt(this._rdev);
            xdr.xdrEncodeInt(this._blocks);
            xdr.xdrEncodeInt(this._fsid);
            xdr.xdrEncodeInt(this._fileid);
            this._atime.xdrEncode(xdr);
            this._mtime.xdrEncode(xdr);
            this._ctime.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._type = (NFSItemTypes)xdr.xdrDecodeInt();

            this._mode = new NFSPermission();
            this._mode.Mode = xdr.xdrDecodeInt();

            this._nlink = xdr.xdrDecodeInt();
            this._uid = xdr.xdrDecodeInt();
            this._gid = xdr.xdrDecodeInt();
            this._size = xdr.xdrDecodeInt();
            this._blocksize = xdr.xdrDecodeInt();
            this._rdev = xdr.xdrDecodeInt();
            this._blocks = xdr.xdrDecodeInt();

            /* Calculate File Size (>4GB) */
            //int fileSize = (int)this._size;

            //double blockForFile = (double)fileSize / (double)this._blocksize;
            //double blocksOnDisk = blockForFile + 0.49;
            //blocksOnDisk = System.Math.Round(blocksOnDisk);

            ///* I think it's a bug on blocks value, cause some times blocks value
            // * comes 8 value greater than calculated size.
            // * Following fixes the related bug(?) */
            //if (blocksOnDisk <= ((this._blocks / 8) - 1))
            //{ this._blocks -= 8; }

            //double diff = (blocksOnDisk - blockForFile) * this._blocksize;

            //long bytesInBlock = (long)(this._blocks / 8) * (long)this._blocksize;
            //bytesInBlock -= (int)diff;

            //this._size = bytesInBlock >= 0? bytesInBlock : _size;
            /* ---- */

            this._fsid = xdr.xdrDecodeInt();
            this._fileid = xdr.xdrDecodeInt();
            this._atime = new NFSTimeValue(xdr);
            this._mtime = new NFSTimeValue(xdr);
            this._ctime = new NFSTimeValue(xdr);
        }

        public NFSItemTypes Type
        {
            get
            { return this._type; }
        }

        public NFSPermission Mode
        {
            get
            { return this._mode; }
        }

        public int Link
        {
            get
            { return this._nlink; }
        }

        public int UserID
        {
            get
            { return this._uid; }
        }

        public int GroupID
        {
            get
            { return this._gid; }
        }

        public long Size
        {
            get
            { return this._size; }
        }

        public int BlockSize
        {
            get
            { return this._blocksize; }
        }

        public int RDev
        {
            get
            { return this._rdev; }
        }

        public int Blocks
        {
            get
            { return this._blocks; }
        }

        public int FSID
        {
            get
            { return this._fsid; }
        }

        public int FileID
        {
            get
            { return this._fileid; }
        }

        public NFSTimeValue LastAccessedTime
        {
            get
            { return this._atime; }
        }

        public NFSTimeValue ModifiedTime
        {
            get
            { return this._mtime; }
        }

        public NFSTimeValue CreateTime
        {
            get
            { return this._ctime; }
        }
    }

    // End of fattr.cs
}