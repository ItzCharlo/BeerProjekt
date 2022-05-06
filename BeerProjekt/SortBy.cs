using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProjekt
{
    public enum SortBy
    {
        UNIT, PROCENT, VOLUME
    }

    public class SortingbeerBy : IComparer
    {
        public int Compare(object x, object y)
        {
            Beer objxbeer = x as Beer;
            Beer objybeer = y as Beer;
            if(_SortBy == SortBy.UNIT)
            {
                double Forskellig = objxbeer.GetUnits() - objybeer.GetUnits();
                if(Forskellig > 0)
                    return 1;
                else if (Forskellig == 0)
                    return 0;
                else
                    return -1;
            }
            else if(_SortBy == SortBy.PROCENT)
            {
                double ProcentFor = objxbeer.GetUnits() - objybeer.GetUnits();
                if (ProcentFor > 1)
                    return 1;
                else if (ProcentFor == 0)
                    return 0;
                else 
                    return - 1;
            }
            else
            {
                return (objxbeer.volume - objybeer.volume);
            }
        }

        private SortBy _SortBy;
        public SortingbeerBy(SortBy type)
        {
            _SortBy = type;
        }
    }
}
