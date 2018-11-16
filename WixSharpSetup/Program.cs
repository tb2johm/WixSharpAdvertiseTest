using System;
using WixSharp;

namespace WixSharpSetup
{
    class Program
    {
        static void Main()
        {
            var project = new Project("FooBar",
                             new Dir(@"%ProgramFiles%\foo\bar",
                                 new File(@"..\..\..\FooBar\bin\debug\foobar.exe",
                                     new FileShortcut("FooBar", @"%ProgramMenu%\FooBar") {WorkingDirectory = "[INSTALLDIR]", Advertise = true})
                            ));

            project.GUID = new Guid("{43A6B2F2-0212-484D-901B-ACC3C812569A}");
            project.OutDir = "../..";
            project.UI = WUI.WixUI_ProgressOnly;

            project.BuildMsi();
        }
    }
}