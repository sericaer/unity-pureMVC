using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using PureMVC.Interfaces;
using System;
using PureMVC.Patterns.Facade;

public class UnityFacade : Facade
{

	public const string STARTUP = "UnityFacade.StartUp";


	// Override Singleton Factory method
	public static UnityFacade GetInstance ()
	{

		if (m_instance == null) {
			m_instance = new UnityFacade ();
		}
		return m_instance as UnityFacade;
	}

	//InitialController used for initial first functions.
	protected override void InitializeController ()
	{
		base.InitializeController ();
		RegisterCommand (STARTUP, ()=> { return new StartUpCommand(); });
	}

	public void StartUp ()
	{
		SendNotification (STARTUP);
	}
	/*
	//Handle IMediatorPlug connection
	public void ConnectMediator( IMediatorPlug item )
	{
		Type mediatorType = Type.GetType( item.GetClassRef() );
		if( mediatorType!=null){
			IMediator mediatorPlug = (IMediator)Activator.CreateInstance( mediatorType, item.GetName(), item.GetView() ) ;
			RegisterMediator( mediatorPlug );
		}
	}

	public void DisconnectMediator( string mediatorName )
	{
		RemoveMediator( mediatorName );
	}
	*/
}
