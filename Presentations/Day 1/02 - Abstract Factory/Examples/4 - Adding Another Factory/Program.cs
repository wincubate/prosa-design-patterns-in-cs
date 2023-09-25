using Wincubate.AbstractFactoryExamples;

// HR New Employee Process

IDeviceFactory factory = new SamsungFactory(); // <-- Only(!) reference to vendor

IMobilePhone phone = factory.CreateMobilePhone();
phone.Call("+45 12345678");

ITablet tablet = factory.CreateTablet();
tablet.PowerOn();
tablet.PowerOff();
