﻿/*
 * Copyright (c) 2020 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Server.Contracts.Events
{
	/// <summary>
	/// Event handler used to indicate that a termination instruction has been detected.
	/// </summary>
	public delegate void TerminationRequestedEventHandler();
}
