using E3Series.Proxy.Abstract;
using E3Series.Proxy.Interfaces;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
	public sealed class E3ConnectionProxy : E3ProxyBase, IAttributed
    {

        public E3ConnectionProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Create(int shti, int pnts, ref object x, ref object y, ref object PointTypArr)
        {
            return ComObject.Create(shti, pnts, ref x, ref y, ref PointTypArr);
        }

        public int CreateBus(int shti, int pnts, ref object x, ref object y)
        {
            return ComObject.CreateBus(shti, pnts, ref x, ref y);
        }

        public int CreateConnection(int flags, int shti, int pnts, ref object x, ref object y, ref object connections, ref object PointTypArr)
        {
            return ComObject.CreateConnection(flags, shti, pnts, ref x, ref y, ref connections, ref PointTypArr);
        }

        public int CreateConnectionBetweenPoints(int shti, double x1, double y1, double x2, double y2, int flags = default(int))
        {
            return ComObject.CreateConnectionBetweenPoints(shti, x1, y1, x2, y2, flags);
        }

        public object CreateOnFormboard(int shti, int pnts, ref object x, ref object y, ref object PointTypArr)
        {
            return ComObject.CreateOnFormboard(shti, pnts, ref x, ref y, ref PointTypArr);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DisplayAttributeValue(string name)
        {
            return ComObject.DisplayAttributeValue(name);
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

        public int GetCoreCount()
        {
            return ComObject.GetCoreCount();
        }

        public int GetCoreIds(ref object ids)
        {
            return ComObject.GetCoreIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNetId()
        {
            return ComObject.GetNetId();
        }

        public int GetNetSegmentCount()
        {
            return ComObject.GetNetSegmentCount();
        }

        public int GetNetSegmentIds(ref object ids)
        {
            return ComObject.GetNetSegmentIds(ref ids);
        }

        public int GetPinCount()
        {
            return ComObject.GetPinCount();
        }

        public int GetPinGroupCount(int num)
        {
            return ComObject.GetPinGroupCount(num);
        }

        public int GetPinGroupIds(int num, ref object ids)
        {
            return ComObject.GetPinGroupIds(num, ref ids);
        }

        public int GetPinGroupsCount()
        {
            return ComObject.GetPinGroupsCount();
        }

        public int GetPinGroupsIds(ref object ids)
        {
            return ComObject.GetPinGroupsIds(ref ids);
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetReferenceSymbolCount()
        {
            return ComObject.GetReferenceSymbolCount();
        }

        public int GetReferenceSymbolIds(ref object ids)
        {
            return ComObject.GetReferenceSymbolIds(ref ids);
        }

        public string GetSignalName()
        {
            return ComObject.GetSignalName();
        }

        public string GetTranslatedSignalName()
        {
            return ComObject.GetTranslatedSignalName();
        }

        public int GetViewNumber()
        {
            return ComObject.GetViewNumber();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Highlight()
        {
            return ComObject.Highlight();
        }

        public int IsValid()
        {
            return ComObject.IsValid();
        }

        public int IsView()
        {
            return ComObject.IsView();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeVisibility(string name, int onoff)
        {
            return ComObject.SetAttributeVisibility(name, onoff);
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
    }
}