using System;

// The namespace makes it easier to organize our application and 
// avoid name collisions with other code
namespace HelloWorld
{

 class Enums  {
   enum Weekdays { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
   enum Days { WeekDay, WeekEnd };

   static void Main(string []args) {
     System.Console.WriteLine("cmdline arg: {0}", args[0]);
     if (args.Length != 1) { 
        System.Console.WriteLine(Weekdays.Mon);
     } else {
       Weekdays z = Weekdays.Mon; // needed for parsing
       Weekdays d = (Weekdays)Enum.Parse(z.GetType(), args[0]);
       Enums.Test(d);
       Enums.Test(Weekdays.Sun);
     }
   }
   static void Test(Weekdays d) {
      Days d0 = Enums.WhatDay(d);
      System.Console.WriteLine("Testing some enums now...");
      Weekdays e = Enums.NextDay(d);
      Days e0 = Enums.WhatDay(e);
      System.Console.WriteLine("Tomorrow of "+d+" (a "+d0+") is "+e+" (a "+e0+")");
      Weekdays f = Enums.NextDay1(d);
      Days f0 = Enums.WhatDay(f);
      System.Console.WriteLine("Tomorrow of "+d+" (a "+d0+") is "+f+" (a "+f0+")");
   }

   static Weekdays NextDay(Weekdays d) {
     // using a switch statement here
     Weekdays e;
     switch (d) {
       case Weekdays.Mon: e=Weekdays.Tue; break;
       case Weekdays.Tue: e=Weekdays.Wed; break;
       case Weekdays.Wed: e=Weekdays.Thu; break;
       case Weekdays.Thu: e=Weekdays.Fri; break;
       case Weekdays.Fri: e=Weekdays.Sat; break;
       case Weekdays.Sat: e=Weekdays.Sun; break;
       case Weekdays.Sun: e=Weekdays.Mon; break;
       default: e=Weekdays.Mon; break; // needs default case to init e
     }
     return e;
   }
   static Weekdays NextDay1(Weekdays d) {
     Weekdays e = (Weekdays)((int)(d+1) % 7);     // uses implicit conversions and int as basetype
     return e;
   }
   static Days WhatDay(Weekdays d) {
     switch (d) {
       case Weekdays.Mon: 
       case Weekdays.Tue: 
       case Weekdays.Wed: 
       case Weekdays.Thu: 
       case Weekdays.Fri: 
	 return Days.WeekDay;
       case Weekdays.Sat: 
       case Weekdays.Sun: 
	 return Days.WeekEnd;
       default:
	 return Days.WeekEnd;
     }
   }
}


}