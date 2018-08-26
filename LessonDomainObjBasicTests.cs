using CWMasterTeacherDataModel.ObjectBuilders;
using CWMasterTeacherDomain;
using CWMasterTeacherDomain.DomainObjects;
using CWMasterTeacherDomain.ViewObjects;
using CWMasterTeacherService.ViewObjectBuilder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[Ability][Action][MethodName],
//For getters:
//Can_Get_Name

//For conditionals/loops:
//Can_BranchToIf_SomeMethod

//For dependencies:
//Can_AccessDependencyName_SomeMethod
//[Subject]_[Scenario] _[Result]

namespace CWTesting.Tests.CWMasterTeacherDomain.DomainObjects
{
    [TestFixture]
    class LessonDomainObjBasicTests
    {
        public Mock_De_Mocks mocks;
        public LessonDomainObjBasic realLDOB;
        public string expected;

        public LessonDomainObjBasicTests()
        {
            realLDOB = new LessonDomainObjBasic();
            mocks = new Mock_De_Mocks();

            realLDOB = new LessonDomainObjBasic();
            realLDOB = mocks.MockLessonDomainObjBasic;
        }

        #region setter/getter tests
        [Test]
        [Author("Kevin")]
        public void Can_Get_Name()
        {
            expected = $"{mocks.DefaultName}";
            Assert.AreEqual(expected, realLDOB.Name);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_Id()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.Id, realLDOB.Id);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_IsMaster()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.IsMaster);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.IsMaster, realLDOB.IsMaster);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_IsHidden()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.IsHidden);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.IsHidden, realLDOB.IsHidden);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_IsCollapsed()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.IsCollapsed);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.IsCollapsed, realLDOB.IsCollapsed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_ActiveDocumentCount()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.ActiveDocumentCount, realLDOB.ActiveDocumentCount);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_CourseId()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.CourseId, realLDOB.CourseId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_UserDisplayName()
        {
            expected = $"{mocks.DefaultUserDisplayName}";
            Assert.AreEqual(expected, realLDOB.UserDisplayName);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DoShowLessonPlanNotifications()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.DoShowLessonPlanNotifications);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DoShowLessonPlanNotifications, realLDOB.DoShowLessonPlanNotifications);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DoShowNarrativeNotifications()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.DoShowNarrativeNotifications);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DoShowNarrativeNotifications, realLDOB.DoShowNarrativeNotifications);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DoShowDocumentsNotifications()
        {
            Assert.IsTrue(mocks.MockLessonDomainObjBasic.DoShowDocumentsNotifications);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DoShowDocumentsNotifications, realLDOB.DoShowDocumentsNotifications);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeId()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeId, realLDOB.NarrativeId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeTextLength()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeTextLength, realLDOB.NarrativeTextLength);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanId()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanId, realLDOB.LessonPlanId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_FullNarrative()
        {
            expected = $"{mocks.DefaultFullNarrative}";
            Assert.AreEqual(expected, realLDOB.FullNarrative);
        }

        [Test]
        public void Can_Get_NarrativeReferenceDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentReferenceDateChoiceConfirmed, realLDOB.DocumentReferenceDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeDateChoiceConfirmed, realLDOB.NarrativeDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeDateModified()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeDateModified, realLDOB.NarrativeDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_MasterNarrativeDateModified()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.MasterNarrativeDateModified, realLDOB.MasterNarrativeDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeGroupMostRecentModDate()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeGroupMostRecentModDate, realLDOB.NarrativeGroupMostRecentModDate);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanReferenceDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanReferenceDateChoiceConfirmed, realLDOB.LessonPlanReferenceDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanDateModified()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanDateModified, realLDOB.LessonPlanDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_MasterLessonPlanDateModified()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.MasterLessonPlanDateModified, realLDOB.MasterLessonPlanDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanDateChoiceConfirmed, realLDOB.LessonPlanDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentReferenceDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentReferenceDateChoiceConfirmed, realLDOB.DocumentReferenceDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentsDateModified()
        {

            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentsDateModified, realLDOB.DocumentsDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_MasterDocumentsDateModified()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.MasterDocumentsDateModified, realLDOB.MasterDocumentsDateModified);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentsDateChoiceConfirmed()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentsDateChoiceConfirmed, realLDOB.DocumentsDateChoiceConfirmed);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentsGroupMostRecentModDate()
        {
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentsGroupMostRecentModDate, realLDOB.DocumentsGroupMostRecentModDate);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeHasNewChangesInMaster()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.NarrativeHasNewChangesInMaster);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeHasNewChangesInMaster, realLDOB.NarrativeHasNewChangesInMaster);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_NarrativeHasNewChangesInGroup()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.NarrativeHasNewChangesInGroup);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.NarrativeHasNewChangesInGroup, realLDOB.NarrativeHasNewChangesInGroup);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanHasNewChangesInGroup()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.LessonPlanHasNewChangesInGroup);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanHasNewChangesInGroup, realLDOB.LessonPlanHasNewChangesInGroup);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonPlanHasNewChangesInMaster()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.LessonPlanHasNewChangesInMaster);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonPlanHasNewChangesInMaster, realLDOB.LessonPlanHasNewChangesInMaster);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentsHaveNewChangesinGroup()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.DocumentsHaveNewChangesinGroup);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentsHaveNewChangesinGroup, realLDOB.DocumentsHaveNewChangesinGroup);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DocumentsHaveNewChangesInMaster()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.DocumentsHaveNewChangesInMaster);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.DocumentsHaveNewChangesInMaster, realLDOB.DocumentsHaveNewChangesInMaster);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_LessonHasGroupChanges()
        {
            Assert.IsFalse(mocks.MockLessonDomainObjBasic.LessonHasGroupChanges);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.LessonHasGroupChanges, realLDOB.LessonHasGroupChanges);
        }

        [Test]
        [Author("Kevin")]
        public void DisplayName_IsCollapsedAsTrue_ReturnsName()
        {
            //expected = $"{mocks.DefaultName}  >>[]<<";
            realLDOB.IsCollapsed = true;
            Assert.IsTrue(realLDOB.IsCollapsed);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.Name + "  >>[]<<", realLDOB.DisplayName);
        }
        #endregion 

        #region method tests
        [Test]
        [Author("Kevin")]
        public void DisplayName_IsCollapsedAsFalse_ReturnsName()
        {
            //expected = $"{mocks.DefaultName}  >>[]<<";
            realLDOB.IsCollapsed = false;
            Assert.IsFalse(realLDOB.IsCollapsed);
            Assert.AreEqual(mocks.MockLessonDomainObjBasic.Name, realLDOB.DisplayName);
        }

        [Test]
        [Author("Kevin")]
        public void DisplayNameForHeading_IsMasterAsTrue_ReturnsName()
        {
            expected = $"{mocks.DefaultName} (Master)";
            realLDOB.IsMaster = true;
            Assert.AreEqual(expected, realLDOB.DisplayNameForHeading);
        }

        [Test]
        [Author("Kevin")]
        public void DisplayNameForHeading_IsMasterAsFalse_ReturnsName()
        {
            expected = $"{mocks.DefaultName}";
            realLDOB.IsMaster = false;
            Assert.AreEqual(expected, realLDOB.DisplayNameForHeading);
        }

        [Test]
        public void ShortExtendedDisplayName_IfIdIsNotNull_ReturnsPrefixAndName() {
            realLDOB.Id = Guid.NewGuid();
            realLDOB.UserDisplayName = mocks.DefaultUserDisplay;
            realLDOB.Name = mocks.DefaultName;
            realLDOB.IsMaster = true;


            expected = $"Master {mocks.DefaultName}";

            Assert.AreEqual(expected, realLDOB.ShortExtendedDisplayName);
        }

        [Test]
        [Author("Kevin")]
        public void ShortExtendedDisplayName_IfIdIsNull_ReturnsUnderscore()
        {
            realLDOB.Id = Guid.Empty;
            expected = "_";
            Assert.AreEqual(expected, realLDOB.ShortExtendedDisplayName);
        }
        #endregion

        // to do: have changes user boolean - problem: private variable cannot access
        // to do: fix ShortExtendedDisplayName test - problem: failing

    } // Kevin 2-25-2018 5:30PM
} // end class