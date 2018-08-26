using CWMasterTeacherDataModel.ObjectBuilders;
using CWMasterTeacherService;
using Moq;
using System;

namespace CWTesting.Tests.moq
{
    class MockClassSectionStudentDomainObjBuilder
    {
        public static Mock<ClassSectionStudentDomainObjBuilder> getMockClassSectionStudentDomainObjBuilder()
        {
            Mock<ClassSectionStudentDomainObjBuilder> mockClassSectionStudentDomainObjBuilder = new Mock<ClassSectionStudentDomainObjBuilder>();
            mockClassSectionStudentDomainObjBuilder.SetupAllProperties();

            return mockClassSectionStudentDomainObjBuilder;
        }
    }
}