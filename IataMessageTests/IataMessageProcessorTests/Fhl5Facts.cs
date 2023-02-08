using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class Fhl5Facts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public Fhl5Facts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void ParserAndFormat()
        {
            string fhl5Text = @"FHL/5
MBI/618-12345675SINJFK/T7K1000
HBS/AEI12345678/SINJFK/1/K400/4/COMPUTER PARTS
TXT/MODEL 3 MEMORY BOARDS AND OTHER ASSORTED PARTS
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/A/12345678
//DNR/D/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/D/UN8901 ID8000
///L/DIPL
/IT/IMP/M/07IT9876AB88901235
HBS/22AA12121212/FRAJFK/200/K1800//BOLTS
HBS/00000002/SVOPVG/176/K10783.00//SPUNBOND NONWOVEN MATERIALS
TXT/CNENAME2-TRADING DEVELOPMENT CO. LTDSHPNAME2-PLANT JOINT STOCK C
/SPARE PARTS
/MEASURING EQUIPMENT  ACCESSORIESS2006-172VOL 0.002 M3DIMS 1  46 X
HBS/51791876/SVOSTR/1/K9.25//ISIS C2 INTRAOPERATIVE NERVE
HBS/U182306/SVOFCO/1/K85/1/HUMAN BLOOD
/NSC/ICE
TXT/HUMAN BLOOD UN3373  CAT.B DRY ICE UN1845 1 20 KG DIMS 79X53X58 CM
/ X 1 HS CODE  3002120005       1 SLAC
HTS/3002120005
OCI/RU/SHP/CT/74956443414
/IT/NFY/CT/3906650431
/RU/DNR/D/1845B
SHP
NAM/AMERICAN MOTORS
ADR/29 BAY JAMES ST
LOC/BLOOMINGTON/MN
/US/52601/TE/4653425
CNE
NAM/AIE EXPRESS INTL
ADR/CENTRAL STREET 13
LOC/JAMAICA/NY
/US/22330/TE/171812344566
CVD/USD/PP/NVD/5696.00/6346.00
";
            Result<object> rObject = parser.Parse(fhl5Text);
            Assert.NotNull(rObject);
            var fhl5 = rObject.ToResult(o => (Fhl5)o);

            var fhl5TextActual = formatter.ToString(fhl5.Value);

            Assert.Equal(fhl5Text, fhl5TextActual);
        }
    }
}
