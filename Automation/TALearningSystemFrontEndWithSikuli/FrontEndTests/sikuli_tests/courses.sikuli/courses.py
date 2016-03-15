import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

test_name = "Courses"

class TestCourses(unittest.TestCase):

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_Archer_HomeWork_Eval_Is_Open(self):
        LoginUser("GiantTestUser","123456")
        wait(Log.giant_test_user_logo,30).highlight(1)
        OpenCourse(Courses.archer_homework_eval,Courses.title_archer_course)
        assert exists(Courses.title_archer_course)

    def test_002_Test_Course_Tow_Is_Open(self):
        OpenCourse(Courses.test_course_two,Courses.title_course_tow)
        assert exists(Courses.title_course_tow)

    def test_003_Export_Test_Course_Is_Open(self):
        OpenCourse(Courses.export_test_course,Courses.title_export_test)
        assert exists(Courses.title_export_test)

    def test_004_Test_Course_One_Is_Open(self):
        OpenCourse(Courses.test_course_one,Courses.title_course_one)
        assert exists(Courses.title_course_one)

    def test_005_Data_Base_Is_Open(self):
        OpenCourse(Courses.data_base, Courses.title_data_base)
        assert exists(Courses.title_data_base)

if __name__ == '__main__':
    LogTestResults(test_name, TestCourses)

