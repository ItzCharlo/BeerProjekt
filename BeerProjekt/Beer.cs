using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProjekt
{
    internal class Beer : Program
    {
        private string _Brewery;
        private string _BeerName;
        private BeerType _Type;
        private int _Volume;
        private double _Procent;


        public string bravery 
        {
            get { return _Brewery; }
            set { _Brewery = value; }
        }

        public string beername
        {
            get { return _BeerName; }
            set { _BeerName = value; }
        }

        public BeerType type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public int volume
        {
            get { return _Volume; }
            set { _Volume = value; }
        }

        public double procent
        {
            get { return _Procent; }
            set { _Procent = value; }
        }

        public Beer() { }

        public Beer(string brewery, string beername, BeerType type, int volume, double procent)
        {
            _Brewery = brewery;
            _BeerName = beername;
            _Type = type;
            _Volume = volume;
            _Procent = procent;
        }
       public double GetUnits()
        {
            return (this._Volume * procent / 150);
        }

        public override string ToString()
        {
            return string.Format("Bryggeri:{0,6}\n Name:{1,6}\n Type:{2,6}\n Volume:{3,6}\n Procent:{4,6}\n Genstande:{5,6}\n", _Brewery, _BeerName, _Type, _Volume, _Procent, GetUnits());
        }

        public void add(Beer beer2)
        {
            _Procent = (_Volume * _Procent + beer2._Volume * beer2._Procent) / (_Volume + beer2.volume);
            _Brewery = _Brewery + " + " + beer2._Brewery;
            _BeerName = _BeerName + " + " + beer2._BeerName;
            _Volume = _Volume + beer2._Volume;
            _Type = BeerType.Mix;
        }

        public Beer mix(Beer beer2)
        {
            Beer Nybeer = new Beer();
            Nybeer._Procent = (_Volume * _Procent + beer2._Volume * beer2._Procent) / (_Volume + beer2.volume);
            Nybeer._Brewery = _Brewery + " + " + beer2._Brewery;
            Nybeer._BeerName = _BeerName + " + " + beer2._BeerName;
            Nybeer._Volume = _Volume + beer2._Volume;
            Nybeer._Type = BeerType.Mix;
            return Nybeer;

        }

        public static Beer Mix(Beer beer1, Beer beer2)
        {
            Beer NyAllBeer = new Beer();
            NyAllBeer._Procent = (beer1._Volume * beer1._Procent + beer2._Volume * beer2._Procent) / (beer1._Volume + beer2._Volume);
            NyAllBeer._Brewery = beer1._Brewery + " + " + beer2._Brewery;
            NyAllBeer._BeerName = beer1._BeerName + " + " + beer2._BeerName;
            NyAllBeer._Volume = beer1._Volume + beer2._Volume;
            NyAllBeer._Type = BeerType.Mix;
            return NyAllBeer;
        }

        public int CompareTo(Object obj)
        {
            Beer objbeer = obj as Beer;
            double forskellig = GetUnits() - objbeer.GetUnits();
            if (forskellig < 0)
            {
                return 1;
            }
            else if (forskellig == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
