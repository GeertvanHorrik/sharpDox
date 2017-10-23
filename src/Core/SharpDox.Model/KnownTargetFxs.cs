﻿using SharpDox.Model.Repository;

namespace SharpDox.Model
{
    public static class KnownTargetFxs
    {
        public static readonly SDTargetFx Net30 = new SDTargetFx
        {
            Identifier = "NET30",
            Name = ".NET Framework 3.0"
        };

        public static readonly SDTargetFx Net35 = new SDTargetFx
        {
            Identifier = "NET35",
            Name = ".NET Framework 3.5"
        };

        public static readonly SDTargetFx Net40 = new SDTargetFx
        {
            Identifier = "NET40",
            Name = ".NET Framework 4.0"
        };

        public static readonly SDTargetFx Net45 = new SDTargetFx
        {
            Identifier = "NET45",
            Name = ".NET Framework 4.5"
        };

        public static readonly SDTargetFx Net46 = new SDTargetFx
        {
            Identifier = "NET46",
            Name = ".NET Framework 4.6"
        };

        public static readonly SDTargetFx Net461 = new SDTargetFx
        {
            Identifier = "NET461",
            Name = ".NET Framework 4.6.1"
        };

        public static readonly SDTargetFx Net462 = new SDTargetFx
        {
            Identifier = "NET462",
            Name = ".NET Framework 4.6.2"
        };

        public static readonly SDTargetFx Net47 = new SDTargetFx
        {
            Identifier = "NET47",
            Name = ".NET Framework 4.7"
        };

        public static readonly SDTargetFx Silverlight5 = new SDTargetFx
        {
            Identifier = "SL5",
            Name = "Silverlight 5"
        };

        public static readonly SDTargetFx WindowsPhone80 = new SDTargetFx
        {
            Identifier = "WP80",
            Name = "Windows Phone 8.0"
        };

        public static readonly SDTargetFx WindowsPhone81Silverlight = new SDTargetFx
        {
            Identifier = "WP81SL",
            Name = "Windows Phone 8.1 (Silverlight)"
        };

        public static readonly SDTargetFx WindowsPhone81Runtime = new SDTargetFx
        {
            Identifier = "WP81RT",
            Name = "Windows Phone 8.1 (Runtime)"
        };

        public static readonly SDTargetFx Windows81 = new SDTargetFx
        {
            Identifier = "WIN81",
            Name = "Windows 8.1"
        };

        public static readonly SDTargetFx Windows100 = new SDTargetFx
        {
            Identifier = "WIN100",
            Name = "Windows 10.0 (Universal Apps)"
        };

        public static readonly SDTargetFx XamarinAndroid = new SDTargetFx
        {
            Identifier = "Xamarin.Android",
            Name = "Xamarin - Android"
        };

        public static readonly SDTargetFx XamariniOS = new SDTargetFx
        {
            Identifier = "Xamarin.iOS",
            Name = "Xamarin - iOS"
        };

        public static readonly SDTargetFx Pcl = new SDTargetFx
        {
            Identifier = "PCL",
            Name = "Portable Class Libraries"
        };

        public static readonly SDTargetFx NetStandard = new SDTargetFx
        {
            Identifier = "NS",
            Name = ".NET Standard (unknown version)"
        };

        public static readonly SDTargetFx NetStandard10 = new SDTargetFx
        {
            Identifier = "NS10",
            Name = ".NET Standard 1.0"
        };

        public static readonly SDTargetFx NetStandard11 = new SDTargetFx
        {
            Identifier = "NS11",
            Name = ".NET Standard 1.1"
        };

        public static readonly SDTargetFx NetStandard12 = new SDTargetFx
        {
            Identifier = "NS12",
            Name = ".NET Standard 1.2"
        };

        public static readonly SDTargetFx NetStandard13 = new SDTargetFx
        {
            Identifier = "NS13",
            Name = ".NET Standard 1.3"
        };

        public static readonly SDTargetFx NetStandard14 = new SDTargetFx
        {
            Identifier = "NS14",
            Name = ".NET Standard 1.4"
        };

        public static readonly SDTargetFx NetStandard15 = new SDTargetFx
        {
            Identifier = "NS15",
            Name = ".NET Standard 1.5"
        };

        public static readonly SDTargetFx NetStandard16 = new SDTargetFx
        {
            Identifier = "NS16",
            Name = ".NET Standard 1.6"
        };

        public static readonly SDTargetFx NetStandard20 = new SDTargetFx
        {
            Identifier = "NS20",
            Name = ".NET Standard 2.0"
        };

        public static readonly SDTargetFx Unknown = new SDTargetFx
        {
            Identifier = "Unknown",
            Name = "Unknown"
        };
    }
}