#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace HelloPhobos
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class HelloPhobosProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new HelloPhobos())
                game.Run();
        }
    }
#endif
}
