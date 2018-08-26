using CWMasterTeacherDataModel.ObjectBuilders;
using CWMasterTeacherService;
using CWMasterTeacherService.ViewObjectBuilder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class mocks builder for StudentHomeViewObjBuilder, which also uses other various mock builders (See moq folder in CWTesting).
// Author: Kevin N.

namespace CWTesting.Tests.moq
{
    class MockStudentHomeViewObjBuilder
    {  
        private static TermDomainObjBuilder termDomainObjBuilder;
        private static ClassSectionDomainObjBuilder classSectionDomainObjBuilder;
        private static UserDomainObjBuilder userDomainObjBuilder;
        private static ClassSectionStudentDomainObjBuilder classSectionStudentDomainObjBuilder;
        private static WorkingGroupDomainObjBuilder workingGroupDomainObjBuilder;
        private static CourseDomainObjBuilder courseDomainObjBuilder;
        private static ClassMeetingDomainObjBuilder classMeetingDomainObjBuilder;
       // private ClassroomViewObjBuilder classroomViewObjBuilder;
        public static ClassroomViewObjBuilder classroomViewObjBuilder;

        private static void setupAll()
        {
            termDomainObjBuilder = MockTermDomainObjBuilder.getMockTermDomainObjBuilder().Object;
            classSectionDomainObjBuilder = MockClassSectionDomainObjBuilder.getMockClassSectionDomainObjBuilder().Object;
            userDomainObjBuilder = MockUserDomainObjBuilder.getMockUserDomainObjBuilder().Object;
            classSectionStudentDomainObjBuilder = MockClassSectionStudentDomainObjBuilder.getMockClassSectionStudentDomainObjBuilder().Object;
            workingGroupDomainObjBuilder = MockWorkingGroupDomainObjBuilder.getMockWorkingGroupDomainObjBuilder().Object;
            courseDomainObjBuilder = MockCourseDomainObjBuilder.getMockCourseDomainObjBuilder().Object;
            classMeetingDomainObjBuilder = MockClassMeetingDomainObjBuilder.getMockClassMeetingDomainObjBuilder().Object;
            classroomViewObjBuilder = MockClassroomViewObjBuilder.getMockClassroomViewObjBuilder().Object;
        }

        public static Mock<StudentHomeViewObjBuilder> getMockStudentHomeViewObjBuilder()
        {
            Mock<StudentHomeViewObjBuilder> mockStudentHomeViewObjBuilder = new Mock<StudentHomeViewObjBuilder>(termDomainObjBuilder, classSectionDomainObjBuilder,
                userDomainObjBuilder, classSectionStudentDomainObjBuilder, courseDomainObjBuilder, classMeetingDomainObjBuilder, classroomViewObjBuilder);

            mockStudentHomeViewObjBuilder.SetupAllProperties();

            return mockStudentHomeViewObjBuilder;
        }
    }
} // End class
