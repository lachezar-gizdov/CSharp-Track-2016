namespace Defining_classes
{
    using System;
    using System.Collections.Generic;
    class App
    {
        static void Main()
        {
            var phoneBattery = new Battery("Li-Io", 36, 10);
            var phone = new GSM("LG", "Nexus 5X", 600, "Lucho", phoneBattery);

            phone.DisplayInfo();
        }        
    }
}