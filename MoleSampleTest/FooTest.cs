using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Moles.Framework;
using NUnit.Framework;
using MoleSample;

namespace MoleSampleTest
{
    [TestFixture]
    public class FooTest
    {
        IDisposable _moleContext;

        [SetUp]
        public void Init()
        {
            _moleContext = MolesContext.Create();
        }

        [TearDown]
        public void Cleanup()
        {
            if (_moleContext != null)
                _moleContext.Dispose();
        }

        [Test]
        public void passes_correct_filename()
        {
            string expectedFilename = "applicationPath:name.txt";
            FileMode expectedFileMode = FileMode.Open;
            bool wasMoleCalled = false;

            System.IO.Moles.MFile.OpenStringFileMode = delegate(string filename, FileMode fileMode)
                {
                    Assert.That(filename, Is.EqualTo(expectedFilename));
                    Assert.That(fileMode, Is.EqualTo(expectedFileMode));
                    wasMoleCalled = true;

                    return null;
                };


            var sut = new Foo();

            sut.ConfigDirectory = "applicationPath:";

            sut.GetTextFile("name");

            Assert.That(wasMoleCalled, Is.True);
        }
    }
}
