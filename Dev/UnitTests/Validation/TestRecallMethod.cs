/*
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
#if TEST

using System;
using OpticianDB.Adaptor;
using OpticianDB.Validation;
using NUnit.Framework;

namespace OpticianDB.Dev.UnitTests.Validation
{
	[TestFixture]
	public class TestRecallMethod
	{
		[Test]
		public void Test29()
		{
			if (!Patient.RecallMethod("Email",
			                          null,
			                          "email@domain.com",
			                          null))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test30()
		{
			if (!Patient.RecallMethod("Post",
			                          "123 Somestreet\nSometown\nA123BC",
			                          null,
			                          null))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test31()
		{
			if (!Patient.RecallMethod("Phone",
			                          null,
			                          null,
			                          "01234567890"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test32()
		{
			
			if (!Patient.RecallMethod("Post",
			                          "123 Somestreet\nSometown\nA123BC",
			                          "email@domain.com",
			                          "01234567890"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test33()
		{
			if (Patient.RecallMethod("Email",
			                         "123 Somestreet\nSometown\nA123BC",
			                         null,
			                         "01234567890"))
			{
				Assert.Fail();
			}
		}
	}
}
#endif
