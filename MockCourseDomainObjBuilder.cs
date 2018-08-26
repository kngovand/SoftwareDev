using CWMasterTeacherDataModel.ObjectBuilders;
using Moq;
using System;

namespace CWTesting.Tests.moq
{
    class MockCourseDomainObjBuilder
    {
        public static Mock<CourseDomainObjBuilder> getMockCourseDomainObjBuilder()
        {
            Mock<CourseDomainObjBuilder> mockCourseDomainObjBuilder = new Mock<CourseDomainObjBuilder>();
            mockCourseDomainObjBuilder.SetupAllProperties();

            return mockCourseDomainObjBuilder;
        }
    }
}