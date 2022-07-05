// See https://aka.ms/new-console-template for more information
using AdapterPattern;

TwoPinSocket twoPinSocket = new TwoPinSocket(); //目标接口
twoPinSocket.Charge();

//想让两脚插座能实现三脚的功能

ThreePinSocket threePinSocket = new ThreePinSocket();
IPin pin = new ThreePinAdapter(threePinSocket);
pin.Charge();

