﻿using System;

namespace YandexLinguistics.NET
{
	[Flags]
	public enum LookupOptions
	{
		Family = 0x0001,
		Morpho = 0x0004,
		PartOfSpeechFilter = 0x0008
	}
}
