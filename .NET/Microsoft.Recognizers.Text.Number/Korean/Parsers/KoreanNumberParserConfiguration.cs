﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Recognizers.Definitions.Korean;

namespace Microsoft.Recognizers.Text.Number.Korean
{
    public class KoreanNumberParserConfiguration : BaseNumberParserConfiguration, ICJKNumberParserConfiguration
    {

        private const RegexOptions RegexFlags = RegexOptions.Singleline | RegexOptions.ExplicitCapture;

        public KoreanNumberParserConfiguration()
            : this(new CultureInfo(Culture.Korean))
        {
        }

        public KoreanNumberParserConfiguration(CultureInfo ci)
        {
            LangMarker = NumbersDefinitions.LangMarker;
            CultureInfo = ci;
            IsCompoundNumberLanguage = NumbersDefinitions.CompoundNumberLanguage;
            IsMultiDecimalSeparatorCulture = NumbersDefinitions.MultiDecimalSeparatorCulture;

            DecimalSeparatorChar = NumbersDefinitions.DecimalSeparatorChar;
            FractionMarkerToken = NumbersDefinitions.FractionMarkerToken;
            NonDecimalSeparatorChar = NumbersDefinitions.NonDecimalSeparatorChar;
            HalfADozenText = NumbersDefinitions.HalfADozenText;
            WordSeparatorToken = NumbersDefinitions.WordSeparatorToken;
            ZeroChar = NumbersDefinitions.ZeroChar;
            PairChar = NumbersDefinitions.PairChar;

            WrittenDecimalSeparatorTexts = Enumerable.Empty<string>();
            WrittenGroupSeparatorTexts = Enumerable.Empty<string>();
            WrittenIntegerSeparatorTexts = Enumerable.Empty<string>();
            WrittenFractionSeparatorTexts = Enumerable.Empty<string>();

            CardinalNumberMap = new Dictionary<string, long>().ToImmutableDictionary();
            OrdinalNumberMap = new Dictionary<string, long>().ToImmutableDictionary();
            RelativeReferenceOffsetMap = NumbersDefinitions.RelativeReferenceOffsetMap.ToImmutableDictionary();
            RelativeReferenceRelativeToMap = NumbersDefinitions.RelativeReferenceRelativeToMap.ToImmutableDictionary();
            RoundNumberMap = NumbersDefinitions.RoundNumberMap.ToImmutableDictionary();
            ZeroToNineMap = NumbersDefinitions.ZeroToNineMap.ToImmutableDictionary();
            RoundNumberMapChar = NumbersDefinitions.RoundNumberMapChar.ToImmutableDictionary();
            FullToHalfMap = NumbersDefinitions.FullToHalfMap.ToImmutableDictionary();
            UnitMap = NumbersDefinitions.UnitMap.ToImmutableDictionary();
            RoundDirectList = NumbersDefinitions.RoundDirectList.ToImmutableList();
            TenChars = NumbersDefinitions.TenChars.ToImmutableList();

            // @TODO Change init to follow design in other languages
            HalfADozenRegex = null;
            DigitalNumberRegex = new Regex(NumbersDefinitions.DigitalNumberRegex, RegexFlags);
            DigitNumRegex = new Regex(NumbersDefinitions.DigitNumRegex, RegexFlags);
            DozenRegex = new Regex(NumbersDefinitions.DozenRegex, RegexFlags);
            PercentageRegex = new Regex(NumbersDefinitions.PercentageRegex, RegexFlags);
            DoubleAndRoundRegex = new Regex(NumbersDefinitions.DoubleAndRoundRegex, RegexFlags);
            FracSplitRegex = new Regex(NumbersDefinitions.FracSplitRegex, RegexFlags);
            NegativeNumberTermsRegex = new Regex(NumbersDefinitions.NegativeNumberTermsRegex, RegexFlags);
            NegativeNumberSignRegex = new Regex(NumbersDefinitions.NegativeNumberSignRegex, RegexFlags);
            PointRegex = new Regex(NumbersDefinitions.PointRegex, RegexFlags);
            SpeGetNumberRegex = new Regex(NumbersDefinitions.SpeGetNumberRegex, RegexFlags);
            PairRegex = new Regex(NumbersDefinitions.PairRegex, RegexFlags);
            RoundNumberIntegerRegex = new Regex(NumbersDefinitions.RoundNumberIntegerRegex, RegexFlags);
            FractionPrepositionRegex = null;
        }

        public string NonDecimalSeparatorText { get; private set; }

        public Regex DigitNumRegex { get; private set; }

        public Regex DozenRegex { get; private set; }

        public Regex PercentageRegex { get; private set; }

        public Regex DoubleAndRoundRegex { get; private set; }

        public Regex FracSplitRegex { get; private set; }

        public Regex NegativeNumberTermsRegex { get; private set; }

        public Regex PointRegex { get; private set; }

        public Regex SpeGetNumberRegex { get; private set; }

        public Regex PairRegex { get; private set; }

        public Regex RoundNumberIntegerRegex { get; private set; }

        public char ZeroChar { get; private set; }

        public char PairChar { get; private set; }

        public ImmutableDictionary<char, double> ZeroToNineMap { get; private set; }

        public ImmutableDictionary<char, long> RoundNumberMapChar { get; private set; }

        public ImmutableDictionary<char, char> FullToHalfMap { get; private set; }

        public ImmutableDictionary<string, string> UnitMap { get; private set; }

        public ImmutableDictionary<char, char> TratoSimMap { get; private set; }

        public ImmutableList<char> RoundDirectList { get; private set; }

        public ImmutableList<char> TenChars { get; private set; }

        public override IEnumerable<string> NormalizeTokenSet(IEnumerable<string> tokens, ParseResult context)
        {
            return tokens;
        }

        public override long ResolveCompositeNumber(string numberStr)
        {
            return 0;
        }
    }
}
