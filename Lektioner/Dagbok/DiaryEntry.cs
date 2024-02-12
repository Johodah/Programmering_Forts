using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbok
{
    public class DiaryEntry
    {
        public DateTime datum;

        public string rubrik;

        public string innehåll;
    }

    public DiaryEntry(DateTime datum1, string rubrik, string innehåll)
    {
        Datum1 = datum1;
        this.Rubrik = rubrik;
        this.Innehåll = innehåll;
    }

    //public DateTime Datum
    //{
    //    get { return datum; }
    //    set { datum = value; }
    //}
    public string Rubrik
    {
        get { return rubrik; }
        set { rubrik = value; }
    }
    public string Innehåll
    {
        get { return innehåll; }
        set { innehåll = value; }
    }

    public DateTime Datum1
    {
        get;
    }

}
