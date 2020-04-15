using System.Linq;

namespace PetrVala.VatPayerReliabilityChecker.ServiceLibrary.Connected_Services.VatPayerReliabilityServiceReference
{
    public partial class StatusType
    {
        public override string ToString()
        {
            return
                $"{nameof(odpovedGenerovanaField)}: {odpovedGenerovanaField}, {nameof(statusCodeField)}: {statusCodeField}, {nameof(statusTextField)}: {statusTextField}, {nameof(bezVypisuUctuField)}: {bezVypisuUctuField}, {nameof(bezVypisuUctuFieldSpecified)}: {bezVypisuUctuFieldSpecified}, {nameof(odpovedGenerovana)}: {odpovedGenerovana}, {nameof(statusCode)}: {statusCode}, {nameof(statusText)}: {statusText}, {nameof(bezVypisuUctu)}: {bezVypisuUctu}, {nameof(bezVypisuUctuSpecified)}: {bezVypisuUctuSpecified}";
        }
    }

    public partial class Adresa
    {
        public override string ToString()
        {
            return
                $"{nameof(uliceCisloField)}: {uliceCisloField}, {nameof(castObceField)}: {castObceField}, {nameof(mestoField)}: {mestoField}, {nameof(pscField)}: {pscField}, {nameof(statField)}: {statField}, {nameof(uliceCislo)}: {uliceCislo}, {nameof(castObce)}: {castObce}, {nameof(mesto)}: {mesto}, {nameof(psc)}: {psc}, {nameof(stat)}: {stat}";
        }
    }

    public partial class NestandardniUcetType
    {
        public override string ToString()
        {
            return $"{nameof(cisloField)}: {cisloField}, {nameof(cislo)}: {cislo}";
        }
    }

    public partial class StandardniUcetType
    {
        public override string ToString()
        {
            return
                $"{nameof(predcisliField)}: {predcisliField}, {nameof(cisloField)}: {cisloField}, {nameof(kodBankyField)}: {kodBankyField}, {nameof(predcisli)}: {predcisli}, {nameof(cislo)}: {cislo}, {nameof(kodBanky)}: {kodBanky}";
        }
    }

    public partial class ZverejnenyUcetType
    {
        public override string ToString()
        {
            return
                $"{nameof(itemField)}: {itemField}, {nameof(datumZverejneniField)}: {datumZverejneniField}, {nameof(Item)}: {Item}, {nameof(datumZverejneni)}: {datumZverejneni}";
        }
    }

    public partial class InformaceOPlatciType
    {
        public override string ToString()
        {
            return
                $"{nameof(zverejneneUctyField)}: {zverejneneUctyField.Aggregate(string.Empty, (s, type) => s + type + ";")}, {nameof(dicField)}: {dicField}, {nameof(nespolehlivyPlatceField)}: {nespolehlivyPlatceField}, {nameof(datumZverejneniNespolehlivostiField)}: {datumZverejneniNespolehlivostiField}, {nameof(datumZverejneniNespolehlivostiFieldSpecified)}: {datumZverejneniNespolehlivostiFieldSpecified}, {nameof(cisloFuField)}: {cisloFuField}, {nameof(zverejneneUcty)}: {zverejneneUcty.Aggregate(string.Empty, (s, type) => s + type + ";")}, {nameof(dic)}: {dic}, {nameof(nespolehlivyPlatce)}: {nespolehlivyPlatce}, {nameof(datumZverejneniNespolehlivosti)}: {datumZverejneniNespolehlivosti}, {nameof(datumZverejneniNespolehlivostiSpecified)}: {datumZverejneniNespolehlivostiSpecified}, {nameof(cisloFu)}: {cisloFu}";
        }
    }

    public partial class InformaceOPlatciRozsireneType
    {
        public override string ToString()
        {
            return
                $"{base.ToString()}, {nameof(nazevSubjektuField)}: {nazevSubjektuField}, {nameof(adresaField)}: {adresaField}, {nameof(nazevSubjektu)}: {nazevSubjektu}, {nameof(adresa)}: {adresa}";
        }
    }

    public partial class getStatusNespolehlivyPlatceRequest
    {
        public override string ToString()
        {
            return $"{nameof(dic)}: {dic}";
        }
    }

    public partial class getStatusNespolehlivyPlatceResponse
    {
        public override string ToString()
        {
            return $"{nameof(status)}: {status}, {nameof(statusPlatceDPH)}: {statusPlatceDPH.Aggregate(string.Empty, (s, type) => s + type + ";")}";
        }
    }

    public partial class getSeznamNespolehlivyPlatceResponse
    {
        public override string ToString()
        {
            return $"{nameof(status)}: {status}, {nameof(statusPlatceDPH)}: {statusPlatceDPH.Aggregate(string.Empty, (s, type) => s + type + ";")}";
        }
    }

    public partial class getStatusNespolehlivyPlatceRequest1
    {
        public override string ToString()
        {
            return $"{nameof(dic)}: {dic.Aggregate(string.Empty, (s, s1) => s + s1 + ";")}";
        }
    }

    public partial class getStatusNespolehlivyPlatceRozsirenyResponse
    {
        public override string ToString()
        {
            return $"{nameof(status)}: {status}, {nameof(statusPlatceDPH)}: {statusPlatceDPH.Aggregate(string.Empty, (s, type) => s + type + ";")}";
        }
    }
}