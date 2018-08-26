using CWMasterTeacherDataModel.ObjectBuilders;
using CWMasterTeacherDomain.DomainObjects;
using CWMasterTeacherDomain.ViewObjects;
using CWMasterTeacherService;
using CWMasterTeacherService.ViewObjectBuilder;
using CWTesting.Tests.moq;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

// This class utilizes MOQ to test StudentHomeViewObj (see mocked builder classes).
// Author: Kevin N.

namespace CWTesting.Tests.CWMasterTeacherDomain.ViewObjects
{
    [TestFixture]
    [Author("Kevin")]
    class StudentHomeViewObjTest
    {
        private StudentHomeViewObj testStudentHomeObj;
        private WorkingGroupDomainObjBasic testWorkingGroupDomainObjBasic;
        private UserDomainObjBasic testUserDomainObjBasic;
        private ClassSectionDomainObjBasic testClassSectionDomainObjBasic;
        private ClassSectionStudentDomainObjBasic testClassSectionStudentDomainObjBasic;
        private ClassMeetingDomainObjBasic testClassMeetingDomainObjBasic;

        List<WorkingGroupDomainObjBasic> testListWorkingGroupDomainObjBasic = new List<WorkingGroupDomainObjBasic>();
        List<UserDomainObjBasic> testInstructorList = new List<UserDomainObjBasic>();
        List<ClassSectionDomainObjBasic> testClassSectionList = new List<ClassSectionDomainObjBasic>();
        List<ClassSectionStudentDomainObjBasic> testClassesAwaitingList = new List<ClassSectionStudentDomainObjBasic>();
        List<ClassSectionStudentDomainObjBasic> testClassesDeniedList = new List<ClassSectionStudentDomainObjBasic>();
        List<ClassSectionStudentDomainObjBasic> testCurrentclassesList = new List<ClassSectionStudentDomainObjBasic>();
        List<ClassMeetingDomainObjBasic> testClassMeetingList = new List<ClassMeetingDomainObjBasic>();

        bool testDoShow = true;
        bool testDoShowRequestCourseAccess = true;
        bool testDoShowRequestGroupAccess = true;
        Guid testId = Guid.NewGuid();
        Guid testInstructorUserId = Guid.NewGuid();
        Guid testClassSectionId = Guid.NewGuid();
        Guid testDisplayedClassSectionId = Guid.NewGuid();
        string testAccessCode = "testAccessCode";
        string testAccessRequestMessage = "testAccessRequestMessage";
        string testCourseRequestMessage = "testCourseRequestMessage";
        IEnumerable<SelectListItem> testClassSectionSelectList;
        IEnumerable<SelectListItem> testWorkingGroupSelectList;
        IEnumerable<SelectListItem> testInstructorSelectList;

        [SetUp]
        public void setup()
        {
            testStudentHomeObj = new StudentHomeViewObj();
            testWorkingGroupDomainObjBasic = new WorkingGroupDomainObjBasic();
            testUserDomainObjBasic = new UserDomainObjBasic();
            testClassSectionDomainObjBasic = new ClassSectionDomainObjBasic();
            testClassSectionStudentDomainObjBasic = new ClassSectionStudentDomainObjBasic();
            testClassMeetingDomainObjBasic = new ClassMeetingDomainObjBasic();
            // to do initializers
            testListWorkingGroupDomainObjBasic = MockWorkingGroupDomainObjBuilder.getMockWorkingGroupDomainObjBuilder().Object.SingleWorkingGroupBasicList(testId);
            //to do add lists
            testListWorkingGroupDomainObjBasic.Add(testWorkingGroupDomainObjBasic);
            //ignore:
            //testWorkingGroupDomainObjBasic = MockWorkingGroupDomainObjBuilder.getMockWorkingGroupDomainObjBuilder().Object.AllWorkingGroupsBasicList();
            //testWorkingGroupDomainObjBasic = MockWorkingGroupDomainObjBuilder.getMockWorkingGroupDomainObjBuilder().Object.SingleWorkingGroupBasicList(testId);
        }

        #region setter/getter tests
        [Test]
        [Author("Kevin")]
        public void Can_Get_InstructorUserId()
        {
            Assert.AreEqual(testInstructorUserId, testStudentHomeObj.InstructorUserId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_testClassSectionId()
        {
            Assert.AreEqual(testClassSectionId, testStudentHomeObj.ClassSectionId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DisplayedClassSectionId()
        {
            Assert.AreEqual(testDisplayedClassSectionId, testStudentHomeObj.DisplayedClassSectionId);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_AccessCode()
        {
            Assert.AreEqual(testAccessCode, testStudentHomeObj.AccessCode);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DoShowRequestCourseAccess()
        {
            Assert.AreEqual(testDoShowRequestCourseAccess, testStudentHomeObj.DoShowRequestCourseAccess);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_DoShowRequestGroupAccess()
        {
            Assert.AreEqual(testDoShowRequestGroupAccess, testStudentHomeObj.DoShowRequestGroupAccess);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_AccessRequestMessage()
        {
            Assert.AreEqual(testAccessRequestMessage, testStudentHomeObj.AccessRequestMessage);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_CourseRequestMessage()
        {
            Assert.AreEqual(testCourseRequestMessage, testStudentHomeObj.CourseRequestMessage);
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_ClassSelectionSelectListItem()
        {
            Assert.AreEqual(testClassSectionSelectList.Count(), testStudentHomeObj.ClassSectionSelectList.Count());
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_WorkingGroupSelectList()
        {
            Assert.AreEqual(testWorkingGroupSelectList.Count(), testStudentHomeObj.WorkingGroupSelectList.Count());
        }

        [Test]
        [Author("Kevin")]
        public void Can_Get_InstructorSelectList()
        {
            Assert.AreEqual(testInstructorSelectList.Count(), testStudentHomeObj.InstructorSelectList.Count());
        }
        #endregion

        #region list<> tests
        [Test]
        [Author("Kevin")]
        public void Can_Get_WorkingGroupList()
        {
            testStudentHomeObj.WorkingGroupList = testListWorkingGroupDomainObjBasic;
            Assert.IsNotNull(testStudentHomeObj.WorkingGroupList);
            Assert.IsNotEmpty(testStudentHomeObj.WorkingGroupList);
            Assert.AreEqual(testWorkingGroupDomainObjBasic.WorkingGroupId, testStudentHomeObj.WorkingGroupList[0].WorkingGroupId);
        }

        // to do instructorlist, classsectiolist, classawaiting, classesdenied, currentclasses, classmeetinglist
        #endregion

        #region method tests
        #endregion
    }
} // End class