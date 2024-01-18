﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Examples
{
    class TextWriterTraceListenerExample
    {
        public static void TraceListenerExample()
        {

            // Create a file for output named TestFile.txt.
            Stream myFile = File.Create("TestFile.txt");

            /* Create a new text writer using the output stream, and add it to the trace listeners. */
            TextWriterTraceListener myTextListener = new TextWriterTraceListener(myFile);
            Trace.Listeners.Add(myTextListener);

            // Write output to the file.
            Trace.Write("Test output ");

            // Flush the output.
            Trace.Flush();

            //return 0;
        }
    }
}
