﻿using NUnit.Framework;

namespace AngleSharp.Core.Tests.Library
{
    [TestFixture]
    public class UrlTests
    {
        [Test]
        public void ValidityOfValidGoogleHostnameAddress()
        {
            var address = "http://www.google.de";
            var result = new Url(address);
            Assert.IsFalse(result.IsInvalid);
        }

        [Test]
        public void ValidityOfValidGoogleHostnameAndPathEmptyAddress()
        {
            var address = "http://www.google.de/";
            var result = new Url(address);
            Assert.IsFalse(result.IsInvalid);
        }

        [Test]
        public void ValidityOfValidGoogleHostnameAndPathAddress()
        {
            var address = "http://www.google.de/some-path";
            var result = new Url(address);
            Assert.IsFalse(result.IsInvalid);
        }

        [Test]
        public void ValidityOfValidGoogleHostnameAndPathAndFragmentEmptyAddress()
        {
            var address = "http://www.google.de/some-path#";
            var result = new Url(address);
            Assert.IsFalse(result.IsInvalid);
        }

        [Test]
        public void ValidityOfValidGoogleHostnameAndPathAndQueryAndFragmentAddress()
        {
            var address = "http://www.google.de/some-path?a=b#header";
            var result = new Url(address);
            Assert.IsFalse(result.IsInvalid);
        }

        [Test]
        public void ValidityOfInvalidFragmentEmptyHostnameAddress()
        {
            var address = "http://#foo";
            var result = new Url(address);
            Assert.IsTrue(result.IsInvalid);
        }
    }
}
