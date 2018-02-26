
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_LUISProgrammaticAPI
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Apps", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Examples", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Features", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Model", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Permissions", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Train", "v2.0"),
                new Tuple<string, string, string>("LUISProgrammaticAPI", "Versions", "v2.0"),
            }.AsEnumerable();
        }
    }
}
