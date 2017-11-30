// Math.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System {

    /// <summary>
    /// Equivalent to the Math object in Javascript.
    /// </summary>
    [ScriptIgnoreNamespace]
    [ScriptImport]
    public static class Math {

        [ScriptName(PreserveCase = true)]
        public static double E;

        [ScriptName(PreserveCase = true)]
        public static double LN2;

        [ScriptName(PreserveCase = true)]
        public static double LN10;

        [ScriptName(PreserveCase = true)]
        public static double LOG2E;

        [ScriptName(PreserveCase = true)]
        public static double LOG10E;

        [ScriptName(PreserveCase = true)]
        public static double PI;

        [ScriptName(PreserveCase = true)]
        public static double SQRT1_2;

        [ScriptName(PreserveCase = true)]
        public static double SQRT2;

        public static extern Int16 Abs(Int16 value);

        public static extern Int32 Abs(Int32 value);

        public static extern Int64 Abs(Int64 value);

        public static extern Single Abs(Single value);

        public static extern Double Abs(Double value);

        public static extern Decimal Abs(Decimal value);

        public static extern Double Acos(Double value);

        public static extern Double Asin(Double value);

        public static extern Double Atan(Double value);

        public static extern Double Atan2(Double value);

        public static extern Double Ceil(Double value);

        public static extern Double Cos(Double value);

        public static extern Double Cosh(Double value);

        public static extern Double Pow(Double baseNumber, Double exponent);

        public static extern Double Exp(Double value);

        public static extern Double Floor(Double value);

        public static extern Decimal Floor(Decimal value);

        public static extern Double Log(Double value);

        public static extern Double Log10(Double value);

        public static extern Double Sin(Double value);

        public static extern Double Sinh(Double value);

        public static extern Double Sqrt(Double value);

        public static extern Double Tan(Double value);

        public static extern Double Tanh(Double value);

        [CLSCompliant(false)]
        public static extern SByte Min(SByte first, SByte second);

        [CLSCompliant(false)]
        public static extern Byte Min(Byte first, Byte second);

        public static extern Int16 Min(Int16 first, Int16 second);

        [CLSCompliant(false)]
        public static extern UInt16 Min(UInt16 first, UInt16 second);

        public static extern Int32 Min(Int32 first, Int32 second);

        [CLSCompliant(false)]
        public static extern UInt32 Min(UInt32 first, UInt32 second);

        public static extern Int64 Min(Int64 first, Int64 second);

        [CLSCompliant(false)]
        public static extern UInt64 Min(UInt64 first, UInt64 second);

        public static extern Single Min(Single first, Single second);

        public static extern Double Min(Double first, Double second);

        public static extern Decimal Min(Decimal first, Decimal second);

        [CLSCompliant(false)]
        public static extern SByte Max(SByte first, SByte second);

        [CLSCompliant(false)]
        public static extern Byte Max(Byte first, Byte second);

        public static extern Int16 Max(Int16 first, Int16 second);

        [CLSCompliant(false)]
        public static extern UInt16 Max(UInt16 first, UInt16 second);

        public static extern Int32 Max(Int32 first, Int32 second);

        [CLSCompliant(false)]
        public static extern UInt32 Max(UInt32 first, UInt32 second);

        public static extern Int64 Max(Int64 first, Int64 second);

        [CLSCompliant(false)]
        public static extern UInt64 Max(UInt64 first, UInt64 second);

        public static extern Single Max(Single first, Single second);

        public static extern Double Max(Double first, Double second);

        public static extern Decimal Max(Decimal first, Decimal second);

        public static extern Double Round(Double value);

        [ScriptAlias("ss.truncate")]
        public static extern int Truncate(double value);

        [ScriptAlias("ss.truncate")]
        public static extern int Truncate(float value);
    }
}
