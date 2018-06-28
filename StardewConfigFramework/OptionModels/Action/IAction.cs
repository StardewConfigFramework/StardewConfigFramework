﻿using System;
namespace StardewConfigFramework.Options {
	public interface IAction: IModOption {
		event ActionHandler ActionWasTriggered;
		ActionType Type { get; set; }
		void Trigger();
	}

	public delegate void ActionHandler(Action action);

	public enum ActionType {
		OK, SET, CLEAR, DONE, GIFT
	}
}
