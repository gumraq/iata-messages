namespace IataMessageStandard.Fhl5Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        [Reference(1)]
        public string StandardMessageIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get; set;  }
    }

    [SeparatorCrlf]
    public class MasterAwbConsignmentDetail
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public MasterAwbIdentification MasterAwbIdentification { get; set; }

        [Reference(3)]
        public AwbOriginAndDestination AwbOriginAndDestination { get; set; }

        [Reference(4)]
        public QuantityDetail QuantityDetail { get; set; }
    }

    public class HouseWaybills
    {
        [Reference(1)]
        public List<HouseWaybillSummaryDetails> HouseWaybillSummaryDetails { get; set; }

        [Reference(2)]
        public FreeTextDescriptionOfGoods FreeTextDescriptionOfGoods { get; set; }

        [Reference(3)]
        public HarmonisedTariffScheduleInformation HarmonisedTariffScheduleInformation { get; set; }

        [Reference(4)]
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }

    [SeparatorCrlf]
    public class ShipperNameAndAddress
    {
        [Reference(1)]
        public string ShpLineIdentifier { get {return "SHP'SeparatorCrlf";} }

        [Reference(2)]
        public Name Name { get; set; }

        [Reference(3)]
        public StreetAddress StreetAddress { get; set; }

        [Reference(4)]
        public Location Location { get; set; }

        [Reference(5)]
        public CodedLocation CodedLocation { get; set; }

        [Reference(6)]
        public List<ContactDetail> ContactDetail { get; set; }
    }

    [SeparatorCrlf]
    public class ConsigneeNameAndAddress
    {
        [Reference(1)]
        public string CneLineIdentifier { get {return "CNE'SeparatorCrlf";} }

        [Reference(2)]
        public Name Name { get; set; }

        [Reference(3)]
        public StreetAddress StreetAddress { get; set; }

        [Reference(4)]
        public Location Location { get; set; }

        [Reference(5)]
        public CodedLocation CodedLocation { get; set; }

        [Reference(6)]
        public List<ContactDetail> ContactDetail { get; set; }
    }

    [SeparatorCrlf]
    public class ChargeDeclarations
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string IsoCurrencyCode { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public PrepaidCollectChargeDeclarations PrepaidCollectChargeDeclarations { get; set; }

        [Reference(4)]
        [SeparatorSlant]
        public ValueForCarriageDeclaration ValueForCarriageDeclaration { get; set; }

        [Reference(5)]
        [SeparatorSlant]
        public ValueForCustomsDeclaration ValueForCustomsDeclaration { get; set; }

        [Reference(6)]
        [SeparatorSlant]
        public ValueForInsuranceDeclaration ValueForInsuranceDeclaration { get; set; }
    }

    [SeparatorCrlf]
    public class HouseWaybillSummaryDetails
    {
        [Reference(1)]
        public string HbsLineIdentifier { get {return "HBS/";} }

        [Reference(2)]
        public string HwbSerialNumber { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public HouseWaybillOriginAndDestination HouseWaybillOriginAndDestination { get; set; }

        [Reference(4)]
        [SeparatorSlant]
        public HouseWaybillTotals HouseWaybillTotals { get; set; }

        [Reference(5)]
        public NatureOfGoods NatureOfGoods { get; set; }

        [Reference(6)]
        public Shrs Shrs { get; set; }
    }

    public class FreeTextDescriptionOfGoods
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<FreeTextDescriptions> FreeTextDescriptions { get; set; }
    }

    public class HarmonisedTariffScheduleInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<HarmonisedTariffs> HarmonisedTariffs { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    public class MasterAwbIdentification
    {
        [Reference(1)]
        public string AirlinePrefix { get; set;  }

        [Reference(2)]
        [SeparatorHyphen]
        public string AwbSerialNumber { get; set;  }
    }

    public class AwbOriginAndDestination
    {
        [Reference(1)]
        public string AirportCodeOfOrigin { get; set;  }

        [Reference(2)]
        public string AirportCodeOfDestitation { get; set;  }
    }

    public class HouseWaybillOriginAndDestination
    {
        [Reference(1)]
        public string AirportCodeOfOrigin { get; set;  }

        [Reference(2)]
        public string AirportCodeOfDestitation { get; set;  }
    }

    public class HouseWaybillTotals
    {
        [Reference(1)]
        public string NumberOfPieces { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string WeightCode { get; set;  }

        [Reference(3)]
        public string Weight { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string Slac { get; set;  }
    }

    [SeparatorCrlf]
    public class FreeTextDescriptions
    {
        [SeparatorSlant]
        public string FreeText { get; set;  }
    }

    [SeparatorCrlf]
    public class HarmonisedTariffs
    {
        [SeparatorSlant]
        public string HarmonisedCommodityCode { get; set;  }
    }

    public class QuantityDetail
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }

        [Reference(3)]
        public string WeightCode { get; set;  }

        [Reference(4)]
        public string Weight { get; set;  }
    }

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get; set;  }
    }

    public class Shrs
    {
        [SeparatorCrlf]
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    public class Name
    {
        [Reference(1)]
        public string NamIdentifier { get {return "NAM";} }

        [Reference(2)]
        public List<NameDetail> NameDetail { get; set; }
    }

    [SeparatorCrlf]
    public class NameDetail
    {
        [SeparatorSlant]
        public string NameInner { get; set;  }
    }

    [SeparatorCrlf]
    public class Location
    {
        [Reference(1)]
        public string LocIdentifier { get {return "LOC";} }

        [Reference(2)]
        [SeparatorSlant]
        public string PlaceInner { get; set;  }

        [Reference(3)]
        public StateProvince StateProvince { get; set; }
    }

    public class StateProvince
    {
        [SeparatorSlant]
        public string StateProvinceInner { get; set;  }
    }

    public class CodedLocation
    {
        [Reference(1)]
        [SeparatorSlant]
        public string IsoCountryCode { get; set;  }

        [Reference(2)]
        public PostCode PostCode { get; set; }
    }

    public class PostCode
    {
        [SeparatorSlant]
        public string PostCodeInner { get; set;  }
    }

    public class ContactDetail
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ContactIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string ContactNumber { get; set;  }
    }

    public class StreetAddress
    {
        [Reference(1)]
        public string AdrIdentifier { get {return "ADR";} }

        [Reference(2)]
        public List<StreetAddressDetail> StreetAddressDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StreetAddressDetail
    {
        [SeparatorSlant]
        public string StreetAddressInner { get; set;  }
    }

    public class ValueForCarriageDeclaration
    {
        [Reference(1)]
        public string DeclaredValueForCarriage { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    public class ValueForCustomsDeclaration
    {
        [Reference(1)]
        public string DeclaredValueForCustoms { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    public class ValueForInsuranceDeclaration
    {
        [Reference(1)]
        public string AmountOfInsurance { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get; set;  }
    }

    public class PrepaidCollectChargeDeclarations
    {
        [Reference(1)]
        public string PcIndWeightValuation { get; set;  }

        [Reference(2)]
        public string PcIndOtherCharges { get; set;  }
    }

    [SeparatorCrlf]
    public class OtherCustSecurityAndRegulatCtrlInfoDet
    {
        [Reference(1)]
        [SeparatorSlant]
        public string IsoCountryCode { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string InformationIdentifier { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string CustSecurityAndRegulatCtrlInfoId { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string SupplemCustSecurityAndRegulatCtrlInfo { get; set;  }
    }
}
