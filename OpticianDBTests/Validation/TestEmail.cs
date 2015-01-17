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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianDB.Validation;

namespace OpticianDBTests
{
    [TestClass]
	public class TestEmail
	{
		[TestMethod]
		public void Test1()
		{
			if (!Patient.Email("someguy@somedomain.org"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test2()
		{
			if (!Patient.Email("someguy@some-subdomain.somedomain.org.uk"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test3()
		{
			if (!Patient.Email("1234@sdomain.me.uk"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test4()
		{
			if (!Patient.Email("webmaster@raf.museum"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test5()
		{
			if (Patient.Email("email@domain"))
			{
				Assert.Fail();
			}
		}
	}
}
