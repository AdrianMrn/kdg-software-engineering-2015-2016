using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {
        int _aantalOgen;
        Boolean _enabled = true;
        public int AantalOgen {get{return _aantalOgen;}set{_aantalOgen = value;}}

        public Boolean Enabled {get{return _enabled;}set{_enabled = value;}}
    }
}
