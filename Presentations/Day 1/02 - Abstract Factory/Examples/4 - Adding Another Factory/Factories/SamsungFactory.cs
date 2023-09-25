namespace Wincubate.AbstractFactoryExamples;

class SamsungFactory : IDeviceFactory
{
    public IMobilePhone CreateMobilePhone() => new SamsungS22(S22Kind.Plus);
    public ITablet CreateTablet() => new SamsungGalaxyTab("S3");
}
