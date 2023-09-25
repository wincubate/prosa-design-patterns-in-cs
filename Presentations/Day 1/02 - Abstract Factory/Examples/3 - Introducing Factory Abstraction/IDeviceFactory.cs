namespace Wincubate.AbstractFactoryExamples;

interface IDeviceFactory
{
    IMobilePhone CreateMobilePhone();
    ITablet CreateTablet();
}
