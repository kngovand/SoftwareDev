using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CWTesting.Tests.NEWMocks.Mocks;
using NUnit.Framework;
using CWMasterTeacherService.CUDRouters;
using CWMasterTeacherDataModel;
using CWTesting.Tests.Compromise;

namespace CWTesting.Tests.CWMasterTeacherService.RetrieveServices
{
    [TestFixture]
    class LessonManagerCUDRouterTest
    {
        private LessonManagerCUDRouter _LessonManagerCUDRouter;
        private ReflectionAttempt<MasterTeacherContext> r;
        private Lesson lesson;
        private Course course;
        private Guid guid;
        private LazyReflection lazyReflection;

        [OneTimeSetUp]
        public void Setup()
        {
            r = ReflectionAttempt<MasterTeacherContext>.GetGood();
            _LessonManagerCUDRouter = r.GetCUD<LessonManagerCUDRouter>();
            lesson = r.Entity<Lesson>();
            course = r.Entity<Course>();
            guid = r.DefaultGuid;
            lazyReflection = new LazyReflection();
        }

        [Test]
        public void SetLessonIsHiddenTest()
        {
            Lesson lesson = r.Entity<Lesson>();
            Guid Id = lesson.Id;
            bool isHidden = lesson.IsHidden;

            _LessonManagerCUDRouter.SetLessonIsHidden(Id, isHidden);

            Assert.AreEqual(lesson.IsHidden, isHidden);
            Assert.AreEqual(lesson.Id, Id);
        }

        [Test]
        public void SetShowHiddenLessonsTest()
        {
            Lesson lesson = r.Entity<Lesson>();
            Course course = r.Entity<Course>();
            Guid Id = lesson.Id;
            bool doShowHidden = course.ShowHiddenLessons;

            _LessonManagerCUDRouter.SetLessonIsHidden(Id, doShowHidden);

            Assert.AreEqual(course.ShowHiddenLessons, doShowHidden);
            Assert.AreEqual(lesson.Id, Id);
        }

        [Test]
        public void RenumberAllLessonsInCourseTest()
        {
            Course course = r.Entity<Course>();
            Guid Id = course.Id;

            _LessonManagerCUDRouter.RenumberAllLessonsInCourse(Id);
            Assert.AreEqual(course.Id, Id);
        }



    }
}
