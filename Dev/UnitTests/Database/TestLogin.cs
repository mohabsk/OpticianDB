﻿/*
 * Copyright (c) 2011 Geoffrey Prytherch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using NUnit.Framework;

#if TEST
namespace OpticianDB.Dev.UnitTests.Database
{
	[TestFixture]
	public class TestLogin
	{
		DBBackEnd dbb;
		[Test]
		public void Test10()
		{
			if (!dbb.LogOn("admin", "admin"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test11()
		{
			if (dbb.LogOn("admin", "admin2"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test12()
		{
			if (dbb.LogOn("ADMIN", "admin"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test13()
		{
			if (dbb.LogOn("notmin", "admin"))
			{
				Assert.Fail();
			}
		}

		[TestFixtureSetUp]
		public void Init()
		{
			dbb = new DBBackEnd(); // if user doesnt exist create user / password like
		}

		[TestFixtureTearDown]
		public void Dispose()
		{
			dbb.Dispose();
		}
	}
}
#endif