﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PlanitWebAppTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Contact Us")]
    public partial class ContactUsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactUs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Contact Us", "\tIn order to make a general enquiry\r\n\tAs a job seeker\r\n\tI want to be able to make" +
                    " contact Planit", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
testRunner.Given("I am on Planit\'s \'Contact Us\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No job title submitted")]
        [NUnit.Framework.CategoryAttribute("contactUs")]
        [NUnit.Framework.TestCaseAttribute("Dogalisk", "eeeee", null)]
        [NUnit.Framework.TestCaseAttribute("yyy", "eeeerrr", null)]
        [NUnit.Framework.TestCaseAttribute("test3", "yeh", null)]
        public virtual void NoJobTitleSubmitted(string firstName, string lastName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "contactUs"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No job title submitted", null, @__tags);
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 11
 testRunner.Given(string.Format("I have entered a first name of {0}", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And(string.Format("I have entered a last name of {0}", lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.But("no job title has been specified", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 14
 testRunner.When("I submit my enquiry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("an error prompt for blank job title appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No email address submitted")]
        [NUnit.Framework.CategoryAttribute("contactUs")]
        [NUnit.Framework.TestCaseAttribute("Dogalisk", "eeeee", null)]
        [NUnit.Framework.TestCaseAttribute("yyy", "eeee", null)]
        [NUnit.Framework.TestCaseAttribute("test3", "yeh", null)]
        public virtual void NoEmailAddressSubmitted(string firstName, string lastName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "contactUs"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No email address submitted", null, @__tags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 26
 testRunner.Given(string.Format("I have entered a first name of {0}", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And(string.Format("I have entered a last name of {0}", lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.But("there has been no specified email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 29
 testRunner.When("I submit my enquiry", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("an error prompt for blank email address appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
