﻿/*
 * Copyright (c) 2020 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.I18n.Contracts;
using SafeExamBrowser.UserInterface.Contracts.MessageBox;

namespace SafeExamBrowser.Runtime.Operations.Events
{
	internal class NotSupportedMessageArgs : MessageEventArgs
	{
		internal NotSupportedMessageArgs(string uri)
		{
			Icon = MessageBoxIcon.Error;
			Message = TextKey.MessageBox_NotSupportedConfigurationResource;
			MessagePlaceholders["%%URI%%"] = uri;
			Title = TextKey.MessageBox_NotSupportedConfigurationResourceTitle;
		}
	}
}