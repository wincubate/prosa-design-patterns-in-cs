using Wincubate.AbstractFactoryExamples;

// HR New Employee Process

IMobilePhone phone = new IPhone13(128);
phone.Call("+45 12345678");

ITablet tablet = new Ipad("Air", 10.9);
tablet.PowerOn();
tablet.PowerOff();
