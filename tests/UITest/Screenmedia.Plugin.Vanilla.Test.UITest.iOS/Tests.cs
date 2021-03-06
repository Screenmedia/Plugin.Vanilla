﻿// -----------------------------------------------------------------------
//  <copyright file="Tests.cs" company="Screenmedia">
//      Copyright (c) Screenmedia 2018. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------
namespace Screenmedia.Plugin.Vanilla.Test.UITest.iOS
{
    using NUnit.Framework;
    using Xamarin.UITest;
    using Xamarin.UITest.iOS;

    [TestFixture]
    public class Tests
    {
        private iOSApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the iOS app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //
            // The iOS project should have the Xamarin.TestCloud.Agent NuGet package
            // installed. To start the Test Cloud Agent the following code should be
            // added to the FinishedLaunching method of the AppDelegate:
            //
            //    #if ENABLE_TEST_CLOUD
            //    Xamarin.Calabash.Start();
            //    #endif
            app = ConfigureApp
                .iOS
                //// TODO: Update this path to point to your iOS app and uncomment the code if the app is not included in the solution.
                .AppBundle("../../../../TestApp/Screenmedia.Plugin.Vanilla.Test.TestApp.iOS/bin/iPhoneSimulator/Debug/Screenmedia.Plugin.Vanilla.Test.TestApp.iOS.app")
                .StartApp();
        }

        [Test]
        public void DispenseCorrectIceCream()
        {
            app.WaitForElement(c => c.Marked("Strawberry").Class("UILabel"));
        }
    }
}
