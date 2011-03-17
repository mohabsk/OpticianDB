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
using NUnit.Framework;

#if TEST
namespace OpticianDB.Dev.UnitTests
{
    [TestFixture]
    public class TestValidation
    {
        [Test]
        public void TestNHSNumber()
        {
            if (!Validation.Patient.NHSNumber("450 557 7104"))
            {
                Assert.Fail("Validation 1 Failed");
            }
            if (!Validation.Patient.NHSNumber("432 678 9123"))
            {
                Assert.Fail("Validation 2 Failed");
            }
            if (Validation.Patient.NHSNumber("123 456 7890"))
            {
                Assert.Fail("Validation 3 Failed");
            }
            if (Validation.Patient.NHSNumber("99"))
            {
                Assert.Fail("Validation 4 Failed");
            }
            Assert.Pass("NHS Number validation passed");

        }
        [Test]
        public void TestEmail()
        {
            if (!Validation.Patient.Email("someguy@somedomain.org"))
            {
                Assert.Fail("Validation 1 Failed");
            }
            if (!Validation.Patient.Email("someguy@some-subdomain.somedomain.org.uk"))
            {
                Assert.Fail("Validation 2 Failed");
            }
            if (!Validation.Patient.Email("1234@sdomain.me.uk"))
            {
                Assert.Fail("Validation 3 Failed");
            }
            if (!Validation.Patient.Email("webmaster@raf.museum"))
            {
                Assert.Fail("Validation 4 Failed");
            }
            if (Validation.Patient.Email("email@domain"))
            {
                Assert.Fail("Validation 5 Failed");
            }
            Assert.Pass("Email validation passed");
        }
    }
}
#endif