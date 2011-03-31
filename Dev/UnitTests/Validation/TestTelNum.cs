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
using NUnit.Framework;
using OpticianDB.Validation;

namespace OpticianDB.Dev.UnitTests.Validation
{
	[TestFixture]
	public class TestTelNum
	{
		[Test]
		public void Test22()
		{
			if(!Patient.TelNum("01704890000"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test23()
		{
			if(!Patient.TelNum("02074558888"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test24()
		{
			if(!Patient.TelNum("07754456911"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test25()
		{
			if(!Patient.TelNum("01515982233"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test26()
		{
			if(Patient.TelNum("04018223719"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test27()
		{
			if(!Patient.TelNum("+34952112628"))
			{
				Assert.Fail();
			}
		}
		[Test]
		public void Test28()
		{
			if(Patient.TelNum("123"))
			{
				Assert.Fail();
			}
		}
	}
}
#endif
