﻿using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageTests
{
    public class IataMessageProcessorTests
    {
        private TextMessageParser parser;
        
        private TextMessageFormatter formatter;

        public IataMessageProcessorTests()
        {
          this.parser = new TextMessageParser(new Fbl4MessageParser(new Ffm8MessageParser(new Fwb17MessageParser(new Fbr2MessageParser()))));
            this.formatter = new TextMessageFormatter();
        }

        [Fact]
        public void Fbr2ParserTests1()
        {
            string fbrText = @"FBR/2
FLT/KL775/09FEB/ZRH
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
";
            Result<object> rObject = this.parser.Parse(fbrText);
            Assert.NotNull(rObject);
            var fbr2 = ((Result<Fbr2>)rObject.Value).Value;

            string fblText = this.formatter.Visit(fbr2);

            Assert.Equal(fbrText, fblText);
        }
        [Fact]
        public void Fbl2ParserTests1()
        {
            string fbrText = @"FBL/4
1/KL775/09FEB/ZRH/HB-IHA
LIS/NIL
CCS
235-59889885SVOHKG/T12K25.9MC0.15/INTEGRATED CIRC
DIM/K0/CMT30-30-13/11
/K0/CMT44-26-17/1
/KVAZAR
555-51810426SVOIKA/T1K175MC0.12/RADIOACTIVE MAT
/470/GSP/471/RRY/PIL
/GSP DGP SU/E
SSR/SPECIALIZED DGR
/SSR3
OSI/ID 1437663181  HS 2844
/HALF-LIFE 8 DAYS  NO DELAY
555-20506555VVONBC/T10K194.4MC1.30/MASKI
ULD/2/PKC10056SU/K178.3/PKC12168SU/K89.1
555-27902932FRASVO/T1K3.8MC0.04/DATA LOADER  CI
/SVC
DIM/K0/CMT40-30-30/1
/LUFTHANSA TECHNIK/S
SSR/INVOICE ATTACHED TO AWB
/OWN
OSI/SPX KC DERA00777-05
OCI/DE/ISS/RA/00777-05
///ED/0521
///SN/BARBARA KLICH
///SD/06FEB210711
/DE/EXP/M/21DE330243450436E8
/DE/EXP/M/AT-ZLATE7100127002202133021
/DE/SHP/T/EUROPEAN VAT NUMBER DE811715450
/DE/SHP/CP/CUSTOMER SERVICE FRA
/DE/SHP/CT/496969647077
555-58195303ZAGMIA/T3K267.4MC2.88/CONSOLIDATION A
/460/CRT/EAP
DIM/K0/CMT120-80-100/3
/EURO-RUTA D.O.O./SU2041/12FEB/ZAG/X
ULD/2/PKC10056SU/K178.3/PKC12168SU/K89.1
SSR/3CLL MARKED AND ADDRESSED DOCUMENTS ATTACHED TO AWB TRANSPORT AN
/D STORAGE TEMPERATURE BETWEEN 15C AND 25C WHENEVER POSSIBLE EMERG
074-69123473ZRHCCS/T12K950DG9/BANKNOTES
/VAL
/ALFA AIR AGENCY/X
074-77184387ZRHMUN/P1K4DG4T12/SPARES
/EMERY
125-77184464ROMCCS/T123K12444MC94.4/CHEM LIQUID
/RFL
//SR917/07FEB/AMS/L
CUR
074-88241152ZRHCUR/T1K830MC1.2/MACHINERY
/HEA/MAG
OSI/CFM THAT SPECIAL TRUCK MUST BE USED TO
/MOVE THIS SHIPMENT
LIM
074-22221112ZRHLIM/T12K144DG4/MEDICINES
/PER
SSR/KEEP COOL STORE AT MINUS 2 DEGREES
/GENERAL
OCI///ST/DSV AIR SEA CO. LTD. CN1 HAS
/DE/EXP/M/20DE880426281976E0
/IT/SHP/T/EUROPEAN VAT NUMBERITIT00748210150
LAST
";
            Result<object> rObject = this.parser.Parse(fbrText);
            Assert.NotNull(rObject);
            var fbl4 = ((Result<Fbl4>)rObject.Value).Value;
            
            string fblText = this.formatter.Visit(fbl4);

            Assert.Equal(fbrText, fblText);
        }

        [Fact]
        public void Ffm8ParserTests1()
        {
            string ffm8OriginText = @"FFM/8
1/SU1145/01JAN0400/AAQ/VPBLN/RU/01JAN0555/SVO
SVO/24JUL1105/24JUL1300
074-12345632HAMAMS/T4K8MC0.16/VIDEO CASSETTES
/COL/RFL/PIL
DIM/K25.5/CMT69-68-70/1
/K15/CMT29-80-47/2
/YYZKL667/19MAR
/TAORU
/G
OSI/OSI EML-NEAPOLIT JINR.RU   TO  SII - SHEREMETYEVO CARGO J.S.C.
/HANDLE WITH CARE  DO NOT TILT MORE THAN 40 DEGREES
COR/X
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/AR/12345678
//DNR/DR/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/DR/UN8901 ID8000
///LR/DIPL
/IT/IMP/MH/07IT9876AB88901235
074-12345641HAMYYZ/T15K160MC0.27/WATCHES
/YYZKL667/19MAR
074-12345653HAMAMS/T3K41MC0.2/COMP TERMINALS
074-12345653HAMAMS/T1K1MC0.01/NEWSFILM
OCI/GB/ISS/RA/001-011
///ED/0213
/US/ISS/AR/12345678
//DNR/DR/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/DR/UN8901 ID8000
///LR/DIPL
/IT/IMP/MG/07IT9876AB88901235
ULD/P1G1234KL-M/HT270WT1658.0ENT
/LISIB785/19MAR
/2
074-12345664HAMLIS/T200K500MC0.53/DIAGNOST.TEST
074-12345653HAMLIS/T4K10MC0.06/PRESSURE GAUGES
OSI/OSI EML-NEAPOLIT JINR.RU   TO  SII - SHEREMETYEVO CARGO J.S.C.
/HANDLE WITH CARE  DO NOT TILT MORE THAN 40 DEGREES
074-12345686TYOLIS/T3K300MC1.36/RADIOS
COR/T1
ULD/AVM9243KL
074-12345690HAMAMS/T60K900MC2.25/MACHINE PARTS
RTM
074-35775331HAMRTM/T1K72MC0.6/PURSES
OSI/CTC CNE PRIOR TO ARRIVAL
/DUE TO URGENCE OF DISTRIBUTION
074-67534415HAMRTM/T10K50MC0.15/BOOKS
COR/C
ULD/AVM9876KL
074-53153155HAMRTM/T100K1200MC3/MAGAZINES
LAST
";
            Result<object> rObject = this.parser.Parse(ffm8OriginText);
            Assert.NotNull(rObject);
            var ffm8 = ((Result<Ffm8>)rObject.Value).Value;

            string ffm8ActualText = this.formatter.Visit(ffm8);

            Assert.Equal(ffm8OriginText, ffm8ActualText);
        }

        [Fact]
        public void Fwb17ParserTests()
        {
            string fwb17OriginText = @"FWB/17
555-64264793SVOREN/T114K2380DG6
FLT/SU1244/01/SU1008/01
RTG/SVORU/AMSRU/LGG
SHP
NAM/T. ULSIDAS LTD.
ADR/105 VEER TAMAN ROAD
LOC/MUMBAI
/IN
CNE/4321
NAM/AMERICAN MOTORS
ADR/29 BAY JAMES ST
LOC/BLOOMINGTON/MN
/US/52601/TE/4653425
AGT/083 0041 0101/0830041/0101
/SCHENKER DEUTSCHLAND AG
/DUESSELDORF
SSR/SHIPPERS CERTIFICATION FOR LIVE ANIMALS ATTACHED
/DO NOT FEED BUT FRESH WATER TO BE PROVIDED
NFY
NAM/EXPOWESTRANS KRASNOPRESNENSKAYA
/NABEREZHNAYA 14 CODE 10129010
ADR/10129-241110-10025-2 MOSCOW
/CUSTOMS-CUSTOMS POST-VISTAVOCHNIJ-
LOC/MOSCOW/RUSSIA
/RU/127015/TE/74956626979
ACC/GEN/DSV AIR   SEA CO.  LTD
/GEN/8-9F  15F RAFFLES CITY CHANGNING
/GEN/OFFICE TOWER 3  NO.1193 CHANGNING
/GEN/SHANGHAI
/GEN/200051
/GEN/CHINA
CVD/USD//PP/NVD/5696.00/6346.00
RTD/1/P1/K2400/CU/W2000/R10000/T10000
/NG/ABRASIVE PASTE
/2/K120.01/CX/S3
/NU/P1C0037XX
/3/CE/W400/R3.25/T1300
/4/PNYC/CU/W1410/R5000/T5000
/5/CE/W990/R2.90/T2871
/6/W142
/7/NC/UN3528.RFL.PI 378
/8/NC/1 ENGINE X 950 KG
/9/NC/OVERPACK USED
/10/ND//CMT606-244-273/1
/11/NV/MC0.10
/12/NS/1
OTH/P/MYC1600.50SCC2667.50AWC13.00
/P/SCC70.00
/P/AWC13.00
/P/CGC10.00
/P/RAC360.00
/P/TEC47.04
PPD/VC45.7
/CT800.00
COL/WT10000
/OA20/CT10020
CER/JOHAN-HALFMANN.LTD
ISU/01OCT06/RIO INTERNACIONAL/SPEEDAIR SERVICES
OSI/SHIPPER SRITIFICATION FOR LIVE ANNVDIMAL NEEDED
/NO FOOD BUT FRESH WATER REQUIRED
CDC/RUB60/1047460.2/0/1047460.2
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
COR/T1
COI///14.40
SII/13076800/XX
ARD/DLA-AFEX21.0019
SPH/OHG/MOW/DGR/ENG/PAX/RFL/AOG/DDX
NOM/F.H. BERTLING AB - TRUST/GOTEBORG
SRI/KKL.44/UUSSDF/QNZ01JUN0800
OPI/AO ALFA LAVAL POTOK
///B/C1001/MOS
OPI/AO ALFA LAVAL POTOK
///D/C1001/MOS
OPI/IWS
//101211020/TRK/IWS/AMS
OPI/MENZIES
//580-24650463/GHA/CTMENZIES/AMS
OPI/MENZIES2
/BHXFRBA/NO.4321098
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/A/12345678
//DNR/D/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/D/UN8901 ID8000
///L/DIPL
/IT/IMP/M/07IT9876AB88901235
";
            Result<object> rObject = this.parser.Parse(fwb17OriginText);
            Assert.NotNull(rObject);
            var fwb17 = ((Result<Fwb17>)rObject.Value).Value;

            string fwb17ActualText = this.formatter.Visit(fwb17);

            Assert.Equal(fwb17OriginText, fwb17ActualText);
        }
    }
}
