using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

public class StartUpCommand : SimpleCommand {

	public override void Execute(PureMVC.Interfaces.INotification notification)
	{
		Debug.Log("Execute StartUpCommand");
		//RegisterProxy used for registering default proxies
		Facade.RegisterProxy( new SampleProxy(SampleProxy.NAME ) );
		Facade.RegisterMediator (new SampleMediator());
		//Facade.RegisterProxy( new Count2Proxy( Count2Proxy.NAME ) );

		SampleProxy proxy=Facade.RetrieveProxy (SampleProxy.NAME) as SampleProxy;

		//SendNotification
		proxy.CallFunc ();

		//SampleMediator shoud log info in 

	}
}
