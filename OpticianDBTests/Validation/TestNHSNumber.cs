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
	public class TestNHSNumber
	{
		[TestMethod]
		public void Test6()
		{
			if (!Patient.NhsNumber("450 557 7104"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test7()
		{
			if (!Patient.NhsNumber("432 678 9123"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test8()
		{
			if (Patient.NhsNumber("123 456 7890"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test9()
		{
			if (Patient.NhsNumber("99"))
			{
				Assert.Fail();
			}
		}

	}
}
