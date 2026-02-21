namespace Skaar.VehicleData.Model.Geographic;

static class Helper
{
    public static Area GetArea(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 1)
        {
            return default;
        }
        return vin[0] switch
        {
            'A' or 'B' or 'C' => Area.Africa,
            'J' or 'K' or 'L' or 'M' or 'N' or 'P' or 'R' => Area.Asia,
            'S' or 'T' or 'U' or 'V' or 'W' or 'X' or 'Y' or 'Z' => Area.Europe,
            '1' or '2' or '3' or '4' or '5' or '7' => Area.NorthAmerica,
            '6' => Area.Oceania,
            '8' or '9' => Area.SouthAmerica,
            _ => Area.Undefined
        };
    }
    
    public static Country GetCountry(ReadOnlySpan<char> vin)
    {
        if (vin.Length < 2)
        {
            return Country.Undefined;
        }

        return (vin[0], vin[1]) switch
        {
            // Africa
            ('A', >= 'A' and <= 'H') => Country.SouthAfrica,
            ('A', >= 'J' and <= 'K') => Country.IvoryCoast,
            ('A', >= 'L' and <= 'M') => Country.Lesotho,
            ('A', >= 'N' and <= 'P') => Country.Botswana,
            ('A', >= 'R' and <= 'S') => Country.Namibia,
            ('A', >= 'T' and <= 'U') => Country.Madagascar,
            ('A', >= 'V' and <= 'W') => Country.Mauritius,
            ('A', >= 'X' and <= 'Y') => Country.Tunisia,
            ('A', 'Z' or '1') => Country.Cyprus,
            ('A', >= '2' and <= '3') => Country.Zimbabwe,
            ('A', >= '4' and <= '5') => Country.Mozambique,
            
            ('B', >= 'A' and <= 'B') => Country.Angola,
            ('B', 'C') => Country.Ethiopia,
            ('B', >= 'F' and <= 'G') => Country.Kenya,
            ('B', 'H') => Country.Rwanda,
            ('B', 'L') => Country.Nigeria,
            ('B', 'R') => Country.Algeria,
            ('B', 'T') => Country.Swaziland,
            ('B', 'U') => Country.Uganda,
            ('B', >= '3' and <= '4') => Country.Libya,
            
            ('C', >= 'A' and <= 'B') => Country.Egypt,
            ('C', >= 'F' and <= 'G') => Country.Morocco,
            ('C', >= 'L' and <= 'M') => Country.Zambia,
            
            // Spare codes
            ('E', _) => Country.Russia,
            ('H', _) => Country.China,
            
            //Asia
            ('J', _) => Country.Japan,
            ('K', >= 'F' and <= 'H') => Country.Israel,
            ('K', >= 'L' and <= 'R') => Country.SouthKorea,
            ('K', >= 'S' and <= 'T') => Country.Jordan,
            ('K', >= '1' and <= '3') => Country.SouthKorea,
            ('K', >= '5' and <= '5') => Country.Kyrgyzstan,
            
            ('L', _) => Country.China,
            
            ('M', >= 'A' and <= 'E') => Country.India,
            ('M', >= 'F' and <= 'K') => Country.Indonesia,
            ('M', >= 'L' and <= 'R') => Country.Thailand,
            ('M', 'S') => Country.Myanmar,
            ('M', 'U') => Country.Mongolia,
            ('M', 'X') => Country.Kazakhstan,
            ('M', >= 'Y' and <= 'Z' or >= '0' and <= '9') => Country.India,
            
            ('N', >= 'A' and <= 'E') => Country.Iran,
            ('N', >= 'F' and <= 'G') => Country.Pakistan,
            ('N', 'J') => Country.Iraq,
            ('N', >= 'L' and <= 'R') => Country.Turkey,
            ('N', >= 'S' and <= 'T') => Country.Uzbekistan,
            ('N', 'V') => Country.Azerbaijan,
            ('N', 'X') => Country.Tajikistan,
            ('N', 'Y') => Country.Armenia,
            ('N', >= '1' and <= '5') => Country.Iran,
            ('N', >= '7' and <= '8') => Country.Turkey,
            
            ('P', >= 'A' and <= 'C') => Country.Philippines,
            ('P', >= 'F' and <= 'G') => Country.Singapore,
            ('P', >= 'L' and <= 'R') => Country.Malaysia,
            ('P', >= 'S' and <= 'T') => Country.Bangladesh,
            ('P', >= '5' and <= '9' or '0') => Country.India,
            
            ('R', >= 'A' and <= 'B') => Country.UnitedArabEmirates,
            ('R', >= 'F' and <= 'K') => Country.Taiwan,
            ('R', >= 'L' and <= 'N') => Country.Vietnam,
            ('R', 'P') => Country.Laos,
            ('R', >= 'S' and <= 'T') => Country.SaudiArabia,
            ('R', >= 'U' and <= 'W') => Country.Russia,
            ('R', >= '1' and <= '7') => Country.HongKong,
            
            //Europe
            ('S', >= 'A' and <= 'M') => Country.UnitedKingdom,
            ('S', >= 'N' and <= 'T') => Country.Germany,
            ('S', >= 'U' and <= 'Z') => Country.Poland,
            ('S', >= '1' and <= '2') => Country.Latvia,
            ('S', '3') => Country.Georgia,
            ('S', '4') => Country.Iceland,
            
            ('T', >= 'A' and <= 'H') => Country.Switzerland,
            ('T', >= 'J' and <= 'P') => Country.CzechRepublic,
            ('T', >= 'R' and <= 'V') => Country.Hungary,
            ('T', >= 'W' and <= 'Z' or '1' or '2') => Country.Portugal,
            ('T', >= '3' and <= '5') => Country.Serbia,
            ('T', '6') => Country.Andorra,
            ('T', >= '7' and <= '8') => Country.Netherlands,
            
            ('U', >= 'A' and <= 'C') => Country.Spain,
            ('U', >= 'H' and <= 'M') => Country.Denmark,
            ('U', >= 'N' and <= 'R') => Country.Ireland,
            ('U', >= 'U' and <= 'X') => Country.Romania,
            ('U', >= '1' and <= '2') => Country.Macedonia,
            ('U', >= '5' and <= '7') => Country.Slovakia,
            ('U', >= '8' and <= '9' or '0') => Country.BosniaHerzegovina,
            
            ('V', >= 'A' and <= 'E') => Country.Austria,
            ('V', >= 'F' and <= 'R') => Country.France,
            ('V', >= 'S' and <= 'W') => Country.Spain,
            ('V', >= 'X' and <= 'Z') => Country.France,
            ('V', >= '1' and <= '2') => Country.France,
            ('V', >= '3' and <= '5') => Country.Croatia,
            ('V', >= '6' and <= '8') => Country.Estonia,
            
            ('W', _) => Country.Germany,
            
            ('X', >= 'A' and <= 'C') => Country.Bulgaria,
            ('X', >= 'D' and <= 'E') => Country.Russia,
            ('X', >= 'F' and <= 'H') => Country.Greece,
            ('X', >= 'J' and <= 'K') => Country.Russia,
            ('X', >= 'L' and <= 'R') => Country.Netherlands,
            ('X', >= 'S' and <= 'W') => Country.Russia,
            ('X', >= 'X' and <= 'Y') => Country.Luxembourg,
            ('X', 'Z' or >= '0') => Country.Russia,
            
            ('Y', >= 'A' and <= 'E') => Country.Belgium,
            ('Y', >= 'F' and <= 'K') => Country.Finland,
            ('Y', 'N') => Country.Malta,
            ('Y', >= 'S' and <= 'W') => Country.Sweden,
            ('Y', >= 'X' and <= 'Z') => Country.Norway,
            ('Y', >= '1' and <= '2') => Country.Norway,
            ('Y', >= '3' and <= '5') => Country.Belarus,
            ('Y', >= '6' and <= '8') => Country.Ukraine,
            
            ('Z', >= 'A' and <= 'U') => Country.Italy,
            ('Z', >= 'X' and <= 'Z') => Country.Slovenia,
            ('Z', '1') => Country.SanMarino,
            ('Z', >= '3' and <= '5') => Country.Lithuania,
            ('Z', >= '6' and <= '9' or '0') => Country.Russia,
            
            //North America
            ('1', _) => Country.UnitedStates,
            
            ('2', >= 'A' and <= 'Z') => Country.Canada,
            ('2', >= '1' and <= '5') => Country.Canada,
            
            ('3', >= 'A' and <= 'X') => Country.Mexico,
            ('3', '4') => Country.Nicaragua,
            ('3', '5') => Country.DominicanRepublic,
            ('3', '6') => Country.Honduras,
            ('3', '7') => Country.Panama,
            ('3', >= '8' and <= '9') => Country.PuertoRico,
            
            ('4', _) => Country.UnitedStates,
            
            ('5', _) => Country.UnitedStates,
            
            ('7', _) => Country.UnitedStates,
            
            //Oceania
            ('6', >= 'A' and <= 'X') => Country.Australia,
            ('6', >= 'Y' and <= 'Z' or '1') => Country.NewZealand,
            
            //South America
            ('8', >= 'A' and <= 'E') => Country.Argentina,
            ('8', >= 'F' and <= 'G') => Country.Chile,
            ('8', >= 'L' and <= 'N') => Country.Equador,
            ('8', >= 'S' and <= 'T') => Country.Peru,
            ('8', >= 'X' and <= 'Z') => Country.Venezuela,
            ('8', '2') => Country.Bolivia,
            ('8', '4') => Country.CostaRica,
            
            ('9', >= 'A' and <= 'E') => Country.Brazil,
            ('9', >= 'F' and <= 'G') => Country.Colombia,
            ('9', >= 'S' and <= 'V') => Country.Uruguay,
            ('9', >= '0' and <= '9') => Country.Brazil,
            
            // Default
            _ => Country.Undefined
        };
    }
}