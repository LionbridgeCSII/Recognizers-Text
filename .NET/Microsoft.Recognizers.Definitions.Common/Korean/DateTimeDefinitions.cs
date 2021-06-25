﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Korean\Korean-DateTime.yaml
//     - Language: Korean
//     - ClassName: DateTimeDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Korean
{
    using System;
    using System.Collections.Generic;

    public static class DateTimeDefinitions
    {
      public const string LangMarker = @"Kor";
      public const string MonthRegex = @"(?<month>(정월|(일|이|삼|사|오|유|육|칠|팔|구|십|시|십일|십이)(월|개월))|((0?\d|1[0-2])(월|개월)))";
      public const string DayRegex = @"(?<day>[0-2]?\d|3[0-1]|하루|이틀|사흘|나흘|닷새|엿새|이레|여드레|아흐레|열흘)";
      public const string OneToNineIntegerRegex = @"[일이삼사오육륙칠팔구]";
      public static readonly string DateDayRegexInCJK = $@"(?<day>(([12][0-9]|3[01]|[1-9]|삼십일?|[이]?[십]({OneToNineIntegerRegex})?|{OneToNineIntegerRegex})[일]))";
      public static readonly string DayRegexNumInCJK = $@"(?<day>[12][0-9]|3[01]|[1-9]|삼십일?|[이]?[십]({OneToNineIntegerRegex})?|{OneToNineIntegerRegex})";
      public const string MonthNumRegex = @"(?<month>(0?\d|1[0-2]))";
      public const string TwoNumYear = @"50";
      public const string YearNumRegex = @"(?<year>((1[5-9]|20)\d{2})|2100)";
      public const string SimpleYearRegex = @"(?<year>(\d{2,4}))";
      public const string ZeroToNineIntegerRegexCJK = @"[일이삼사오육륙칠팔구영공십]";
      public const string DynastyStartYear = @"元";
      public const string RegionTitleRegex = @"(贞观|开元|神龙|洪武|建文|永乐|景泰|天顺|成化|嘉靖|万历|崇祯|顺治|康熙|雍正|乾隆|嘉庆|道光|咸丰|同治|光绪|宣统|民国)";
      public static readonly string DynastyYearRegex = $@"(?<dynasty>{RegionTitleRegex})(?<biasYear>({DynastyStartYear}|\d{{1,3}}|[十拾]?({ZeroToNineIntegerRegexCJK}[十百拾佰]?){{0,3}}))";
      public static readonly string DateYearInCJKRegex = $@"(?<yearCJK>({ZeroToNineIntegerRegexCJK}{{2,4}}|[일이]천{ZeroToNineIntegerRegexCJK}{{1,2}}))";
      public const string WeekDayRegex = @"(?<weekday>일요일|월요일|화요일|수요일|목요일|금요일|토요일)";
      public const string LunarRegex = @"음력";
      public static readonly string DateThisRegex = $@"(이번(\s+)?(주\s+)?){WeekDayRegex}";
      public static readonly string DateLastRegex = $@"((저번|지난)(\s+)?(주\s+)?){WeekDayRegex}";
      public static readonly string DateNextRegex = $@"(다음(\s+)?(주\s+)?){WeekDayRegex}";
      public const string SpecialMonthRegex = @"^[.]";
      public const string SpecialYearRegex = @"^[.]";
      public const string SpecialDayRegex = @"(최근|그저께|그제|((내일)?\s?모레)|그끄저께|어제|내일|오늘|금일|작일|익일|당일|명일|전일|다음 날|마지막 날|며칠|글피|그글피)";
      public static readonly string DurationFromSpecialDayRegex = $@"({SpecialDayRegex}|지금(으로)?)\s*((부터)\s*(\d+|{ZeroToNineIntegerRegexCJK}+)\s*(?!월){DateUnitRegex})(\s*후)?";
      public const string SpecialDayWithNumRegex = @"(하루|이틀|사흘|나흘|닷새|엿새)";
      public static readonly string WeekDayOfMonthRegex = $@"(((((이번|저번|지난|다음)\s)?{MonthRegex}|((이번|저번|지난|다음)\s)?{MonthNumRegex}월|(이번|저번|지난|다음)\s*달)의?\s*)?(?<cardinal>첫\s?번?째|두\s?번째|둘째|세\s?번째|셋째|네\s?번째|넷째|다섯\s?번?째|다섯째|여섯\s?번?째|여섯째|일곱\s?번?째|여덟\s?번?째|아홉\s?번?째|열\s?번?\s?째|마지막)\s*주?\s*{WeekDayRegex})";
      public const string WeekDayAndDayRegex = @"^[.]";
      public const string ThisPrefixRegex = @"이번?|금";
      public const string LastPrefixRegex = @"저번|지난";
      public const string NextPrefixRegex = @"다음|다가오는";
      public static readonly string RelativeRegex = $@"(?<order>({ThisPrefixRegex}|{LastPrefixRegex}|{NextPrefixRegex}))";
      public static readonly string SpecialDate = $@"(?<thisyear>({ThisPrefixRegex}|{LastPrefixRegex}|{NextPrefixRegex})년)?({RelativeRegex}\s달의?\s)?{DateDayRegexInCJK}";
      public const string DateUnitRegex = @"(?<unit>년|개?월|주|(?<!내)일)";
      public const string BeforeRegex = @"이?전|之前|前";
      public const string AfterRegex = @"이?후|후에";
      public static readonly string DateRegexList1 = $@"({RelativeRegex}\s*)?({SimpleYearRegex}년\s*)?({LunarRegex}\s*)?({MonthRegex}\s*)?{DateDayRegexInCJK}(\s*(,\s*)?{WeekDayRegex})?(\s*(,\s*)?{SimpleYearRegex})?";
      public static readonly string DateRegexList2 = $@"({WeekDayRegex},?\s*)?({MonthRegex}\s*[/\\\-\.]?\s*{DateDayRegexInCJK})(\s*{WeekDayRegex})?(\s*(,\s*)?({SimpleYearRegex}|{DateYearInCJKRegex})년?)?";
      public static readonly string DateRegexList3 = $@"(({SpecialDayRegex}으?로?부터)\s((\d+\s*주간?(\s*{WeekDayRegex})?)|({DateDayRegexInCJK}|{SpecialDayRegex})\s[전후]))|((\d+년\s*)?(((한|두|세|네|다섯|여섯|일곱|여덟|아홉|열|열한|열두)\s?달\s*)|(\d+개월\s*))?(((,\s*)|(\s*하고\s*))?{DateDayRegexInCJK}|{SpecialDayRegex})\s(전|후|지나서))|(((그\s)?(다음날|전날))|([그이] 날)|(지난 날)|(새해\s첫\s?날))|({DayRegex}일\s*{MonthNumRegex}월\s*{SimpleYearRegex}년)|(((앞으로\s+)|({SpecialDayRegex}으?로?부터\s+))?\d+\s*주\s(후|동안)\s+{WeekDayRegex})|(나의 하루)|(몇\s*[달일] 전)";
      public static readonly string DateRegexList4 = $@"{MonthNumRegex}\s*/\s*{DayRegex}(?!\s*퍼센트)";
      public static readonly string DateRegexList5 = $@"{DayRegex}\s*/\s*{MonthNumRegex}(?!\s*퍼센트)";
      public static readonly string DateRegexList6 = $@"{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}\s*[/\\\-,]\s*{SimpleYearRegex}";
      public static readonly string DateRegexList7 = $@"{DayRegex}\s*[/\\\-\.]\s*{MonthNumRegex}\s*[/\\\-\.,]\s*{SimpleYearRegex}";
      public static readonly string DateRegexList8 = $@"{SimpleYearRegex}\s*[/\\\-\. ]\s*{MonthNumRegex}\s*[/\\\-\. ]\s*{DayRegex}";
      public static readonly string DateRegexList9 = $@"({WeekDayRegex},\s*{MonthRegex}\s*{DateDayRegexInCJK},\s*{SimpleYearRegex}년)";
      public const string DatePeriodTillRegex = @"(?<till>--|-|—|——|~|–|로?부터|에서|[과와]|들어|,)";
      public const string DatePeriodRangeSuffixRegex = @"(사이|까지|안|이?전|이내|간)";
      public const string DatePeriodRangePrefixRegex = @"^\b$";
      public const string DatePeriodTillSuffixRequiredRegex = @"(?<till>로?부터|에서|과)";
      public const string DatePeriodDayRegexInCJK = @"(?<day>[1-9]\s*일|[12][0-9]\s*일|3[01]\s*일|[일이삼사오육칠팔구십]\s*일|이?십[일이삼사오륙칠팔구]?\s*일|삼십일?\s*일|0[1-9]\s*일|며칠)";
      public const string DatePeriodThisRegex = @"이번?";
      public const string DatePeriodLastRegex = @"저번?|지난|과거";
      public const string DatePeriodNextRegex = @"다?다음|다가오는|마지막";
      public const string WoMLastRegex = @"마지막";
      public const string WoMPreviousRegex = @"이전";
      public const string WoMNextRegex = @"다음";
      public static readonly string RelativeMonthRegex = $@"(?<relmonth>({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex}|같은)\s*달)";
      public const string HalfYearRegex = @"((?<firstHalf>[상전]반기)|(?<secondHalf>[하후]반기))";
      public static readonly string YearRegex = $@"(({YearNumRegex}|{SimpleYearRegex})\s*년)(\s*{HalfYearRegex})?";
      public static readonly string StrictYearRegex = $@"((({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex})\s+)?{YearRegex}(?=[\u4E00-\u9FFF]|\s|$|\W))";
      public const string YearRegexInNumber = @"(?<year>(\d{4}))";
      public static readonly string DatePeriodYearInCJKRegex = $@"{DateYearInCJKRegex}년{HalfYearRegex}?";
      public static readonly string MonthSuffixRegex = $@"(?<msuf>({RelativeMonthRegex}|{MonthRegex}))";
      public static readonly string SimpleCasesRegex = $@"(({YearRegex}|{DatePeriodYearInCJKRegex})\s*)?{MonthSuffixRegex}(\s+{DatePeriodDayRegexInCJK}|{DayRegex})\s*{DatePeriodTillRegex}?\s*(({YearRegex}|{DatePeriodYearInCJKRegex})\s*)?{MonthSuffixRegex}(\s+{DatePeriodDayRegexInCJK}|{DayRegex})(까지|\s+사이)?(\s*{DatePeriodRangeSuffixRegex})?";
      public static readonly string YearAndMonth = $@"({DatePeriodYearInCJKRegex}|{YearRegex})\s*{MonthRegex}";
      public static readonly string SimpleYearAndMonth = $@"({YearNumRegex}[/\\\-]{MonthNumRegex}\b$)";
      public static readonly string PureNumYearAndMonth = $@"({YearRegexInNumber}\s*[-\.\/]\s*{MonthNumRegex})|({MonthNumRegex}\s*\/\s*{YearRegexInNumber})";
      public static readonly string OneWordPeriodRegex = $@"((({MonthRegex}\s*)({DateDayRegexInCJK}\s*)|(그\s*)?(일|사건))(이 있[는던]|의)\s+[달주해])|(((?<yearrel>(작년|((다음|올)\s?해)|금년|내년))|({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex}))\s*)?{MonthRegex}(\s+달)?(\s*(초|말))?(\s+([1-9]|[12]\d|3[01])일,\s+([1-9]|[12]\d|3[01])일)?|(({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex}|그|다가오는|지난|올)\s+(몇\s+)?(며칠|날|주말?|해|달)(\s+([말안]|([초후]반?)))?(\s+휴가)?(에\s좀\s더\s일찍)?)|(금년|올\s?해|작년|내년)(\s*({HalfYearRegex}|[초말안]))?|((다다음주|금주|주말)(\s+[말안])?)|((앞으로)\s+(하루|이틀|사흘|나흘|닷새|엿새|이레|여드레|아흐레|열흘)(\s+동안)?)|((다가오는|다음)\s+(({DateDayRegexInCJK})|{MonthRegex}|((하루|이틀|사흘|나흘|닷새|엿새|이레|여드레|아흐레|열흘)|[주달])))|((({YearRegex})|(\d{{1,2}}년)\s*)?((({MonthRegex})|((한|두|세|네|다섯|여섯|일곱|여덟|아홉|열|열한|열두)\s+달))\s*)?({DateDayRegexInCJK})?(\s+이내))|((같은|이번|올)\s+[달주해])|((어제|오늘|내일)로?부터(\s+최소)?\s+((\d{{1,2}}주)|(하루|이틀|사흘|나흘|닷새|엿새|이레|여드레|아흐레|열흘)|(\d{{1,2}}일)|(오늘|내일))((\s+[후내안전])|(까지)|(\s+이내)))|(\d{{1,2}}번 째 주)|(\d{{1,2}}\s*세기)|(\d{{4}}-\d{{4}})";
      public static readonly string WeekOfMonthRegex = $@"(?<wom>{MonthSuffixRegex}의?\s+(?<cardinal>첫\s?번?째|두\s?번?째|둘째|세\s?번?째|셋째|네\s?번?째|넷째|마지막)\s*주\s*)";
      public static readonly string WeekOfYearRegex = $@"(?<woy>(?<yearrel>내년|금년|작년|((다음|올)\s*해)|{YearRegex})의?\s+(?<cardinal>첫\s?번?째|두\s?번?째|둘째|세\s?번?째|셋째|네\s?번?째|넷째|마지막)\s*주\s*)";
      public const string UnitRegex = @"(?<unit>년|(개)?월(\s달)?|달|주|일)";
      public static readonly string FollowedUnit = $@"^\s*{UnitRegex}";
      public static readonly string NumberCombinedWithUnit = $@"(?<num>\d+(\.\d*)?){UnitRegex}";
      public const string DateRangePrepositions = @"((从|在|自)\s*)?";
      public static readonly string YearToYear = $@"({DatePeriodYearInCJKRegex}|{YearRegex})\s*{DatePeriodTillRegex}\s*({DatePeriodYearInCJKRegex}|{YearRegex})";
      public static readonly string YearToYearSuffixRequired = $@"({DateRangePrepositions})({DatePeriodYearInCJKRegex}|{YearRegex})\s*({DatePeriodTillSuffixRequiredRegex})\s*({DatePeriodYearInCJKRegex}|{YearRegex})\s*(까지|사이)";
      public static readonly string MonthToMonth = $@"({DateRangePrepositions})({MonthRegex}){DatePeriodTillRegex}({MonthRegex})";
      public static readonly string MonthToMonthSuffixRequired = $@"({DateRangePrepositions})({MonthRegex}){DatePeriodTillSuffixRequiredRegex}({MonthRegex})\s*(까지|사이)";
      public const string DayToDay = @"^[.]";
      public const string DayRegexForPeriod = @"^[.]";
      public static readonly string WeekToWeek = $@"(\d+\s*주{DatePeriodTillRegex}\s+\d+\s*주\s*{DatePeriodRangeSuffixRegex})";
      public static readonly string RelativePeriodRegex = $@"(({SpecialDayRegex}|지금|올 해)\s*{DatePeriodTillRegex}\s*((\d+\s*주)|(하루|이틀|사흘|나흘|닷새|엿새|이흐레|여드레|아흐레|열흘)|(지금))(\s*반)?(\s*[전후뒤앞])?\s*{DatePeriodRangeSuffixRegex})";
      public const string PastRegex = @"(?<past>지난|과거)";
      public const string FutureRegex = @"(?<future>앞으로|지금부터)";
      public const string SeasonRegex = @"(한\s*)?(?<season>봄|여름|가을|겨울)";
      public static readonly string SeasonWithYear = $@"(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>내년|올\s?해|금년|작년)|(이번?|저번?|다음|그))의?\s+)?{SeasonRegex}\s*(초|중반|말)?";
      public static readonly string QuarterRegex = $@"(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>내년|올\s?해|금년|작년))(의)?\s+)?((?<cardinal>1|2|3|4|일|이|삼|사)사?분기)";
      public const string CenturyRegex = @"(?<century>\d|1\d|2\d)\s*세기";
      public const string CenturyRegexInCJK = @"(?<century>일|이|삼|사|오|육|칠|팔|구|이?십(일|이|삼|사|오|육|칠|팔|구))\s*세기";
      public static readonly string RelativeCenturyRegex = $@"(?<relcentury>({DatePeriodLastRegex}|{DatePeriodThisRegex}|{DatePeriodNextRegex}))세기";
      public const string DecadeRegexInCJK = @"(?<decade>십|일십|이십|삼십|사십|오십|육십|칠십|팔십|구십)";
      public static readonly string DecadeRegex = $@"(?<centurysuf>({CenturyRegex}|{CenturyRegexInCJK}|{RelativeCenturyRegex}))?(?<decade>(\d0|{DecadeRegexInCJK}|\d{{3}}0))년대";
      public const string PrepositionRegex = @"(?<prep>^的|在$)";
      public const string NowRegex = @"(?<now>지금)";
      public const string NightRegex = @"(?<night>이른|늦은)";
      public const string TimeOfTodayRegex = @"(今晚|今早|今晨|明晚|明早|明晨|昨晚)(的|在)?";
      public const string DateTimePeriodTillRegex = @"(?<till>到|直到|--|-|—|——)";
      public const string DateTimePeriodPrepositionRegex = @"(?<prep>^\s*的|在\s*$)";
      public static readonly string HourRegex = $@"\b{BaseDateTime.HourRegex}";
      public const string HourNumRegex = @"(?<hour>[한두세네]|다섯|여섯|일곱|여덟|아홉|스무|스물[한두세네]|열([한두세네]|다섯|여섯|일곱|여덟|아홉)?)";
      public const string ZhijianRegex = @"^\s*(까지)";
      public const string DateTimePeriodThisRegex = @"这个|这一个|这|这一";
      public const string DateTimePeriodLastRegex = @"上个|上一个|上|上一";
      public const string DateTimePeriodNextRegex = @"下个|下一个|下|下一";
      public const string AmPmDescRegex = @"(?<daydesc>(am|a\.m\.|a m|a\. m\.|a\.m|a\. m|a m|pm|p\.m\.|p m|p\. m\.|p\.m|p\. m|p m))";
      public const string TimeOfDayRegex = @"(?<timeOfDay>凌晨|清晨|早上|早间|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|夜间|深夜|傍晚|晚)";
      public static readonly string SpecificTimeOfDayRegex = $@"((({DateTimePeriodThisRegex}|{DateTimePeriodNextRegex}|{DateTimePeriodLastRegex})\s+{TimeOfDayRegex})|(今晚|今早|今晨|明晚|明早|明晨|昨晚))";
      public const string DateTimePeriodUnitRegex = @"(个)?(?<unit>(小时|钟头|分钟|秒钟|时|分|秒))";
      public static readonly string DateTimePeriodFollowedUnit = $@"^\s*{DateTimePeriodUnitRegex}";
      public static readonly string DateTimePeriodNumberCombinedWithUnit = $@"\b(?<num>\d+(\.\d*)?){DateTimePeriodUnitRegex}";
      public const string DurationAllRegex = @"(내내|종일)";
      public const string DurationHalfRegex = @"ㅂ";
      public const string DurationRelativeDurationUnitRegex = @"(지난|저번|작(?=년))";
      public const string DurationDuringRegex = @"(동안)";
      public const string DurationSomeRegex = @"^\b$";
      public const string DurationMoreOrLessRegex = @"(더|이상|이하|초과|미만)";
      public static readonly string DurationYearRegex = $@"(\d+|{ZeroToNineIntegerRegexCJK})\s*년\s*간";
      public const string DurationHalfSuffixRegex = @"반";
      public static readonly Dictionary<string, string> DurationSuffixList = new Dictionary<string, string>
        {
            { @"M", @"분" },
            { @"S", @"초" },
            { @"H", @"시|시간" },
            { @"D", @"일|칠|날" },
            { @"BD", @"영업일 기준으로" },
            { @"QD", @"한나절" },
            { @"W", @"주|주일" },
            { @"MON", @"개월|월|달" },
            { @"Y", @"년" },
            { @"P1D", @"하루" },
            { @"P2D", @"이틀" },
            { @"P3D", @"사흘" },
            { @"P4D", @"나흘" },
            { @"P5D", @"닷새" },
            { @"P6D", @"엿새" },
            { @"P7D", @"이레" },
            { @"P8D", @"여드레" },
            { @"P9D", @"아흐레" },
            { @"P10D", @"열흘" }
        };
      public static readonly IList<string> DurationAmbiguousUnits = new List<string>
        {
            @"분",
            @"초",
            @"시",
            @"시간",
            @"일",
            @"주",
            @"주일",
            @"달",
            @"월",
            @"년",
            @"시"
        };
      public const string DurationUnitRegex = @"(?<unit>(년|개?월|달|주일?|(?<!종)(?<=\d|\s+)일|(?<=\s)날|한나절|(?<=며)칠|시간?|분|초|영업일\s*기준으로|하루|이틀|사흘|나흘|닷새|엿새|이레|여드레|아흐레|열흘|하루|종일|내내|몇|여러|더|이상|이하|초과|미만)\s*(이상|이하|초과|미만)?)";
      public const string DurationConnectorRegex = @"(?<connector>\s*그리고\s*|\s+|,\s*)";
      public static readonly string DurationMoreOrLessThanSurfix = $@"(?<DurationUnitRegex>\s*(이상|이하|초과|미만))";
      public static readonly string LunarHolidayRegex = $@"(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>내년|금년|작년))(의)?\s)?(?<holiday>섣달그믐날?|음력설|구정|추석|한가위|정월대보름|단오|석가탄신일)";
      public static readonly string HolidayRegexList1 = $@"(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>내년|금년|작년))(의)?\s)?(?<holiday>새해|설날|양력설|신정|근로자의 날|만우절|크리스마스 이브|크리스마스|식목일|건국기념일|발렌타인데이|밸런타인데이|스승의 날|교사의 날|어린이날|국제 여성의 날|세계 여성의 날|삼일절|3.1절|3·1절|현충일|광복절|개천절|한글날|기독탄신일)";
      public static readonly string HolidayRegexList2 = $@"(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>내년|금년|작년))(의)?\s)?(?<holiday>추수감사절|할로윈|제헌절|국군의 날|유엔의 날|아버지의 날|클린 먼데이|마틴 루터 킹 데이|메이데이|부활절|국제 노동자의 날)";
      public const string SetUnitRegex = @"(?<unit>년|월|달|주일?|일|시간|시|분|초)";
      public static readonly string SetEachUnitRegex = $@"(?<each>{SetUnitRegex}\s?(마다))";
      public const string SetEachPrefixRegex = @"(?<each>(매)\s*$)";
      public const string SetLastRegex = @"(?<last>last|this|next)";
      public const string SetEachDayRegex = @"(每|每一)(天|日)\s*$";
      public const string TimeHourNumRegex = @"(00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)";
      public const string TimeMinuteNumRegex = @"(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)";
      public const string TimeSecondNumRegex = @"(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)";
      public const string TimeHourCJKRegex = @"([零〇一二两三四五六七八九]|二十[一二三四]?|十[一二三四五六七八九]?)";
      public const string TimeMinuteCJKRegex = @"([二三四五]?十[一二三四五六七八九]?|六十|[零〇一二三四五六七八九])";
      public static readonly string TimeSecondCJKRegex = $@"{TimeMinuteCJKRegex}";
      public const string TimeClockDescRegex = @"(点\s*整|点\s*钟|点|时)";
      public const string TimeMinuteDescRegex = @"(分钟|分|)";
      public const string TimeSecondDescRegex = @"(秒钟|秒)";
      public const string TimeBanHourPrefixRegex = @"(第)";
      public static readonly string TimeHourRegex = $@"(?<!{TimeBanHourPrefixRegex})(?<hour>{TimeHourCJKRegex}|{TimeHourNumRegex}){TimeClockDescRegex}";
      public static readonly string TimeMinuteRegex = $@"(?<min>{TimeMinuteCJKRegex}|{TimeMinuteNumRegex}){TimeMinuteDescRegex}";
      public static readonly string TimeSecondRegex = $@"(?<sec>{TimeSecondCJKRegex}|{TimeSecondNumRegex}){TimeSecondDescRegex}";
      public const string TimeHalfRegex = @"(?<half>过半|半)";
      public const string TimeQuarterRegex = @"(?<quarter>[一两二三四1-4])\s*(刻钟|刻)";
      public static readonly string TimeCJKTimeRegex = $@"{TimeHourRegex}({TimeQuarterRegex}|{TimeHalfRegex}|((过|又)?{TimeMinuteRegex})({TimeSecondRegex})?)?";
      public static readonly string TimeDigitTimeRegex = $@"(?<hour>{TimeHourNumRegex}):(?<min>{TimeMinuteNumRegex})(:(?<sec>{TimeSecondNumRegex}))?";
      public const string TimeDayDescRegex = @"(?<daydesc>凌晨|清晨|早上|早间|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|午夜|夜间|深夜|傍晚|晚)";
      public const string TimeApproximateDescPreffixRegex = @"(大[约概]|差不多|可能|也许|约|不超过|不多[于过]|最[多长少]|少于|[超短长多]过|几乎要|将近|差点|快要|接近|至少|起码|超出|不到)";
      public const string TimeApproximateDescSuffixRegex = @"(左右)";
      public static readonly string TimeRegexes1 = $@"{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeCJKTimeRegex}{TimeApproximateDescSuffixRegex}?";
      public static readonly string TimeRegexes2 = $@"{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeDigitTimeRegex}{TimeApproximateDescSuffixRegex}?(\s*{AmPmDescRegex}?)";
      public static readonly string TimeRegexes3 = $@"差{TimeMinuteRegex}{TimeCJKTimeRegex}";
      public const string TimePeriodTimePeriodConnectWords = @"(起|至|到|–|-|—|~|～)";
      public static readonly string TimePeriodLeftCJKTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeCJKTimeRegex}))";
      public static readonly string TimePeriodRightCJKTimeRegex = $@"{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeCJKTimeRegex})(之间)?";
      public static readonly string TimePeriodLeftDigitTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeDigitTimeRegex}))";
      public static readonly string TimePeriodRightDigitTimeRegex = $@"{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeDigitTimeRegex})(之间)?";
      public static readonly string TimePeriodShortLeftCJKTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeHourCJKRegex}))";
      public static readonly string TimePeriodShortLeftDigitTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeHourNumRegex}))";
      public static readonly string TimePeriodRegexes1 = $@"({TimePeriodLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodLeftCJKTimeRegex}{TimePeriodRightCJKTimeRegex})";
      public static readonly string TimePeriodRegexes2 = $@"({TimePeriodShortLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodShortLeftCJKTimeRegex}{TimePeriodRightCJKTimeRegex})";
      public const string FromToRegex = @"(으?로?부터|과|에서).+(까지).+";
      public const string AmbiguousRangeModifierPrefix = @"(从|自)";
      public const string ParserConfigurationBefore = @"((?<include>和|或|及)?(之前|以前)|前)";
      public const string ParserConfigurationAfter = @"((?<include>和|或|及)?(之后|之後|以后|以後)|后|後)";
      public const string ParserConfigurationUntil = @"(直到|直至|截至|截止(到)?)";
      public const string ParserConfigurationSincePrefix = @"(自从|自|自打|打|从)";
      public const string ParserConfigurationSinceSuffix = @"(以来|开始|起)";
      public const string ParserConfigurationLastWeekDayToken = @"最后一个";
      public const string ParserConfigurationNextMonthToken = @"下一个";
      public const string ParserConfigurationLastMonthToken = @"上一个";
      public const string ParserConfigurationDatePrefix = @" ";
      public static readonly Dictionary<string, string> ParserConfigurationUnitMap = new Dictionary<string, string>
        {
            { @"년", @"Y" },
            { @"월", @"MON" },
            { @"달", @"MON" },
            { @"일", @"D" },
            { @"날", @"D" },
            { @"칠", @"D" },
            { @"영업일 기준으로", @"BD" },
            { @"한나절", @"QD" },
            { @"주", @"W" },
            { @"주일", @"W" },
            { @"시", @"H" },
            { @"시간", @"H" },
            { @"분", @"M" },
            { @"초", @"S" },
            { @"하루", @"P1D" },
            { @"이틀", @"P2D" },
            { @"사흘", @"P3D" },
            { @"나흘", @"P4D" },
            { @"닷새", @"P5D" },
            { @"엿새", @"P6D" },
            { @"이레", @"P7D" },
            { @"여드레", @"P8D" },
            { @"아흐레", @"P9D" },
            { @"열흘", @"P10D" },
            { @"종일", @"whole" },
            { @"내내", @"whole" },
            { @"몇", @"some" },
            { @"여러", @"some" },
            { @"더", @"more" },
            { @"이상", @"more" },
            { @"이하", @"less" },
            { @"초과", @"more" },
            { @"미만", @"less" }
        };
      public static readonly Dictionary<string, long> ParserConfigurationUnitValueMap = new Dictionary<string, long>
        {
            { @"years", 31536000 },
            { @"year", 31536000 },
            { @"months", 2592000 },
            { @"month", 2592000 },
            { @"weeks", 604800 },
            { @"week", 604800 },
            { @"days", 86400 },
            { @"day", 86400 },
            { @"hours", 3600 },
            { @"hour", 3600 },
            { @"hrs", 3600 },
            { @"hr", 3600 },
            { @"h", 3600 },
            { @"minutes", 60 },
            { @"minute", 60 },
            { @"mins", 60 },
            { @"min", 60 },
            { @"seconds", 1 },
            { @"second", 1 },
            { @"secs", 1 },
            { @"sec", 1 }
        };
      public static readonly IList<string> MonthTerms = new List<string>
        {
            @"월",
            @"달"
        };
      public static readonly IList<string> WeekendTerms = new List<string>
        {
            @"주말"
        };
      public static readonly IList<string> WeekTerms = new List<string>
        {
            @"주",
            @"주일"
        };
      public static readonly IList<string> YearTerms = new List<string>
        {
            @"년"
        };
      public static readonly IList<string> ThisYearTerms = new List<string>
        {
            @"금년",
            @"올해"
        };
      public static readonly IList<string> LastYearTerms = new List<string>
        {
            @"작년"
        };
      public static readonly IList<string> NextYearTerms = new List<string>
        {
            @"내년"
        };
      public static readonly IList<string> YearAfterNextTerms = new List<string>
        {
            @"내후년"
        };
      public static readonly IList<string> YearBeforeLastTerms = new List<string>
        {
            @"재작년"
        };
      public static readonly Dictionary<string, string> ParserConfigurationSeasonMap = new Dictionary<string, string>
        {
            { @"봄", @"SP" },
            { @"여름", @"SU" },
            { @"가을", @"FA" },
            { @"겨울", @"WI" }
        };
      public static readonly Dictionary<string, int> ParserConfigurationSeasonValueMap = new Dictionary<string, int>
        {
            { @"SP", 3 },
            { @"SU", 6 },
            { @"FA", 9 },
            { @"WI", 12 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationCardinalMap = new Dictionary<string, int>
        {
            { @"일", 1 },
            { @"이", 2 },
            { @"삼", 3 },
            { @"사", 4 },
            { @"오", 5 },
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"첫 번째", 1 },
            { @"두 번째", 2 },
            { @"세 번째", 3 },
            { @"네 번째", 4 },
            { @"다섯 번째", 5 },
            { @"첫째", 1 },
            { @"둘째", 2 },
            { @"셋째", 3 },
            { @"넷째", 4 },
            { @"다섯째", 5 },
            { @"마지막", 5 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationDayOfMonth = new Dictionary<string, int>
        {
            { @"01", 1 },
            { @"02", 2 },
            { @"03", 3 },
            { @"04", 4 },
            { @"05", 5 },
            { @"06", 6 },
            { @"07", 7 },
            { @"08", 8 },
            { @"09", 9 },
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"6", 6 },
            { @"7", 7 },
            { @"8", 8 },
            { @"9", 9 },
            { @"10", 10 },
            { @"11", 11 },
            { @"12", 12 },
            { @"13", 13 },
            { @"14", 14 },
            { @"15", 15 },
            { @"16", 16 },
            { @"17", 17 },
            { @"18", 18 },
            { @"19", 19 },
            { @"20", 20 },
            { @"21", 21 },
            { @"22", 22 },
            { @"23", 23 },
            { @"24", 24 },
            { @"25", 25 },
            { @"26", 26 },
            { @"27", 27 },
            { @"28", 28 },
            { @"29", 29 },
            { @"30", 30 },
            { @"31", 31 },
            { @"1일", 1 },
            { @"2일", 2 },
            { @"3일", 3 },
            { @"4일", 4 },
            { @"5일", 5 },
            { @"6일", 6 },
            { @"7일", 7 },
            { @"8일", 8 },
            { @"9일", 9 },
            { @"10일", 10 },
            { @"11일", 11 },
            { @"12일", 12 },
            { @"13일", 13 },
            { @"14일", 14 },
            { @"15일", 15 },
            { @"16일", 16 },
            { @"17일", 17 },
            { @"18일", 18 },
            { @"19일", 19 },
            { @"20일", 20 },
            { @"21일", 21 },
            { @"22일", 22 },
            { @"23일", 23 },
            { @"24일", 24 },
            { @"25일", 25 },
            { @"26일", 26 },
            { @"27일", 27 },
            { @"28일", 28 },
            { @"29일", 29 },
            { @"30일", 30 },
            { @"31일", 31 },
            { @"일일", 1 },
            { @"십일일", 11 },
            { @"이십일", 21 },
            { @"십일", 11 },
            { @"이십일일", 21 },
            { @"삼십일일", 31 },
            { @"이일", 2 },
            { @"삼일", 3 },
            { @"사일", 4 },
            { @"오일", 5 },
            { @"육일", 6 },
            { @"칠일", 7 },
            { @"팔일", 8 },
            { @"구일", 9 },
            { @"십이일", 12 },
            { @"십삼일", 13 },
            { @"십사일", 14 },
            { @"십오일", 15 },
            { @"십육일", 16 },
            { @"십칠일", 17 },
            { @"십팔일", 18 },
            { @"십구일", 19 },
            { @"이십이일", 22 },
            { @"이십삼일", 23 },
            { @"이십사일", 24 },
            { @"이십오일", 25 },
            { @"이십육일", 26 },
            { @"이십칠일", 27 },
            { @"이십팔일", 28 },
            { @"이십구일", 29 },
            { @"삼십일", 31 },
            { @"초하루", 32 },
            { @"1번", 1 },
            { @"2번", 2 },
            { @"3번", 3 },
            { @"4번", 4 },
            { @"5번", 5 },
            { @"6번", 6 },
            { @"7번", 7 },
            { @"8번", 8 },
            { @"9번", 9 },
            { @"10번", 10 },
            { @"11번", 11 },
            { @"12번", 12 },
            { @"13번", 13 },
            { @"14번", 14 },
            { @"15번", 15 },
            { @"16번", 16 },
            { @"17번", 17 },
            { @"18번", 18 },
            { @"19번", 19 },
            { @"20번", 20 },
            { @"21번", 21 },
            { @"22번", 22 },
            { @"23번", 23 },
            { @"24번", 24 },
            { @"25번", 25 },
            { @"26번", 26 },
            { @"27번", 27 },
            { @"28번", 28 },
            { @"29번", 29 },
            { @"30번", 30 },
            { @"31번", 31 },
            { @"일번", 1 },
            { @"십일번", 11 },
            { @"이십번", 20 },
            { @"십번", 10 },
            { @"이십일번", 21 },
            { @"삼십일번", 31 },
            { @"이번", 2 },
            { @"삼번", 3 },
            { @"사번", 4 },
            { @"오번", 5 },
            { @"육번", 6 },
            { @"칠번", 7 },
            { @"팔번", 8 },
            { @"구번", 9 },
            { @"십이번", 12 },
            { @"십삼번", 13 },
            { @"십사번", 14 },
            { @"십오번", 15 },
            { @"십육번", 16 },
            { @"십칠번", 17 },
            { @"십팔번", 18 },
            { @"십구번", 19 },
            { @"이십이번", 22 },
            { @"이십삼번", 23 },
            { @"이십사번", 24 },
            { @"이십오번", 25 },
            { @"이십육번", 26 },
            { @"이십칠번", 27 },
            { @"이십팔번", 28 },
            { @"이십구번", 29 },
            { @"삼십번", 30 },
            { @"삼십", 30 },
            { @"일", 1 },
            { @"이십", 20 },
            { @"십", 10 },
            { @"이", 2 },
            { @"삼", 3 },
            { @"사", 4 },
            { @"오", 5 },
            { @"육", 6 },
            { @"칠", 7 },
            { @"팔", 8 },
            { @"구", 9 },
            { @"십이", 12 },
            { @"십삼", 13 },
            { @"십사", 14 },
            { @"십오", 15 },
            { @"십육", 16 },
            { @"십칠", 17 },
            { @"십팔", 18 },
            { @"십구", 19 },
            { @"이십이", 22 },
            { @"이십삼", 23 },
            { @"이십사", 24 },
            { @"이십오", 25 },
            { @"이십육", 26 },
            { @"이십칠", 27 },
            { @"이십팔", 28 },
            { @"이십구", 29 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationDayOfWeek = new Dictionary<string, int>
        {
            { @"월요일", 1 },
            { @"화요일", 2 },
            { @"수요일", 3 },
            { @"목요일", 4 },
            { @"금요일", 5 },
            { @"토요일", 6 },
            { @"일요일", 0 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationMonthOfYear = new Dictionary<string, int>
        {
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"6", 6 },
            { @"7", 7 },
            { @"8", 8 },
            { @"9", 9 },
            { @"10", 10 },
            { @"11", 11 },
            { @"12", 12 },
            { @"01", 1 },
            { @"02", 2 },
            { @"03", 3 },
            { @"04", 4 },
            { @"05", 5 },
            { @"06", 6 },
            { @"07", 7 },
            { @"08", 8 },
            { @"09", 9 },
            { @"한", 1 },
            { @"두", 2 },
            { @"세", 3 },
            { @"네", 4 },
            { @"다섯", 5 },
            { @"여섯", 6 },
            { @"일곱", 7 },
            { @"여덟", 8 },
            { @"아홉", 9 },
            { @"열", 10 },
            { @"얼한", 11 },
            { @"열두", 12 },
            { @"일월", 1 },
            { @"이월", 2 },
            { @"삼월", 3 },
            { @"사월", 4 },
            { @"오월", 5 },
            { @"유월", 6 },
            { @"육월", 6 },
            { @"칠월", 7 },
            { @"팔월", 8 },
            { @"구월", 9 },
            { @"시월", 10 },
            { @"십월", 10 },
            { @"십일월", 11 },
            { @"십이월", 12 },
            { @"1월", 1 },
            { @"2월", 2 },
            { @"3월", 3 },
            { @"4월", 4 },
            { @"5월", 5 },
            { @"6월", 6 },
            { @"7월", 7 },
            { @"8월", 8 },
            { @"9월", 9 },
            { @"10월", 10 },
            { @"11월", 11 },
            { @"12월", 12 },
            { @"01월", 1 },
            { @"02월", 2 },
            { @"03월", 3 },
            { @"04월", 4 },
            { @"05월", 5 },
            { @"06월", 6 },
            { @"07월", 7 },
            { @"08월", 8 },
            { @"09월", 9 },
            { @"1개월", 1 },
            { @"2개월", 2 },
            { @"3개월", 3 },
            { @"4개월", 4 },
            { @"5개월", 5 },
            { @"6개월", 6 },
            { @"7개월", 7 },
            { @"8개월", 8 },
            { @"9개월", 9 },
            { @"10개월", 10 },
            { @"11개월", 11 },
            { @"12개월", 12 },
            { @"새해", 13 }
        };
      public const string DateTimeSimpleAmRegex = @"(?<am>早|晨)";
      public const string DateTimeSimplePmRegex = @"(?<pm>晚)";
      public const string DateTimePeriodMORegex = @"(凌晨|清晨|早上|早间|早|上午)";
      public const string DateTimePeriodMIRegex = @"(中午)";
      public const string DateTimePeriodAFRegex = @"(下午|午后|傍晚)";
      public const string DateTimePeriodEVRegex = @"(晚上|夜里|夜晚|晚)";
      public const string DateTimePeriodNIRegex = @"(半夜|夜间|深夜)";
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"早", @"(?<!今|明|日|号)早(?!上)" },
            { @"晚", @"(?<!今|明|昨|傍|夜|日|号)晚(?!上)" },
            { @"^\d{1,2}일", @"^\d{1,2}号" },
            { @"周", @"周岁" },
            { @"금일", @"오늘" },
            { @"명일", @"내일" },
            { @"시", @"시간" }
        };
      public static readonly Dictionary<string, long> DurationUnitValueMap = new Dictionary<string, long>
        {
            { @"Y", 31536000 },
            { @"MON", 2592000 },
            { @"W", 604800 },
            { @"D", 86400 },
            { @"BD", 5 },
            { @"QD", 21600 },
            { @"H", 3600 },
            { @"M", 60 },
            { @"S", 1 },
            { @"P1D", 86400 },
            { @"P2D", 172800 },
            { @"P3D", 259200 },
            { @"P4D", 345600 },
            { @"P5D", 432000 },
            { @"P6D", 518400 },
            { @"P7D", 604800 },
            { @"P8D", 691200 },
            { @"P9D", 777600 },
            { @"P10D", 864000 },
            { @"whole", 1 },
            { @"some", 2 },
            { @"more", 3 },
            { @"less", 4 }
        };
      public static readonly Dictionary<string, string> HolidayNoFixedTimex = new Dictionary<string, string>
        {
            { @"父亲节", @"-06-WXX-6-3" },
            { @"母亲节", @"-05-WXX-7-2" },
            { @"感恩节", @"-11-WXX-4-4" }
        };
      public const string MergedBeforeRegex = @"(이?전)$";
      public const string MergedAfterRegex = @"((이?후)|뒤)$";
      public static readonly Dictionary<char, int> TimeNumberDictionary = new Dictionary<char, int>
        {
            { '영', 0 },
            { '일', 1 },
            { '이', 2 },
            { '삼', 3 },
            { '사', 4 },
            { '오', 5 },
            { '육', 6 },
            { '칠', 7 },
            { '팔', 8 },
            { '구', 9 },
            { '공', 0 },
            { '십', 10 },
            { '한', 1 },
            { '두', 2 },
            { '세', 3 },
            { '네', 4 },
            { '열', 10 }
        };
      public static readonly Dictionary<string, int> TimeLowBoundDesc = new Dictionary<string, int>
        {
            { @"오전", 11 },
            { @"정오", 12 },
            { @"오후", 13 },
            { @"午后", 12 },
            { @"晚上", 18 },
            { @"夜里", 18 },
            { @"夜晚", 18 },
            { @"夜间", 18 },
            { @"深夜", 18 },
            { @"傍晚", 18 },
            { @"晚", 18 },
            { @"pm", 12 }
        };
      public const string DefaultLanguageFallback = @"YMD";
      public static readonly IList<string> MorningTermList = new List<string>
        {
            @"早",
            @"上午",
            @"早间",
            @"早上",
            @"清晨"
        };
      public static readonly IList<string> MidDayTermList = new List<string>
        {
            @"中午",
            @"正午"
        };
      public static readonly IList<string> AfternoonTermList = new List<string>
        {
            @"下午",
            @"午后"
        };
      public static readonly IList<string> EveningTermList = new List<string>
        {
            @"晚",
            @"晚上",
            @"夜里",
            @"傍晚",
            @"夜晚"
        };
      public static readonly IList<string> DaytimeTermList = new List<string>
        {
            @"白天",
            @"日间"
        };
      public static readonly IList<string> NightTermList = new List<string>
        {
            @"深夜"
        };
      public static readonly Dictionary<string, int> DynastyYearMap = new Dictionary<string, int>
        {
            { @"贞观", 627 },
            { @"开元", 713 },
            { @"神龙", 705 },
            { @"洪武", 1368 },
            { @"建文", 1399 },
            { @"永乐", 1403 },
            { @"景泰", 1450 },
            { @"天顺", 1457 },
            { @"成化", 1465 },
            { @"嘉靖", 1522 },
            { @"万历", 1573 },
            { @"崇祯", 1628 },
            { @"顺治", 1644 },
            { @"康熙", 1662 },
            { @"雍正", 1723 },
            { @"乾隆", 1736 },
            { @"嘉庆", 1796 },
            { @"道光", 1821 },
            { @"咸丰", 1851 },
            { @"同治", 1862 },
            { @"光绪", 1875 },
            { @"宣统", 1909 },
            { @"民国", 1912 }
        };
    }
}