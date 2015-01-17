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
	public class TestName
	{
		
		[TestMethod]
		public void Test14()
		{
			if (!Patient.Name("Geoffrey Shaun Prytherch"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test15()
		{
			if (!Patient.Name("Mahershalalhashbaz Ali"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test16()
		{
			if (!Patient.Name("Roberto Garcia-Ramirez"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test17()
		{
			if (Patient.Name("E1234 56rror"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test18()
		{
			if (Patient.Name("geoffrey prytherch"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test19()
		{
			if (!Patient.Name("Dara O'Briain"))
			{
				Assert.Fail();
			}
		}
		[TestMethod]
		public void Test20()
		{
			if(Patient.Name("-Geoffrey Prytherch"))
			{
				Assert.Fail();
			}
			
		}
	}
}