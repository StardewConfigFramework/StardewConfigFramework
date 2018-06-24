﻿
namespace StardewConfigFramework.Options {

	public class Toggle: ModOption {
		public delegate void Handler(Toggle toggle);
		public event Handler StateDidChange;

		public Toggle(string identifier, string labelText, bool isOn = true, bool enabled = true) : base(identifier, labelText, enabled) {
			IsOn = isOn;
		}

		public bool IsOn {
			get {
				return _isOn;
			}
			set {
				if (_isOn == value)
					return;

				_isOn = value;
				StateDidChange?.Invoke(this);
			}
		}

		private bool _isOn;

		public void Flip() {
			IsOn = !IsOn;
		}
	}
}
