using E3Series.Proxy.Abstract;
using E3Series.Proxy.Interfaces;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3NetProxy : E3ProxyBase, IAttributed
    {
        public E3NetProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DisplayAttributeValueAt(string name, int sheetid, double x, double y)
        {
            return ComObject.DisplayAttributeValueAt(name, sheetid, x, y);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public string GetGUID()
        {
            return ComObject.GetGUID();
        }

        public int GetHarnessId()
        {
            return ComObject.GetHarnessId();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetIds(ref object ids)
        {
            return ComObject.GetNetIds(ref ids);
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetParentID()
        {
            return ComObject.GetParentID();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public string GetSignalName()
        {
            return ComObject.GetSignalName();
        }

        public string GetTranslatedSignalName()
        {
            return ComObject.GetTranslatedSignalName();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsSignalTransferred()
        {
            return ComObject.IsSignalTransferred();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return ComObject.SetAttributeVisibility(name, onoff);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public string SetGUID(string guid)
        {
            return ComObject.SetGUID(guid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetSignalName(string name)
        {
            return ComObject.SetSignalName(name);
        }

        public int SetSignalNameOnLocalNet(string name)
        {
            return ComObject.SetSignalNameOnLocalNet(name);
        }

        public int SetTransferSignal(int value)
        {
            return ComObject.SetTransferSignal(value);
        }

        public int SplitHarness()
        {
            return ComObject.SplitHarness();
        }

    }
}