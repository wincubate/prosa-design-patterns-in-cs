namespace Wincubate.AbstractFactoryExamples;

class AppleFactory : IDeviceFactory
{
    public IMobilePhone CreateMobilePhone() => new IPhone13(128); // <-- now easy change to 256 GB
    public ITablet CreateTablet() => new Ipad("Air", 10.9); // <-- now easy change to 12.8"
}