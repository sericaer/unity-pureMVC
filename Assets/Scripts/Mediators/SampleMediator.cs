using UnityEngine;
using PureMVC.Patterns.Mediator;
using PureMVC.Interfaces;
using PureMVC.Core;
using System.Collections.Generic;
using System;
/// <summary>
/// Sample mediators.
/// </summary>
public class SampleMediator :  Mediator{

	//member data
	//m_mediatorName
	//m_viewComponent
	//NAME="Mediator"

	//get set
	//ViewComponent
	//MediatorName {get]
	//public static string NAME="smapleMediator";
	//private IList<string> notificationList=new List<string>();

	//public SampleMediator()
	//{
	//	init ();
	//}
	//public SampleMediator(string mediatorName):base(mediatorName)
	//{
	//	init ();
	//}
	//public SampleMediator(string mediatorName,object viewComponent):base(mediatorName,viewComponent)
	//{
	//	init ();
	//}

	//private void init()
	//{
 //       //notificationList.Add(typeof(Notification).Name);
	//}

	public override void HandleNotification(INotification notification)
	{
        Debug.Log("Receive " + notification.Name);
        Demo.Update((Notification)notification.Body);
	}

	public override string[] ListNotificationInterests()
	{
        List<string> notificationList = new List<string>();
        notificationList.Add(typeof(Notification).Name);
        return notificationList.ToArray();
	}

	public override void OnRegister()
	{
		Debug.Log (MediatorName+ " onRegisterd.");
	}
	public override void OnRemove ()
	{
		
	}

}
