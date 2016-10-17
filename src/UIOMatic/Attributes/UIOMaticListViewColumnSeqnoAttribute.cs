using System;

namespace UIOMatic.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class UIOMaticListViewColumnSeqnoAttribute : Attribute
    {
        public int Seqno { get; set; }

        public UIOMaticListViewColumnSeqnoAttribute()
        {
        }

        public UIOMaticListViewColumnSeqnoAttribute(int seqno)
        {
            Seqno = seqno;
        }
    }
}