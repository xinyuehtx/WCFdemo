using System.ServiceModel;

namespace HelloWorld
{
    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        void SayHello();
    }
}