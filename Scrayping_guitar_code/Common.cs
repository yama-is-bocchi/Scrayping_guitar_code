using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrayping_guitar_code
{
    internal class Common
    {
        public static List<string> num_List = new List<string>() {  "Ⅰ",
                                                                    "Ⅰ#",
                                                                    "Ⅱ♭",
                                                                    "Ⅱ",
                                                                    "Ⅱ#",
                                                                    "Ⅲ♭",
                                                                    "Ⅳ",
                                                                    "Ⅳ#",
                                                                    "Ⅴ♭",
                                                                    "Ⅴ",
                                                                    "Ⅴ#",
                                                                    "Ⅵ♭",
                                                                    "Ⅵ",
                                                                    "Ⅵ#",
                                                                    "Ⅶ♭",
                                                                    "Ⅶ",
                                                                    "Ⅰ♭",
                                                                    };

        public static ReadOnlyCollection<string> readOnlynum =
            new ReadOnlyCollection<string>(num_List);

        public static List<string> code_List = new List<string>() {  "C",
                                                                    "C#",
                                                                    "D♭",
                                                                    "D",
                                                                    "D#",
                                                                    "E♭",
                                                                    "E",
                                                                    "E#",
                                                                    "F♭",
                                                                    "F",
                                                                    "F#",
                                                                    "G♭",
                                                                    "G",
                                                                    "G#",
                                                                    "G♭",
                                                                    "G",
                                                                    "C♭",
                                                                    };

        public static ReadOnlyCollection<string> readOnlycode =
            new ReadOnlyCollection<string>(code_List);
    }
}
