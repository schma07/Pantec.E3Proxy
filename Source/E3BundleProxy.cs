using E3Series.Proxy.Abstract;
using E3Series.Proxy.Interfaces;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3BundleProxy : E3ProxyBase, IAttributed
    {
        public E3BundleProxy(object comObject) : base(comObject)
        {
        }
        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Capture(ref object cabwirids)
        {
            return ComObject.Capture(cabwirids);
        }

        public int Create(ref object aroundids)
        {
            return ComObject.Create(aroundids);
        }

        public int CreateBundle(ref object aroundids)
        {
            return ComObject.CreateBundle(aroundids);
        }

        public int CreateBundleIn(int cableid)
        {
            return ComObject.CreateBundleIn(cableid);
        }

        public int CreateIn(int cableid)
        {
            return ComObject.CreateIn(cableid);
        }

        public int CreateShield(ref object aroundids)
        {
            return ComObject.CreateShield(aroundids);
        }

        public int CreateShieldIn(int cableid)
        {
            return ComObject.CreateShieldIn(cableid);
        }

        public int CreateTwist(ref object aroundids)
        {
            return ComObject.CreateTwist(aroundids);
        }

        public int CreateTwistIn(int cableid)
        {
            return ComObject.CreateTwistIn(cableid);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAnyCount()
        {
            return ComObject.GetAnyCount();
        }

        public int GetAnyIds(ref object ids)
        {
            return ComObject.GetAnyIds(ids);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetBundleCount()
        {
            return ComObject.GetBundleCount();
        }

        public int GetBundleIds(ref object ids)
        {
            return ComObject.GetBundleIds(ids);
        }

        public int GetCableCount()
        {
            return ComObject.GetCableCount();
        }

        public int GetCableIds(ref object ids)
        {
            return ComObject.GetCableIds(ids);
        }

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ids);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public string GetGUID()
        {
            return ComObject.GetGUID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetOverbraidId()
        {
            return ComObject.GetOverbraidId();
        }

        public int GetOverbraidIdEx()
        {
            return ComObject.GetOverbraidIdEx();
        }

        public int GetParentBundleId()
        {
            return ComObject.GetParentBundleId();
        }

        public int GetPeerIds(ref object ids)
        {
            return ComObject.GetPeerIds(ids);
        }

        public int GetShieldCount()
        {
            return ComObject.GetShieldCount();
        }

        public int GetShieldIds(ref object ids)
        {
            return ComObject.GetShieldIds(ids);
        }

        public int GetTwistCount()
        {
            return ComObject.GetTwistCount();
        }

        public int GetTwistIds(ref object ids)
        {
            return ComObject.GetTwistIds(ids);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int HasParentBundle()
        {
            return ComObject.HasParentBundle();
        }

        public int InsertAfter(int elemid)
        {
            return ComObject.InsertAfter(elemid);
        }

        public int InsertBefore(int elemid)
        {
            return ComObject.InsertBefore(elemid);
        }

        public int InsertBundleAfter(int elemid, int position)
        {
            return ComObject.InsertBundleAfter(elemid, position);
        }

        public int InsertBundleBefore(int elemid, int position)
        {
            return ComObject.InsertBundleBefore(elemid, position);
        }

        public int IsOverbraid()
        {
            return ComObject.IsOverbraid();
        }

        public int IsShield()
        {
            return ComObject.IsInShield();
        }

        public int IsTwist()
        {
            return ComObject.IsTwist();
        }

        public int RemoveFromBundle()
        {
            return ComObject.RemoveFromBundle();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetName(string newname)
        {
            return ComObject.SetName(newname);
        }

    }
}