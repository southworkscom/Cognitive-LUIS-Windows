
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_LUISRuntimeAPI
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("LUISRuntimeAPI", "Prediction", "v2.0"),
            }.AsEnumerable();
        }
    }
}
