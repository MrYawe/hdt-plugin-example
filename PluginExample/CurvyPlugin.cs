﻿using System;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;

namespace PluginExample
{
	public class CurvyPlugin : IPlugin
	{
		public string Author
		{
			get { return "andburn"; }
		}

		public string ButtonText
		{
			get { return "Setttings"; }
		}

		public string Description
		{
			get { return "An simple example plugin showing oppoents class cards on curve."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "Curvy"; }
		}

		public void OnButtonPress()
		{
		}

		public void OnLoad()
		{
			var canvas = Hearthstone_Deck_Tracker.API.Core.OverlayCanvas;
			var curvyList = new CurvyList();
			canvas.Children.Add(curvyList);
			Curvy curvy = new Curvy(curvyList);
			GameEvents.OnInMenu.Add(curvy.InMenu);
			GameEvents.OnTurnStart.Add(curvy.TurnStart);
		}

		public void OnUnload()
		{
		}

		public void OnUpdate()
		{
		}

		public Version Version
		{
			get { return new Version(0, 1, 0); }
		}
	}
}