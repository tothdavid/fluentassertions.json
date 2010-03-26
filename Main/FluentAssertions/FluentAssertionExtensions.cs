﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace FluentAssertions
{
    /// <summary>
    /// Contains extension methods for custom assertions in unit tests.
    /// </summary>
    [DebuggerNonUserCode]
    public static  class FluentAssertionExtensions
    {
        public static ThrowAssertions<T> ShouldThrow<T>(this T actualValue, Action<T> action)
        {
            return new ThrowAssertions<T>(actualValue, action);
        }

        public static ThrowAssertions<Action> ShouldThrow(this Action action)
        {
            return new ThrowAssertions<Action>(action);
        }

        public static ObjectAssertions Should(this object actualValue)
        {
            return new ObjectAssertions(actualValue);
        }

        public static BooleanAssertions Should(this bool actualValue)
        {
            return new BooleanAssertions(actualValue);
        }

        public static NullableBooleanAssertions Should(this bool? actualValue)
        {
            return new NullableBooleanAssertions(actualValue);
        }

        public static NonGenericCollectionAssertions Should(this IEnumerable actualValue)
        {
            return new NonGenericCollectionAssertions(actualValue);
        }

        public static GenericCollectionAssertions<T> Should<T>(this IEnumerable<T> actualValue)
        {
            return new GenericCollectionAssertions<T>(actualValue);
        }

        public static DateTimeAssertions Should(this DateTime actualValue)
        {
            return new DateTimeAssertions(actualValue);
        }

        public static NullableDateTimeAssertions Should(this DateTime? actualValue)
        {
            return new NullableDateTimeAssertions(actualValue);
        }

        public static NumericAssertions<int> Should(this int actualValue)
        {
            return new NumericAssertions<int>(actualValue);
        }

        public static NullableNumericAssertions<int> Should(this int? actualValue)
        {
            return new NullableNumericAssertions<int>(actualValue);
        }

        public static NumericAssertions<long> Should(this long actualValue)
        {
            return new NumericAssertions<long>(actualValue);
        }

        public static NullableNumericAssertions<long> Should(this long? actualValue)
        {
            return new NullableNumericAssertions<long>(actualValue);
        }

        public static NumericAssertions<float> Should(this float actualValue)
        {
            return new NumericAssertions<float>(actualValue);
        }

        public static NullableNumericAssertions<float> Should(this float? actualValue)
        {
            return new NullableNumericAssertions<float>(actualValue);
        }

        public static NumericAssertions<double> Should(this double actualValue)
        {
            return new NumericAssertions<double>(actualValue);
        }

        public static NullableNumericAssertions<double> Should(this double? actualValue)
        {
            return new NullableNumericAssertions<double>(actualValue);
        }

        public static StringAssertions Should(this string actualValue)
        {
            return new StringAssertions(actualValue);
        }

        public static PropertyAssertions<T> ShouldHave<T>(this T subject)
        {
            return new PropertyAssertions<T>(subject);
        }

    }
}