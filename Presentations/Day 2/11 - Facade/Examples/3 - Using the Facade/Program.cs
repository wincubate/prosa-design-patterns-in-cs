using Wincubate.FacadeExamples;
using Wincubate.FacadeExamples.ApplicationApi; // <--- Notice this is not needed
using Wincubate.FacadeExamples.SettingsApi;    // <--- Notice this is not needed

LongWalkFacade facade = new();
facade.Set();

Console.WriteLine( $"{Environment.NewLine}Long Walk beginning... :-)" );
Thread.Sleep(5000);
Console.WriteLine($"Long Walk ended :-){Environment.NewLine}");

facade.Revert();
